using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee
{
    public abstract class CondimentDecorator:Beverage
    {
        public override abstract String getDescription(); //Special class for condiments
    }
}
