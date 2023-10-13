class Worspace
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Pizza: ");
            string pizzaName = Console.ReadLine();
            Pizza pizza = new Pizza(pizzaName);

            Console.Write("Dough: ");
            string[] input = Console.ReadLine().Split(' ');
            flourType flour = (flourType)Enum.Parse(typeof(flourType), input[0].ToLower());
            backingTechnique backing = (backingTechnique)Enum.Parse(typeof(backingTechnique), input[1].ToLower());
            int doughWeight = int.Parse(input[2]);
            pizza.setDought(new Dough(flour, backing, doughWeight));
                

            while (true)
            {
                Console.Write("Topping: ");
                input = Console.ReadLine().Split(' ');
                if (input[0].ToUpper()== "END") { break; } 
                else {
                    toppingType toppingType = (toppingType)Enum.Parse(typeof(toppingType), input[0].ToLower());
                    int toppingWeight = int.Parse(input[1]);

                    Topping topping = new Topping(toppingType, toppingWeight);
                    pizza.addTopping(topping);
                }
            }
            Console.WriteLine(pizza);
        } catch (ArgumentException e) {
            Console.WriteLine(e.Message);
        }
    
    }
}