using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RJ.Domaine;
namespace RJ.Data
{  
    /// <summary>
    /// semaine5-seance2
    /// </summary>
   public class RJContext: DbContext
    {
        public RJContext(): base("name=DB")
        {

        }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Provider> Providers { get; set; }
        public   DbSet<Category> Categories { get; set; }
    }
}
