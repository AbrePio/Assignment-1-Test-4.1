using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface IGuacomole
    abstract class Guacomole:ingredientDecorator
    {
        //string Guacomole { get; }
        //int Price { get; }

        // testing
        public abstract string GuacomoleClass();
        public abstract int Price();
        // end testing
    }
}
