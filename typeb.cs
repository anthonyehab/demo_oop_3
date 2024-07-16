using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_3
{
    internal class typeb : typea
    {
        public int B { get; set; }

        public typeb(int a, int b):base(a)
        {
            B = b;
        
        }
        public new void myfun01()
        {
            Console.WriteLine("i am derived [child]");

        }
        
      
        public override void myfun02()
        {
            Console.WriteLine($"typeB:  A =  {A} ,B=  {B}");
        }
    }
}
