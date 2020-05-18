using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface IVegetation
    abstract class Vegetation:ingredientDecorator
    {
        //string Vegetation { get; }
        //int Price { get; }

        // testing
        public abstract string VegetationClass();
        public abstract int Price();
        // end testing
    }
}
