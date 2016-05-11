using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using UltraShopBd.Entites;


namespace UltraShopBd.DataAccess
{

   public class AddNewProductDA
    {
       FrameWork.DataAccess da = new FrameWork.DataAccess();
    
     

       public void InserData(AddNewProduct allData)
       {

           string sql = string.Format(" INSERT INTO products (product_name,cat_id,sub_cat_id,sub_sub_cat_id,description,color,condition_id) VALUES('"+allData.name+"','" + allData.catId + "','" + allData.subCatId1 + "','" + allData.subCatId2 + "','" + allData.description + "','" + allData.color + "','" + allData.conditionId+ "') ");

           SqlCommand cmd = new SqlCommand(sql);

           da.Execute(cmd);

       }
       public int GetId( string tableName, string colName , string  name)
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
       public List<AddNewProduct> GetName(string tableName)
       {
           List<AddNewProduct> getName = new List<AddNewProduct>();

           string sql = string.Format(" SELECT * FROM {0}   ", tableName);
           SqlCommand cmd = new SqlCommand(sql);

           DataTable dt = da.GetData(cmd);

           foreach (DataRow row in dt.Rows)
           {
               AddNewProduct cat = new AddNewProduct();
               cat.color = row[1].ToString();
               getName.Add(cat);
           }

           return getName;

       }


       
       public List<AddNewProduct> GetSubCategory(string tableName, string colName, int id)
       {
           List<AddNewProduct> subCategories = new List<AddNewProduct>();

           string sql = string.Format(" SELECT * FROM {0}  where  {1} = '" + id + "'  ", tableName, colName);
           SqlCommand cmd = new SqlCommand(sql);

          DataTable dt = da.GetData(cmd);

           foreach (DataRow row in dt.Rows)
           {
               AddNewProduct cat = new AddNewProduct();
               cat.subCategory1= row[1].ToString();
               subCategories.Add(cat);
           }

           return subCategories;

       }

      



       
    }
  

}
