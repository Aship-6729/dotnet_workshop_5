using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Vehicle
    {
        private string brand;
        private string speed;


        public string GetBrand()
        {
            return this.brand;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetSpeed()
        {
            return this.speed;
        }

        public void SetSpeed(string speed)
        {
            this.speed = speed;
        }

        public void Start()
        {
            Console.WriteLine($"The {GetBrand()} vehicle is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"The vehicle {GetBrand()} is stopping.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {this.brand}, Speed: {this.speed}");
        }

    }

}
