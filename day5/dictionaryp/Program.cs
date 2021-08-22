using System;
using System.Collections.Generic;

namespace dictionaryp
{
    class Program
    {
        static void Main()
        {
            Dictionary<string,int> obj= new Dictionary<string,int>();
            obj.Add("Karan",200);
            obj.Add("Rahul",500);
            obj.Add("Mahesh",800);
            obj.Add("Mohit",400);


            foreach(KeyValuePair<string,int> k1 in obj)
            {
                Console.WriteLine(k1.Key+" and "+k1.Value);
            }
        }    
    }
}
