using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Turkey:Poultry
    {
         //string Poultry { get { return "Turkey"; } }
         //int Price { get { return 15; } }

        // testing
        public override string PoultryClass() 
        { 
            return "Turkey"; 
        }
        public override int Price() 
        {
            return 15; 
        }
        //
    }
}
