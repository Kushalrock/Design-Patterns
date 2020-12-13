using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee
{
    public class MouseBlend : Beverage
    {
        public MouseBlend()
        {
            Descrpt = "MouseBlend";
        }
        public override double cost()
        {
            return .99;
        }
    }
}
