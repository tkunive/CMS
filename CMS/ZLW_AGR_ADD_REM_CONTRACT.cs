using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS
{
    public class ZLW_AGR_ADD_REM_CONTRACT
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
