using System;

namespace ArrProg3.Model
{
    public class ArrayFunc
    {
        public void reverseArray(int[] arr)
        {    
            int n = arr.Length;
            int[] arr2 = new int[n];
            for(int i=0;i<n;i++)
            {
                arr2[i] = arr[n-i-1];
            }
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}