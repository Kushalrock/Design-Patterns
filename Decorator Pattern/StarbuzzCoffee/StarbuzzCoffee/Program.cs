using System;

namespace StarbuzzCoffee
{
    class StarbuzzOrder
    {
        static void Main(string[] args)
        {
            //Refer Coffee Shop class diagram

            #region Somedescription
            Console.WriteLine("Welcome to Starbuzz Coffee");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("We usually do care about customers,");
            Console.WriteLine("But profit is more important to us.");
            Console.WriteLine("So today due to excessive amount of orders,");
            Console.WriteLine("We would not cater to your needs and show you what programmer decides");
            Console.WriteLine("Yes you read it right the programmer not the barista");
            Console.WriteLine("");
            #endregion

            #region PatternImplementation
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " "
                + beverage.cost() + "$");

            /*In the code example below and above we have used Liskov Substitution principle just a fancy name
             for saying the thing that inherited class can be substituted for the parent class like we use
            Beverage but create espresso object*/


            Beverage beverage2 = new Espresso(); 
            beverage2 = new Mocha(beverage2); 
            beverage2 = new Mocha(beverage2); 

            // The above order translates to one espresso with two shots of mocha. Silly order :)


            Console.WriteLine(beverage2.getDescription() + " "
               + beverage2.cost() + "$");
            #endregion

            #region EndDescription
            Console.WriteLine("");
            Console.WriteLine("Thank you for your time at StarBuzz");
            Console.WriteLine("We added above both orders even if you don't wanna drink");
            Console.WriteLine("Warning: It's not free either");
            Console.WriteLine("Our Programmer is our Barista");
            #endregion

            Console.ReadLine();
        }
    }
}
