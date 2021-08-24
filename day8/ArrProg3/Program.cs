using System;
using ArrProg3.Model;

namespace ArrProg3
{
    class Program
    {
        static void Main()
        {
            ArrayFunc arrayFunc = new ArrayFunc();
            Console.WriteLine("Size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            arrayFunc.reverseArray(arr);
        }
    }
}
