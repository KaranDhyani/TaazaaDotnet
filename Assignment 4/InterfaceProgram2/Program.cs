//I have created 2 interfaces namely Sport and Subject each of them having one member fuction(abstract by default)
//I have also created a class StudentClass which has implemented both of the necessary functions of interfaces
//It also has another function named hobbie which is optional 
//In this file I have made an object of StudentClass and called both functions(of both interfaces) with the class object  


using System;
using InterfaceProgram2.Sport;
using InterfaceProgram2.Subject;
using InterfaceProgram2.Student;

namespace InterfaceProgram2
{
    class Program
    {
        static void Main()
        {
            var obj = new StudentClass();
            string temp1 = obj.subject();
            Console.WriteLine(temp1);
            string temp2 = obj.sport();
            Console.WriteLine(temp2);
            obj.hobbie();                            

        }
    }
}
