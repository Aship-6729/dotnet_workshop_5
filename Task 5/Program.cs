namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Laptop laptop = new Laptop("Acer-Xiaomi-Dell", 250000);
            SmartPhone smartPhone = new SmartPhone("Redmi-Apple-Samsung", 178000);

            ElectronicsStore store = new ElectronicsStore();
            store.AddDevice(laptop);
            store.AddDevice(smartPhone);    

            store.ShowAllDeviceDetails();
        }
    }
}
