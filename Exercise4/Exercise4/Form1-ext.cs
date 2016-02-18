using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class OrderingSystemExt : Form
    {



        public ListView populateIndividual()
        {

            list_individual = new ListView();

            item = new ListViewItem("L1001");
            item.SubItems.Add("1");
            list_individual.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("L1002");
            item.SubItems.Add("2");
            list_individual.Items.AddRange(new ListViewItem[] { item });

            return list_individual;

        }

        public ListView populateCompany()
        {
            list_company = new ListView();

            item = new ListViewItem("Gregg");
            item.SubItems.Add("0");
            item.SubItems.Add("3");
            list_company.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("Jovy");
            item.SubItems.Add("0");
            item.SubItems.Add("4");
            list_company.Items.AddRange(new ListViewItem[] { item });

            return list_company;

        }

        public ListView populateCustomer()
        {
            list_customer = new ListView();

            item = new ListViewItem("1");
            item.SubItems.Add("Talisay");
            item.SubItems.Add("Mariem");
            item.SubItems.Add("0975");
            list_customer.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("2");
            item.SubItems.Add("Toledo");
            item.SubItems.Add("Reindel");
            item.SubItems.Add("0910");
            list_customer.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("3");
            item.SubItems.Add("Cebu");
            item.SubItems.Add("Mariem Technologies, Inc.");
            item.SubItems.Add("325-0001");
            list_customer.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("4");
            item.SubItems.Add("Cebu");
            item.SubItems.Add("Mariem Technologies, Inc.");
            item.SubItems.Add("325-0022");
            list_customer.Items.AddRange(new ListViewItem[] { item });

            return list_customer;

        }

        public ListView populateHardware() {

            

            list_hardware= new ListView();

            item = new ListViewItem("1");
            item.SubItems.Add("10001");
            list_hardware.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("4");
            item.SubItems.Add("10002");
            list_hardware.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("1");
            item.SubItems.Add("10003");
            list_hardware.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("2");
            item.SubItems.Add("10004");
            list_hardware.Items.AddRange(new ListViewItem[] { item });

 

            return list_hardware;
        }

        public ListView populateSoftware()
        {

            list_software = new ListView();

            item = new ListViewItem("AA-01");
            item.SubItems.Add("10005");
            list_software.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("AA-02");
            item.SubItems.Add("10006");
            list_software.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("AA-03");
            item.SubItems.Add("10007");
            list_software.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("AA-04");
            item.SubItems.Add("10008");
            list_software.Items.AddRange(new ListViewItem[] { item });

            return list_software;
        }

        public ListView populateProduct()
        {

            list_product = new ListView();

            item = new ListViewItem("90 watts");
            item.SubItems.Add("10001");
            item.SubItems.Add("LED Light");
            item.SubItems.Add("60.00");
            list_product.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("5KG");
            item.SubItems.Add("10002");
            item.SubItems.Add("Washing Machine");
            item.SubItems.Add("2000.00");
            list_product.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("Sync rice cooker status to your android device");
            item.SubItems.Add("10003");
            item.SubItems.Add("Android Rice Cooker");
            item.SubItems.Add("8000.00");
            list_product.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("With taser for unrecognizable users");
            item.SubItems.Add("10004");
            item.SubItems.Add("Electric Door Knob");
            item.SubItems.Add("9000.00");
            list_product.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("Can make you beautiful");
            item.SubItems.Add("10005");
            item.SubItems.Add("Power Photo Editor");
            item.SubItems.Add("300.00");
            list_product.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("For Windows and MAC");
            item.SubItems.Add("10006");
            item.SubItems.Add("Wifi Stealer");
            item.SubItems.Add("200.00");
            list_product.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("Turns your phone into waterproof");
            item.SubItems.Add("10007");
            item.SubItems.Add("Super Smart Protector App");
            item.SubItems.Add("1200.00");
            list_product.Items.AddRange(new ListViewItem[] { item });

            item = new ListViewItem("Turns off your phone.");
            item.SubItems.Add("10008");
            item.SubItems.Add("Battery Saver App");
            item.SubItems.Add("2200.00");
            list_product.Items.AddRange(new ListViewItem[] { item });

  



            return list_product;
        }



        protected bool is_newCustomer = false;
        protected bool is_hardware = false;
        protected ListView list;
        protected ListView list_individual;
        protected ListView list_customer;
        protected ListView list_company;
        protected ListView list_hardware;
        protected ListView list_software;
        protected ListView list_product;
        protected ListView list_orderitem;
        protected ListView list_order;


        protected const String INDIVIDUAL_TABLE = "individual";
        protected const int iLICENCE = 0;
        protected const int iCUSTOMER_ID = 1;

        protected const String CUSTOMER_TABLE = "customer";
        protected const int cCUSTOMER_ID = 0;
        protected const int cADDRESS = 1;
        protected const int cNAME = 2;
        protected const int cPHONE = 3;

        protected const String COMPANY_TABLE = "company";
        protected const int cpCONTACT = 0;
        protected const int cpDISCOUNT = 1;
        protected const int cpCUSTOMER_ID = 2;

        protected const String HARDWARE_TABLE = "hardware";
        protected const int hWARRANTY_PERIOD = 0;
        protected const int hPRODUCT_ID = 1;

        protected const String SOFTWARE_TABLE = "software";
        protected const int sLICENCE = 0;
        protected const int sPRODUCT_ID = 1;

        protected const String PRODUCT_TABLE = "product";
        protected const int pDESCRIPTION = 0;
        protected const int pPRODUCT_ID = 1;
        protected const int pNAME = 2;
        protected const int pRETAIL_PRICE = 3;

        protected const String ORDER_ITEM_TABLE = "order_item";
        protected const int oi_linenbr = 0;
        protected const int oi_quantity = 1;
        protected const int oi_productid = 3;
        protected const int oi_orderid = 2;

        protected const String ORDER_TABLE = "order";
        protected const int o_orderid = 0;
        protected const int o_date = 1;
        protected const int o_customer = 2;

        protected const String SELECTED_ORDER_VIEW = "selected_order_view";
        protected const int sov_lineno = 0;
        protected const int sov_prod_name = 1;
        protected const int sov_quanity = 2;
        protected const int sov_itemtotal = 3;




        protected const int view_productname = 0;
        protected const int view_price = 2;
        protected const int view_warranty = 3;
        protected const int view_licence = 4;
         


        protected int generated_orderno;
        protected int generated_lineno = 0;
        protected int generated_quantity = 1;
        protected ListViewItem item;
        

    }
}
