using System;
using System.Collections.Generic;
using AdvGenerics.Models;
using AdvGenerics.TrainingList;

namespace AdvGenerics
{
    class Program
    {
        static void Main()
        {
           TaazaaTrainingList Object = new TaazaaTrainingList();
           List<Details> Object2 = Object.TrainingList();
           var temp = Object2.Count;
           for(int i=0; i<temp; i++)
           {
               Console.WriteLine(Object2[i].PhoneNumber+" "+Object2[i].Email);
           }
        }
    }
}
