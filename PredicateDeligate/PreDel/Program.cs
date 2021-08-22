using System;

namespace PreDel
{
    class Program
    {
        static bool IsEven(int num)
        {
            if(num%2==0)
            {
                return true;
            }
            else
                return false;
        }

        static void Main()
        {
            Predicate<int> DelName = IsEven;
            bool result = DelName(46);
            Console.WriteLine(result);
        }
    }
}
