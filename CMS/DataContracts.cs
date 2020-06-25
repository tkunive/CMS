using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CMS
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "OrganizationAndAgreementCollection", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.CompositeEntities")]
    public partial class OrganizationAndAgreementCollection : object
    {

        private ContractsDTO[] ContractsField;

        private SoldToOEMDTO[] OrganizationsField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContractsDTO[] Contracts
        {
            get
            {
                return this.ContractsField;
            }
            set
            {
                this.ContractsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoldToOEMDTO[] Organizations
        {
            get
            {
                return this.OrganizationsField;
            }
            set
            {
                this.OrganizationsField = value;
            }
        }
    }

    public interface IDTOBase
    {
        System.Collections.Generic.Dictionary<string, object> KeysAndValues { get; set; }

        string SetName { get; set; }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ContractsDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class ContractsDTO : DTOBase
    {

        private AgreementTypeDTO AgreementTypeField;

        private string BillingScheduleField;

        private System.Nullable<System.DateTime> ContractEndDateField;

        private string ContractNumberField;

        private System.Nullable<System.DateTime> ContractSignDateField;

        private System.Nullable<System.DateTime> ContractStartDateField;

        private string ContractStatusField;

        private string ContractTypeField;

        private byte[] Contracts_TimeStampField;

        private string CustomerGroupField;

        private string CustomerNumberField;

        private string DistributionChannelField;

        private string DivisionField;

        private string DocumentCurrencyField;

        private System.Nullable<int> ExtendedDaysField;

        private byte IsAvailableToExternalField;

        private byte IsContractAvailableField;

        private bool IsContractVisibleField;

        private string NetInvoiceFlagField;

        private System.Nullable<System.DateTime> PODateField;

        private string PONumberField;

        private string PaymentTermField;

        private string PriceGroupField;

        private string PriceListTypeField;

        private string RoyaltyRptTermField;

        private string SalesDistrictField;

        private string SalesGroupField;

        private string SalesOfficeField;

        private string SalesOrgField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public AgreementTypeDTO AgreementType
        {
            get
            {
                return this.AgreementTypeField;
            }
            set
            {
                this.AgreementTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillingSchedule
        {
            get
            {
                return this.BillingScheduleField;
            }
            set
            {
                this.BillingScheduleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ContractEndDate
        {
            get
            {
                return this.ContractEndDateField;
            }
            set
            {
                this.ContractEndDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContractNumber
        {
            get
            {
                return this.ContractNumberField;
            }
            set
            {
                this.ContractNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ContractSignDate
        {
            get
            {
                return this.ContractSignDateField;
            }
            set
            {
                this.ContractSignDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ContractStartDate
        {
            get
            {
                return this.ContractStartDateField;
            }
            set
            {
                this.ContractStartDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContractStatus
        {
            get
            {
                return this.ContractStatusField;
            }
            set
            {
                this.ContractStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContractType
        {
            get
            {
                return this.ContractTypeField;
            }
            set
            {
                this.ContractTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Contracts_TimeStamp
        {
            get
            {
                return this.Contracts_TimeStampField;
            }
            set
            {
                this.Contracts_TimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerGroup
        {
            get
            {
                return this.CustomerGroupField;
            }
            set
            {
                this.CustomerGroupField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerNumber
        {
            get
            {
                return this.CustomerNumberField;
            }
            set
            {
                this.CustomerNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DistributionChannel
        {
            get
            {
                return this.DistributionChannelField;
            }
            set
            {
                this.DistributionChannelField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Division
        {
            get
            {
                return this.DivisionField;
            }
            set
            {
                this.DivisionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentCurrency
        {
            get
            {
                return this.DocumentCurrencyField;
            }
            set
            {
                this.DocumentCurrencyField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ExtendedDays
        {
            get
            {
                return this.ExtendedDaysField;
            }
            set
            {
                this.ExtendedDaysField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte IsAvailableToExternal
        {
            get
            {
                return this.IsAvailableToExternalField;
            }
            set
            {
                this.IsAvailableToExternalField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte IsContractAvailable
        {
            get
            {
                return this.IsContractAvailableField;
            }
            set
            {
                this.IsContractAvailableField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsContractVisible
        {
            get
            {
                return this.IsContractVisibleField;
            }
            set
            {
                this.IsContractVisibleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NetInvoiceFlag
        {
            get
            {
                return this.NetInvoiceFlagField;
            }
            set
            {
                this.NetInvoiceFlagField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> PODate
        {
            get
            {
                return this.PODateField;
            }
            set
            {
                this.PODateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PONumber
        {
            get
            {
                return this.PONumberField;
            }
            set
            {
                this.PONumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PaymentTerm
        {
            get
            {
                return this.PaymentTermField;
            }
            set
            {
                this.PaymentTermField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PriceGroup
        {
            get
            {
                return this.PriceGroupField;
            }
            set
            {
                this.PriceGroupField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PriceListType
        {
            get
            {
                return this.PriceListTypeField;
            }
            set
            {
                this.PriceListTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoyaltyRptTerm
        {
            get
            {
                return this.RoyaltyRptTermField;
            }
            set
            {
                this.RoyaltyRptTermField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SalesDistrict
        {
            get
            {
                return this.SalesDistrictField;
            }
            set
            {
                this.SalesDistrictField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SalesGroup
        {
            get
            {
                return this.SalesGroupField;
            }
            set
            {
                this.SalesGroupField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SalesOffice
        {
            get
            {
                return this.SalesOfficeField;
            }
            set
            {
                this.SalesOfficeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SalesOrg
        {
            get
            {
                return this.SalesOrgField;
            }
            set
            {
                this.SalesOrgField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SoldToOEMDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class SoldToOEMDTO : DTOBase
    {

        private string AccountGroupField;

        private System.Nullable<int> AppTypeField;

        private ContractInfoDTO[] AssociatedContractInfoField;

        private ContractsDTO[] AssociatedContractsField;

        private string AuthorizationGroupCodeField;

        private string BillingCalendarField;

        private string CompanyName2Field;

        private string ContactPersonField;

        private string CountryNameField;

        private string CustomerGroupField;

        private string CustomerGroup3Field;

        private string CustomerStatusField;

        private string DoingBusinessAsNameField;

        private string EmailField;

        private string FaxNumberField;

        private string ICDFlagField;

        private byte IsActiveField;

        private System.Nullable<int> MapPtAccountidField;

        private string OEMAddress1Field;

        private string OEMAddress2Field;

        private string OEMCityField;

        private string OEMCountryField;

        private string OEMNameField;

        private string OEMPostalCodeField;

        private string OEMSAPNumberField;

        private string OEMSiteIDField;

        private string OEMStateProvinceField;

        private string PhoneNumberField;

        private string PriceGroupCodeField;

        private string RMARequiredField;

        private string SalesOrgCodeField;

        private string TeleBoxNbrField;

        private System.Nullable<System.DateTime> UpdatedField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountGroup
        {
            get
            {
                return this.AccountGroupField;
            }
            set
            {
                this.AccountGroupField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> AppType
        {
            get
            {
                return this.AppTypeField;
            }
            set
            {
                this.AppTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContractInfoDTO[] AssociatedContractInfo
        {
            get
            {
                return this.AssociatedContractInfoField;
            }
            set
            {
                this.AssociatedContractInfoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContractsDTO[] AssociatedContracts
        {
            get
            {
                return this.AssociatedContractsField;
            }
            set
            {
                this.AssociatedContractsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthorizationGroupCode
        {
            get
            {
                return this.AuthorizationGroupCodeField;
            }
            set
            {
                this.AuthorizationGroupCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillingCalendar
        {
            get
            {
                return this.BillingCalendarField;
            }
            set
            {
                this.BillingCalendarField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName2
        {
            get
            {
                return this.CompanyName2Field;
            }
            set
            {
                this.CompanyName2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactPerson
        {
            get
            {
                return this.ContactPersonField;
            }
            set
            {
                this.ContactPersonField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryName
        {
            get
            {
                return this.CountryNameField;
            }
            set
            {
                this.CountryNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerGroup
        {
            get
            {
                return this.CustomerGroupField;
            }
            set
            {
                this.CustomerGroupField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerGroup3
        {
            get
            {
                return this.CustomerGroup3Field;
            }
            set
            {
                this.CustomerGroup3Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerStatus
        {
            get
            {
                return this.CustomerStatusField;
            }
            set
            {
                this.CustomerStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DoingBusinessAsName
        {
            get
            {
                return this.DoingBusinessAsNameField;
            }
            set
            {
                this.DoingBusinessAsNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FaxNumber
        {
            get
            {
                return this.FaxNumberField;
            }
            set
            {
                this.FaxNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ICDFlag
        {
            get
            {
                return this.ICDFlagField;
            }
            set
            {
                this.ICDFlagField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte IsActive
        {
            get
            {
                return this.IsActiveField;
            }
            set
            {
                this.IsActiveField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MapPtAccountid
        {
            get
            {
                return this.MapPtAccountidField;
            }
            set
            {
                this.MapPtAccountidField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMAddress1
        {
            get
            {
                return this.OEMAddress1Field;
            }
            set
            {
                this.OEMAddress1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMAddress2
        {
            get
            {
                return this.OEMAddress2Field;
            }
            set
            {
                this.OEMAddress2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMCity
        {
            get
            {
                return this.OEMCityField;
            }
            set
            {
                this.OEMCityField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMCountry
        {
            get
            {
                return this.OEMCountryField;
            }
            set
            {
                this.OEMCountryField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMName
        {
            get
            {
                return this.OEMNameField;
            }
            set
            {
                this.OEMNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMPostalCode
        {
            get
            {
                return this.OEMPostalCodeField;
            }
            set
            {
                this.OEMPostalCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMSAPNumber
        {
            get
            {
                return this.OEMSAPNumberField;
            }
            set
            {
                this.OEMSAPNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMSiteID
        {
            get
            {
                return this.OEMSiteIDField;
            }
            set
            {
                this.OEMSiteIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMStateProvince
        {
            get
            {
                return this.OEMStateProvinceField;
            }
            set
            {
                this.OEMStateProvinceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PriceGroupCode
        {
            get
            {
                return this.PriceGroupCodeField;
            }
            set
            {
                this.PriceGroupCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RMARequired
        {
            get
            {
                return this.RMARequiredField;
            }
            set
            {
                this.RMARequiredField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SalesOrgCode
        {
            get
            {
                return this.SalesOrgCodeField;
            }
            set
            {
                this.SalesOrgCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TeleBoxNbr
        {
            get
            {
                return this.TeleBoxNbrField;
            }
            set
            {
                this.TeleBoxNbrField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Updated
        {
            get
            {
                return this.UpdatedField;
            }
            set
            {
                this.UpdatedField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DTOBase", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(AgreementTypeDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SoldToOEMDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ContractAmendmentRequestARDetailsDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ContractAmendmentRequestDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UserInfoDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(vwViewSubmissionHistoryDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(vwViewSubmissionHistoryDetailsDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ContractsDTO))]
    public partial class DTOBase : IDTOBase
    {

        private System.Collections.Generic.Dictionary<string, object> KeysAndValuesField;

        private string SetNameField;

        public DTOBase()
        {
            this.KeysAndValuesField = new System.Collections.Generic.Dictionary<string, object>();
        }


        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, object> KeysAndValues
        {
            get
            {
                return this.KeysAndValuesField;
            }
            set
            {
                this.KeysAndValuesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SetName
        {
            get
            {
                return this.SetNameField;
            }
            set
            {
                this.SetNameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AgreementTypeDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class AgreementTypeDTO : DTOBase
    {

        private string AgreementTypeCodeField;

        private string AgreementTypeNameField;

        private System.Nullable<System.DateTime> LastModifiedDateField;

        private string ModifiedByUserField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgreementTypeCode
        {
            get
            {
                return this.AgreementTypeCodeField;
            }
            set
            {
                this.AgreementTypeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgreementTypeName
        {
            get
            {
                return this.AgreementTypeNameField;
            }
            set
            {
                this.AgreementTypeNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastModifiedDate
        {
            get
            {
                return this.LastModifiedDateField;
            }
            set
            {
                this.LastModifiedDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModifiedByUser
        {
            get
            {
                return this.ModifiedByUserField;
            }
            set
            {
                this.ModifiedByUserField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ContractAmendmentRequestARDetailsDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class ContractAmendmentRequestARDetailsDTO : DTOBase
    {
        public ContractAmendmentRequestARDetailsDTO()
        {
            base.SetName = "ContractAmendmentRequestARDetails";
        }


        private System.Nullable<short> ActionField;

        private string BillingTypeCodeField;

        private string COAEndItemPartNumberField;

        private ContractAmendmentRequestDTO ContractAmendmentRequestField;

        private System.Nullable<long> ContractAmendmentRequestIDField;

        private string ContractNumberField;

        private System.Nullable<System.DateTime> DateOnPriceListField;

        private bool DisplayStatusField;

        private string LanguageCodeField;

        private string LanguageNameField;

        private string LicensableIDField;

        private string ProductGroupingField;

        private System.Nullable<long> ProductIDField;

        private string ProductNameField;

        private System.Nullable<short> StatusField;

        private string VisibleActionField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Action
        {
            get
            {
                return this.ActionField;
            }
            set
            {
                this.ActionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillingTypeCode
        {
            get
            {
                return this.BillingTypeCodeField;
            }
            set
            {
                this.BillingTypeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string COAEndItemPartNumber
        {
            get
            {
                return this.COAEndItemPartNumberField;
            }
            set
            {
                this.COAEndItemPartNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContractAmendmentRequestDTO ContractAmendmentRequest
        {
            get
            {
                return this.ContractAmendmentRequestField;
            }
            set
            {
                this.ContractAmendmentRequestField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> ContractAmendmentRequestID
        {
            get
            {
                return this.ContractAmendmentRequestIDField;
            }
            set
            {
                this.ContractAmendmentRequestIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContractNumber
        {
            get
            {
                return this.ContractNumberField;
            }
            set
            {
                this.ContractNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateOnPriceList
        {
            get
            {
                return this.DateOnPriceListField;
            }
            set
            {
                this.DateOnPriceListField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DisplayStatus
        {
            get
            {
                return this.DisplayStatusField;
            }
            set
            {
                this.DisplayStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LanguageCode
        {
            get
            {
                return this.LanguageCodeField;
            }
            set
            {
                this.LanguageCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LanguageName
        {
            get
            {
                return this.LanguageNameField;
            }
            set
            {
                this.LanguageNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicensableID
        {
            get
            {
                return this.LicensableIDField;
            }
            set
            {
                this.LicensableIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductGrouping
        {
            get
            {
                return this.ProductGroupingField;
            }
            set
            {
                this.ProductGroupingField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> ProductID
        {
            get
            {
                return this.ProductIDField;
            }
            set
            {
                this.ProductIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName
        {
            get
            {
                return this.ProductNameField;
            }
            set
            {
                this.ProductNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleAction
        {
            get
            {
                return this.VisibleActionField;
            }
            set
            {
                this.VisibleActionField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ContractAmendmentRequestDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class ContractAmendmentRequestDTO : DTOBase
    {

        private ContractAmendmentRequestARDetailsDTO[] ContractAmendmentRequestARDetailsField;

        private System.Nullable<long> ContractAmendmentRequestIDField;

        private string CustomerNumberField;

        private string DescriptionField;

        private bool IsArchivedField;

        private string LastModifiedByField;

        private System.Nullable<System.DateTime> LastModifiedDateField;

        private System.Nullable<System.DateTime> SAPResponseDateTimeField;

        private string SAPResponseDetailsField;

        private System.Nullable<short> StatusField;

        private System.Nullable<System.DateTime> SubmissionDateTimeField;

        private System.Nullable<short> TypeField;

        private string UserEmailField;

        private UserInfoDTO UserInfoField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContractAmendmentRequestARDetailsDTO[] ContractAmendmentRequestARDetails
        {
            get
            {
                return this.ContractAmendmentRequestARDetailsField;
            }
            set
            {
                this.ContractAmendmentRequestARDetailsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> ContractAmendmentRequestID
        {
            get
            {
                return this.ContractAmendmentRequestIDField;
            }
            set
            {
                this.ContractAmendmentRequestIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerNumber
        {
            get
            {
                return this.CustomerNumberField;
            }
            set
            {
                this.CustomerNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsArchived
        {
            get
            {
                return this.IsArchivedField;
            }
            set
            {
                this.IsArchivedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastModifiedBy
        {
            get
            {
                return this.LastModifiedByField;
            }
            set
            {
                this.LastModifiedByField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastModifiedDate
        {
            get
            {
                return this.LastModifiedDateField;
            }
            set
            {
                this.LastModifiedDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> SAPResponseDateTime
        {
            get
            {
                return this.SAPResponseDateTimeField;
            }
            set
            {
                this.SAPResponseDateTimeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SAPResponseDetails
        {
            get
            {
                return this.SAPResponseDetailsField;
            }
            set
            {
                this.SAPResponseDetailsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> SubmissionDateTime
        {
            get
            {
                return this.SubmissionDateTimeField;
            }
            set
            {
                this.SubmissionDateTimeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserEmail
        {
            get
            {
                return this.UserEmailField;
            }
            set
            {
                this.UserEmailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserInfoDTO UserInfo
        {
            get
            {
                return this.UserInfoField;
            }
            set
            {
                this.UserInfoField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "UserInfoDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class UserInfoDTO : DTOBase
    {
        public UserInfoDTO()
        {
            base.SetName = "UserInfo";
        }
        private ContractAmendmentRequestDTO[] ContractAmendmentRequestField;
        private string CountryCodeField;

        private System.Nullable<int> DateFormatField;

        private string EMailField;

        private System.Nullable<int> Entity_IDField;

        private string F_NameField;

        private string FaxField;

        private System.Nullable<int> Geography_IDField;

        private string JobTitleField;

        private System.Nullable<int> LCIDField;

        private string L_NameField;

        private System.Nullable<System.DateTime> LastLoginDateField;

        private System.Nullable<int> Passport_ID_HiField;

        private System.Nullable<int> Passport_ID_LoField;

        private System.Nullable<int> Primary_Cust_IDField;

        private string SkipPassportField;

        private string Special_InfoField;

        private string TelCountryCodeField;

        private string TelExtField;

        private string TelNumberField;

        private System.Nullable<int> TimeZoneField;

        private string skipdcField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContractAmendmentRequestDTO[] ContractAmendmentRequest
        {
            get
            {
                return this.ContractAmendmentRequestField;
            }
            set
            {
                this.ContractAmendmentRequestField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryCode
        {
            get
            {
                return this.CountryCodeField;
            }
            set
            {
                this.CountryCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> DateFormat
        {
            get
            {
                return this.DateFormatField;
            }
            set
            {
                this.DateFormatField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EMail
        {
            get
            {
                return this.EMailField;
            }
            set
            {
                this.EMailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Entity_ID
        {
            get
            {
                return this.Entity_IDField;
            }
            set
            {
                this.Entity_IDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string F_Name
        {
            get
            {
                return this.F_NameField;
            }
            set
            {
                this.F_NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fax
        {
            get
            {
                return this.FaxField;
            }
            set
            {
                this.FaxField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Geography_ID
        {
            get
            {
                return this.Geography_IDField;
            }
            set
            {
                this.Geography_IDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobTitle
        {
            get
            {
                return this.JobTitleField;
            }
            set
            {
                this.JobTitleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> LCID
        {
            get
            {
                return this.LCIDField;
            }
            set
            {
                this.LCIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string L_Name
        {
            get
            {
                return this.L_NameField;
            }
            set
            {
                this.L_NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastLoginDate
        {
            get
            {
                return this.LastLoginDateField;
            }
            set
            {
                this.LastLoginDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Passport_ID_Hi
        {
            get
            {
                return this.Passport_ID_HiField;
            }
            set
            {
                this.Passport_ID_HiField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Passport_ID_Lo
        {
            get
            {
                return this.Passport_ID_LoField;
            }
            set
            {
                this.Passport_ID_LoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Primary_Cust_ID
        {
            get
            {
                return this.Primary_Cust_IDField;
            }
            set
            {
                this.Primary_Cust_IDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SkipPassport
        {
            get
            {
                return this.SkipPassportField;
            }
            set
            {
                this.SkipPassportField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Special_Info
        {
            get
            {
                return this.Special_InfoField;
            }
            set
            {
                this.Special_InfoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TelCountryCode
        {
            get
            {
                return this.TelCountryCodeField;
            }
            set
            {
                this.TelCountryCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TelExt
        {
            get
            {
                return this.TelExtField;
            }
            set
            {
                this.TelExtField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TelNumber
        {
            get
            {
                return this.TelNumberField;
            }
            set
            {
                this.TelNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TimeZone
        {
            get
            {
                return this.TimeZoneField;
            }
            set
            {
                this.TimeZoneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string skipdc
        {
            get
            {
                return this.skipdcField;
            }
            set
            {
                this.skipdcField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "vwViewSubmissionHistoryDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class vwViewSubmissionHistoryDTO : DTOBase
    {

        private System.Nullable<long> ContractAmendmentRequestIDField;

        private string ContractNumberField;

        private string EmailField;

        private System.Nullable<short> StatusField;

        private System.Nullable<System.DateTime> SubmissionDateTimeField;

        private string VisibleDateField;

        private string VisibleStatusField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> ContractAmendmentRequestID
        {
            get
            {
                return this.ContractAmendmentRequestIDField;
            }
            set
            {
                this.ContractAmendmentRequestIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContractNumber
        {
            get
            {
                return this.ContractNumberField;
            }
            set
            {
                this.ContractNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> SubmissionDateTime
        {
            get
            {
                return this.SubmissionDateTimeField;
            }
            set
            {
                this.SubmissionDateTimeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleDate
        {
            get
            {
                return this.VisibleDateField;
            }
            set
            {
                this.VisibleDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleStatus
        {
            get
            {
                return this.VisibleStatusField;
            }
            set
            {
                this.VisibleStatusField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "vwViewSubmissionHistoryDetailsDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class vwViewSubmissionHistoryDetailsDTO : DTOBase
    {

        private string COAEndItemPartNumberField;

        private ContractAmendmentRequestDTO ContractAmendmentRequestField;

        private System.Nullable<long> ContractAmendmentRequestIDField;

        private string ContractNumberField;

        private System.DateTime DateOnPriceListField;

        private bool DisplayStatusField;

        private string FulfillmentTypeField;

        private string LanguageCodeField;

        private string LanguageNameField;

        private string LicensableIDField;

        private string OEMNameField;

        private string ProductGroupingField;

        private System.Nullable<long> ProductIDField;

        private string ProductNameField;

        private System.Nullable<System.DateTime> SubmissionDateTimeField;

        private string VisibleActionField;

        private string VisibleFriendlyNameField;

        private string VisibleProductIDField;

        private string VisibleProductListDateField;

        private string VisibleSubmittedDateField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string COAEndItemPartNumber
        {
            get
            {
                return this.COAEndItemPartNumberField;
            }
            set
            {
                this.COAEndItemPartNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContractAmendmentRequestDTO ContractAmendmentRequest
        {
            get
            {
                return this.ContractAmendmentRequestField;
            }
            set
            {
                this.ContractAmendmentRequestField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> ContractAmendmentRequestID
        {
            get
            {
                return this.ContractAmendmentRequestIDField;
            }
            set
            {
                this.ContractAmendmentRequestIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContractNumber
        {
            get
            {
                return this.ContractNumberField;
            }
            set
            {
                this.ContractNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOnPriceList
        {
            get
            {
                return this.DateOnPriceListField;
            }
            set
            {
                this.DateOnPriceListField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DisplayStatus
        {
            get
            {
                return this.DisplayStatusField;
            }
            set
            {
                this.DisplayStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FulfillmentType
        {
            get
            {
                return this.FulfillmentTypeField;
            }
            set
            {
                this.FulfillmentTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LanguageCode
        {
            get
            {
                return this.LanguageCodeField;
            }
            set
            {
                this.LanguageCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LanguageName
        {
            get
            {
                return this.LanguageNameField;
            }
            set
            {
                this.LanguageNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicensableID
        {
            get
            {
                return this.LicensableIDField;
            }
            set
            {
                this.LicensableIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OEMName
        {
            get
            {
                return this.OEMNameField;
            }
            set
            {
                this.OEMNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductGrouping
        {
            get
            {
                return this.ProductGroupingField;
            }
            set
            {
                this.ProductGroupingField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> ProductID
        {
            get
            {
                return this.ProductIDField;
            }
            set
            {
                this.ProductIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName
        {
            get
            {
                return this.ProductNameField;
            }
            set
            {
                this.ProductNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> SubmissionDateTime
        {
            get
            {
                return this.SubmissionDateTimeField;
            }
            set
            {
                this.SubmissionDateTimeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleAction
        {
            get
            {
                return this.VisibleActionField;
            }
            set
            {
                this.VisibleActionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleFriendlyName
        {
            get
            {
                return this.VisibleFriendlyNameField;
            }
            set
            {
                this.VisibleFriendlyNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleProductID
        {
            get
            {
                return this.VisibleProductIDField;
            }
            set
            {
                this.VisibleProductIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleProductListDate
        {
            get
            {
                return this.VisibleProductListDateField;
            }
            set
            {
                this.VisibleProductListDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisibleSubmittedDate
        {
            get
            {
                return this.VisibleSubmittedDateField;
            }
            set
            {
                this.VisibleSubmittedDateField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ContractInfoDTO", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.DTOs")]
    public partial class ContractInfoDTO : object
    {

        private string AgreementExpirationDateField;

        private string AgreementTypeCodeField;

        private string AgreementTypeDescriptionField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgreementExpirationDate
        {
            get
            {
                return this.AgreementExpirationDateField;
            }
            set
            {
                this.AgreementExpirationDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgreementTypeCode
        {
            get
            {
                return this.AgreementTypeCodeField;
            }
            set
            {
                this.AgreementTypeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgreementTypeDescription
        {
            get
            {
                return this.AgreementTypeDescriptionField;
            }
            set
            {
                this.AgreementTypeDescriptionField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AddRemoveRequestCompositeEntity", Namespace = "http://schemas.datacontract.org/2004/07/MS.IT.OEM.ContractManagement.DataContract" +
        "s.CompositeEntities")]
    public partial class AddRemoveRequestCompositeEntity : object
    {

        private string AssociatedSoldToField;

        private List<ContractAmendmentRequestARDetailsDTO> ContractAddRemoveRequestDetailsField;

        private UserInfoDTO UserInfoField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AssociatedSoldTo
        {
            get
            {
                return this.AssociatedSoldToField;
            }
            set
            {
                this.AssociatedSoldToField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<ContractAmendmentRequestARDetailsDTO> ContractAddRemoveRequestDetails
        {
            get
            {
                return this.ContractAddRemoveRequestDetailsField;
            }
            set
            {
                this.ContractAddRemoveRequestDetailsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserInfoDTO UserInfo
        {
            get
            {
                return this.UserInfoField;
            }
            set
            {
                this.UserInfoField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IAddRemoveProuctsService")]
    public interface IAddRemoveProuctsService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAddRemoveProuctsService/RetrieveOrgData", ReplyAction = "http://tempuri.org/IAddRemoveProuctsService/RetrieveOrgDataResponse")]
        OrganizationAndAgreementCollection RetrieveOrgData(int userID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAddRemoveProuctsService/RetrieveOrgData", ReplyAction = "http://tempuri.org/IAddRemoveProuctsService/RetrieveOrgDataResponse")]
        System.Threading.Tasks.Task<OrganizationAndAgreementCollection> RetrieveOrgDataAsync(int userID);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IAddRemoveProuctsService/SubmitAddRemoveRequest")]
        void SubmitAddRemoveRequest(AddRemoveRequestCompositeEntity addRemoveRequestCompositeEntity);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IAddRemoveProuctsService/SubmitAddRemoveRequest")]
        System.Threading.Tasks.Task SubmitAddRemoveRequestAsync(AddRemoveRequestCompositeEntity addRemoveRequestCompositeEntity);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAddRemoveProuctsService/RetrieveSubmittedRequests", ReplyAction = "http://tempuri.org/IAddRemoveProuctsService/RetrieveSubmittedRequestsResponse")]
        vwViewSubmissionHistoryDTO[] RetrieveSubmittedRequests(string contractNumbers, int historyPeriod);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAddRemoveProuctsService/RetrieveSubmittedRequests", ReplyAction = "http://tempuri.org/IAddRemoveProuctsService/RetrieveSubmittedRequestsResponse")]
        System.Threading.Tasks.Task<vwViewSubmissionHistoryDTO[]> RetrieveSubmittedRequestsAsync(string contractNumbers, int historyPeriod);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAddRemoveProuctsService/RetrieveAddRemoveRequestDetails", ReplyAction = "http://tempuri.org/IAddRemoveProuctsService/RetrieveAddRemoveRequestDetailsRespon" +
            "se")]
        vwViewSubmissionHistoryDetailsDTO[] RetrieveAddRemoveRequestDetails(int contractAmendmentRequestID, int EntityID);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAddRemoveProuctsService/RetrieveAddRemoveRequestDetails", ReplyAction = "http://tempuri.org/IAddRemoveProuctsService/RetrieveAddRemoveRequestDetailsRespon" +
            "se")]
        System.Threading.Tasks.Task<vwViewSubmissionHistoryDetailsDTO[]> RetrieveAddRemoveRequestDetailsAsync(int contractAmendmentRequestID, int EntityID);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public interface IAddRemoveProuctsServiceChannel : IAddRemoveProuctsService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public partial class AddRemoveProuctsServiceClient : System.ServiceModel.ClientBase<IAddRemoveProuctsService>, IAddRemoveProuctsService
    {

        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);





        public OrganizationAndAgreementCollection RetrieveOrgData(int userID)
        {
            return base.Channel.RetrieveOrgData(userID);
        }

        public System.Threading.Tasks.Task<OrganizationAndAgreementCollection> RetrieveOrgDataAsync(int userID)
        {
            return base.Channel.RetrieveOrgDataAsync(userID);
        }

        public void SubmitAddRemoveRequest(AddRemoveRequestCompositeEntity addRemoveRequestCompositeEntity)
        {
            base.Channel.SubmitAddRemoveRequest(addRemoveRequestCompositeEntity);
        }

        public System.Threading.Tasks.Task SubmitAddRemoveRequestAsync(AddRemoveRequestCompositeEntity addRemoveRequestCompositeEntity)
        {
            return base.Channel.SubmitAddRemoveRequestAsync(addRemoveRequestCompositeEntity);
        }

        public vwViewSubmissionHistoryDTO[] RetrieveSubmittedRequests(string contractNumbers, int historyPeriod)
        {
            return base.Channel.RetrieveSubmittedRequests(contractNumbers, historyPeriod);
        }

        public System.Threading.Tasks.Task<vwViewSubmissionHistoryDTO[]> RetrieveSubmittedRequestsAsync(string contractNumbers, int historyPeriod)
        {
            return base.Channel.RetrieveSubmittedRequestsAsync(contractNumbers, historyPeriod);
        }

        public vwViewSubmissionHistoryDetailsDTO[] RetrieveAddRemoveRequestDetails(int contractAmendmentRequestID, int EntityID)
        {
            return base.Channel.RetrieveAddRemoveRequestDetails(contractAmendmentRequestID, EntityID);
        }

        public System.Threading.Tasks.Task<vwViewSubmissionHistoryDetailsDTO[]> RetrieveAddRemoveRequestDetailsAsync(int contractAmendmentRequestID, int EntityID)
        {
            return base.Channel.RetrieveAddRemoveRequestDetailsAsync(contractAmendmentRequestID, EntityID);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        /*private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAddRemoveProuctsService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }*/

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAddRemoveProuctsService))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost/ContractManagement/AddRemoveProductService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }


        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AddRemoveProuctsServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IAddRemoveProuctsService);
        }

        public enum EndpointConfiguration
        {

            BasicHttpBinding_IAddRemoveProuctsService,
        }
    }
}
