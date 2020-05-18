using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface ITomato
    abstract class Tomato:ingredientDecorator
    {
        //string Tomato { get; }
        //int Price { get; }

        // testing
        public abstract string TomatoClass();
        public abstract int Price();
        // end testing
    }
}
