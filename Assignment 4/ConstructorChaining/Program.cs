//Constructor chaining program

using System;

namespace ConstructorChaining
{
    class Program
    {
        Program()
        {
            Console.WriteLine("I am default constructor");
        }
        Program(int a) : this()
        {
            Console.WriteLine("I am parameterised constructor with value " + a);
        }
        public static void Main()
        {
            var obj = new Program(12);
        }
    }
}
