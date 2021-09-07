using System;
using  ArrProg2.Model;

namespace ArrProg2
{
    class Program
    {
        static void Main()
        {
            Search search = new Search();
            Console.WriteLine("Size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Element to search : ");
            int s = Convert.ToInt32(Console.ReadLine());
            search.searchelement(arr,s);

        }
    }
}
