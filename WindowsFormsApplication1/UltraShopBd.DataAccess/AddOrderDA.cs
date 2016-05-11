using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using UltraShopBd.FrameWork;
using UltraShopBd.Entites;
namespace UltraShopBd.DataAccess
{
   public class AddOrderDA
    {

       FrameWork.DataAccess da = new FrameWork.DataAccess();
      public int  customerId;

       public void InsertOrder(AddOrder order , List<AddOrder> orderList, Dictionary<string , int>proName, Dictionary<string , int>colorNameId, Dictionary<string , int>orderBy)
      {

        string  sql = string.Format("select order_Id From orders where customer_id='" + order.customerID + "' and ship_date = '" + order.shipDate + "' and order_status = '5'");
          SqlCommand cmd2 = new SqlCommand(sql);
          DataTable dt = new DataTable();
          dt = da.GetData(cmd2);
           if(dt.Rows.Count>0)
           {

               int order_id = Convert.ToInt32(dt.Rows[0].ItemArray[0]);

               foreach (AddOrder item in orderList)
               {
                   string sql2  = string.Format("update stock set quantity=quantity-'"+item.quantity+"' where product_id = '"+proName[item.product_name]+"' and color_id = '"+colorNameId[item.color]+"'") ;

                   SqlCommand cmd4 = new SqlCommand(sql2);
                  
                   da.Execute(cmd4);
                   sql = string.Format("INSERT INTO order_details(order_Id,product_id,quantity,color_id,price,total,order_by_id, order_by_id_id,inserted_by) values('" + order_id + "','" + proName[item.product_name] + "','" + item.quantity + "','" + colorNameId[item.color] + "','" + item.sellingPrice + "','" + item.perItemTtlAmount + "','" + orderBy[item.orderByName] + "','" + item.orderById + "','" + order.userId + "')");

                   SqlCommand cmd3 = new SqlCommand(sql);
                   da.Execute(cmd3);

               }

               string update = string.Format("Update orders set total_price = '"+order.totalAmount+"'+total_price where order_Id = '"+order_id+"'  ");
               SqlCommand cmd5 = new SqlCommand(update);
               da.Execute(cmd5);


           }
           else
           {


              string sql1 = string.Format("INSERT INTO orders(customer_id,total_price,shipper_id, inserted_by, ship_date,order_date,discount,ship_cost,order_status) values('" + order.customerID + "','" + order.totalAmount + "','" + order.shipId + "','" + order.userId + "','" + order.shipDate + "','" + order.todayDate + "' ,'" + order.discount + "','" + order.shipCost + "','5') ");

               SqlCommand cmd1 = new SqlCommand(sql1);
               da.Execute(cmd1);

               string sql2 = string.Format("select order_Id from orders where customer_id='" + order.customerID + "' and ship_date = '" + order.shipDate + "' and order_status = '5'");

               SqlCommand cmd4 = new SqlCommand(sql2);
               DataTable dtt = new DataTable();
               dtt = da.GetData(cmd4);

               int order_id = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);

               foreach (AddOrder item in orderList)
               {
                   string sql6 = string.Format("update stock set quantity=quantity-'" + item.quantity + "' where product_id = '" + proName[item.product_name] + "' and color_id = '" + colorNameId[item.color] + "'");

                   SqlCommand cmd6 = new SqlCommand(sql6);

                   da.Execute(cmd6);

                   sql = string.Format("INSERT INTO order_details(order_Id,product_id,quantity,color_id,price,total,order_by_id, order_by_id_id,inserted_by) values('" + order_id + "','" + proName[item.product_name] + "','" + item.quantity + "','" + colorNameId[item.color] + "','" + item.sellingPrice + "','" + item.perItemTtlAmount + "','" + orderBy[item.orderByName] + "','" + item.orderById + "','" + order.userId + "')");
                   SqlCommand cmd3 = new SqlCommand(sql);
                   da.Execute(cmd3);

               }




           }
         
      

      }
       public List<AddOrder> GetPreviousOrder(int customerId)
       {

           List<AddOrder> getOrer = new List<AddOrder>();
           string sql = string.Format(" SELECT orders.order_id, orders.order_date,orders.ship_date,orders.total_price,order_status.status_ FROM orders inner join order_status on orders.order_status = order_status.status_id where orders.customer_id='" + customerId + "'");
           SqlCommand cmd = new SqlCommand(sql);

           DataTable dt = da.GetData(cmd);

           foreach (DataRow row in dt.Rows)
           {
               AddOrder str = new AddOrder();
               str.orderID = Convert.ToInt32(row.ItemArray[0]);
               str.oderDate = row.ItemArray[1].ToString();
               str.shipDate = row.ItemArray[2].ToString();
               str.totalAmount = Convert.ToInt32(row.ItemArray[3]);
               str.orderStatus = row.ItemArray[4].ToString();

               getOrer.Add(str);
           }


           return getOrer;

       }



       public List<AddOrder> GetOrderBy_()
       {

           List<AddOrder> getName = new List<AddOrder>();
           string sql = string.Format(" SELECT id ,name FROM order_by");
           SqlCommand cmd = new SqlCommand(sql);

           DataTable dt = da.GetData(cmd);

           foreach (DataRow row in dt.Rows)
           {
               AddOrder str = new AddOrder();
               str.orderByName = row[1].ToString();
               str.orderBy_id = Convert.ToInt32(row[0]);

               getName.Add(str);
           }

           return getName;

       }

       public List<AddOrder> GetProductName()
       {

           List<AddOrder> getName = new List<AddOrder>();
           string sql = string.Format(" SELECT distinct  products.product_name , products.product_id FROM products inner join stock  on products.product_id = stock.product_id ");
           SqlCommand cmd = new SqlCommand(sql);

           DataTable dt = da.GetData(cmd);

           foreach (DataRow row in dt.Rows)
           {
               AddOrder str = new AddOrder();
               str.product_name = row[0].ToString();
               str.productId = Convert.ToInt32(row[1]);

               getName.Add(str);
           }

           return getName;

       }
      public List<AddOrder> GetItemName(string tableName, string colName)
      {
          List<AddOrder> getName = new List<AddOrder>();

          string sql = string.Format(" SELECT * FROM {0}  ORDER BY {1} ", tableName, colName);
          SqlCommand cmd = new SqlCommand(sql);

          DataTable dt = da.GetData(cmd);

          foreach (DataRow row in dt.Rows)
          {
              AddOrder str = new AddOrder();
              str.customer_name = row[1].ToString();
              getName.Add(str);
          }

          return getName;

      }

      public int GetId(string tableName, string colName, string name)
      {
          string sql = string.Format(" SELECT * FROM {0}  where  {1} = '" + name + "'  ", tableName, colName);

          SqlCommand cmd = new SqlCommand(sql);

          DataTable dt = da.GetData(cmd);
          if (dt.Rows.Count > 0)
          {
              int id = dt.Rows[0].Field<int>(0);
              return id;
          }
          else
          {

              return -1;
          }
      }

       public AddOrder GetStockInfo(AddOrder aOrder)
      {

          string sql = string.Format("SELECT quantity, selling_price ,purchase_price From stock where product_id='" + aOrder.productId + "' and color_id ='" + aOrder.colorId + "' ");
             SqlCommand cmd = new SqlCommand(sql);

          DataTable dt = da.GetData(cmd);
          aOrder.ttlQuantiy =Convert.ToInt32( dt.Rows[0].ItemArray[0]);
          aOrder.sellingPrice =Convert.ToDouble( dt.Rows[0].ItemArray[1]);
          if (dt.Rows[0].ItemArray[2]!=null)
          aOrder.purchasePrice =Convert.ToDouble( dt.Rows[0].ItemArray[2]);
          return aOrder;
      }
       public List<AddOrder> GetColor()
       {
           List<AddOrder> getColor = new List<AddOrder>();
            string sql = string.Format(" SELECT color_id, color_name FROM color");
          SqlCommand cmd = new SqlCommand(sql);
          DataTable dt = da.GetData(cmd);

          foreach (DataRow row in dt.Rows)
          {
              AddOrder str = new AddOrder();
              str.color = row[1].ToString();
              str.colorId = Convert.ToInt32(row[0]);
              getColor.Add(str);
          }

          return getColor;

       }

      public List<AddOrder> GetComboData(AddOrder info)
      {
          List<AddOrder> getName = new List<AddOrder>();

          string sql = string.Format(" SELECT color.color_name FROM stock inner join color  on stock.color_id = color.color_id where  stock.product_id ='"+info.productId+"' ORDER BY color_name");
          SqlCommand cmd = new SqlCommand(sql);

          DataTable dt = da.GetData(cmd);

          foreach (DataRow row in dt.Rows)
          {
              AddOrder str = new AddOrder();
              str.color = row[0].ToString();
              getName.Add(str);
          }

          return getName;

      }
      public List<AddOrder> GetComboData()
      {
          List<AddOrder> getName = new List<AddOrder>();

          string sql = string.Format(" SELECT name FROM order_by ");
          SqlCommand cmd = new SqlCommand(sql);

          DataTable dt = da.GetData(cmd);

          foreach (DataRow row in dt.Rows)
          {
              AddOrder str = new AddOrder();
              str.orderByName = row[0].ToString();
              getName.Add(str);
          }

          return getName;

      }

   
    }
}
