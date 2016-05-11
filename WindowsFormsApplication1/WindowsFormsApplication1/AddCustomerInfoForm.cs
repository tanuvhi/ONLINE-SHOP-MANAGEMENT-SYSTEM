using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraShopBd.DataAccess;
using UltraShopBd.Entites;

namespace WindowsFormsApplication1
{
    public partial class AddCustomerInfoForm : Form
    {
        AddCustomerInfo customer = new AddCustomerInfo();
        AddcustomerInfoDA customerData = new AddcustomerInfoDA();
        AddOrderForm OrderFrom = new AddOrderForm();
        Login userInfo = new Login();
        
       

        public AddCustomerInfoForm()
        {
            InitializeComponent();
            FillRegionCombo();
            FillShippersCombo();

           
        }

        public void GetUserData(Login user)
        {
            userInfo = user;

        }

        private  void FillRegionCombo()
        {
           
            List<AddCustomerInfo> region = new List<AddCustomerInfo>();


            region = customerData.GetComboData("regions","region_name");

            foreach(AddCustomerInfo  add in region)
            {

                regionComboBox.Items.Add(add.name);
            }


        }

        private void FillShippersCombo()
        {

            List<AddCustomerInfo> shippers = new List<AddCustomerInfo>();


            shippers = customerData.GetComboData("shippers", "company_name");

            foreach (AddCustomerInfo add in shippers)
            {

              shipComboBox.Items.Add(add.name);
            }


        }

        private void splitContainer1_Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shipLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            

            customer.phone_num1 = PhoneTextBox.Text.Trim();

            if (customer.phone_num1.Length == 0)
            {
                MessageBox.Show("please input phone number \n");


            }
            else
            {
                AddCustomerInfo cus = new AddCustomerInfo();
                cus = customerData.GetCustomerId(customer.phone_num1);
                if (cus.customer_id ==-1)
                {

                    MessageBox.Show("Not Found");

                }
                else
                {
                    customer =cus;
                    this.Hide();
                    OrderFrom.GetCustomerInfo(customer);
                    OrderFrom.GetUserData(userInfo);
                    OrderFrom.Show();
                    
                }
            }


        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.MaxLength = 40;

        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {

            customer.name = nameTextBox.Text.Trim();
            customer.address1 = addressTextBox.Text.Trim();
            
            customer.phone_num1 = PhoneTextBox.Text.Trim();
            customer.phone_num2 = phoneTextBox2.Text.Trim();
            customer.region = regionComboBox.Text.Trim();
            customer.city = cityComboBox.Text.Trim();
            customer.company_name = shipComboBox.Text.Trim();
            int flag = 0;
            int flag2 = 0;
            int flag3 = 0;
            string mobielOperator1="";
            string mobielOperator2="";
            int p1L=customer.phone_num1.Length;
            int p2L = customer.phone_num2.Length;
            string message = " ";

            
            if( p1L >2)
            {
                flag2 = 1;
                mobielOperator1 = customer.phone_num1.Substring(0, 3);
            }

            if (p2L >2)
            {
                flag3 = 1;
                mobielOperator2 = customer.phone_num2.Substring(0, 3);
                
            }


            if (p2L> 0 && p2L < 9)
            {
                flag = 1;
                message += "Invalid phone number \n";
            }

            if(p1L >0 && p1L < 9)
            {
                flag = 1;
                message += "Invalid phone number \n";
            }



            if (flag2 == 1 && flag == 0)
            {
                if (mobielOperator1 == "016" || mobielOperator1 == "017" || mobielOperator1 == "018" || mobielOperator1 == "019" || mobielOperator1 == "044" || mobielOperator1 == "015" || mobielOperator1 == "011")
                {

                    if (p1L < 11)
                    {
                        flag = 1;
                        message += "Invalid phone number \n";
                    }
                }

            }
            if (flag3 == 1 && flag==0)
            {
                if (mobielOperator2 == "016" || mobielOperator2 == "017" || mobielOperator2 == "018" || mobielOperator2 == "019" || mobielOperator2 == "044" || mobielOperator2 == "015" || mobielOperator1 == "011")
                {
                    if(p2L <11)
                    {
                        flag = 1;
                    message += "Invalid phone number \n";
                    }

                }

            }



            if (p1L == 0)
            {
                flag = 1;
                message += "Please input phone number\n";
            }
            

            if(customer.name.Length == 0)
            {
                flag = 1;

                message += "Please enter customer name\n "; 
            }
          
            if(customer.address1.Length == 0 )
            {

                flag = 1;
                message += "Please enter address1\n";
            }
            else
            {
                customer.address1.Replace(Environment.NewLine, " ");
            }

            if(regionComboBox.SelectedIndex == -1 || customer.region.Length == 0)
            {

                flag = 1;
                message += "please select region\n";
            }

            if(cityComboBox.SelectedIndex == -1  || customer.city.Length == 0)
            {

                flag =1;
                message +="Please select city\n";
            }
            else
            {
                customer.city_id = customerData.GetId("city","city_name",customer.city);
               
            }
            if ( shipComboBox.SelectedIndex == -1 || customer.company_name.Length == 0)
            {

                flag =1;
                message +="Please select shippiny company\n";
            }
            else
            {

                customer.shipper_id = customerData.GetId("shippers", "company_name", customer.company_name);
            }

  
        
     
            
            if(flag==1)
            {

                MessageBox.Show(message);

            }
            else
            {
                AddCustomerInfo cus = new AddCustomerInfo();
                cus = customerData.GetCustomerId(customer.phone_num1);


                if (cus.customer_id == -1 && p2L!=0)
                cus = customerData.GetCustomerId(customer.phone_num2);

                

                if (cus.customer_id == -1 )
                {
                    
                    customerData.InserData(customer);
                    customer = customerData.GetCustomerId(customer.phone_num1);

                    if (customer.customer_id != 0)
                    {
                        OrderFrom.GetCustomerInfo(customer);

                        OrderFrom.GetUserData(userInfo);


                        OrderFrom.Show();
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Faild");
                    }

                }
                else
                {
                    customer.customer_id = cus.customer_id;
            
                    
                    OrderFrom.GetCustomerInfo(customer);
                    OrderFrom.GetUserData(userInfo);

                    
                    OrderFrom.Show();
                    this.Close();
                    
                }

               
            }


         
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            PhoneTextBox.MaxLength = 11;
        
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar))
            {

                e.Handled = e.KeyChar != (char)Keys.Back;

            }

          
        
        }

        private void phoneTextBox2_TextChanged(object sender, EventArgs e)
        {
          phoneTextBox2.MaxLength = 11;
        }

        private void phoneTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))
            {

                e.Handled = e.KeyChar != (char) Keys.Back;

            }
           

        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboBox.Items.Clear();
            if (regionComboBox.Text.Length != 0)
            {
              customer.region_id = customerData.GetId("regions","region_name",regionComboBox.Text);
                FillCityCombo();
            }
           

        }


       private void FillCityCombo()
        {
            List<AddCustomerInfo> cityList = new List<AddCustomerInfo>();


            cityList = customerData.GetCityCombo("city","region_id", customer.region_id);
           

            foreach (AddCustomerInfo add in cityList)
            {

                cityComboBox.Items.Add(add.city);
            }


        }
        private void shipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            addressTextBox.MaxLength = 200;
        }

        private void allBoxClearButton_Click(object sender, EventArgs e)
        {
            PhoneTextBox.Text = "";
             phoneTextBox2.Text = "";
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            shipComboBox.Text = "";
            regionComboBox.Text = "";
            cityComboBox.Text = "";
            pasteTextBox.Text = "";
            cityComboBox.Items.Clear();
 


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string str= pasteTextBox.Text;
          int nameIndex = str.IndexOf("Name, Surname");
          int addressIndex = str.IndexOf("Order Shipping Address");
          int phoneIndex = str.IndexOf("Phone Number");
          int regionIndex = str.IndexOf("Region");
          
          string strrr="";
        
          for (int i = nameIndex+14; i < addressIndex;i++ )
          {
              
                
                  if (str[i] != '\n')
                    strrr += str[i];

          }
          nameTextBox.Text = strrr.Trim();
         strrr = "";
         
          for (int i = addressIndex + 23; i < regionIndex; i++)
          {
              
                  strrr += str[i];

          }
          addressTextBox.Text = strrr.Trim();

          strrr = "";
          int count = 0;
          for (int i = phoneIndex + 17; i < str.Length ; i++)
          {
              if (count < 11)
              {
                  if (str[i] != '\n' && str[i]!=' ')
                  {
                      strrr += str[i];
                      count++;
                  }
              }
          }
          PhoneTextBox.Text = strrr.Trim();
        
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            pasteTextBox.Text = "";

        }
    }
}
