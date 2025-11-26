namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Bike bike = new Bike();
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();

            Car car = new Car();
            car.Display();
            car.StartEngine();
            car.StopEngine();

        }
    }
}
