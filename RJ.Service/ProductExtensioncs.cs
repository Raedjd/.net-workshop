
using System;
using System.Collections.Generic;
using System.Text;
using RJ.Domaine;
namespace RJ.Service
{
    public static class ProductExtensioncs
    {
        public static void UpperName(this ProductManage productMange,  Product product) {

            product.Name.ToLower();
        }

        public static bool InCategory(this CategorieManage categorieManage,Category category) {
            IList<Product> listProducts = new List<Product>();
            foreach (Product item in listProducts)
            {
                if (item.CategoryId.Equals(category))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
