using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Software : Product
    {
        private String licence;

        public String Licence
        {
            get { return licence; }
            set { licence = value; }
        }

        public String getLicenceNo()
        {
            return licence;
        }

    }
}
