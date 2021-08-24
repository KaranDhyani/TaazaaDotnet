using System;

namespace abstract_class.Abstract
{
    public abstract class HumanBehaviour
    {
        public void Asset()
        {
            Console.WriteLine("Everything");
        }
        public abstract void job();
        

    }
    public class Person : HumanBehaviour
    {
        public override void job()
        {
             Console.WriteLine("Yes! I got a job.");
        }  
        public static void Main()
        {
            var obj = new Person();
            obj.Asset();
            obj.job();
        }
    }
}