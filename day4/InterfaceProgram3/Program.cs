using System;
using InterfaceProgram3.Interface1;
using InterfaceProgram3.Interface2;
using InterfaceProgram3.Interface3;
using InterfaceProgram3.Class;

namespace InterfaceProgram3
{
    class Program
    {
        static void Main()
        {
            var obj = new C1();
            obj.func1();
            Console.WriteLine(obj.func2());
            Console.WriteLine(obj.func3());
        }
    }
}
