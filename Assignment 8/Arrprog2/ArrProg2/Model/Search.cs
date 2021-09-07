using System;
namespace ArrProg2.Model
{
    public class Search
    {
        public void searchelement(int[] arr, int s)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==s)
                {
                    Console.WriteLine("Element found at : "+(i+1)+" position");
                    break;
                }
            }
        }
    }
}