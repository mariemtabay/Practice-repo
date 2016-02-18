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
    public partial class OrderingSystem : OrderingSystemExt
    {

        
        public OrderingSystem()
        {
            InitializeComponent();
            populateIndividual();
            populateCustomer();
            populateCompany();

            populateProduct();
            populateHardware();
            populateSoftware();
        }


        private void createNewCustomer(object sender, EventArgs e)
        {
            is_newCustomer = true;

            this.individual_licence.ResetText();
            this.company_contact.ResetText();
            this.customer_address.ResetText();
            this.customer_name.ResetText();
            this.customer_phone.ResetText();
            this.company_discount.ResetText();
            this.customer_id.ResetText();

            this.customer_address.Enabled = true;
            this.customer_name.Enabled = true;
            this.customer_id.Enabled = true;
            this.customer_phone.Enabled = true;
            this.company_discount.Enabled = true;

            this.save.Visible = true;
            this.cancel_button.Visible = true;

        }

        private void saveCustomer(object sender, EventArgs e)
        {
            Individual individual;
            Company company;
            Customer customer;
            String result;
            String licence;
            String contact;
            bool is_readyToInsert = true;
            String target_table = null;
            if (this.individual_licence.TextLength > 0)
            {
                target_table = INDIVIDUAL_TABLE;
                licence = this.individual_licence.Text;
                result = findValue(INDIVIDUAL_TABLE, iLICENCE, iLICENCE, licence);
                if (result != null)
                {
                    MessageBox.Show("licence not available");
                    is_readyToInsert = false;
                }
                else
                {
                    
                }

            }
            else if (this.company_contact.TextLength > 0)
            {
                target_table = COMPANY_TABLE;
                contact = this.company_contact.Text;
                result = findValue(COMPANY_TABLE, cpCONTACT, cpCONTACT, contact);
                if (result != null)
                {
                    MessageBox.Show("contact person already exists.");
                    is_readyToInsert = false;
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("fill required fields");
                is_readyToInsert = false;
            }

            String customer_id = this.customer_id.Text;
            result = findValue(CUSTOMER_TABLE, cCUSTOMER_ID, cCUSTOMER_ID, customer_id);
            if (result != null)
            {
                MessageBox.Show("customer id not available.");
                is_readyToInsert = false;
            }

            if (is_readyToInsert)
            {
                customer = new Customer();
                individual = new Individual();
                company = new Company();
                String add_licence;
                String add_contact;

                String add_discount;

                String add_address = this.customer_address.Text;
                String add_name = this.customer_name.Text;
                String add_phone = this.customer_phone.Text;
                String add_id = this.customer_id.Text;

               


                if (target_table == INDIVIDUAL_TABLE)
                {
                    add_licence = this.individual_licence.Text;

                    individual.LicNumber = add_licence;
                    individual.Id = Convert.ToInt32(add_id);
                    individual.Address = add_address;
                    individual.Name = add_name;
                    individual.Phone = add_phone;

                    item = new ListViewItem(individual.getId().ToString());
                    item.SubItems.Add(individual.getAddress());
                    item.SubItems.Add(individual.getName());
                    item.SubItems.Add(individual.getPhone());
                    list_customer.Items.AddRange(new ListViewItem[] { item });




                    item = new ListViewItem(individual.getLicenseNumber());
                    item.SubItems.Add(add_id);
                    list_individual.Items.AddRange(new ListViewItem[] { item });



                    
                }
                else if (target_table == COMPANY_TABLE) 
                {
                    add_contact = this.company_contact.Text;
                    add_discount = this.company_discount.Text;

                    company.Contact = add_contact;
                    company.Discount = Convert.ToInt32(add_discount);
                    company.Id = Convert.ToInt32(add_id);
                    company.Address = add_address;
                    company.Name = add_name;
                    company.Phone = add_phone;

                    item = new ListViewItem(company.getId().ToString());
                    item.SubItems.Add(company.getAddress());
                    item.SubItems.Add(company.getName());
                    item.SubItems.Add(company.getPhone());
                    list_customer.Items.AddRange(new ListViewItem[] { item });

                    item = new ListViewItem(        company.getContact());
                    item.SubItems.Add(              company.getDiscount().ToString());
                    item.SubItems.Add(add_id);
                    list_company.Items.AddRange(new ListViewItem[] { item });

                }


                is_newCustomer = false;
                this.customer_address.Enabled = false;
                this.customer_name.Enabled = false;
                this.customer_id.Enabled = false;
                this.customer_phone.Enabled = false;
                this.company_discount.Enabled = false;

                this.save.Visible = false;
                this.cancel_button.Visible = false;

                MessageBox.Show("Saved");


            }


        }

        private void cancel(object sender, EventArgs e)
        {
            this.individual_licence.ResetText();
            this.company_contact.ResetText();
            this.customer_address.ResetText();
            this.customer_name.ResetText();
            this.customer_phone.ResetText();
            this.company_discount.ResetText();
            this.customer_id.ResetText();

            this.customer_address.Enabled = false;
            this.customer_name.Enabled = false;
            this.customer_id.Enabled = false;
            this.customer_phone.Enabled = false;
            this.company_discount.Enabled = false;

            this.save.Visible = false;
            this.cancel_button.Visible = false;
            is_newCustomer = false;

        }

        private String findValue(String table,int select,int where,String value)
        {
            String to_return = null;
            ListViewItem item = null;
            try
            {
                switch (table)
                {
                    case INDIVIDUAL_TABLE:
                        item = list_individual.FindItemWithText(value);
                        list = list_individual;
                        break;

                    case CUSTOMER_TABLE:
                        item = list_customer.FindItemWithText(value);
                        list = list_customer;
                        break;

                    case COMPANY_TABLE:
                        item = list_company.FindItemWithText(value);
                        list = list_company;
                        break;

                    case HARDWARE_TABLE:
                        item = list_hardware.FindItemWithText(value);
                        list = list_hardware;
                        break;

                    case SOFTWARE_TABLE:
                        item = list_software.FindItemWithText(value);
                        list = list_software;
                        break;

                    case PRODUCT_TABLE:
                        item = list_product.FindItemWithText(value);
                        list = list_product;
                        break;

                    case ORDER_ITEM_TABLE:
                        item = list_orderitem.FindItemWithText(value);
                        list = list_orderitem;
                        break;

                    case ORDER_TABLE:
                        item = list_order.FindItemWithText(value);
                        list = list_order;
                        break;

                    case SELECTED_ORDER_VIEW:
                        item = selected_listview.FindItemWithText(value);
                        list = selected_listview;
                        break;


                    default:
                        MessageBox.Show("table not found");
                        break;

                }
            }
      
            catch(Exception e){
               
            }
            
            int index;
            if (item != null)
            {
               
                index = Convert.ToInt32(list.Items.IndexOf(item).ToString());
                String result = (list.Items[index].SubItems[where].Text);

                if (value == result)
                {
                    to_return = (list.Items[index].SubItems[select].Text);
                    
                }
  
            }
   

            return to_return;

        }

        private void searchIndividualLicence(object sender, KeyPressEventArgs e)
        {
            this.company_contact.ResetText();
            if (is_newCustomer) {
                this.company_discount.Text = "N/A";
            }
           
            this.company_discount.Enabled = false;
            if (e.KeyChar == 13 && !is_newCustomer)
            {
                String input = this.individual_licence.Text;
                printCustomer(input,INDIVIDUAL_TABLE);
            }
        }

        private void searchCompanyContact(object sender, KeyPressEventArgs e)
        {
            this.company_discount.Text = "";
            if (is_newCustomer) {
                this.company_discount.Enabled = true;
            }
        
            this.individual_licence.ResetText();
            if (e.KeyChar == 13 && !is_newCustomer)
            {
                String input = this.company_contact.Text;
                printCustomer(input,COMPANY_TABLE);
            }
        }

        private void printCustomer(String input,String table)
        {
            Random rnd = new Random();
            
            generated_orderno = rnd.Next(100000, 200000);
            this.label_orderno.Text = generated_orderno.ToString();
            String customer_id = null;
            String discount = null; ;

            switch (table)
            {
                case INDIVIDUAL_TABLE:
                    customer_id = findValue(INDIVIDUAL_TABLE, iCUSTOMER_ID, iLICENCE, input);
                    
                    break;
                case COMPANY_TABLE:
                    customer_id = findValue(COMPANY_TABLE, cpCUSTOMER_ID, cpCONTACT, input);
                    break;
            }

            
            String name = findValue(CUSTOMER_TABLE, cNAME, cCUSTOMER_ID, customer_id);
            String address = findValue(CUSTOMER_TABLE, cADDRESS, cCUSTOMER_ID, customer_id);
            String phone = findValue(CUSTOMER_TABLE, cPHONE, cCUSTOMER_ID, customer_id);
            String id = findValue(CUSTOMER_TABLE, cCUSTOMER_ID, cCUSTOMER_ID, customer_id);


            switch (table)
            {
                case INDIVIDUAL_TABLE:
                    Individual individual = new Individual();
                    discount = "N/A";

                    //individual.LicNumber = input;
                   
                    individual.Id = Convert.ToInt32(id);
                    individual.Address = address;
                    individual.Name = name;
                    individual.Phone = phone;

                    this.company_discount.Text = discount;

                    this.customer_name.Text = individual.getName();;
                    this.customer_address.Text = individual.getAddress();
                    this.customer_phone.Text = individual.getPhone();
                    this.customer_id.Text = individual.getId().ToString();
                    
                    

                    break;

                case COMPANY_TABLE:
                    Company company = new Company();
                    discount = findValue(COMPANY_TABLE, cpDISCOUNT, cpCONTACT, input);

                    company.Contact = input;
                    company.Discount = Convert.ToInt32(discount);
                    company.Id = Convert.ToInt32(id);
                    company.Address = address;
                    company.Name = name;
                    company.Phone = phone;

                    this.company_discount.Text = company.getDiscount().ToString();

                    this.customer_name.Text = company.getName();;
                    this.customer_address.Text = company.getAddress();
                    this.customer_phone.Text = company.getPhone();
                    this.customer_id.Text = company.getId().ToString();


                    break;
                    
            }





            

            if (customer_id == null)
            {
                this.customer_id.ResetText();
                this.company_discount.ResetText();
                MessageBox.Show("Customer Not Found");
            }

        }

        private void selectCategory(object sender, EventArgs e)
        {
            if (product_listview.Items.Count > 0)
            {
                this.product_listview.Items.Clear();
                this.product_listview.Update(); 
                this.product_listview.Refresh();
            }
            String value = category_combobox.Text;
            if (value == "Hardware")
            {
                viewHardwareList();
              
            }
            else if (value == "Software")
            {
                viewSoftwareList();
          
            }
        }

        private void viewHardwareList()
        {
            is_hardware = true;
            ListViewItem product_item;
            foreach (ListViewItem row in list_hardware.Items)
            {
                String warranty = row.SubItems[hWARRANTY_PERIOD].Text;
                String prod_id = row.SubItems[hPRODUCT_ID].Text;
                String prod_name = findValue(PRODUCT_TABLE, pNAME, pPRODUCT_ID, prod_id);
                String prod_price = findValue(PRODUCT_TABLE, pRETAIL_PRICE, pPRODUCT_ID, prod_id);
                String prod_description = findValue(PRODUCT_TABLE, pDESCRIPTION, pPRODUCT_ID, prod_id);

                Hardware hardware = new Hardware();
                hardware.WarrantyPeriod = Convert.ToInt32(warranty);
                hardware.Description = prod_description;
                hardware.Id = Convert.ToInt32(prod_id);
                hardware.Name = prod_name;
                hardware.RetailPrice = Convert.ToDouble(prod_price);
                


                product_item = new ListViewItem(hardware.Name);
                product_item.SubItems.Add(hardware.getDescription());
                product_item.SubItems.Add(hardware.RetailPrice.ToString());
                product_item.SubItems.Add(hardware.WarrantyPeriod.ToString());
                product_item.SubItems.Add("N/A");
                product_listview.Items.AddRange(new ListViewItem[] { product_item });

            }

           
        }

        private void viewSoftwareList()
        {
            is_hardware = false;
            ListViewItem product_item;
            foreach (ListViewItem row in list_software.Items)
            {
                String licence = row.SubItems[sLICENCE].Text;
                String prod_id = row.SubItems[sPRODUCT_ID].Text;
                String prod_name = findValue(PRODUCT_TABLE, pNAME, pPRODUCT_ID, prod_id);
                String prod_price = findValue(PRODUCT_TABLE, pRETAIL_PRICE, pPRODUCT_ID, prod_id);
                String prod_description = findValue(PRODUCT_TABLE, pDESCRIPTION, pPRODUCT_ID, prod_id);

                Software software = new Software();
                software.Licence = licence;
                software.Description = prod_description;
                software.Id = Convert.ToInt32(prod_id);
                software.Name = prod_name;
                software.RetailPrice = Convert.ToDouble(prod_price);

                product_item = new ListViewItem(software.Name);
                product_item.SubItems.Add(software.getDescription());
                product_item.SubItems.Add(software.RetailPrice.ToString());
                product_item.SubItems.Add("N/A");
                product_item.SubItems.Add(software.getLicenceNo());
                product_listview.Items.AddRange(new ListViewItem[] { product_item });

            }

        }

        private void pickProduct(object sender, EventArgs e)
        {
            String prod_name = (product_listview.SelectedItems[0].Text);


            OrderItem orderitem = new OrderItem();
            
            Product product = new Product();
            product.Name = prod_name;

            String search_result = findValue(SELECTED_ORDER_VIEW, sov_prod_name, sov_prod_name, product.Name);
            String unit_price = findValue(PRODUCT_TABLE, pRETAIL_PRICE, pNAME, prod_name);
            
           
            if (search_result == null)
            {
               
                ListViewItem selected_item;
                generated_lineno = selected_listview.Items.Count;
                generated_lineno++;
                orderitem.Quantity = generated_quantity;
                product.RetailPrice = Convert.ToDouble(unit_price);

                if (is_hardware)
                {
                    double tax = new Hardware().getTax();
                    product.RetailPrice += product.RetailPrice * tax;
                    //MessageBox.Show(tax.ToString());
                }
               
                selected_item = new ListViewItem(generated_lineno.ToString());
                selected_item.SubItems.Add(product.Name);
                selected_item.SubItems.Add(product.RetailPrice.ToString("C"));
                selected_item.SubItems.Add(orderitem.getQuantity().ToString());
                selected_listview.Items.AddRange(new ListViewItem[] { selected_item });
            }

            



            
            
            
        }

        private void delete_selected(object sender, EventArgs e)
        {
            String prod_name = (selected_listview.SelectedItems[0].SubItems[1].Text);
            var index = selected_listview.FindItemWithText(prod_name);


            foreach (ListViewItem item in selected_listview.Items)
                if (item.Selected)
                    selected_listview.Items.Remove(item);

          

        }










    }


}
