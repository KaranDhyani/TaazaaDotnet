using System;
using System.Collections.Generic;
using System.Linq;
using LinqQuery.Models;

namespace LinqQuery
{
    class Program
    {
        static void Main()
        {
            List<Player> list = new List<Player>();
            {
                new Player()
                {
                    ID = 100,
                    Name = "Karan",
                    age = 21
                };
                new Player()
                {
                    ID = 103,
                    Name = "Aman",
                    age = 22
                };
                new Player()
                {
                    ID = 111,
                    Name = "Rohit",
                    age = 25
                };

            };

            var number = from s in list
                         where s.age>21 && s.age<23
                         select s;
        
            foreach(var str in number)
            {
                Console.WriteLine(str.Name);
            }

        }
    }
}
