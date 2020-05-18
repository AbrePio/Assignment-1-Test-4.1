using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Relish:Tomato
    {
        //public string Tomato { get { return "Relish"; } }
        //public int Price { get { return 5; } }

        // testing 
        public override string TomatoClass()
        {
            return "Relish";
        }
        public override int Price()
        {
            return 5;
        }
        //
    }
}
