using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class ElectronicsStore
    {
        private List <ElectronicDevice> electronicStore = new List<ElectronicDevice> ();


        public void AddDevice(ElectronicDevice device) 
        {
            electronicStore.Add (device);
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            electronicStore.Remove (device);
        }


        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("..... IIC Electronic Devices Store.....");
            foreach (var device in electronicStore)
            {

                if(device is Laptop laptop) // downcasting 
                {
                    laptop.ShowInfo();
                    laptop.TurnOnBattery();
                }
                else if(device is SmartPhone smartphone) // downcasting
                {
                    smartphone.ShowInfo();
                    smartphone.EnableCamera();
                }
            }
        }
    }
}
