using RJ.Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Data.Configuration
{
    public class CategoryConfiguration: EntityTypeConfiguration<Category>
    { 
        public CategoryConfiguration()
        {
            ToTable("MyCategories");
            HasKey(cat=> cat.CategoryId);
            Property(cat => cat.Name).IsRequired().HasMaxLength(50);
           // HasMany(cat => cat.products).WithOptional(prod => prod.categoryRef).HasForeignKey(prod => prod.categoryRef).WillCascadeOnDelete(false);
        }
    }
}
