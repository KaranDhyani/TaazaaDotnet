using InterfaceProgram3.Interface1;
using InterfaceProgram3.Interface2;
using InterfaceProgram3.Interface3;
using System;

namespace InterfaceProgram3.Class
{
    public class C1 : I1, I2, I3
    {
        public void func1()
        {
            Console.WriteLine("First Function");            
        }
        public int func2()
        {
            return 5;
        }
        public string func3()
        {
            return "Hello";
        }
    }
}