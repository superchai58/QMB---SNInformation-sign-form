using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFormSN_Information
{
    public class snTraceInfo
    {
        private string strSN = "";
        private string strStation = "";
        private string strStatus = "";
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

        public string StrStation
        {
            get
            {
                return strStation;
            }

            set
            {
                strStation = value;
            }
        }

        public string StrStatus
        {
            get
            {
                return strStatus;
            }

            set
            {
                strStatus = value;
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
