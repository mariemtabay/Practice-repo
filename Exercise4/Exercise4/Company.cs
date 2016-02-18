using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Company:Customer
    {
        private String contact;
        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public String Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public String getContact() {

            return contact;
        }
        public int getDiscount() {

            return discount;
        }
      
    
    }
}
