using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Descrpt = "The Exquisite black coffee, Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
