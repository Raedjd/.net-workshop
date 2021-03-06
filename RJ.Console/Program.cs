using System;
using System.Collections.Generic;
using RJ.Domaine;
using RJ.Service;
using RJ.Data;
namespace RJ.Console;
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductId = 1;
            product.Name = "yaghort";
            product.Price =0.5;
            product.Quantity = 10;
            product.DateProd = DateTime.Now;
            System.Console.WriteLine("idProduct:"+ product.ProductId + "" + "Name:" +product.Name+""+"Price:"+ 
                                      product.Price+""+"DateProduct:"+ product.DateProd);
            product.getDetails();

            Provider provider = new Provider() { Pwd = "raed12", ConfPwd = "raed12", UserName="raedjaidi",Email="raed.jaidi@esprit.tn" };
            System.Console.WriteLine(provider.Login("raedjaidi", "raed12", "raed.jaidi@esprit.tn"));
            //System.Console.WriteLine(provider.Login("raedjaidi", "raed12"));
            System.Console.WriteLine("///////////////////////////////////////////////////////////////");
        Product produit2 = new Product() {
            Name = "delice";
            };
            Product ch = new Chemical();
            Product bi = new Biological();
            produit2.GetMyType();
            ch.GetMyType();
            bi.GetMyType();
            System.Console.WriteLine("///////////////////////////////////////////////////////////////");

            provider.products.Add(product);
            provider.getDetails();
            System.Console.WriteLine("///////////////////////////////////////////////////////////////");

            IList<Product> products = new List<Product>()
            {
                new Product()
                {
                    Description = "lait",
                    Price = 2,
                    DateProd = new DateTime(2021, 02, 07),
                    Quantity = 12

                },
            };

            System.Console.WriteLine("///////////////////////////////////////////////////////////////");

            provider.Find = delegate (Product Product)
            {
                System.Console.WriteLine(Product.Description);
                return null;
            };

            System.Console.WriteLine("/////////////////////////////////TP2 SEMAINE4////////////////////////////");

             ProductManage productManage = new ProductManage(products);
                //Méthode anonyme de findProduct
                productManage.FindProduct("r", delegate (string r)){ 
                  IList<Product> listProducts = new List<Product>();
                foreach (Product item in myProducts)
                {
                if (item.Name.StartsWith(r)) listProducts.Add(item);
                }
                return listProducts;
                };

              //Méthode anonyme de scanProduct
               productManage.ScanProduct(pc, delegate (Category myCategory)){
               // IList<Product> listProducts = new List<Product>();
                foreach (Product item in myProducts)
              {
                if (item.category.Equals(myCategory))
                {
                    item.getDetails();
                }

                }
                };

              //Expression lambda de findProduct
            productManage.FindProduct("r", delegate (string r))=>
            IList<Product> listProducts = new List<Product>();
            foreach (Product item in myProducts)
            {
                if (item.Name.StartsWith(r)) listProducts.Add(item);
            }
            return listProducts;
            };

                //Expression lambda de scanProduct
               productManage.ScanProduct(pc, delegate (Category myCategory))=>
               // IList<Product> listProducts = new List<Product>();
                foreach (Product item in myProducts)
                {
                if (item.category.Equals(myCategory))
                {
                    item.getDetails();
                }

                }
                };

             //Methode d'extension
             productManage.UpperName(produit2);

               /////////////////////semaine5_seance2////////////////////
                
            System.Console.ReadKey();

        
        }
        //public IList<Product> FindUser(Product product)
        //{
        //  System.Console.WriteLine("");
        // return null;
        // }
      
       /*  IList<Product> myProducts;
        public IList<Product> FindProduct(string r)
        {
            IList<Product> listProducts = new List<Product>();
            foreach (Product item in myProducts)
            {
                if (item.Name.StartsWith(r)) listProducts.Add(item);
            }
            return listProducts;
        }

        public void ScanProduct(Category myCategory)
        {
            // IList<Product> listProducts = new List<Product>();
            foreach (Product item in myProducts)
            {
                if (item.category.Equals(myCategory))
                {
                    item.getDetails();
                }

            }

        } */
    } 
}
  //notions de tableau
  //int [] tab = new int [10]; 
  // [,] tab= new [2,3];
  // int [] [] tab new [3][];

   