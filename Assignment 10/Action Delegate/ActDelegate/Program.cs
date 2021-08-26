using System;

namespace ActDelegate
{
    class Program
    {
        delegate void DelName(int a);

        static void iseven(int i)
        {
            if(i%2==0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }

        static void Main(string[] args)
        {           
            DelName delName = iseven;
            delName(10);
        }
    }
}
