using System;
using System.Collections.Generic;
using System.Text;
using RJ.Domaine;
namespace RJ.Service
{
    public delegate IList<Product> FindProduct(string r);
    public delegate void ScanProduct(Category myCategory);
    class ProductManage
    {

        public FindProduct FindProduct { get; set; }
        public ScanProduct ScanProduct { get; set; }

        List<Product> myProducts;

        public ProductManage(List<Product> myProducts)
        {
            this.myProducts = myProducts;
        }

    }
}
