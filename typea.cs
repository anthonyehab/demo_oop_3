using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_3
{
    internal class typea
    {
        public int A { get; set; }  
        public typea(int a)
        {
            this.A = a;
        }

        public virtual void myfun01()
        {
            Console.WriteLine("i am base parent");
        
        }
        public virtual void myfun02()
        {
            Console.WriteLine($"typeA:  A ={A}");
        }




    }
}
