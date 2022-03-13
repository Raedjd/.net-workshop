using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RJ.Data.Configuration;
using RJ.Domaine;
namespace RJ.Data
{  
    /// <summary>
    /// semaine5-seance2
    /// </summary>
   public class RJContext: DbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Provider> Providers { get; set; }
        DbSet<Chemical> Chemicals { get; set; }
        DbSet<Biological> Biologicals { get; set; }
        DbSet<Category> Categories { get; set; }

          internal void add(Category cat)
          {
              throw new NotImplementedException();
          }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //  base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ChemicalConfiguration());
            modelBuilder.Configurations.Add(new ProviderConfiguration());
            modelBuilder.Configurations.Add(new AddresseConfiguration());
            //modelBuilder.Entity<Product>().ToTable("Product");
            //modelBuilder.Entity<Chemical>().ToTable("Chemical");
            //modelBuilder.Entity<Biological>().ToTable("Biological");
        }




    }
}
