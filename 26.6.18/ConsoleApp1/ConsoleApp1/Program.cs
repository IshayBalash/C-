using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindEntities ef = new NorthwindEntities())
            {
                List<Product> ProductAfterDisscount = new List<Product>();
                foreach(Product p in ef.Products)
                {
                    foreach(Category c in ef.Categories)
                    {
                        if (p.ProductName.Length == c.CategoryName.Length)
                        {
                            if (ProductAfterDisscount.Contains(p)){
                                continue;
                            }
                            else
                            {
                                ProductAfterDisscount.Add(p);
                            }
                            
                        }
                    }
                }
                Console.WriteLine($"there is {ProductAfterDisscount.Count} results");
                foreach (Product p in ProductAfterDisscount)
                {
                    Console.WriteLine(p.ProductName);
                }

                foreach (Product origen in ef.Products)
                {
                    for (int i = 0; i < ProductAfterDisscount.Count; i++)
                    {
                        if (origen.ProductID == ProductAfterDisscount[i].ProductID)
                        {
                            origen.UnitPrice = origen.UnitPrice - (origen.UnitPrice / 10);
                        }
                    }
                }

                ef.SaveChanges();
                Console.WriteLine("changes were done to the DB");

            }
                
            }
        }
    }

