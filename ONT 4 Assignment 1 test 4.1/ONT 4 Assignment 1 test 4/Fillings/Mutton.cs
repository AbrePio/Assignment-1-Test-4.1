﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Mutton:Meat
    {
        //public string Meat { get { return "Mutton"; } }
        //public int Price { get { return 22; } }

        // testing 
        public override string MeatClass()
        {
            return "Mutton";
        }
        public override int Price()
        {
            return 22;
        }
        //
    }
}
