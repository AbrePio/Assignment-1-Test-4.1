using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface IChili
    abstract class Chili:ingredientDecorator
    {
        //string Chili { get; }
        //int Price { get; }

        // testing
        public abstract string ChiliClass();
        public abstract int Price();
        // end testing
    }
}
