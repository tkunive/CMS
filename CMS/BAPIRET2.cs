using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS
{
    public class BAPIRET2

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
}
