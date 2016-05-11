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
    public partial class TransactionForm : Form
    {


        PendingDelivery left = new PendingDelivery();
        PendingDeliveryDA leftDA = new PendingDeliveryDA();

        Login userInfo = new Login();
        public TransactionForm()
        {
            InitializeComponent();
            FillDataGridView();
        }
        public void GetUserData(Login user)
        {
            userInfo = user;

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void FillDataGridView()
        {

            TraDataGridView.EnableHeadersVisualStyles = false;
            TraDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            TraDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            List<PendingDelivery> tommorow = new List<PendingDelivery>();
            DataTable dt = new DataTable();
            dt = leftDA.GetDueData();
            MessageBox.Show("dfdf");

            TraDataGridView.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int n = TraDataGridView.Rows.Add();
                if (dt.Rows[i].ItemArray[11].ToString() == "Due")
                {

                    TraDataGridView.Rows[n].Cells[8].Style.BackColor = Color.Red;
                }


                
                TraDataGridView.Rows[n].Cells[0].Value = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                TraDataGridView.Rows[n].Cells[1].Value = dt.Rows[i].ItemArray[1].ToString();
                TraDataGridView.Rows[n].Cells[2].Value = dt.Rows[i].ItemArray[2].ToString();
                TraDataGridView.Rows[n].Cells[3].Value = dt.Rows[i].ItemArray[3].ToString();

                TraDataGridView.Rows[n].Cells[4].Value = dt.Rows[i].ItemArray[4].ToString();
                TraDataGridView.Rows[n].Cells[5].Value = dt.Rows[i].ItemArray[5].ToString();
                TraDataGridView.Rows[n].Cells[6].Value = dt.Rows[i].ItemArray[6].ToString();
                TraDataGridView.Rows[n].Cells[7].Value = Convert.ToDouble(dt.Rows[i].ItemArray[7]);
                TraDataGridView.Rows[n].Cells[10].Value = dt.Rows[i].ItemArray[8].ToString();
                TraDataGridView.Rows[n].Cells[11].Value = Convert.ToDouble(dt.Rows[i].ItemArray[9]);
                TraDataGridView.Rows[n].Cells[12].Value = Convert.ToDouble(dt.Rows[i].ItemArray[10]);
                TraDataGridView.Rows[n].Cells[8].Value = dt.Rows[i].ItemArray[11].ToString();
                TraDataGridView.Rows[n].Cells[9].Value = dt.Rows[i].ItemArray[12].ToString();
               
            }

            
    
      


        }

        private void TraDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            ReceiptForm RcForm = new ReceiptForm();
            RcForm.GetUserData(userInfo);
            left.orderID = Convert.ToInt32(TraDataGridView.Rows[e.RowIndex].Cells[0].Value);

            left.shipDate = TraDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            left.customerName = TraDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            left.phoneNumber = TraDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            left.cityName = TraDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            left.companyName = TraDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            left.bill = Convert.ToDouble(TraDataGridView.Rows[e.RowIndex].Cells[7].Value);
            left.address = TraDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            left.discount = Convert.ToDouble(TraDataGridView.Rows[e.RowIndex].Cells[11].Value);
            left.shipCost = Convert.ToDouble(TraDataGridView.Rows[e.RowIndex].Cells[12].Value);


            RcForm.GetCustomerInfo(left);
            RcForm.Show();
        }

        private void orderIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderIDTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            for (int i = 0; i < TraDataGridView.Rows.Count; i++)
            {
                if (!TraDataGridView.Rows[i].IsNewRow)
                {

                    if (TraDataGridView[0, i].Value.ToString() == orderIDTextBox.Text)
                    {

                        TraDataGridView.Rows[i].Selected = true;
                        TraDataGridView.FirstDisplayedScrollingRowIndex = i;


                    }
                    else
                        TraDataGridView.Rows[i].Selected = false;
                }
            }

        }

        private void phoneTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < TraDataGridView.Rows.Count; i++)
            {
                if (!TraDataGridView.Rows[i].IsNewRow)
                {

                    if (TraDataGridView[4, i].Value.ToString() == phoneTextBox.Text.Trim())
                    {

                        TraDataGridView.Rows[i].Selected = true;
                        TraDataGridView.FirstDisplayedScrollingRowIndex = i;


                    }
                    else
                        TraDataGridView.Rows[i].Selected = false;
                }
            }
        }

    }
}
