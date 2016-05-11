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
    public class AddcustomerInfoDA
    {

        FrameWork.DataAccess da = new  FrameWork.DataAccess();

        public void InserData(AddCustomerInfo cusInfo)
        {
            string sql = string.Format(" INSERT INTO customer (name ,address1,phone_num1,phone_num2,region_id,city_id,shipper_id) VALUES('" + cusInfo.name + "','" + cusInfo.address1 + "','" + cusInfo.phone_num1 + "','" + cusInfo.phone_num2 + "','" + cusInfo.region_id + "','" + cusInfo.city_id + "','" + cusInfo.shipper_id + "') ");
           
            SqlCommand cmd = new SqlCommand(sql);

            da.Execute(cmd);


        }
        public List<AddCustomerInfo> GetCustomerInfo(string tableName, string phoneNumber)
        {
            List<AddCustomerInfo> customerlist = new List<AddCustomerInfo>();

            string sql = string.Format(" SELECT * FROM {0}  where  {1} = phone_num1  OR  {1} = phone_num2 ", tableName, phoneNumber, phoneNumber);

            SqlCommand cmd = new SqlCommand(sql);

            DataTable dt = da.GetData(cmd);
         
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    AddCustomerInfo aCustomerInfo = new AddCustomerInfo();
                    aCustomerInfo.customerInfo = dt.Columns.ToString();
                    customerlist.Add(aCustomerInfo);

                }

                return customerlist;
        }
        public AddCustomerInfo  GetCustomerId(string phoneNumber)
        {
            string sql = string.Format(" SELECT customer.customer_id ,customer.name, customer.address1,customer.address2,customer.phone_num1,customer.phone_num2, shippers.shipper_id, shippers.company_name, regions.region_name, city.city_name  FROM customer inner join regions on customer.region_id=regions.region_id inner join city on city.city_id = customer.city_id inner join shippers on shippers.shipper_id= customer.shipper_id where phone_num1= '" + phoneNumber + "'  OR   phone_num2 = '" + phoneNumber + "' ");

            AddCustomerInfo customer = new AddCustomerInfo();
            SqlCommand cmd = new SqlCommand(sql);
            customer.customer_id = -1;
            DataTable dt = da.GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                customer.customer_id = Convert.ToInt32( dt.Rows[0].ItemArray[0]);
                customer.name = dt.Rows[0].ItemArray[1].ToString();
                customer.address1 = dt.Rows[0].ItemArray[2].ToString();
                customer.address2 = dt.Rows[0].ItemArray[3].ToString();
                customer.phone_num1 = dt.Rows[0].ItemArray[4].ToString();
                customer.phone_num2 = dt.Rows[0].ItemArray[5].ToString();
                customer.shipper_id = Convert.ToInt32(dt.Rows[0].ItemArray[6]);
                customer.company_name = dt.Rows[0].ItemArray[7].ToString();
                customer.region = dt.Rows[0].ItemArray[8].ToString();
                customer.city = dt.Rows[0].ItemArray[9].ToString();

                return customer;
            }
            else
            {

                return customer;
            }
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


        public List<AddCustomerInfo> GetCityCombo(string tableName, string colName ,int id)
        {
            List<AddCustomerInfo> cityList = new List<AddCustomerInfo>();

            string sql = string.Format(" SELECT * FROM {0}  where  {1} = '" + id + "' order by city_name ASC", tableName, colName);
            SqlCommand cmd = new SqlCommand(sql);
        

            DataTable dt = da.GetData(cmd);

            foreach (DataRow row in dt.Rows)
            {
               AddCustomerInfo str = new AddCustomerInfo();
                str.city = row[1].ToString();
               cityList.Add(str);
            }

            return cityList;

        }

        public List<AddCustomerInfo> GetComboData(string tableName, string colName)
        {
            List<AddCustomerInfo> getName = new List<AddCustomerInfo>();

            string sql = string.Format(" SELECT * FROM {0}  ORDER BY {1} ", tableName,colName);
            SqlCommand cmd = new SqlCommand(sql);

            DataTable dt = da.GetData(cmd);

            foreach (DataRow row in dt.Rows)
            {
              AddCustomerInfo str = new AddCustomerInfo();
                str.name = row[1].ToString();
                getName.Add(str);
            }

            return getName;

        }

   

    }
}
