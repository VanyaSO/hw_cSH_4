namespace hw_cSH_4
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Money money = new Money( 32.33, "USD");
                Product broad = new Product("Broad", 20.40, "UAH");
                Console.WriteLine(money);
                Console.WriteLine();
                
                Console.WriteLine(broad);
                
                broad.ReducePrice(1.22);
                Console.WriteLine(broad);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

