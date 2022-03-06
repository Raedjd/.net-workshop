using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class ProviderConf : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.ToTable("Fournisseur");
            builder.Property(p => p.UserName).HasColumnName("Name").HasMaxLength(20).IsRequired().HasDefaultValue("UserName");
            builder.HasKey(p => p.Id);
            builder.Ignore(p => p.ConfirmPassword);

        }
    }
}
