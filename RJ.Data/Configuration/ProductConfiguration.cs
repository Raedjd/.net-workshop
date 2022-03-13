using RJ.Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Data.Configuration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Product");
           // HasRequired(prod => prod.categoryRef).WithMany(cat => cat.products).HasForeignKey(prod => prod.categoryRef);

           /* HasMany(prod => prod.providers).WithMany(prod => prod.products).Map(m => { m.MapLeftKey("Providers");
                m.MapRightKey("Products");
                m.ToTable("ProdProv");
            }); */
        }
    }
}
