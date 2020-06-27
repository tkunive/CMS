using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS
{
    public class ZLW_OUT_GENERAL_DATA
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
}
