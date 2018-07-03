using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product>fullProductList= DBmanager.GetProductList();
            Console.WriteLine($"in the origen list there are {fullProductList.Count}");
            List<Product> filterProductList = BLL.BLL.GetFilterList();
            Console.WriteLine($"in the filter list there are {filterProductList.Count}");
            Console.WriteLine();
            Console.WriteLine("this is the products info:");
            Console.WriteLine();
            foreach (Product item in filterProductList)
            {
                Console.WriteLine($"ProductName {item.ProductName} CategoryName:{item.CategoryName} UnitPrice: {item.UnitPrice}");
            }               
        }
    }
}
