using System;
using DeAnLa.Models;

delegate int DelSquareCube(int a);

namespace DeAnLa
{
    class Program
    {
        static void Main()
        {
            //Delegate Method
            DelSquareCube delSquareCube = new DelSquareCube(MyClass.Square);
            int temp = delSquareCube.Invoke(3);
            Console.WriteLine(temp);
            
            //Anonymous Method
            DelSquareCube delSquareCube1 = delegate(int x)
            {
                return x*x;
            };

            //Lamda Function
            DelSquareCube delSquareCube2 = (int x)=>
            {
                return x*x*x;
            };

            Console.WriteLine(delSquareCube1(6));
            Console.WriteLine(delSquareCube2(4));
        }
    }
}
