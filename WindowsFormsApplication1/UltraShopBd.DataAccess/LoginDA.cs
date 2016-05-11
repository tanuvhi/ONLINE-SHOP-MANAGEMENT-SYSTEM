using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using UltraShopBd.Entites;
using UltraShopBd.FrameWork;
namespace UltraShopBd.DataAccess
{
    public class LoginDA
    {

        FrameWork.DataAccess da = new FrameWork.DataAccess();
        Login login = new Login();
         
     
        
       public Login GetUserId( Login mailPass)
       {
           string sql = string.Format("SELECT user_id, first_name, status_id FROM users  WHERE  email = '"+mailPass.email+"' and password ='"+mailPass.password+"'  ");

           SqlCommand cmd = new SqlCommand(sql);
          

           DataTable dt = da.GetData(cmd);
           if (dt.Rows.Count > 0)
           {
               login.userId = Convert.ToInt32( dt.Rows[0].ItemArray[0]);
               login.firstName = dt.Rows[0].ItemArray[1].ToString();
               login.statusId = Convert.ToInt32( dt.Rows[0].ItemArray[2]);

              
           }
           else
           {
               login.userId = -1;

               
           }
           return login;
       }
       
    }
}
