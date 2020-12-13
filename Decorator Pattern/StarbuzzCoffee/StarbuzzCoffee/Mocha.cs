using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        Double costToMake = 0.20;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return costToMake + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + " ,Mocha";
        }
    }
}
