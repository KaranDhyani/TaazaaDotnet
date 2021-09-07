using System;

namespace AbstractClass
{
    abstract class AbstractClassK
    {
        public abstract int number();
    }
    class Program : AbstractClassK
    {
        public override int number()
        {
            return 55;
        }
        void simple()
        {
            Console.WriteLine("Simple function");
        }
        static void Main(string[] args)
        {
            var Obj  = new Program();
            Console.WriteLine(Obj.number());
            Obj.simple();
        }
    }
}
