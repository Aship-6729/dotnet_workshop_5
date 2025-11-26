using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Car : Vehicle
    {
        private string doors = "four doors";
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doors: {this.doors}");
        }
    }
}
