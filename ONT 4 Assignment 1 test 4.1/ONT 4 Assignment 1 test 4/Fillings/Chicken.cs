using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Chicken:Poultry
    {
        //public string Poultry { get { return "Chicken"; } }
        //public int Price { get { return 15; } }

        // testing 
        public override string PoultryClass()
        {
            return "Chicken";
        }
        public override int Price()
        {
            return 15;
        }
        //
    }
}
