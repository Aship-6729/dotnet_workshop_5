using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Laptop : ElectronicDevice
    {

        public Laptop(string brand, double price) : base(brand, price)
        {

        }


        public void TurnOnBattery()
        {
           Console.WriteLine("Turning on the Laptop Battery.");
        }

        public override void ShowInfo()
        {
           Console.WriteLine($"Laptop Brand: {GetBrand()}, Price: {GetPrice()}");
        }
    }
}
