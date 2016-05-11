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
    public partial class AddOrderForm : Form
    {
        AddOrder order = new AddOrder();
        AddOrderDA orderDA = new AddOrderDA();
     public   Dictionary<string, int> productNameId = new Dictionary<string, int>();
     public  Dictionary<string, int> colorNameId = new Dictionary<string, int>();
     public Dictionary<string, int> orderbyNameId = new Dictionary<string, int>();
    
        Login userInfo = new Login();

        List<AddOrder> orderByList = new List<AddOrder>();

      
       
        public AddOrderForm()
        {
            InitializeComponent();
            autoCompletar(itemNameTextBox);
            RemoveButton.Hide();
            dateTimePicker1.Value = DateTime.Now;
            GetOrderBy();
            GetColorNameId();

            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
           
        }
        public void GetPreviousOrder()
        {
            List<AddOrder> anOrder = new List<AddOrder>();
          
            anOrder= orderDA.GetPreviousOrder(order.customerID);
            
            foreach (AddOrder or in anOrder)
            {
               
                ListViewItem item1 = new ListViewItem();

                item1.Text = or.orderID.ToString();
                item1.SubItems.Add(or.shipDate);
                item1.SubItems.Add(or.oderDate);
                item1.SubItems.Add(or.totalAmount.ToString());
                item1.SubItems.Add(or.orderStatus.ToString());

                PreOrderListView.Items.Add(item1);
   

            }
            

         
        }
       
        public void GetUserData(Login user)
        {
            userInfo = user;
            order.userId = user.userId;
        
        }

       public void GetColorNameId()
        {
            List<AddOrder> colorList = new List<AddOrder>();
            colorList = orderDA.GetColor();
            foreach (AddOrder add in colorList)
            {
                colorNameId[add.color] = add.colorId;
                
            }
           
        }
        public void GetOrderBy()
       {


           orderByList = orderDA.GetOrderBy_();

           foreach (AddOrder add in orderByList)
           {
               orderbyNameId[add.orderByName] = add.orderBy_id;

           }

       }

       

        public void AnOrderInfo(AddOrder aOrder)
        {
            
            order= aOrder;
            
            
        }

   
       public void GetCustomerInfo(AddCustomerInfo customer)
        {
            order.customerID = customer.customer_id;
            order.shipId = customer.shipper_id;
            nameTextBox.Text = customer.name;
            cityTextBox.Text = customer.city;
            addressTextBox.Text = customer.address1;
            phone1TextBox.Text = customer.phone_num1;
            phone2TextBox.Text = customer.phone_num2;
           shipperTextBox.Text = customer.company_name;
           GetPreviousOrder();

        }
        public void autoCompletar(TextBox nameTextBox)
        {
            List<AddOrder> nameList= new List<AddOrder>();
            nameList = orderDA.GetProductName();
           foreach(AddOrder add in nameList)
            {
                productNameId[add.product_name] = add.productId;
                nameTextBox.AutoCompleteCustomSource.Add(add.product_name);

            }

        }
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void showItembutton_Click(object sender, EventArgs e)
        {
            order.product_name = itemNameTextBox.Text;

            if(itemNameTextBox.Text.Length !=0)
            {
                if (!productNameId.ContainsKey(order.product_name))
                {
                    MessageBox.Show(" Product name not found\n ");
                }
                else
                {
                    AddItem addItem = new AddItem(order.product_name);

                    List<AddOrder> colorList = new List<AddOrder>();
                    order.productId = productNameId[order.product_name];
                    colorList = orderDA.GetComboData(order);

                    addItem.FilColorCombo(colorList);

                    addItem.FilNameField(order);
                    addItem.FillOrderByCom(orderByList );
                    order.addButton = 0;

                    addItem.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please input product name\n");
            }

            if (order.addButton == 1)
            {
                AddList();
            }

           
        }

        public void AddList()
        {

            double total;
            ListViewItem item = new ListViewItem();

            item.Text = order.product_name;
            item.SubItems.Add(order.color);
            item.SubItems.Add(order.quantity.ToString());
            item.SubItems.Add(order.sellingPrice.ToString());
         

            total = order.sellingPrice * order.quantity;
            int flag = 0;

            foreach (ListViewItem items in orderlistView.Items)
            {
                if(items.SubItems[0].Text == order.product_name && items.SubItems[1].Text== order.color)
                {
                    flag = 1;
                    MessageBox.Show("Duplicate Order\n");

                }
            }
            
                item.SubItems.Add(total.ToString());
                item.SubItems.Add(order.orderByName);
                item.SubItems.Add(order.orderById);

                if (flag == 0)
                {
                    orderlistView.Items.Add(item);
                    SumTotalAmount();
                }
            
        }
      
        public List<AddOrder> GetAllOrderList()
        {
            List<AddOrder> orderList = new List<AddOrder>();

            for (int i = 0; i < orderlistView.Items.Count;i++ )
            {
                AddOrder aOrder = new AddOrder();
                if (orderlistView.Items[i].SubItems[0].Text != "Discount" && orderlistView.Items[i].Text != "Shipping Cost")
                {
                    aOrder.product_name = orderlistView.Items[i].Text;

                    aOrder.color = orderlistView.Items[i].SubItems[1].Text;

                    aOrder.quantity = Convert.ToInt32(orderlistView.Items[i].SubItems[2].Text);

                    aOrder.sellingPrice = Convert.ToDouble(orderlistView.Items[i].SubItems[3].Text);

                    aOrder.perItemTtlAmount = Convert.ToDouble(orderlistView.Items[i].SubItems[4].Text);

                    aOrder.orderByName = orderlistView.Items[i].SubItems[5].Text;

                    aOrder.orderById = orderlistView.Items[i].SubItems[6].Text;

                    orderList.Add(aOrder);
                }

            }
            return orderList;
        }
        public bool checkDiscontShip()
        {


            int  count = 0;
            foreach (ListViewItem item in orderlistView.Items)
            {
                if (item.SubItems[0].Text == "Discount")
                {
                    count++;
                }
                if (item.SubItems[0].Text == "Shipping Cost")
                 {
                 count++;
                }

            }

            if (count == 2)
                return true;
            else
                return false;


        }
        public void SumTotalAmount()
        {
   
         
            double totalAmount=0;
            foreach (ListViewItem item in orderlistView.Items)
            {
                if (item.SubItems[0].Text == "Discount")
                {
                    totalAmount += (-1 * Convert.ToDouble(item.SubItems[4].Text));
                }
                else
                {
                    totalAmount +=  Convert.ToDouble(item.SubItems[4].Text);

                }

              
            }

            order.totalAmount = totalAmount;
            showTotalLabel.Text = totalAmount.ToString();

           
        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void commentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oderListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveButton.Show();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            shipperTextBox.MaxLength = 7;
            
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            discountTextBox.MaxLength = 7;

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < orderlistView.Items.Count; i++)
            {
                if (orderlistView.Items[i].Selected)
                {
                   orderlistView.Items[i].Remove();
                    i--;
                }
            }
            SumTotalAmount();
        }

        private void shipCostTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void shipCostTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
   

        }

        private void discountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void shipCostTextBox_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void shipCostTextBox_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(shipCostTextBox.Text.Length ==0)
            {
                MessageBox.Show("Please input ship cost\n");
              
             

            }
            else
            {
                ListViewItem item = new ListViewItem();

                item.Text = "Shipping Cost";
                item.SubItems.Add("-");
                item.SubItems.Add("-");
                item.SubItems.Add("-");

                item.SubItems.Add(shipCostTextBox.Text);
                int flag1 = 0;

                foreach (ListViewItem items in orderlistView.Items)
                {
                    if (items.SubItems[0].Text == "Shipping Cost")
                    {
                        flag1 = 1;
                        MessageBox.Show("Duplicate Shipping Cost\n");

                    }
                }

                if (flag1 == 0)
                {
                    orderlistView.Items.Add(item);

                }
             


                if (discountTextBox.Text.Length != 0)
                {

                    ListViewItem item2 = new ListViewItem();

                    item2.Text = "Discount";
                    item2.SubItems.Add("-");
                    item2.SubItems.Add("-");
                    item2.SubItems.Add("-");

                    item2.SubItems.Add(discountTextBox.Text);

                    item2.SubItems.Add("-");
                    int flag2 = 0;

                    foreach (ListViewItem items in orderlistView.Items)
                    {
                        if (items.SubItems[0].Text == "Discount")
                        {
                            flag2 = 1;
                            MessageBox.Show("Duplicate Delivery Charge\n");

                        }
                    }



                    if (flag2 == 0)
                    {
                        orderlistView.Items.Add(item2);

                    }

                }

                SumTotalAmount();

            }
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            if(orderlistView.Items.Count==0)
            {

                MessageBox.Show("Please Add Order\n");
             
            }
            else if(checkDiscontShip()==false)
            {

                MessageBox.Show("Please Add Discount and shipping cost\n");
            }
            else
            {
                order.todayDate = DateTime.Now.ToString();
                order.shipDate = dateTimePicker1.Value.ToString();


                if (discountTextBox.Text.Length!= 0)
                order.discount = Convert.ToDouble(discountTextBox.Text);


                if(shipCostTextBox.Text.Length!=0)

                order.shipCost = Convert.ToDouble(shipCostTextBox.Text);

                if (order.customerID != 0)
                {

                    orderDA.InsertOrder(order, GetAllOrderList(), productNameId, colorNameId, orderbyNameId);
                    MessageBox.Show("Order Added successfully");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Faild");
                    this.Close();

                }

            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void shipCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar))
            {

                e.Handled = e.KeyChar != (char)Keys.Back;

            }
        }

        private void discountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar))
            {

                e.Handled = e.KeyChar != (char)Keys.Back;

            }
        }

       
    }
}
