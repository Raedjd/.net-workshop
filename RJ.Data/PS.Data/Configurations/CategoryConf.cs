using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class CategoryConf : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("MyCategories");
            builder.HasKey(cat => cat.CategoryId);
            builder.Property(cat => cat.Name).HasMaxLength(50).IsRequired();

        }
    }
}
