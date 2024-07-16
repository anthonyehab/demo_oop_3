using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_3
{
    public class employee
    {
        public employee(int Id, string Name, int Age)
        {


        }
        public int id { get; set; }
        public string name { get; set; }    
        public int age { get; set; }
        public void getemployeetype()
        {
            Console.WriteLine("I am Employee");
        }

        public virtual void getemployeedata()
        {
            Console.WriteLine($"Employee : id = {id} , name ={name} , age = {age}");
        }
    }
}
