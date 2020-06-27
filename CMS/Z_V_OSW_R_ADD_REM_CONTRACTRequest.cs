using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS
{
    public class Z_V_OSW_R_ADD_REM_CONTRACTRequest
    {
        public ZLW_AGR_ADD_REM_CONTRACT[] In_Agr_Add_Rem_Contract_In { get; set; }
        public ZLW_OUT_GENERAL_DATA[] Out_General_Data_In { get; set; }
        public BAPIRET2[] Out_Messages_In { get; set; }
    }
}
