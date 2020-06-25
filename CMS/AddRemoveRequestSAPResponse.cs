using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Enumerations;

namespace CMS
{
    public class AddRemoveRequestSAPResponse
    {


        List<AddRemoveProductSAPResponse> _productSAPResponse = new List<AddRemoveProductSAPResponse>();
        AddRemoveRequestResponseStatus _requestResponseStatus = AddRemoveRequestResponseStatus.Success;

        string _agreementNumber;
        string _SAPResponse;
        string _userEmail;
        string _uniqueIdentifier;
        long _sapResponseCode;

        public long SapResponseCode
        {
            get { return _sapResponseCode; }
            set { _sapResponseCode = value; }
        }
        public string UniqueIdentifier
        {
            get { return _uniqueIdentifier; }
            set { _uniqueIdentifier = value; }
        }

        public AddRemoveRequestResponseStatus RequestResponseStatus
        {
            get { return _requestResponseStatus; }
            set { _requestResponseStatus = value; }
        }

        public string UserEmail
        {
            get { return _userEmail; }
            set { _userEmail = value; }
        }
        public string SAPResponse
        {
            get { return _SAPResponse; }
            set { _SAPResponse = value; }
        }

        public List<AddRemoveProductSAPResponse> ProductSAPResponse
        {
            get { return _productSAPResponse; }
            set { _productSAPResponse = value; }
        }

        public string AgreementNumber
        {
            get { return _agreementNumber; }
            set { _agreementNumber = value; }
        }
    }
    public class AddRemoveProductSAPResponse
    {
        string _productID, _productName, _licensableID, _message;
        AddRemoveRequestDetailStatus _status;
        AddRemoveRequestDetailAction _action;

        public AddRemoveRequestDetailAction Action
        {
            get { return _action; }
            set { _action = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string LicensableID
        {
            get { return _licensableID; }
            set { _licensableID = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public string ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public AddRemoveRequestDetailStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }

    public enum AddRemoveRequestResponseStatus
    {
        Success = 1,
        SuccessWithWarnings = 2,
        Failure = 3,
        RFCFailure = 4
    }

}
