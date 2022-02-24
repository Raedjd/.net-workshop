using System;
using System.Collections.Generic;
using System.Text;
using RJ.Domaine;
using System.Linq;
namespace RJ.Service
{
    public delegate IList<Product> FindProduct(string r);
    public delegate void ScanProduct(Category myCategory);
   public class ProductManage
    {

        public FindProduct FindProduct { get; set; }
        public ScanProduct ScanProduct { get; set; }

        List<Product> myProducts;

        public ProductManage(List<Product> myProducts)
        {
            this.myProducts = myProducts;
        }

        //////////////////////////////semaine5-seance1///////////////////////////////////////
        
        public IEnumerable<Product> Get5Chemical(double price)
        {
            var query = from prod in myProducts
                        where prod is Chemical
                        select prod;
            return query.Skip(5);
        }

        public IEnumerable<Product> GetProductPrice(double price)
        {
            var query = from prod in myProducts
                        where prod.Price>price
                        select prod;
            return query.Skip(2);
        }

        public double GetAveragePrice()
        {
            var query = from prod in myProducts
                        select prod.Price;
            return query.Average();

        }

        public Product GetMaxPrice()
        {
            var query = from prod in myProducts
                        select prod;
            return query.Max();

        }

        public int GetCountProduct(string city)
        {
            var query = from prod in myProducts
                        where prod is Chemical && ((Chemical)prod).City.Contains(city)

                        select prod;
            return query.Count();
        }

        public List<Product> GetChemicalCity()
        {
            var query = from prod in myProducts
                        where prod is Chemical orderby ((Chemical)prod).City
                        select prod;
            return query.ToList();
        }
        public void GetChemicalGroupByCity()
        {
            var query = from prod in myProducts
                        where prod is Chemical
                        orderby ((Chemical)prod).City
                        group prod by ((Chemical)prod).City;

            foreach (var item in query)
            {
                Console.WriteLine(item.Key);
            }
           
        }


    }
}
