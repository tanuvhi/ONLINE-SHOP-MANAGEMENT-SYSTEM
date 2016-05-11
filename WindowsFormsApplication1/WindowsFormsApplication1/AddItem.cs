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
    public partial class AddItem : Form
    {
        AddOrderDA orderDA = new AddOrderDA();
        AddOrder order = new AddOrder();
        AddOrderForm addOrderForm = new AddOrderForm();

        
      
        public AddItem(string productName)
        {
            order.product_name = productName;
            InitializeComponent();
            

        }


        public void FillOrderByCom(List<AddOrder> orderByList)
        {
            orderComboBox.Items.Clear();

            foreach (AddOrder list in orderByList)
            {
                orderComboBox.Items.Add(list.orderByName);
            }
            

        }

        public void FilColorCombo(List<AddOrder> colorList )
        {
            colorComboBox.Items.Clear();
           foreach(AddOrder list in colorList)
           {
             
               colorComboBox.Items.Add(list.color);
               
           }
           colorComboBox.Text = colorList[0].color;

        }

        public void FilNameField(AddOrder itemInfo )
        {
            itemNameLabel.Text = itemInfo.product_name;
             itemInfo.color = colorComboBox.Text;             
            itemInfo.colorId = addOrderForm.colorNameId[itemInfo.color];
   
            itemInfo.productId =  addOrderForm.productNameId [itemInfo.product_name];
           itemInfo = orderDA.GetStockInfo(itemInfo);
            priceTextBox.Text = itemInfo.sellingPrice.ToString();
            avaliableQuantity.Text = itemInfo.ttlQuantiy.ToString();

           quantityTextBox.Text = "1";
           order = itemInfo;

            
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          FilNameField(order);

   
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            quantityTextBox.MaxLength = 8;

        }

        private void itemNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {

                e.Handled = e.KeyChar != (char)Keys.Back;

            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            priceTextBox.MaxLength = 8;

        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
               
            }
        }

        private void avaliableQuantity_Click(object sender, EventArgs e)
        {
            
        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            order.orderByName = orderComboBox.Text.Trim();
            order.orderById = orderIdTextBox.Text.Trim();

            int flag = 0;
            string message = "";

           if( order.orderByName.Length==0)
           {
               flag = 1;
               message += "Please select order by\n"; 
           }
           else
           {

               if(order.orderByName=="kaymu")
               {
                   if(order.orderById.Length==0)
                   {
                       flag = 1;
                       message += "Plesase input " + order.orderByName + " order id\n";
                   }
               }
           }

            if(flag==1)
            {

                MessageBox.Show(message);

            }
            else
            {

                order.orderBy_id = orderDA.GetId("order_by", "name", order.orderByName);
                
                order.quantity = Convert.ToInt32( quantityTextBox.Text.Trim());
                order.sellingPrice = Convert.ToInt32( priceTextBox.Text.Trim() );
                order.addButton = 1;
                AddOrderForm addOrderForm = new AddOrderForm();
                addOrderForm.AnOrderInfo(order);
                
                
                this.Close();


            }

            
        }

        private void orderIdTextBox_TextChanged(object sender, EventArgs e)
        {
            orderIdTextBox.MaxLength = 49;

        }

        private void colorComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
