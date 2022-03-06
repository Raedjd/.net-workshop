using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class ProductConf : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(p => p.Providers).WithMany(p => p.Products).UsingEntity(p => p.ToTable("Providings"));
            builder.HasDiscriminator<int>("type").HasValue<Product>(0).HasValue<Chemical>(1).HasValue<Biological>(2);
            
        }
    }
}
