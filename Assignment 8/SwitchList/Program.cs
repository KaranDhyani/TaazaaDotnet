using System;
using ListInterface.Model;
using ListInterface.Mylist;

namespace ListInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.EmpID = 600;
            obj.EmpName = "Karan";
            MyClass obj1 = new MyClass();
            obj1.EmpID = 100;
            obj1.EmpName = "Rahul";
            MyClass obj2 = new MyClass();
            obj2.EmpID = 900;
            obj2.EmpName = "Mohit";
            

            Employee employee = new Employee();
            Starting:
            int x;
            Console.WriteLine("What operation you want to choose : ");
            x = Convert.ToInt32(Console.ReadLine());
            switch(x)
            {
                case 1 : employee.addEmp(obj);
                         employee.addEmp(obj1);
                         employee.addEmp(obj2);
                         break;
                case 2 : employee.dispEmp(obj1);
                         break;
                case 3 : var temp = employee.EmpSearch(obj2.EmpID);
                         Console.WriteLine(temp.EmpID+" "+temp.EmpName);
                         break;
                default : Console.WriteLine("No such operation.");
                         break;
            }
            Console.WriteLine("Press 1 to start again : ");
            int temp2 = Convert.ToInt32(Console.ReadLine());
            if(temp2 == 1)
            {
                goto Starting;
            }




        }
    }
}
