using Microsoft.EntityFrameworkCore;
using PS.Data.Configurations;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data
{
    public class PSContext : DbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Provider> Providers { get; set; }
        DbSet<Chemical> Chemicals { get; set; }
        DbSet<Biological> Biologicals { get; set; }
        DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLlocalDB; Initial catalog=Tarek; Integrated Security = True; ");
           
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProviderConf());
            modelBuilder.ApplyConfiguration(new CategoryConf());
            modelBuilder.ApplyConfiguration(new ProductConf());
          //Conf des table d'heritage , repartition
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Chemical>().ToTable("Chemical");
            modelBuilder.Entity<Biological>().ToTable("Biological");
            

            //modelBuilder.Entity<Provider>().Property(p => p.UserName).HasMaxLength(20).IsRequired().HasDefaultValue("UserName");
            //modelBuilder.Entity<Provider>().HasKey(p => p.Id);
            //modelBuilder.Entity<Provider>().Ignore(p => p.ConfirmPassword);
            


        }   

    }
}
