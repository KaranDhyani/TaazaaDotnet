using System;

namespace switchp
{
    class Program
    {
        static void Main()
        {
            int Eid = 103;
            switch(Eid){
                case 101: 
                Console.WriteLine("Rahul");
                break;
                case 102: 
                Console.WriteLine("Sachin");
                break;
                case 103: 
                Console.WriteLine("Karan");
                break;
                case 104: 
                Console.WriteLine("Sukdev");
                break;
                case 105: 
                Console.WriteLine("Gurpreet");
                break;
                default: 
                Console.WriteLine("No Employee Found!");
                break;

            }
        }
    }
}
