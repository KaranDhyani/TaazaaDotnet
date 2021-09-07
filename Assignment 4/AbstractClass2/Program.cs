//I have created AbstractClassK2 inside AbstractClass2.AClass namespace.
//AbstractClassK2 has 2 abstract function(necessay to implement) and one normal function
//Program class is inheriting from AbstractClassK2 and implementing those 2 functions

using System;
using AbstractClass2.AClass;

namespace AbstractClass2
{
    class Program : AbstractClassK2
    {
        public override int luckynumber()
        {
            return 55;
        }
        public override string luckyword()
        {
            return "Karan";
        }

        static void Main(string[] args)
        {
            var Obj = new Program();
            Console.WriteLine(Obj.luckynumber());
            Console.WriteLine(Obj.luckyword());
            Obj.regularfunc();
        }
    }
}
