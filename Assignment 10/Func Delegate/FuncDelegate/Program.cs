using System;

namespace FuncDelegate
{
    class Program
    {
        static int Area(int x,int y)
        {
            return x*y;
        }

        static void Main()
        {
            Func<int,int,int> func = Area;
            Console.WriteLine((10,15));
            
        }
        }
    }
}
