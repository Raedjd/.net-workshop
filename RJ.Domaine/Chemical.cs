﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Domaine
{
   public  class Chemical:Product
    {
        public string City { get; set; }
        public string LabName { get; set; }
        public string StreetAddress { get; set; }

        public override void GetMyType()
        {
            Console.WriteLine("I'am a chemical");
        }
    }
}
 