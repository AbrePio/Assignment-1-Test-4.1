using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
     class SAIngredientFactory : IngredientFactory
    {
        public override Beans GetBeans()
        {
            return new RefriedBeans();
        }

        public override Cheese GetCheese()
        {
            return new CheddarCheese();
        }

        public override Chili GetChili()
        {
            return new JalapenoChilies();
        }

        public override CreamCheese GetCreamCheese()
        {
            return new SmoothCreamCheese();
        }

        public override Guacomole GetGuacomole()
        {
            return new SlicedAvocados();
        }

        public override Meat GetMeat()
        {
            return new Mutton();
        }

        public override Poultry GetPoultry()
        {
            return new Chicken();
        }

        public override Rice GetRice()
        {
            return new JasminRice();
        }

        public override Tomato GetTomato()
        {
            return new Relish();
        }

        public override Vegetation GetVegetation()
        {
            return new Samp();
        }
    }
}
