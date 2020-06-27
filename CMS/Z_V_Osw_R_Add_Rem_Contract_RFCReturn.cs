using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS
{
    public class Z_V_Osw_R_Add_Rem_Contract_RFCReturn
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
}
