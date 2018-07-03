using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public static class BLL
    {
        public static List<Product> GetFilterList()
        {
            List<Product> FullProductList = DBmanager.GetProductList();
            if (FullProductList == null)
            {
                return null;
            }
            List<Product> FilterProducts = new List<Product>();
            foreach (Product item in FullProductList)
            {
                if (item.ProductName.Length == item.CategoryName.Length)
                {
                    FilterProducts.Add(item);
                }
            }
            return FilterProducts;
        }
    }
}
