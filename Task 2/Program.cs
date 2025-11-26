namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            Motorcycle motorcycle = new Motorcycle();
            
            motorcycle.SetBrand("BMW");
            motorcycle.SetSpeed("168");

            motorcycle.DisplayInfo();
            motorcycle.Start();
            motorcycle.Stop();

            Car car = new Car();
            car.SetBrand("Audi");
            car.SetSpeed("240");
            car.DisplayInfo();
            car.Start();
            car.Stop();

        }
    }
}
