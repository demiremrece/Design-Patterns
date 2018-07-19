using System;

namespace Launch
{
    public class LaunchOrder
    {
        public static void OrderHamburger(Hamburger hamburger)
        {
            Console.WriteLine("Bread: "+ hamburger.bread);
            Console.WriteLine("Meat: "+ hamburger.meat);
            Console.WriteLine("isToasted: "+ hamburger.isToasted);

            Console.Write("Condiments: ");
            foreach (var condiment in hamburger.condiments)
            {
                Console.Write(condiment + " ");
            }

        }
    }
}