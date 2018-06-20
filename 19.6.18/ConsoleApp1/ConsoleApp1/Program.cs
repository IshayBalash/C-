using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{

    
    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> CoustomersInfo = new List<dynamic>();
            string SqlConnection = "Data Source=DESKTOP-8FERJR4\\SQL_SERVER;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection sql = null;


            try
            {
                using (sql = new SqlConnection(SqlConnection))
                {
                    sql.Open();
                    SqlCommand Query = new SqlCommand("select CustomerID,CompanyName,Address,City,Region,Country from Customers", sql);
                    SqlDataReader DataReader = Query.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var coustomerInfo = new
                        {
                            coustomerId = DataReader[0],
                            CompanyName = DataReader[1],
                            Adress = DataReader[2],
                            City = DataReader[3],
                            Region = DataReader[4],
                            Country = DataReader[5]
                        };
                        CoustomersInfo.Add(coustomerInfo);
                    }
                }
                int count = CoustomersInfo.Count();
                Console.WriteLine($" there are {count} coustomers in the list");
                foreach (var item in CoustomersInfo)
                {
                    Console.WriteLine("------------------------------------");
                    Console.Write($"Id: {item.coustomerId} ");
                    Console.Write($"Company_Name: {item.CompanyName} ");
                    Console.Write($"Adress: {item.Adress} ");
                    Console.Write($"City: {item.City} ");
                    Console.Write($"Region: {item.Region} ");
                    Console.Write($"Country: {item.Country} ");
                    Console.WriteLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
