using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_3
{
    public class fulltime_employee: employee
    {
        public fulltime_employee(int Id,string Name,int Age,decimal Salary):base (Id,Name,Age)
        {
            salary = Salary;


        }
        public decimal salary { get; set; }

        public new void getemployeetype()
        {
            Console.WriteLine("I am fulltime Employee");
        }

        public override void getemployeedata()
        {
            Console.WriteLine($"fulltime Employee : id = {id} , name ={name} , age = {age} , salary ={salary}");
        }
    }
}
