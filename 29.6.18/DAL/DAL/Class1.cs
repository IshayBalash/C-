using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data.SqlClient;


namespace DAL
{
    public static class DBmanager
    {
         static string ConnectionString { get; set; } = "Data Source=DESKTOP-8FERJR4\\SQL_SERVER;Initial Catalog=Northwind;Integrated Security=True";
         
          public static List<Product> GetProductList()
        {
            SqlConnection sql = null;
            try
            {
                using(sql= new SqlConnection(ConnectionString))
                {
                    List<Product> ProductList = new List<Product>();
                    sql.Open();
                    SqlCommand Query = new SqlCommand("select ProductName,Categories.CategoryName,UnitPrice from Products INNER jOIN  Categories on Products.CategoryID=Categories.CategoryID", sql);
                    SqlDataReader DataReader = Query.ExecuteReader();
                    while (DataReader.Read())
                    {
                        Product NewProduct = new Product();
                        NewProduct.ProductName = DataReader[0].ToString();
                        NewProduct.CategoryName = DataReader[1].ToString();
                        NewProduct.UnitPrice = (decimal)(DataReader[2]);
                        ProductList.Add(NewProduct);
                    }
                    return ProductList;
                }
            }
            catch
            {
                return null; 
            }
        }

    }
}
