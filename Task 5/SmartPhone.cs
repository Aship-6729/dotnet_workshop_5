using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class SmartPhone : ElectronicDevice
    {

        public SmartPhone(string brand, double price ) : base(brand, price) 
        {

        }

        public void EnableCamera()
        {
            Console.WriteLine("Enabling the smartphone camera.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Brand : {GetBrand()} and Price : {GetPrice()}");
        }

    }
}
