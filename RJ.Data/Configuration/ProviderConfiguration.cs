using RJ.Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Data.Configuration
{
   public  class ProviderConfiguration: EntityTypeConfiguration<Provider>
    { 
        public ProviderConfiguration()
        {
          /*  HasMany(prod => prod.products).WithMany(prov=>prov.providers).Map(m => {
                m.MapLeftKey("ProductsProviders");
                m.MapRightKey("Providers");
                m.ToTable("ProdProv");
            }); */
        }
    }
}
