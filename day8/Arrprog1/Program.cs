using System;

namespace Arrprog1
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
