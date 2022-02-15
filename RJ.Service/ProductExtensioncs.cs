
using System;
using System.Collections.Generic;
using System.Text;
using RJ.Domaine;
namespace RJ.Service
{
    public static class ProductExtensioncs
    {
        public static void UpperName(  Product product) {

            product.Name.ToLower();
        }

        public static bool InCategory(Category category) {
            IList<Product> listProducts = new List<Product>();
            foreach (Product item in listProducts)
            {
                if (item.category.Equals(category))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
