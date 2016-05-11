using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraShopBd.Entites;
using UltraShopBd.DataAccess;
namespace WindowsFormsApplication1
{
    public partial class PurchaseForm : Form
    {
        Purchase purchase = new Purchase();
        PurchaseDA purchaseDA = new PurchaseDA();
          
        public PurchaseForm()
        {
            InitializeComponent();

            FillColorCombo();
            autoCompletar(nameTextBox);
            autoCompletar(itemNameTextBox);
            purchaseDate.Value = DateTime.Now;
            MinDatePiker.Value = DateTime.Now;
            MaxDatePiker.Value = DateTime.Now;

            

            purchase.MinDate = MinDatePiker.Value.ToString();
            purchase.MaxDate = MaxDatePiker.Value.ToString();
            purchase.date = purchaseDate.Value.ToString();

            FillDataGridView();

          
           
        }


        public void FillDataGridView()
        {

            List<Purchase> purchaseList = new List<Purchase>();

           purchaseList = purchaseDA.GetGridData(purchase);
           double totalAmount = 0;

           dataGridView.Rows.Clear();
            foreach(Purchase show  in purchaseList)
            {               
                int n = dataGridView.Rows.Add();

                dataGridView.Rows[n].Cells[0].Value = show.date.ToString();
                dataGridView.Rows[n].Cells[1].Value = show.productId.ToString();
                dataGridView.Rows[n].Cells[2].Value = show.name;
                dataGridView.Rows[n].Cells[6].Value = show.purchasePrice.ToString();
                dataGridView.Rows[n].Cells[3].Value = show.color.ToString();
                dataGridView.Rows[n].Cells[5].Value = show.sellingPrice.ToString();
                dataGridView.Rows[n].Cells[7].Value = show.quantity.ToString();
                double total = show.quantity * show.purchasePrice;
                totalAmount += total;

                dataGridView.Rows[n].Cells[8].Value = total.ToString();

            }

          showAmountLabe.Text = totalAmount.ToString();
            
        }


        public void FillDataGridViewName()
        {

            List<Purchase> purchaseList = new List<Purchase>();

            purchaseList = purchaseDA.GetGridDataName(purchase);
            double totalAmount = 0;

            dataGridView.Rows.Clear();
            foreach (Purchase show in purchaseList)
            {
                int n = dataGridView.Rows.Add();

                dataGridView.Rows[n].Cells[0].Value = show.date.ToString();
                dataGridView.Rows[n].Cells[1].Value = show.productId.ToString();
                dataGridView.Rows[n].Cells[2].Value = show.name;
                dataGridView.Rows[n].Cells[6].Value = show.purchasePrice.ToString();
                dataGridView.Rows[n].Cells[3].Value = show.color.ToString();
                dataGridView.Rows[n].Cells[5].Value = show.sellingPrice.ToString();
                dataGridView.Rows[n].Cells[7].Value = show.quantity.ToString();
                double total = show.quantity * show.purchasePrice;
                totalAmount += total;

                dataGridView.Rows[n].Cells[8].Value = total.ToString();

            }

            showAmountLabe.Text = totalAmount.ToString();

        }



        public void FillColorCombo()
        {

            List<Purchase> colorList = new List<Purchase>();

            colorList = purchaseDA.GetComboData("color","color_name");
            foreach (Purchase showData in colorList)
            {
                colorComboBox.Items.Add(showData.name);

            }
        }
        
        
        public void autoCompletar(TextBox boxName)
        {
            List<Purchase> purchaseList = new List<Purchase>();
            purchaseList = purchaseDA.GetItemName("products", "product_name");


            foreach (Purchase add in purchaseList)
            {
                boxName.AutoCompleteCustomSource.Add(add.name);


            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {



            int flag = 0;
            string message="";

            purchase.name = nameTextBox.Text.Trim();
            purchase.color = colorComboBox.Text.Trim();
            
          
            
        
            if(purchase.name.Length!=0)
            {
                purchase.productId = purchaseDA.GetId("products","product_name",purchase.name);

                if(purchase.productId==-1)
                {
                    message += "Product Name not found \n";
                    flag = 1;
                }

            }
            else
            {
                flag = 1;
                message =" Please input Product name\n";

            }

            if(quantityTextBox.Text.Length!=0)
            {

                purchase.quantity = Convert.ToInt32(quantityTextBox.Text);
            }
            else
            {
                flag = 1;
                message += "Please input quantity\n";
            }

            if ( pPriceTextBox.Text.Length != 0)
            {

                purchase.purchasePrice = Convert.ToDouble(pPriceTextBox.Text);
            }
            else
            {
                flag = 1;
                message += "Please input purchase price \n";
            }


            if (sPriceTextBox.Text.Length != 0)
            {

                purchase.sellingPrice = Convert.ToDouble(sPriceTextBox.Text);
            }
            else
            {
                purchase.sellingPrice = -1;

            }
          

            if(purchase.color.Length ==0)
            {

                flag = 1;
                message += "Please select color";

            }
            else
            {
                purchase.colorId = purchaseDA.GetId("color", "color_name", purchase.color);

            
            }



            if(flag==1)
            {

                MessageBox.Show(message);
            }
            else
            {

                purchaseDA.InsertData(purchase);
                bool check = purchaseDA.SearchNameIdStock(purchase);
                 
                if(check== true)
                {
                    MessageBox.Show("Purchase list update sucessfully\n");
                    purchaseDA.StockUpdate(purchase);
                }
                else
                {

                    purchaseDA.InsertInStock(purchase);
                }
                
                FillDataGridView();

                nameTextBox.Text = "";
                quantityTextBox.Text = "";
                pPriceTextBox.Text = "";
                sPriceTextBox.Text = "";
                colorComboBox.Text = "";
                
         

            }
            


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.MaxLength = 49;

        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            itemNameTextBox.MaxLength = 49;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {

                e.Handled = e.KeyChar != (char)Keys.Back;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {

                e.Handled = e.KeyChar != (char)Keys.Back;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {

                e.Handled = e.KeyChar != (char)Keys.Back;

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            purchase.date = purchaseDate.Value.ToString();
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            quantityTextBox.MaxLength = 9;

        }

        private void pPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            pPriceTextBox.MaxLength = 14;

        }

        private void sPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            sPriceTextBox.MaxLength = 14;
        }

        private void itemViewButton_Click(object sender, EventArgs e)
        {


            string message =  "";
            int flag = 0;
          
            purchase.itemName = itemNameTextBox.Text;
            if(MinDatePiker.Value>MaxDatePiker.Value)
            {

                flag = 1;
                message = "please check date \n";

            }

           if(flag==1)
           {

               MessageBox.Show(message);
           }
           else
           {
               if(purchase.itemName.Length!=0)
               {

                   FillDataGridViewName();
                   itemNameTextBox.Text = "";

               }
               else
               {
                   FillDataGridView();


               }

           }






        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void addItemLabel_Click(object sender, EventArgs e)
        {

        }

        private void MinDatePiker_ValueChanged(object sender, EventArgs e)
        {
            purchase.MinDate = MinDatePiker.Value.ToString();
        }

        private void MaxDatePiker_ValueChanged(object sender, EventArgs e)
        {
            purchase.MaxDate = MaxDatePiker.Value.ToString();

        }
    }
}
