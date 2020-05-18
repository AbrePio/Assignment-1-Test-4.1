using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface IBeans
    abstract class Beans:ingredientDecorator
    {
        //string Beans { get; }
        //int Price { get; }

        // testing
        public abstract string BeansClass();
        public abstract int Price();
        // end testing
    }
}
