using RJ.Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Data.Configuration
{
   public  class AddresseConfiguration : EntityTypeConfiguration<Adresse>
    {
        public AddresseConfiguration()
        {
            Property(a => a.StreetAddress).IsOptional().IsRequired().HasMaxLength(20).HasColumnName("street");
        }
    }
}
