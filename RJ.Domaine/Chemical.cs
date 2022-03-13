using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Domaine
{
   public  class Chemical:Product
    {
        
        public string LabName { get; set; }
        public Adresse Adresse { get; set; }

        public override void GetMyType()
        {
            Console.WriteLine("I'am a chemical");
        }
    }
}
 