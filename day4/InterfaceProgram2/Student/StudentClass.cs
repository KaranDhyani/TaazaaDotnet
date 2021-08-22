using System;
using InterfaceProgram2.Sport;
using InterfaceProgram2.Subject;

namespace InterfaceProgram2.Student 

{
    public class StudentClass : ISport, ISubject
    {
        public string sport()
        {
            return "I play football";
        }

        public string subject()
        {
            return "I like Maths";
        }

        public void hobbie()
        {
            Console.WriteLine("My hobbie is Painting");
        } 
        
    }
}