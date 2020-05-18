using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface ICreamCheese
    abstract class CreamCheese:ingredientDecorator
    {
        //string CreamCheese { get; }
        //int Price { get; }

        // testing
        public abstract string CreamCheeseClass();
        public abstract int Price();
        // end testing
    }
}
