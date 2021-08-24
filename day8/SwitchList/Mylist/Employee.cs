using ListInterface.Model;
using System;
using System.Collections.Generic;

namespace ListInterface.Mylist
{
    public class Employee : MyInterface
    {
        List<MyClass> list = new List<MyClass>();
        public void addEmp(MyClass obj)
        {
            list.Add(obj);
            Console.WriteLine("Added successfully.");
        }

        public void dispEmp(MyClass obj)
        {
            Console.WriteLine(obj.EmpID+" "+obj.EmpName);
        }

        public MyClass EmpSearch(int empid)
        {
            return list.Find(e=>e.EmpID==empid);
        }
        
        

            
        
    }
}