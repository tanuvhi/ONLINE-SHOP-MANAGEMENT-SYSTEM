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
    public  class StockDA
    {
        FrameWork.DataAccess da = new FrameWork.DataAccess();


        public List<Stock> GetGridDataName(Stock sl)
        {
            List<Stock> getData = new List<Stock>();
            string sql = string.Format("select  stock.product_id, products.product_name,color.color_name, stock.quantity,stock.selling_price From  stock inner join products  on products.product_id = stock.product_id inner join color on stock.color_id = color.color_id where products.product_name='" + sl.productName + "' ORDER BY stock.quantity ASC  ");

            SqlCommand cmd = new SqlCommand(sql);
            DataTable dt = da.GetData(cmd);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Stock  str = new Stock();

                
                str.productId = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                str.productName = dt.Rows[i].ItemArray[1].ToString();
                str.color = dt.Rows[i].ItemArray[2].ToString();
                str.quantiy = Convert.ToInt32(dt.Rows[i].ItemArray[3]);
                str.sellingPrice = Convert.ToDouble(dt.Rows[i].ItemArray[4]);
               
                getData.Add(str);
            }

            return getData;
        }

        public List<Stock> GetGridData()
        {
            List<Stock> getData = new List<Stock>();
            string sql = string.Format("select  stock.product_id, products.product_name,color.color_name, stock.quantity,stock.selling_price From  stock inner join products  on products.product_id = stock.product_id inner join color on stock.color_id = color.color_id ORDER BY stock.quantity ASC  ");

            SqlCommand cmd = new SqlCommand(sql);
            DataTable dt = da.GetData(cmd);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Stock str = new Stock();


                str.productId = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                str.productName = dt.Rows[i].ItemArray[1].ToString();
                str.color = dt.Rows[i].ItemArray[2].ToString();
                str.quantiy = Convert.ToInt32(dt.Rows[i].ItemArray[3]);
                str.sellingPrice = Convert.ToDouble(dt.Rows[i].ItemArray[4]);

                getData.Add(str);
            }

            return getData;
        }

    }
}
