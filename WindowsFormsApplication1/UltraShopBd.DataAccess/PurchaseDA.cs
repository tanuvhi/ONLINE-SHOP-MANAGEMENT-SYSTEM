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
    public class PurchaseDA
    {
        FrameWork.DataAccess da = new FrameWork.DataAccess();
        Purchase purchase = new Purchase();

        public void InsertData(Purchase data)
        {
            
            string sql = string.Format(" INSERT INTO purchases (product_id,color_id,quantity,selling_price,purchase_price,date) VALUES('" + data.productId + "','" + data.colorId + "','" + data.quantity + "','" + data.sellingPrice + "','" + data.purchasePrice + "','" + data.date + "') ");

            SqlCommand cmd = new SqlCommand(sql);

            da.Execute(cmd);

        }
        public void InsertInStock(Purchase data)
        {
            string sql = string.Format(" INSERT INTO stock (product_id,color_id,quantity,selling_price ,purchase_price) VALUES('" + data.productId + "','" + data.colorId + "','" + data.quantity + "','" + data.sellingPrice + "','"+data.purchasePrice+"') ");

            SqlCommand cmd = new SqlCommand(sql);

            da.Execute(cmd);

        }
        public bool  SearchNameIdStock(Purchase data)
        {
             string sql = string.Format("SELECT * FROM stock where product_id = '"+data.productId+"' and color_id = '"+data.colorId+"'");
            SqlCommand cmd = new SqlCommand(sql);

            DataTable dt = new DataTable();
            dt = da.GetData(cmd);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

        public void StockUpdate(Purchase data)
        {
            
           
            if (data.sellingPrice < 0)
            {

                string sql1 = string.Format("SELECT selling_price From stock where product_id='" + data.productId + "' and color_id ='" + data.colorId + "' ");
                 SqlCommand cmd1 = new SqlCommand(sql1);

                DataTable dt = new DataTable();

                dt = da.GetData(cmd1);
                data.sellingPrice = Convert.ToDouble(dt.Rows[0].ItemArray[0]);
            }
           
           string sql2 = string.Format("UPDATE stock set quantity='"+data.quantity+"'+quantity , selling_price ='"+data.sellingPrice+"',purchase_price='"+data.purchasePrice+"' where product_id = '"+data.productId+"' and color_id = '"+data.colorId+"' ");

            SqlCommand cmd = new SqlCommand(sql2);

            da.Execute(cmd);
         

        }
        public List<Purchase>  GetGridData(Purchase sl)
        {
            List<Purchase> getData = new List<Purchase>();

          

            string sql = string.Format("select purchases.date, products.product_id, products.product_name,color.color_name, purchases.quantity,purchases.purchase_price,purchases.selling_price From products inner join purchases  on products.product_id = purchases.product_id inner join color on purchases.color_id = color.color_id  where purchases.date >= '" + sl.MinDate + "' and purchases.date <= '" + sl.MaxDate + "'   ");
            SqlCommand cmd = new SqlCommand(sql);
            DataTable dt = da.GetData(cmd);
          
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                Purchase str = new Purchase();

                str.date = dt.Rows[i].ItemArray[0].ToString();
                str.productId = Convert.ToInt32(dt.Rows[i].ItemArray[1]);
                str.name = dt.Rows[i].ItemArray[2].ToString();
                str.color = dt.Rows[i].ItemArray[3].ToString();
                str.quantity = Convert.ToInt32(dt.Rows[i].ItemArray[4]);
                str.purchasePrice = Convert.ToDouble(dt.Rows[i].ItemArray[5]);
                str.sellingPrice = Convert.ToDouble(dt.Rows[i].ItemArray[6]);

                getData.Add(str);
            }

            return getData;
        
        }
        public List<Purchase> GetGridDataName(Purchase sl)
        {
            List<Purchase> getData = new List<Purchase>();
            string sql = string.Format("select purchases.date, products.product_id, products.product_name,color.color_name, purchases.quantity,purchases.purchase_price,purchases.selling_price From products inner join purchases  on products.product_id = purchases.product_id inner join color on purchases.color_id = color.color_id where purchases.date >= '" + sl.MinDate + "' and purchases.date <= '" + sl.MaxDate + "'  and products.product_name='" + sl.itemName + "'  ");

            SqlCommand cmd = new SqlCommand(sql);
            DataTable dt = da.GetData(cmd);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Purchase str = new Purchase();

                str.date = dt.Rows[i].ItemArray[0].ToString();
                str.productId = Convert.ToInt32(dt.Rows[i].ItemArray[1]);
                str.name = dt.Rows[i].ItemArray[2].ToString();
                str.color = dt.Rows[i].ItemArray[3].ToString();
                str.quantity = Convert.ToInt32(dt.Rows[i].ItemArray[4]);
                str.purchasePrice = Convert.ToDouble(dt.Rows[i].ItemArray[5]);
                str.sellingPrice = Convert.ToDouble(dt.Rows[i].ItemArray[6]);



                getData.Add(str);
            }

            return getData;
        }

        public List<Purchase> GetItemName(string tableName, string colName)
        {
            List<Purchase> getName = new List<Purchase>();

            string sql = string.Format("SELECT * FROM {0}  ORDER BY {1} ", tableName, colName);
            SqlCommand cmd = new SqlCommand(sql);

            DataTable dt = da.GetData(cmd);

            foreach (DataRow row in dt.Rows)
            {
                Purchase str = new Purchase();
                str.name = row[1].ToString();
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

        public List<Purchase> GetComboData(string tableName, string colName)
        {
            List<Purchase> getName = new List<Purchase>();

            string sql = string.Format(" SELECT * FROM {0}  ORDER BY {1} ", tableName, colName);
            SqlCommand cmd = new SqlCommand(sql);

            DataTable dt = da.GetData(cmd);

            foreach (DataRow row in dt.Rows)
            {
                Purchase str = new Purchase();
                str.name = row[1].ToString();
                getName.Add(str);
            }

            return getName;

        }


    }
}
