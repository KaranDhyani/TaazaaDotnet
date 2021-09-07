using System;

namespace ActDel
{
    class Program
    {
        delegate void DelName(int x);

        static void Square(int i)
        {
            Console.WriteLine(i*i);
        }

        static void Main(string[] args)
        {           
            DelName DelObject = Square;
            DelObject(10);
        }
    }
}
