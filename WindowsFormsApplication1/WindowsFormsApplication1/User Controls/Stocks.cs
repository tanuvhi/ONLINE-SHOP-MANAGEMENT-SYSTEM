using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraShopBd.DataAccess;
using UltraShopBd.Entites;
namespace WindowsFormsApplication1.User_Controls
{
    public partial class Stocks : UserControl
    {

        Stock stock = new Stock();
        StockDA stockDA = new StockDA();
        public Stocks()
        {
            InitializeComponent();
            FillDataGridView();
            
        }

        public void FillDataGridView()
        {

            List<Stock> stockList = new List<Stock>();

            stockList = stockDA.GetGridData();
            
             stockDataGridView.Rows.Clear();
            foreach (Stock show in stockList)
            {
                int n = stockDataGridView.Rows.Add();

                stockDataGridView.Rows[n].Cells[0].Value = show.productId.ToString();
                stockDataGridView.Rows[n].Cells[1].Value = show.productName;
                stockDataGridView.Rows[n].Cells[3].Value = show.color.ToString();
                stockDataGridView.Rows[n].Cells[4].Value = show.quantiy.ToString();
                stockDataGridView.Rows[n].Cells[5].Value = show.sellingPrice.ToString();
             

            }


            

        }

        public void FillDataGridView(Stock s)
        {

            List<Stock> stockList = new List<Stock>();

            stockList = stockDA.GetGridDataName(s);

            stockDataGridView.Rows.Clear();
            foreach (Stock show in stockList)
            {
                int n = stockDataGridView.Rows.Add();

                stockDataGridView.Rows[n].Cells[0].Value = show.productId.ToString();
                stockDataGridView.Rows[n].Cells[1].Value = show.productName;
                stockDataGridView.Rows[n].Cells[3].Value = show.color.ToString();
                stockDataGridView.Rows[n].Cells[4].Value = show.quantiy.ToString();
                stockDataGridView.Rows[n].Cells[5].Value = show.sellingPrice.ToString();


            }



        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stock.productName = nameTextBox.Text;

            if(stock.productName.Length ==0)
            {

                MessageBox.Show("Please input product name");
            }
            else
            {
            FillDataGridView(stock);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
