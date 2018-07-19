using Launch;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Hamburger hamburger =
                new HamburgerBuilder()
                    .Meat(Meat.Chicken)
                    .Bread(Bread.Wholewheat)
                    .Toasted(false)
                    .AddCondiment(Condiments.BBQ)
                    .AddCondiment(Condiments.Ketchap)
                    .Build();
            
            LaunchOrder.OrderHamburger(hamburger);

        }
    }
}