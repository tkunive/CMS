using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using CMS.Enumerations;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using CMS.Controllers;

namespace CMS
{
    public class ContractAmendmentSAPService
    {
       
        

        

        AddRemoveRequestCompositeEntity _addremoveRequest = null;

        public async Task<AddRemoveRequestSAPResponse> SendSAPRequest(List<ContractAmendmentRequestARDetailsDTO> contractAmendmentRequestARDetailsDTOList)
        {
            try
            {
                _addremoveRequest = new AddRemoveRequestCompositeEntity();
                _addremoveRequest.ContractAddRemoveRequestDetails = contractAmendmentRequestARDetailsDTOList;
                //Service SAPRFCService = new Service();
                //string strURL = System.Configuration.ConfigurationManager.AppSettings["ContractManagementSAPURL"];
                AddRemoveRequestSAPResponse addremoveResp = null;
                ZLW_AGR_ADD_REM_CONTRACT[] sapAddRemoveProductData = null;
                ZLW_OUT_GENERAL_DATA[] sapOutput = null;
                BAPIRET2[] messageOutput = null;
                int numberOfProducts = contractAmendmentRequestARDetailsDTOList.Count;
                sapAddRemoveProductData = new ZLW_AGR_ADD_REM_CONTRACT[numberOfProducts];
                sapOutput = new ZLW_OUT_GENERAL_DATA[0];
                messageOutput = new BAPIRET2[numberOfProducts];
                int count = 0;
                foreach (ContractAmendmentRequestARDetailsDTO addRemoveProduct in contractAmendmentRequestARDetailsDTOList)
                {
                    sapAddRemoveProductData[count] = new ZLW_AGR_ADD_REM_CONTRACT();
                    messageOutput[count] = new BAPIRET2();

                    if (addRemoveProduct.Action == 1)
                        sapAddRemoveProductData[count].ACTN_CODE = "A";
                    else
                        sapAddRemoveProductData[count].ACTN_CODE = "R";

                    sapAddRemoveProductData[count].VBELN = addRemoveProduct.ContractNumber;
                    sapAddRemoveProductData[count].MATNR = addRemoveProduct.LicensableID;
                    sapAddRemoveProductData[count].ITEM_CATEG = addRemoveProduct.BillingTypeCode;
                    count++;
                }
                Z_V_OSW_R_ADD_REM_CONTRACTRequest request = new Z_V_OSW_R_ADD_REM_CONTRACTRequest();
                request.In_Agr_Add_Rem_Contract_In = sapAddRemoveProductData;
                request.Out_General_Data_In = sapOutput;
                request.Out_Messages_In = messageOutput;
               // HttpConnector client = new HttpConnector();
                HttpClient httpClient = new HttpClient();
                var baseUri = "https://saptstws.trafficmanager.net/MST/MSSDOEMCONTRACT/";
                httpClient.BaseAddress = new Uri(baseUri);
                string token = "";

                AuthenticationResult accessToken = await GetToken();
                token = accessToken.AccessToken;
                // httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "c55ddee3fc0643eab5534af29776892c");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("Authorization", accessToken.CreateAuthorizationHeader());
                httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "c55ddee3fc0643eab5534af29776892c");
                httpClient.DefaultRequestHeaders.Add("Ocp-Apim-trace", "true");
                httpClient.DefaultRequestHeaders.Add("X-CorrelationId", Guid.NewGuid().ToString());
                var myContent = JsonConvert.SerializeObject(request);
                 var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                 var byteContent = new ByteArrayContent(buffer);
                 byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                 var response = await httpClient.PostAsync("api/Contracts/AddOrRemove", byteContent);
                //var response = await httpClient.PostAsync("api/Contracts/AddOrRemove/", request, new JsonMediaTypeFormatter());

                var responseContent = await response.Content.ReadAsStringAsync();
                Z_V_Osw_R_Add_Rem_Contract_RFCReturn RFCStrOutput = JsonConvert.DeserializeObject<Z_V_Osw_R_Add_Rem_Contract_RFCReturn>(responseContent);
                addremoveResp = ProcessSAPResponse(RFCStrOutput);
                addremoveResp.SAPResponse = SerializeObject(RFCStrOutput, typeof(Z_V_Osw_R_Add_Rem_Contract_RFCReturn));

                return addremoveResp;
            }
            catch (Exception ex)
            {
               // _logger.LogError(ex, ex.Message);
                throw ex;
            }
            

        }
        private string SerializeObject(object objectToBeSerialized, Type objectType)
        {
            XmlSerializer xlmSerializer = new XmlSerializer(objectType);

            MemoryStream memoryStream = new MemoryStream();

            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);

            xlmSerializer.Serialize(xmlTextWriter, objectToBeSerialized);

            memoryStream = (MemoryStream)xmlTextWriter.BaseStream;

            UTF8Encoding utf8Encoding = new UTF8Encoding();

            string serializedResponse = utf8Encoding.GetString(memoryStream.ToArray());

            return serializedResponse;
        }
        public async static Task<AuthenticationResult> GetToken()
        {
            string clientID = "335b45e9-7ce3-46fa-a5fc-8fbbe764e855";
            string password = "kOqtQaI8r9m6AQxxBkxOLB28KtypyI/28WQl1zt47wA=";


            ClientCredential cc = new ClientCredential(clientID, password);
            AuthenticationContext context = new AuthenticationContext("https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47");

            AuthenticationResult authenticationResult = await context.AcquireTokenAsync("https://tSAPWSAADApp", cc);
            return authenticationResult;

        }
        private AddRemoveRequestSAPResponse ProcessSAPResponse(Z_V_Osw_R_Add_Rem_Contract_RFCReturn RFCStrOutput)
        {
            try
            {
                AddRemoveRequestSAPResponse addremoveSAPResponse = new AddRemoveRequestSAPResponse();
                addremoveSAPResponse.ProductSAPResponse = new List<AddRemoveProductSAPResponse>();

                bool isAtLeastOneProductActionFailed = false;

                foreach (ZLW_OUT_GENERAL_DATA outGeneralData in RFCStrOutput.Out_General_Data)
                {
                    AddRemoveProductSAPResponse LstSAPResponse = new AddRemoveProductSAPResponse();

                    addremoveSAPResponse.AgreementNumber = outGeneralData.OUT_IDENTIFIER;
                    LstSAPResponse.LicensableID = outGeneralData.OUT_MATERIAL;

                    if (outGeneralData.OUT_RETURN_VALUE == "00")
                    {
                        LstSAPResponse.Status = AddRemoveRequestDetailStatus.Success;
                    }
                    else if (outGeneralData.OUT_RETURN_VALUE == "02")
                    {
                        LstSAPResponse.Status = AddRemoveRequestDetailStatus.Warning;
                    }
                    else
                    {
                        LstSAPResponse.Status = AddRemoveRequestDetailStatus.Failure;
                        isAtLeastOneProductActionFailed = true;
                    }

                    LstSAPResponse.Message = outGeneralData.OUT_RETURN_MSG;

                    ContractAmendmentRequestARDetailsDTO obj = _addremoveRequest.ContractAddRemoveRequestDetails.Where(c => c.LicensableID == LstSAPResponse.LicensableID).First();
                    LstSAPResponse.ProductID = obj.ProductID.ToString();
                    LstSAPResponse.ProductName = obj.ProductName;
                    LstSAPResponse.Action = (AddRemoveRequestDetailAction)obj.Action;

                    addremoveSAPResponse.ProductSAPResponse.Add(LstSAPResponse);
                }

                if (isAtLeastOneProductActionFailed)
                    addremoveSAPResponse.RequestResponseStatus = AddRemoveRequestResponseStatus.Failure;
                else
                    addremoveSAPResponse.RequestResponseStatus = AddRemoveRequestResponseStatus.Success;

                return addremoveSAPResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
    
    
    

}

