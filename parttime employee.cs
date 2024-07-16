using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_3
{
    internal class parttime_employee : employee
    {
        public int countofhours { get; set; }   
        public decimal hourrate { get; set; }

        public new void getemployeetype()
        {
            Console.WriteLine("I am parttime Employee");
        }

        public override void getemployeedata()
        {
            Console.WriteLine($"parttime Employee : id = {id} , name ={name} , age = {age} , countof hours ={countofhours},hour rate = {hourrate}");
        }
    }
}
}
