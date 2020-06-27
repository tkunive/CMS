using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CMS.Models;
using CMS.Enumerations;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using Microsoft.Extensions.Logging;
using Microsoft.ApplicationInsights;
using System.Runtime.CompilerServices;
using CMS.Controllers;

namespace CMS
{
    public class AddRemoveRequestService
    {

        //private readonly ILogger<AddRemoveRequestService> _logger;
       

        
        public void SubmitAddRemoveRequest(AddRemoveRequestCompositeEntity addRemoveRequestCompositeEntity)
        {
            try
            {
                using (ContractDbContext contractDetailsEntities = new ContractDbContext())
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<ContractAmendmentRequestARDetailsDTO, ContractAmendmentRequestARDetails>();
                        cfg.CreateMap<UserInfoDTO, UserInfo>();
                    }
                );
                    var mapper = new Mapper(config);
                    //UserInfo userInfo1 = mapper.Map<UserInfo>(addRemoveRequestCompositeEntity.UserInfo);
                    UserInfo userInfo = new UserInfo();

                    userInfo = GetEntityByDTOKey(addRemoveRequestCompositeEntity.UserInfo);

                   // _logger.LogInformation("Logging from addremoverequestservice");

                    //UserInfo userInfo = mapper. userMap<UserInfo>(addRemoveRequestCompositeEntity.UserInfo);
                    var customerNumber = addRemoveRequestCompositeEntity.AssociatedSoldTo;
                    //var ContractAmendmentAr = new List<ContractAmendmentRequestARDetails>();
                    //ContractAmendmentAr = ContractAmendmentRequestARs(addRemoveRequestCompositeEntity);
                    var entityID = userInfo.Entity_ID;
                    var email = userInfo.EMail;
                    ContractAmendmentRequest contractAmendmentRequest = new ContractAmendmentRequest
                    {
                        // ContractAmendmentRequestID = 98373,
                        SubmissionDateTime = System.DateTime.UtcNow,
                        EntityID = entityID,
                        SAPResponseDateTime = System.DateTime.UtcNow,
                        SAPResponseDetails = " ",
                        CustomerNumber = customerNumber,
                        Description = " ",
                        Status = (short)AddRemoveRequestStatus.InProgress,
                        Type = (short)AddRemoveRequestType.AddRemove,
                        LastModifiedDate = System.DateTime.UtcNow,
                        LastModifiedBy = "xyz",
                        IsArchived = false,
                        UserEmail = email,
                        
                    };

                    // contractDetailsEntities.Entry(contractAmendmentRequest).State = EntityState.Added;
                    //contractDetailsEntities.ContractAmendmentRequest.Add(contractAmendmentRequest);
                    contractDetailsEntities.ContractAmendmentRequest.Add(contractAmendmentRequest);
                    contractDetailsEntities.SaveChanges();
                    string contractSalesOrg = string.Empty;

                    string sAgreementNumber = string.Empty;
                    //contractAmendmentRequest.ContractAmendmentRequestARDetails = ContractAmendmentRequestARs(addRemoveRequestCompositeEntity);
                    foreach (ContractAmendmentRequestARDetailsDTO contractAmendmentRequestARDetailsDTO in addRemoveRequestCompositeEntity.ContractAddRemoveRequestDetails)
                    {
                        ContractAmendmentRequestARDetails contractAmendmentRequestARDetails = mapper.Map<ContractAmendmentRequestARDetails>(contractAmendmentRequestARDetailsDTO);
                        contractAmendmentRequest.ContractAmendmentRequestARDetails.Add(contractAmendmentRequestARDetails);
                          //contractDetailsEntities.Entry(contractAmendmentRequestARDetails).State = EntityState.Added;
                        
                        //contractDetailsEntities.ContractAmendmentRequestARDetails.Add(contractAmendmentRequestARDetails);
                        //contractAmendmentRequest.ContractAmendmentRequestARDetails.Add(contractAmendmentRequestARDetails);
                    }
                    
                    contractDetailsEntities.Entry(contractAmendmentRequest).State = EntityState.Modified;
                    try { 
                        contractDetailsEntities.SaveChanges(); }
                    catch(Exception e)
                    {

                        throw e;
                    }

                    //Send SAP request
                    ContractAmendmentSAPService contractAmendmentSAPServices = new ContractAmendmentSAPService();
                     AddRemoveRequestSAPResponse addRemoveRequestSAPResponse = null;
                     try
                     {
                         addRemoveRequestSAPResponse = contractAmendmentSAPServices.SendSAPRequest(addRemoveRequestCompositeEntity.ContractAddRemoveRequestDetails).GetAwaiter().GetResult();
                     }
                     catch (Exception ex)
                     {
                         addRemoveRequestSAPResponse = CreateFailureSAPResponse(addRemoveRequestCompositeEntity.ContractAddRemoveRequestDetails, sAgreementNumber);
                        
                         // objlog.LogException(ex, -1, null, "AddRemoveRequestService", System.Diagnostics.TraceEventType.Error, "", "SubmitAddRemoveRequest");
                         // LogHelper.LogExceptionMessage(ex);
                         //logger.LogException(ex);
                     }
                     finally
                     {
                         UpdateSAPResponse(contractAmendmentRequest, addRemoveRequestSAPResponse);
                        
                         // persist the changes to database.
                         contractDetailsEntities.SaveChanges();
                     }
                }





            }
            catch (Exception ex)
            {
                
                throw ex;   
            }


        }
        public List<ContractAmendmentRequestARDetails> ContractAmendmentRequestARs(AddRemoveRequestCompositeEntity addRemoveRequestCompositeEntity)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ContractAmendmentRequestARDetailsDTO, ContractAmendmentRequestARDetails>();
                cfg.CreateMap<UserInfoDTO, UserInfo>();
            });
            var AmendmentRequestARDetails = new List<ContractAmendmentRequestARDetails>();
            var mapper = new Mapper(config);
            foreach(ContractAmendmentRequestARDetailsDTO contractAmendmentRequestARDetailsDTO in addRemoveRequestCompositeEntity.ContractAddRemoveRequestDetails)
            {
                ContractAmendmentRequestARDetails contractAmendmentRequestARDetails = mapper.Map<ContractAmendmentRequestARDetails>(contractAmendmentRequestARDetailsDTO);
                AmendmentRequestARDetails.Add(contractAmendmentRequestARDetails);

            }
            return AmendmentRequestARDetails;
        }
        public UserInfo GetEntityByDTOKey(UserInfoDTO userInfoDTO)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ContractAmendmentRequestARDetailsDTO, ContractAmendmentRequestARDetails>();
                cfg.CreateMap<UserInfoDTO, UserInfo>();
            });
            var mapper = new Mapper(config);
            UserInfo userInfo = mapper.Map<UserInfo>(userInfoDTO);
            ContractDbContext contractDetailsEntities = new ContractDbContext();
            var userInfo1 = contractDetailsEntities.UserInfo.FirstOrDefault(e => e.Entity_ID == userInfo.Entity_ID);
            return userInfo1;
        }


        private AddRemoveRequestSAPResponse CreateFailureSAPResponse(List<ContractAmendmentRequestARDetailsDTO> contractAmendmentRequestARDetailsDTOList, string agreementNumber)
        {
            AddRemoveRequestSAPResponse addRemoveRequestSAPResponse = new AddRemoveRequestSAPResponse();
            addRemoveRequestSAPResponse.RequestResponseStatus = AddRemoveRequestResponseStatus.RFCFailure;

            addRemoveRequestSAPResponse.AgreementNumber = agreementNumber;
            addRemoveRequestSAPResponse.UniqueIdentifier = contractAmendmentRequestARDetailsDTOList[0].ContractAmendmentRequestID.ToString();

            foreach (ContractAmendmentRequestARDetailsDTO contractAddRemoveRequestDetailsDTO in contractAmendmentRequestARDetailsDTOList)
            {
                AddRemoveProductSAPResponse objProdResponse = new AddRemoveProductSAPResponse();
                objProdResponse.LicensableID = contractAddRemoveRequestDetailsDTO.LicensableID;
                objProdResponse.ProductID = contractAddRemoveRequestDetailsDTO.ProductID.ToString();
                objProdResponse.ProductName = contractAddRemoveRequestDetailsDTO.ProductName;
                objProdResponse.Status = AddRemoveRequestDetailStatus.Failure;
                objProdResponse.Action = (AddRemoveRequestDetailAction)contractAddRemoveRequestDetailsDTO.Action;

                addRemoveRequestSAPResponse.ProductSAPResponse.Add(objProdResponse);
            }

            return addRemoveRequestSAPResponse;
        }
        private void UpdateSAPResponse(ContractAmendmentRequest contractAmendmentRequest, AddRemoveRequestSAPResponse addRemoveRequestSAPResponse)
        {
            if (addRemoveRequestSAPResponse.RequestResponseStatus == AddRemoveRequestResponseStatus.Failure ||
                addRemoveRequestSAPResponse.RequestResponseStatus == AddRemoveRequestResponseStatus.RFCFailure)
            {
                contractAmendmentRequest.Status = (int)AddRemoveRequestStatus.Failure;
            }
            else if (addRemoveRequestSAPResponse.RequestResponseStatus == AddRemoveRequestResponseStatus.Success)
            {
                contractAmendmentRequest.Status = (int)AddRemoveRequestStatus.Success;
            }
            else if (addRemoveRequestSAPResponse.RequestResponseStatus == AddRemoveRequestResponseStatus.SuccessWithWarnings)
            {
                contractAmendmentRequest.Status = (int)AddRemoveRequestStatus.Success;
            }

            foreach (ContractAmendmentRequestARDetails contractContractAmendmentRequestARDetails in contractAmendmentRequest.ContractAmendmentRequestARDetails)
            {
                AddRemoveProductSAPResponse addRemoveProductSAPResponse
                    = addRemoveRequestSAPResponse.ProductSAPResponse.Where(
                                c => c.LicensableID == contractContractAmendmentRequestARDetails.LicensableID &&
                                    Convert.ToInt64(c.ProductID) == contractContractAmendmentRequestARDetails.ProductID).First();

                contractContractAmendmentRequestARDetails.Status = (short)addRemoveProductSAPResponse.Status;
            }
        }

    }
}
