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
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class SellsHistory : Form
    {

        PendingDelivery left = new PendingDelivery();
        PendingDeliveryDA leftDA = new PendingDeliveryDA();
        Dictionary<string, int> orderStatusID = new Dictionary<string, int>();
        Login userInfo = new Login();
        public SellsHistory()
        {
           
            InitializeComponent();
            FillDataGridView();
            FillOrderStatusCombo();
            FillOrderSourceCombo();
            FillShpCombo();

        }




        private void FillOrderStatusCombo()
        {

            List<PendingDelivery> orderSt = new List<PendingDelivery>();


              
                 orderSt= leftDA.GetComboData("order_status","status_");

            foreach (PendingDelivery add in orderSt)
            {

               statusComboBox.Items.Add(add.name);
            }


        }
        private void FillShpCombo()
        {

            List<PendingDelivery> orderSt = new List<PendingDelivery>();



            orderSt = leftDA.GetComboData("shippers", "company_name");

            foreach (PendingDelivery add in orderSt)
            {

                shipComboBox.Items.Add(add.name);
            }


        }
        private void FillOrderSourceCombo()
        {

            List<PendingDelivery> orderSt = new List<PendingDelivery>();



            orderSt = leftDA.GetComboData("order_by", "name");

            foreach (PendingDelivery add in orderSt)
            {

                sourceComboBox.Items.Add(add.name);
            }


        }
        public void GetUserData(Login user)
        {
            userInfo = user;

        }
        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void FillDataGridView()
        {

            List<PendingDelivery> sellHisList = new List<PendingDelivery>();
            sellHisList = leftDA.sellHistory();

   
           
                TraDataGridView.EnableHeadersVisualStyles = false;
                TraDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.ForestGreen;
                TraDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                TraDataGridView.Rows.Clear();
                foreach (PendingDelivery show in sellHisList)
                {

                    int n = TraDataGridView.Rows.Add();
                    if (show.order_status == "Due")
                    {

                        TraDataGridView.Rows[n].Cells[8].Style.BackColor = Color.Red;
                    }
                    TraDataGridView.Rows[n].Cells[0].Value = show.orderID.ToString();
                    TraDataGridView.Rows[n].Cells[1].Value = show.orderDate.ToString();
                    TraDataGridView.Rows[n].Cells[2].Value = show.shipDate.ToString();
                    TraDataGridView.Rows[n].Cells[3].Value = show.customerName.ToString();
                    TraDataGridView.Rows[n].Cells[4].Value = show.phoneNumber.ToString();
                    TraDataGridView.Rows[n].Cells[5].Value = show.cityName.ToString();
                    TraDataGridView.Rows[n].Cells[6].Value = show.companyName.ToString();
                    TraDataGridView.Rows[n].Cells[7].Value = show.bill.ToString();
                    TraDataGridView.Rows[n].Cells[8].Value = show.order_status;
                    TraDataGridView.Rows[n].Cells[9].Value = show.confirm_by;
                    TraDataGridView.Rows[n].Cells[10].Value = show.address.ToString();
                    TraDataGridView.Rows[n].Cells[11].Value = show.discount.ToString();
                    TraDataGridView.Rows[n].Cells[12].Value = show.shipCost.ToString();


                }
    
          
        }

        private void saveToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;
            ws.Cells[1, 1] = "Order id";
            ws.Cells[1, 2] = "Order Date";
            ws.Cells[1, 3] = "Shipping Date";
            ws.Cells[1, 4] = "Customer Name";
            ws.Cells[1, 5] = "Phone number";
            ws.Cells[1, 6] = "Adress";
            ws.Cells[1, 7] = "City";
            ws.Cells[1, 8] = "Bill";
            ws.Cells[1, 9] = "Billing Status";
            int count = 1;
           
            for(int j=2;j<=TraDataGridView.Rows.Count;j++)
            {

                for (int i = 1; i <= TraDataGridView.ColumnCount; i++)
                {
                    
                    ws.Cells[j, i] = TraDataGridView.Rows[j - 2].Cells[i - count].Value;
                }
            }


        }
    }
}
