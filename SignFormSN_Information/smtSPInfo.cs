using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFormSN_Information
{
    public class smtSPInfo
    {
        private string strSN = "";
        private string strWO = "";
        private string strLine = "";
        private string strDate = "";

        public string StrSN
        {
            get
            {
                return strSN;
            }

            set
            {
                strSN = value;
            }
        }

        public string StrWO
        {
            get
            {
                return strWO;
            }

            set
            {
                strWO = value;
            }
        }

        public string StrLine
        {
            get
            {
                return strLine;
            }

            set
            {
                strLine = value;
            }
        }

        public string StrDate
        {
            get
            {
                return strDate;
            }

            set
            {
                strDate = value;
            }
        }
    }
}
