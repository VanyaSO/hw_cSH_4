namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Kettle kettle = new Kettle("ElectricKettle123", "A sleek electric kettle for your kitchen", 7);
            Microwave microwave = new Microwave("Microwave2000", "A powerful microwave oven with multiple cooking options", 20);
            Car car = new Car("SuperCarX", "A luxurious sports car with high performance", 3.5);
            Steamer steamer = new Steamer("HomeSteamer200", "A versatile steamer for home use", 32);

            // Вызов методов для каждого объекта
            kettle.Show();
            kettle.Desc();
            kettle.Sound();
            Console.WriteLine();
            microwave.Show();
            microwave.Desc();
            microwave.Sound();
            Console.WriteLine();
            car.Show();
            car.Desc();
            car.Sound();
            Console.WriteLine();
            steamer.Show();
            steamer.Desc();
            steamer.Sound();
        }
    }
}