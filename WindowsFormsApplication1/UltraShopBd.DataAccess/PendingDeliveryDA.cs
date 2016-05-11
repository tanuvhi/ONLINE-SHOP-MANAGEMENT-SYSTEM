using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UltraShopBd.FrameWork;
using UltraShopBd.Entites;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace UltraShopBd.DataAccess
{
   public  class PendingDeliveryDA
    {
       FrameWork.DataAccess da = new FrameWork.DataAccess();
       PendingDelivery left = new PendingDelivery();

       public void confirmation(PendingDelivery confirm)
       {

           string sql = string.Format("UPDATE orders set confirmation_date='"+confirm.date+"' ,confirmation_by='"+confirm.userId+"' ,ship_cost='" + confirm.shipCost + "' , discount ='"+confirm.discount +"',total_price='" + confirm.bill+ "', order_status='"+confirm.order_status_id+"' where order_id = '" + confirm.orderID + "' ");

           SqlCommand cmd = new SqlCommand(sql);

           da.Execute(cmd);


       }

       public void UpdateQuantity(List<PendingDelivery> list)
       {
           foreach (PendingDelivery pa in list)
           {
               string sql = string.Format("UPDATE stock set quantity=quantity+'" + pa.quantity + "' where product_id= '" + pa.productID + "' and color_id='"+pa.colorID+"' ");

               SqlCommand cmd = new SqlCommand(sql);

               da.Execute(cmd);
           }
       }

       public void UpdateDateDiscont(PendingDelivery up)
       {

           string sql = string.Format("UPDATE orders set ship_date='" + up.shipDate + "' , discount ='" + up.discount + "',total_price='" + up.bill + "' where order_id = '" + up.orderID + "' ");

           SqlCommand cmd = new SqlCommand(sql);

           da.Execute(cmd);



       }

        public List<PendingDelivery> GetOrderStatus(string tableName)
       {
           List<PendingDelivery> getName = new List<PendingDelivery>();

           string sql = string.Format(" SELECT * FROM {0}   ", tableName);
           SqlCommand cmd = new SqlCommand(sql);

           DataTable dt = da.GetData(cmd);

           foreach (DataRow row in dt.Rows)
           {
               PendingDelivery status = new PendingDelivery();
               status.order_status_id = Convert.ToInt32(row[0]);
               status.order_status = row[1].ToString();
               getName.Add(status);
           }

           return getName;

       }

       public List<PendingDelivery> GetOrderList(int orderId)
       {

           string sql = string.Format("select products.product_name,color.color_name,  order_details.price , order_details.quantity, order_details.total , order_details.product_id,order_details.color_id From order_details inner join products on   order_details.product_id = products.product_id inner join color on color.color_id = order_details.color_id where order_id = '" + orderId + "' ");
          
           SqlCommand cmd = new SqlCommand(sql);
           DataTable dt =new DataTable();
           dt = da.GetData(cmd);
           List<PendingDelivery> orderList = new List<PendingDelivery>();

                
           
           
           for(int i= 0 ;i<dt.Rows.Count ; i++)
           {
               PendingDelivery order = new PendingDelivery();
               order.ProductName = dt.Rows[i].ItemArray[0].ToString();
               order.color = dt.Rows[i].ItemArray[1].ToString();
               order.unitPrice = Convert.ToDouble(dt.Rows[i].ItemArray[2]);
               order.quantity = Convert.ToInt32(dt.Rows[i].ItemArray[3]);
               order.totalAmount = Convert.ToDouble(dt.Rows[i].ItemArray[4]);
               order.productID = Convert.ToInt32(dt.Rows[i].ItemArray[5]);
               order.colorID = Convert.ToInt32(dt.Rows[i].ItemArray[6]);
               orderList.Add(order);

           }

           return orderList;
       }


       public DataTable GetDueData()
       {
           string sql;
        
           List<PendingDelivery> getData = new List<PendingDelivery>();
           sql = string.Format("select  orders.order_id,orders.order_date,orders.ship_date, customer.name, customer.phone_num1 , city.city_name , shippers.company_name, orders.total_price ,customer.address1, orders.discount,orders.ship_cost , order_status.status_ , users.first_name from orders inner join customer on customer.customer_id =orders.customer_id inner join city on city.city_id =customer.city_id inner join shippers on orders.shipper_id = shippers.shipper_id inner join order_status on order_status.status_id=orders.order_status inner join users on  orders.inserted_by=users.user_id  where status_='Due' or status_='return' or status_='paid'  order by orders.order_id desc ");
          

           SqlCommand cmd = new SqlCommand(sql);
           DataTable dt = da.GetData(cmd);

          

           return dt;
       }



       public List<PendingDelivery> sellHistory()
       {
           string sql;

           List<PendingDelivery> getData = new List<PendingDelivery>();
           sql = string.Format("select  orders.order_id,orders.order_date,orders.ship_date, customer.name, customer.phone_num1 , city.city_name , shippers.company_name, orders.total_price ,customer.address1, orders.discount,orders.ship_cost , order_status.status_ , users.first_name from orders inner join customer on customer.customer_id =orders.customer_id inner join city on city.city_id =customer.city_id inner join shippers on orders.shipper_id = shippers.shipper_id inner join order_status on order_status.status_id=orders.order_status inner join users on  orders.inserted_by=users.user_id  where status_='Due' or status_='return' or status_='paid'  order by orders.order_id desc ");


           SqlCommand cmd = new SqlCommand(sql);
           DataTable dt = da.GetData(cmd);

           for (int i = 0; i < dt.Rows.Count; i++)
           {

               PendingDelivery str = new PendingDelivery();
               str.orderID = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
               str.orderDate = dt.Rows[i].ItemArray[1].ToString();
               str.shipDate = dt.Rows[i].ItemArray[2].ToString();
               str.customerName = dt.Rows[i].ItemArray[3].ToString();

               str.phoneNumber = dt.Rows[i].ItemArray[4].ToString();
               str.cityName = dt.Rows[i].ItemArray[5].ToString();
               str.companyName = dt.Rows[i].ItemArray[6].ToString();
               str.bill = Convert.ToDouble(dt.Rows[i].ItemArray[7]);
               str.address = dt.Rows[i].ItemArray[8].ToString();
               str.discount = Convert.ToDouble(dt.Rows[i].ItemArray[9]);
               str.shipCost = Convert.ToDouble(dt.Rows[i].ItemArray[10]);
               str.order_status = dt.Rows[i].ItemArray[11].ToString();
               str.confirm_by = dt.Rows[i].ItemArray[12].ToString();
               getData.Add(str);
           }

           return getData;
       }
       public List<PendingDelivery> GetComboData(string tableName, string colName)
       {
           List<PendingDelivery> getName = new List<PendingDelivery>();

           string sql = string.Format(" SELECT * FROM {0}  ORDER BY {1} ", tableName, colName);
           SqlCommand cmd = new SqlCommand(sql);

           DataTable dt = da.GetData(cmd);

           foreach (DataRow row in dt.Rows)
           {
               PendingDelivery str = new PendingDelivery();
               str.name = row[1].ToString();
               getName.Add(str);
           }

           return getName;

       }
       public List<PendingDelivery> GetTommorowData(string day )
       {
           string sql ;
           string date = DateTime.Now.AddDays(1).ToString();
           List<PendingDelivery> getData = new List<PendingDelivery>();

         

           if( day =="tommorow")
               sql = string.Format("select  orders.order_id,orders.order_date,orders.ship_date, customer.name, customer.phone_num1 , city.city_name , shippers.company_name, orders.total_price ,customer.address1, orders.discount,orders.ship_cost , order_status.status_ , users.first_name from orders inner join customer on customer.customer_id =orders.customer_id inner join city on city.city_id =customer.city_id inner join shippers on orders.shipper_id = shippers.shipper_id inner join order_status on order_status.status_id=orders.order_status inner join users on  orders.inserted_by=users.user_id where  (orders.order_status=5 OR orders.order_status=1) AND(orders.ship_date = '" + date + "') order by orders.order_id desc");
           else
               sql = string.Format("select  orders.order_id,orders.order_date,orders.ship_date, customer.name, customer.phone_num1 , city.city_name , shippers.company_name, orders.total_price ,customer.address1, orders.discount,orders.ship_cost , order_status.status_ , users.first_name from orders inner join customer on customer.customer_id =orders.customer_id inner join city on city.city_id =customer.city_id inner join shippers on orders.shipper_id = shippers.shipper_id inner join order_status on order_status.status_id=orders.order_status inner join users on  orders.inserted_by=users.user_id  where (orders.order_status=5 OR orders.order_status=1) AND(orders.ship_date > '" + date + "')  order by orders.order_id desc");
          

           SqlCommand cmd = new SqlCommand(sql);
           DataTable dt = da.GetData(cmd);

           for (int i = 0; i < dt.Rows.Count; i++)
           {
              
               PendingDelivery str = new PendingDelivery();
               str.orderID = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
               str.orderDate = dt.Rows[i].ItemArray[1].ToString();
               str.shipDate = dt.Rows[i].ItemArray[2].ToString();
               str.customerName = dt.Rows[i].ItemArray[3].ToString();

               str.phoneNumber = dt.Rows[i].ItemArray[4].ToString();
               str.cityName = dt.Rows[i].ItemArray[5].ToString();
               str.companyName = dt.Rows[i].ItemArray[6].ToString();
               str.bill = Convert.ToDouble(dt.Rows[i].ItemArray[7]);
               str.address = dt.Rows[i].ItemArray[8].ToString();
               str.discount = Convert.ToDouble(dt.Rows[i].ItemArray[9]);
               str.shipCost = Convert.ToDouble(dt.Rows[i].ItemArray[10]);
               str.order_status = dt.Rows[i].ItemArray[11].ToString();
               str.confirm_by = dt.Rows[i].ItemArray[12].ToString();
               getData.Add(str);
           }

           return getData;
       }




    }
}
