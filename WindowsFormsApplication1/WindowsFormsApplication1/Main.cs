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
    public partial class Main : Form
    {
        Login userInfo = new Login();
     
        public Main()
        {
            InitializeComponent();         

        }

        public void GetUserData( Login user)
        {
            userInfo = user;
            userNameLabel.Text = user.firstName;
            ShowTransection();

        }
        public void ShowTransection()
        {

            showUserConPanel.Controls.Clear();
            User_Controls.TotalTrasection transection = new User_Controls.TotalTrasection();

            showUserConPanel.Controls.Add(transection);
            transection.Dock = DockStyle.Top;

            
        }

     
        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void shToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PendingDeliveryForm pa = new PendingDeliveryForm();
            pa.FillDataGridView("tommorow");
            pa.GetUserData(userInfo);
            pa.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pURCHASEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseForm show = new PurchaseForm();
            show.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerInfoForm addOrder = new AddCustomerInfoForm();
            addOrder.GetUserData(userInfo);
   
            addOrder.Show();

        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewProductForm addItem = new AddNewProductForm();
            addItem.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

                Application.Exit();
          

        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Visible =true;
          

        }

        private void sTOCKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showUserConPanel.Controls.Clear();
            User_Controls.Stocks stock = new User_Controls.Stocks();
            
            showUserConPanel.Controls.Add(stock);

            stock.Dock = DockStyle.Fill;
                       
        }

      

        private void stocks1_Load_1(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
            
        }

        private void showUserConPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm pur = new PurchaseForm();
            pur.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AddNewProductForm add = new AddNewProductForm();
           add.Show();
        }

        private void sTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void wAITINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PendingDeliveryForm paa = new PendingDeliveryForm();
          
            paa.FillDataGridView("waiting");
           paa.GetUserData(userInfo);
            paa.Show();


        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm tF = new TransactionForm();
            tF.GetUserData(userInfo);
            tF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTransection();
        }

        private void salesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellsHistory sellHistory = new SellsHistory();
            sellHistory.GetUserData(userInfo);
            sellHistory.Show();
        }
    }
}
