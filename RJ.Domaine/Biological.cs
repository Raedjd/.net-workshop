﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Domaine
{
    public class Biological:Product
    {
        public string Herbs { get; set; }

        public override void GetMyType()
        {
            Console.WriteLine("I'am a biological");
        }
    }
}
 