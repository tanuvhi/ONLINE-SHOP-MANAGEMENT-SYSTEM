using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraShopBd.Entites;
using UltraShopBd.DataAccess;

namespace WindowsFormsApplication1.User_Controls
{
    public partial class TotalTrasection : UserControl
    {
        TotalTransectionEN totalTransection = new TotalTransectionEN();
        TotalTransectionEN totalTra = new TotalTransectionEN();
        TotalTransectionDA totalTransectionDA = new TotalTransectionDA();
        public TotalTrasection()
        {
            InitializeComponent();
            FillData();
        }
       
        public void FillData()
        {


          totalTransection= totalTransectionDA.GetTransectionData();
          totalPaidLabel.Text = totalTransection.totalPaid.ToString();

          totalDueLabel.Text = totalTransection.totalDue.ToString();
          totalTra = totalTransectionDA.GetTodayTransectionData();
          todayPaidLabel.Text = totalTra.todayPaid.ToString();
          todayDueLabel.Text = totalTra.todayDue.ToString();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void todayDueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
