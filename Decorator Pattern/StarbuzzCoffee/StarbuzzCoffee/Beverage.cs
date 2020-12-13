using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee
{
    public abstract class Beverage
    {
        protected String Descrpt = "Generic Beverage";
        public virtual String getDescription() //Set to virtual so that it can be overriden
        {
            return Descrpt;
        }
        public abstract Double cost();
    }
}
