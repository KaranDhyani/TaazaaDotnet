using System;

namespace PredDelegate
{
    class Program
    {
        static bool IsOdd(int a)
        {
            if(a%2!=0)
            {
                return true;
            }
            else
                return false;
        }

        static void Main()
        {
            Predicate<int> predicate = IsOdd;
            Console.WriteLine(predicate(46));
        }
    }
}
