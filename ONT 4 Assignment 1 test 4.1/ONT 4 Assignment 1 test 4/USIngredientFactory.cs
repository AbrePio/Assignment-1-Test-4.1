using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
     class USIngredientFactory : IngredientFactory
    {
        public override Beans GetBeans()
        {
            return new BlackBeans();
        }

        public override Cheese GetCheese()
        {
            return new PepperJackCheese();
        }

        public override Chili GetChili()
        {
            return new HabaneroChilies();
        }

        public override CreamCheese GetCreamCheese()
        {
            return new ChunkyCreamCheese();
        }

        public override Guacomole GetGuacomole()
        {
            return new Guacamole();
        }

        public override Meat GetMeat()
        {
            return new Beef();
        }

        public override Poultry GetPoultry()
        {
            return new Turkey();
        }

        public override Rice GetRice()
        {
            return new BasmatiRice();
        }

        public override Tomato GetTomato()
        {
            return new Salsa();
        }

        public override Vegetation GetVegetation()
        {
            return new Chickpeas();
        }
    }
}
