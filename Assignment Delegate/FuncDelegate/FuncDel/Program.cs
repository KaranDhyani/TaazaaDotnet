using System;

namespace FuncDel
{
    class Program
    {
        static int Square(int x)
        {
            return x*x;
        }

        static void Main()
        {
            Func<int,int> Delname = Square;
            int temp = Delname(10);
            Console.WriteLine(temp); 
        }
    }
}
    
