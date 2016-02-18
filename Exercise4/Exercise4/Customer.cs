using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Customer
    {
        private int id;
        private String address;
        private String name;
        private String phone;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int getId() {

            return id;
        }
        public String getAddress() {

            return address;
        }

        public String getName() {

            return name;
        }

        public String getPhone()
        {
            return phone;
        }


    }
    

}
