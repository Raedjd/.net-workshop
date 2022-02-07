using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RJ.Domaine;
namespace RJ.Console
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
            Product produit2 = new Product();
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

             System.Console.ReadKey();

        
        }
        //public IList<Product> FindUser(Product product)
        //{
          //  System.Console.WriteLine("");
           // return null;
       // }
    } 
}
  //notions de tableau
  //int [] tab = new int [10]; 
  // [,] tab= new [2,3];
  // int [] [] tab new [3][];

   