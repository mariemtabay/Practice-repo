using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Product
    {
        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private double retailPrice;

        public double RetailPrice
        {
            get { return retailPrice; }
            set { retailPrice = value; }
        }
        
        public String getDescription() {

            return description;
        }



    }
}
