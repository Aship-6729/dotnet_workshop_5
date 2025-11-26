using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Teacher
    {

        private string name;


        public string GetName()
        {
            return name;
        }


        public void SetName(string name)
        {
            this.name = name;
        }


        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        public void SalaryInfo()
        {
            Console.WriteLine("Teacher's salary is $5000 per month");
        }




    }
}
