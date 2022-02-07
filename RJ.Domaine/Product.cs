using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Domaine
{
    public class Product
    {
        //Attribute & Getters et Setters
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateProd { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Category category { get; set; }
        public IList<Provider> providers { get; set; }

        public Product()
        {
            this.providers = new List<Provider>();
        }

        public void getDetails()
        {
            Console.WriteLine($"{Quantity} {Name} {Price}" + $"{ProductId} {Description} {DateProd}");
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("I'am a product");
        }
    }
} 
 