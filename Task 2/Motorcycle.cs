using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Motorcycle : Vehicle
    {
        private string handle = "one handle";


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Handle: {this.handle}");

        }
    }
}
