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

                HttpClient httpClient = new HttpClient();
                var baseUri = "https://saptstws.trafficmanager.net/MST/MSSDOEMCONTRACT/";
                httpClient.BaseAddress = new Uri(baseUri);
               string token = "";
                
                    AuthenticationResult accessToken = await GetToken();
                    token = accessToken.AccessToken;
               // httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "c55ddee3fc0643eab5534af29776892c");
                httpClient.DefaultRequestHeaders.Add("Authorization", accessToken.CreateAuthorizationHeader());
                httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "c55ddee3fc0643eab5534af29776892c");
                /* var myContent = JsonConvert.SerializeObject(sapAddRemoveProductData);
                 var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                 var byteContent = new ByteArrayContent(buffer);
                 byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                 var response = await httpClient.PostAsync("api/Contracts/AddOrRemove", byteContent);*/
                var response = await httpClient.PostAsync("api/Contracts/AddOrRemove", sapAddRemoveProductData, new JsonMediaTypeFormatter());
                
                var responseContent = await response.Content.ReadAsStringAsync();
                Z_V_Osw_R_Add_Rem_Contract_RFCReturn RFCStrOutput = JsonConvert.DeserializeObject<Z_V_Osw_R_Add_Rem_Contract_RFCReturn>(responseContent);
                addremoveResp = ProcessSAPResponse(RFCStrOutput);
                addremoveResp.SAPResponse = SerializeObject(RFCStrOutput, typeof(Z_V_Osw_R_Add_Rem_Contract_RFCReturn));

                return addremoveResp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            /* var myContent = JsonConvert.SerializeObject(sapAddRemoveProductData);
             var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
             var byteContent = new ByteArrayContent(buffer);
             byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
             var result = httpClient.PostAsync("api/Contracts/AddOrRemove", byteContent).Result;*/


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
    internal class BAPIRET2
    {

        private string tYPEField;

        private string idField;

        private string nUMBERField;

        private string mESSAGEField;

        private string lOG_NOField;

        private string lOG_MSG_NOField;

        private string mESSAGE_V1Field;

        private string mESSAGE_V2Field;

        private string mESSAGE_V3Field;

        private string mESSAGE_V4Field;

        private string pARAMETERField;

        private int rOWField;

        private string fIELDField;

        private string sYSTEMField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NUMBER
        {
            get
            {
                return this.nUMBERField;
            }
            set
            {
                this.nUMBERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE
        {
            get
            {
                return this.mESSAGEField;
            }
            set
            {
                this.mESSAGEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOG_NO
        {
            get
            {
                return this.lOG_NOField;
            }
            set
            {
                this.lOG_NOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOG_MSG_NO
        {
            get
            {
                return this.lOG_MSG_NOField;
            }
            set
            {
                this.lOG_MSG_NOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE_V1
        {
            get
            {
                return this.mESSAGE_V1Field;
            }
            set
            {
                this.mESSAGE_V1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE_V2
        {
            get
            {
                return this.mESSAGE_V2Field;
            }
            set
            {
                this.mESSAGE_V2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE_V3
        {
            get
            {
                return this.mESSAGE_V3Field;
            }
            set
            {
                this.mESSAGE_V3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MESSAGE_V4
        {
            get
            {
                return this.mESSAGE_V4Field;
            }
            set
            {
                this.mESSAGE_V4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PARAMETER
        {
            get
            {
                return this.pARAMETERField;
            }
            set
            {
                this.pARAMETERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ROW
        {
            get
            {
                return this.rOWField;
            }
            set
            {
                this.rOWField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIELD
        {
            get
            {
                return this.fIELDField;
            }
            set
            {
                this.fIELDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SYSTEM
        {
            get
            {
                return this.sYSTEMField;
            }
            set
            {
                this.sYSTEMField = value;
            }
        }
    }
    internal class Z_V_Osw_R_Add_Rem_Contract_RFCReturn
    {

        private ZLW_AGR_ADD_REM_CONTRACT[] in_Agr_Add_Rem_ContractField;

        private ZLW_OUT_GENERAL_DATA[] out_General_DataField;

        private BAPIRET2[] out_MessagesField;

        private string processMessageField;

        /// <remarks/>
        public ZLW_AGR_ADD_REM_CONTRACT[] In_Agr_Add_Rem_Contract
        {
            get
            {
                return this.in_Agr_Add_Rem_ContractField;
            }
            set
            {
                this.in_Agr_Add_Rem_ContractField = value;
            }
        }

        /// <remarks/>
        public ZLW_OUT_GENERAL_DATA[] Out_General_Data
        {
            get
            {
                return this.out_General_DataField;
            }
            set
            {
                this.out_General_DataField = value;
            }
        }

        /// <remarks/>
        public BAPIRET2[] Out_Messages
        {
            get
            {
                return this.out_MessagesField;
            }
            set
            {
                this.out_MessagesField = value;
            }
        }

        /// <remarks/>
        public string ProcessMessage
        {
            get
            {
                return this.processMessageField;
            }
            set
            {
                this.processMessageField = value;
            }
        }
    }
    internal class ZLW_OUT_GENERAL_DATA
    {

        private string oUT_IDENTIFIERField;

        private string oUT_MATERIALField;

        private string oUT_RETURN_VALUEField;

        private string oUT_RETURN_MSGField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OUT_IDENTIFIER
        {
            get
            {
                return this.oUT_IDENTIFIERField;
            }
            set
            {
                this.oUT_IDENTIFIERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OUT_MATERIAL
        {
            get
            {
                return this.oUT_MATERIALField;
            }
            set
            {
                this.oUT_MATERIALField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OUT_RETURN_VALUE
        {
            get
            {
                return this.oUT_RETURN_VALUEField;
            }
            set
            {
                this.oUT_RETURN_VALUEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OUT_RETURN_MSG
        {
            get
            {
                return this.oUT_RETURN_MSGField;
            }
            set
            {
                this.oUT_RETURN_MSGField = value;
            }
        }
    }
    internal class ZLW_AGR_ADD_REM_CONTRACT
    {


        private string vBELNField;

        private string mATNRField;

        private string iTEM_CATEGField;

        private string aCTN_CODEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VBELN
        {
            get
            {
                return this.vBELNField;
            }
            set
            {
                this.vBELNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MATNR
        {
            get
            {
                return this.mATNRField;
            }
            set
            {
                this.mATNRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ITEM_CATEG
        {
            get
            {
                return this.iTEM_CATEGField;
            }
            set
            {
                this.iTEM_CATEGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACTN_CODE
        {
            get
            {
                return this.aCTN_CODEField;
            }
            set
            {
                this.aCTN_CODEField = value;
            }
        }

    }
}

