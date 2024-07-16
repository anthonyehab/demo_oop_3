using System.Security.Cryptography.X509Certificates;

namespace demo_oop_3
{
    internal class program
    {
        #region over loading

            public static int sum(int x, int y)
        { 
        return x + y;   
        
        }

        public static int sum(int x, int y,int z)
        {
            return x + y +z;

        }
        public static double sum(double x, double y)
        {
            return x + y ;

        }
        public static double sum(int x, double y)
        {
            return x + y;

        }
        public static double sum(double x, int y)
        {
            return x + y;

        }

        #endregion
        public static void processemployee(fulltime_employee employee)
        {
            if(employee is not null)
            {
                employee.getemployeetype();
                employee.getemployeedata();

            }

        }
        static void main(string[] args)
        {

            #region polymarphism [over loading]

            //int result = sum(1, 2);
            //Console.WriteLine(result);


            //result = sum(1, 2,3);
            //Console.WriteLine(result);

            //double result02 = sum(1.2, 2.3);
            //Console.WriteLine(result02);
            #endregion
            #region polymarphism [over riding]
            ////supported with class only
            //typea typea = new typea(1);
            //typea.A = 10;
            //typea.myfun01();
            //typea.myfun02();


            //typeb typeb = new typeb(1,2);

            //typeb.A = 10;
            //typeb.B = 20;
            //typeb.myfun01();
            //typeb.myfun02();


            #endregion
            #region binding
            typea refbase;
            refbase = new typeb(1, 2);

            refbase.A = 10;
            refbase.myfun01();
            refbase.myfun02();
            #endregion
            #region not binding
            //typeb childref = (typeb)new typea(1);


            //typea typea = new typea(1);
            //typeb typeb = (typeb)typea;



            //Console.WriteLine(typeb.A);
            //Console.WriteLine(typeb.B);


            //typea typea = new typeb(1, 2);
            //typeb typeb = (typeb)typea;

            //Console.WriteLine(typeb.A);
            //Console.WriteLine(typeb.B);

            //object o = 2;
            //int x = (int)o;
            #endregion
            #region ex
            //fulltime_employee fulltime_Employee = new fulltime_employee(10, "tony", 20, 150000);
            //processemployee(fulltime_Employee);

            //parttime_employee parttime_Employee = new parttime_employee();


            #endregion
        }



    }

}