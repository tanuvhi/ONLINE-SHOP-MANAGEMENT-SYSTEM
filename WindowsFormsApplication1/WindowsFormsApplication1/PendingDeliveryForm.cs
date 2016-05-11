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
    public partial class PendingDeliveryForm : Form
    {

        PendingDelivery left = new PendingDelivery();
        PendingDeliveryDA leftDA = new PendingDeliveryDA();

        Login userInfo = new Login();
          
        
        string days;
        
        public PendingDeliveryForm()
        {
            InitializeComponent();

            
        }


        public void GetUserData(Login user)
        {
            userInfo = user;

        }

        public void FillDataGridView(string day)
        {
            leftDataGridView.EnableHeadersVisualStyles = false;
            leftDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab;
            leftDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            days=day;
         
            List<PendingDelivery> tommorow = new List<PendingDelivery>();

            tommorow = leftDA.GetTommorowData(day);
          
           
                leftDataGridView.Rows.Clear();

                totalOrderLabel.Text = totalOrderLabel.Text + tommorow.Count.ToString();
                int count = 0;
                double totalBill = 0;
            foreach (PendingDelivery show in tommorow)
            {
                if (show.cityName.ToString() == "Dhaka")
                    count++;
                int n = leftDataGridView.Rows.Add();
                leftDataGridView.Rows[n].Cells[0].Value = show.orderID.ToString();
                leftDataGridView.Rows[n].Cells[1].Value = show.orderDate.ToString();
                leftDataGridView.Rows[n].Cells[2].Value = show.shipDate.ToString();
                leftDataGridView.Rows[n].Cells[3].Value = show.customerName.ToString();
                leftDataGridView.Rows[n].Cells[4].Value = show.phoneNumber.ToString();
                leftDataGridView.Rows[n].Cells[5].Value = show.cityName.ToString();
                leftDataGridView.Rows[n].Cells[6].Value = show.companyName.ToString();
                leftDataGridView.Rows[n].Cells[7].Value = show.bill.ToString();
                leftDataGridView.Rows[n].Cells[8].Value = show.order_status;
                leftDataGridView.Rows[n].Cells[9].Value = show.confirm_by;
                leftDataGridView.Rows[n].Cells[10].Value = show.address.ToString();
                leftDataGridView.Rows[n].Cells[11].Value = show.discount.ToString();
                leftDataGridView.Rows[n].Cells[12].Value = show.shipCost.ToString();
                totalBill += show.bill;

            }
            inDhakaLabel.Text = inDhakaLabel.Text + count.ToString();
            outDhaka.Text = outDhaka.Text + (tommorow.Count - count).ToString();
            totalCostLabel.Text = totalBill.ToString();

        }

       
      
        private void leftDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void leftDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              
            ReceiptForm RcForm = new ReceiptForm();
            RcForm.GetUserData(userInfo);
           left.orderID = Convert.ToInt32( leftDataGridView.Rows[e.RowIndex].Cells[0].Value);
          
           left.shipDate = leftDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
           left.customerName = leftDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
           left.phoneNumber = leftDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
           left.cityName = leftDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
           left.companyName = leftDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
           left.bill = Convert.ToDouble( leftDataGridView.Rows[e.RowIndex].Cells[7].Value);
           left.address = leftDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
           left.discount = Convert.ToDouble(leftDataGridView.Rows[e.RowIndex].Cells[11].Value);
           left.shipCost = Convert.ToDouble(leftDataGridView.Rows[e.RowIndex].Cells[12].Value);
        

            RcForm.GetCustomerInfo(left);
            RcForm.Show();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            FillDataGridView(days);
        }

        private void orderIDTextBox_KeyUp(object sender, KeyEventArgs e)
        {
          
            for (int i = 0; i < leftDataGridView.Rows.Count; i++)
              {
                 if (!leftDataGridView.Rows[i].IsNewRow)
                 {

                     if (leftDataGridView[0, i].Value.ToString() == orderIDTextBox.Text)
                     {
                         
                         leftDataGridView.Rows[i].Selected = true;

                         leftDataGridView.FirstDisplayedScrollingRowIndex = i;
                     }
                     else
                         leftDataGridView.Rows[i].Selected = false;
                }
             }
         
            
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < leftDataGridView.Rows.Count; i++)
            {
                if (!leftDataGridView.Rows[i].IsNewRow)
                {

                    if (leftDataGridView[4, i].Value.ToString() == phoneTextBox.Text.Trim())
                    {

                        leftDataGridView.Rows[i].Selected = true;
                        leftDataGridView.FirstDisplayedScrollingRowIndex = i;


                    }
                    else
                        leftDataGridView.Rows[i].Selected = false;
                }
            }

        }
    }
}
