using System;

namespace pconstructorp
{
    class Program
    {
        public static int Eid;
        public int esalary;

        private Program()
        {
            Console.WriteLine("Private Constructor");
        }
        public Program(int id)
        {
            Eid = id;
        }
        static void Main()
        {
            var obj = new Program(10);
            Console.WriteLine("Employee ID = "+Program.Eid);

            
        }
    }
}
