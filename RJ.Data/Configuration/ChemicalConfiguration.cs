using RJ.Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Data.Configuration
{
    public class ChemicalConfiguration:EntityTypeConfiguration<Chemical>
    { 
        public ChemicalConfiguration()
        {
           ToTable("Chemical");
        }
    }
}
