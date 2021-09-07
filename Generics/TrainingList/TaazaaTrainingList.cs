using System.Collections.Generic;
using AdvGenerics.Models;
using System;


namespace AdvGenerics.TrainingList
{
    public class TaazaaTrainingList
    {
        public List<Details> TrainingList()
        {
            List<Details> NewList = new List<Details>();
            NewList.Add(
                new Details
                {
                    PhoneNumber = 987987,
                    Email = "Karan@taazaa.com"
                }
            );
            NewList.Add(
                new Details
                {
                    PhoneNumber = 111111,
                    Email = "Rahul@taazaa.com"
                }
            );
            NewList.Add(
                new Details
                {
                    PhoneNumber = 55555,
                    Email = "Gurpreet@taazaa.com"
                }
            );

            return NewList;



        }
    }
}