using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal abstract class ElectronicDevice
    {
        private string brand;
        private double price;


        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }


        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public abstract void ShowInfo();
    }
}
