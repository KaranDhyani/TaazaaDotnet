//enumeration program.

using System;

namespace Enumk
{
    class Program
    {
        public enum StudentRollNumber {Karan=55, Rahul, Aakash, Prateek}
        public static void Main()
        {
            Console.WriteLine(StudentRollNumber.Rahul);
            Console.WriteLine((int)StudentRollNumber.Aakash);
        }
    }
}
