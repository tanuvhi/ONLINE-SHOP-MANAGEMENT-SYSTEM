using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using UltraShopBd.Entites;
using UltraShopBd.FrameWork;

namespace UltraShopBd.DataAccess
{
   public class TotalTransectionDA
    {
       FrameWork.DataAccess da = new FrameWork.DataAccess();

        public TotalTransectionEN GetTransectionData()
        {
            TotalTransectionEN tra = new TotalTransectionEN();
            string sql = string.Format("select order_status ,sum(total_price) from orders group by order_status");
            SqlCommand cmd = new SqlCommand(sql);
            DataTable dt = da.GetData(cmd);



                tra.totalPaid = Convert.ToDouble(dt.Rows[0].ItemArray[1]);
                tra.totalDue = Convert.ToDouble(dt.Rows[3].ItemArray[1]);
                
        
     

            return tra;
        }

        public TotalTransectionEN GetTodayTransectionData()
        {
            TotalTransectionEN tra = new TotalTransectionEN();
            string date = DateTime.Now.ToString();

            string sql = string.Format("select sum(total_price) from  orders where order_date='" + date + "' and order_status= 5 ");
            SqlCommand cmd = new SqlCommand(sql);
            DataTable dt = da.GetData(cmd);

            if (dt.Rows[0].ItemArray[0].ToString().Length != 0)
                tra.todayDue = Convert.ToDouble(dt.Rows[0].ItemArray[0]);
            else
                tra.todayDue = 0;

            string sql2 = string.Format("select sum(total_price) from orders where confirmation_date ='" + date + "' and order_status= 1 ");

            SqlCommand cmd2 = new SqlCommand(sql2);
            DataTable dt2 = da.GetData(cmd2);

            if (dt2.Rows[0].ItemArray[0].ToString().Length != 0)
                tra.todayPaid = Convert.ToDouble(dt2.Rows[0].ItemArray[0]);
            else
                tra.todayPaid = 0;
            return tra;
        }
    }
}
