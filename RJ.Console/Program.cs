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
            System.Console.WriteLine("///////////////////////////////////////////////////////////////:");
            Product produit2 = new Product();
            Product ch = new Chemical();
            Product bi = new Biological();
            produit2.GetMyType();
            ch.GetMyType();
            bi.GetMyType();
             

            System.Console.ReadKey();
        }
    }
}
