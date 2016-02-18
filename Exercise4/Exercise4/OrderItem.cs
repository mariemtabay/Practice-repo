using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class OrderItem :Product
    {
        List<String> list = new List<String>();
        private int lineNbr;

        public int LineNbr
        {
            get { return lineNbr; }
            set { lineNbr = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product getProduct()
        {
            Product product = new Product();
            return product;
        }

     

        public int getQuantity()
        {
            return quantity;
        }
        //private int orderPrice;
      

   


        
    }
}
