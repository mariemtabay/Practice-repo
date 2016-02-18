using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Hardware : Product, Taxable
    {
        private int warrantyPeriod;

        public int WarrantyPeriod
        {
            get { return warrantyPeriod; }
            set { warrantyPeriod = value; }
        }

        public int getWarrantyPeriod()
        {
            return warrantyPeriod;
        }

        public double getTax()
        {
            return 0.10;
        }

   
    }

  
}
