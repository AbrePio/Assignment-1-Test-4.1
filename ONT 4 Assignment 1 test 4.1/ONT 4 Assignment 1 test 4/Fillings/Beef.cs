using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Beef:Meat
    {
        //public string Meat { get { return "Beef"; } }
        //public int Price { get { return 20; } }

        // testing 
        public override string MeatClass()
        {
            return "Beef";
        }
        public override int Price()
        {
            return 20;
        }
        //
    }
}
