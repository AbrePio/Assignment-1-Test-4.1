using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface ICheese
    abstract class Cheese:ingredientDecorator
    {
        //string Cheese { get; }
        //int Price { get; }

        // testing
        public abstract string CheeseClass();
        public abstract int Price();
        // end testing
    }
}
