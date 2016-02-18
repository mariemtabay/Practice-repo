using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Order:Customer
    {

        private int id;

        public int Id1
        {
            get { return id; }
            set { id = value; }
        }
        private String[] items;

        public String[] Items
        {
            get { return items; }
            set { items = value; }
        }
        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        private double orderTotal;

        public double OrderTotal
        {
            get { return orderTotal; }
            set { orderTotal = value; }
        }
      


       
        
    }
}
