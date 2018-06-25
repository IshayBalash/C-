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
            List<Customers> CustomersList = new List<Customers>();
            string conectionstring = "Data Source=DESKTOP-8FERJR4\\SQL_SERVER;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection sql = null;
            try
            {
                using (sql = new SqlConnection(conectionstring))
                {
                    sql.Open();
                    SqlCommand Query = new SqlCommand("select * from Customers", sql);
                    SqlDataReader DataRead = Query.ExecuteReader();
                    while (DataRead.Read())
                    {
                        Customers customerInfo = new Customers
                        {
                            CustomerID = DataRead[0].ToString(),
                            CompanyName = DataRead[1].ToString(),
                            ContactName = DataRead[2].ToString(),
                            ContactTitle = DataRead[3].ToString(),
                            Adress = DataRead[4].ToString(),
                            City = DataRead[5].ToString(),
                            Region = DataRead[6].ToString(),
                            PostalCode = DataRead[7].ToString(),
                            Country = DataRead[8].ToString(),
                            Phone = DataRead[9].ToString(),
                            Fax = DataRead[10].ToString()

                        };
                        CustomersList.Add(customerInfo);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            IEnumerable<Customers> customersList2 = CustomersList.Where((Customers customer) => { return customer.CustomerID.Contains("A") || customer.CustomerID.Contains("a"); });
            var FinalList = customersList2.Select((Customers customer) =>
            {
                return new
                {
                    id = customer.CustomerID,
                    company = customer.ContactName,
                    adress = customer.Adress,
                    city = customer.City,
                    region = customer.Region,
                    country = customer.Country
                };

            }
            );
            Console.WriteLine($"there is:{FinalList.Count()} results on the list");
            foreach (var item in FinalList)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"id: {item.id}");
                Console.WriteLine($"company: {item.company}");
                Console.WriteLine($"adress: {item.adress}");
                Console.WriteLine($"City: {item.city}");
                Console.WriteLine($"Country: {item.country}");
            }



        }
            
    }
}
