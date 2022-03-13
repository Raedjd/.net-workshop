using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Domaine
{
    public class Adresse
    {
        public string StreetAddress { get; set; }
        [Required]
        [MinLength(8)]
        public string City { get; set; }
    }
}
