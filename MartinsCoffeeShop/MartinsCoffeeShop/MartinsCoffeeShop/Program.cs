namespace MartinsCoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BlackCoffee blackCoffee = new BlackCoffee(0, "Mexican Coffe");
            Cortado cortado = new Cortado(2, "Mexican Coffe");
            Latte latte = new Latte(5, "Mexican Coffe");
            List<Coffee> coffeSelection = new List<Coffee>();
            coffeSelection.Add(blackCoffee);
            coffeSelection.Add(cortado);
            coffeSelection.Add(latte);
            
            foreach (Coffee c in coffeSelection)
            {
                Console.WriteLine(c.ToString());
            }

            List<IMilk> milkList = new List<IMilk>()
            {
                new Cortado(4, "Sidamo"),
                new Cortado(5, "Mexican Coffe"),
                new Latte(5, "Sidamo"),

            };
            foreach (IMilk m in milkList)
            {
                Console.WriteLine(m.ToString());
            }

        }
    }
}
