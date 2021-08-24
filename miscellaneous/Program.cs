using System;
using miscellaneous.IT;

namespace miscellaneous
{
    class Program
    {
        static void Main()
        {
            Taazaa Karan = new Taazaa(101,10000);
            Taazaa Sachin = new Taazaa(102,20000);

            var Holder = Karan.EmpSalary();
            Console.WriteLine(Holder);
            
            var Holder2 = Sachin.EmpSalary();
            Console.WriteLine(Holder2);

            var Holder3 = Taazaa.CoffeeHouse();
            Console.WriteLine(Holder3);

            Console.WriteLine(Taazaa.CoffeeHouse());



        }
    }
}
