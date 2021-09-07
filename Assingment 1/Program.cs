using System;

using mlab;   //using is a keyword to include namepace(mlab is a namespace).

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {  
            
           calculas obj =  new calculas();
           string temp = obj.limits(); 
            Console.WriteLine(temp);        
        }

    }
}
