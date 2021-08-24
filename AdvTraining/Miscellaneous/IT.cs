using System;

namespace AdvTraining.Miscellaneous
{
    public class IT
    {
        static IT()          //Static Constructor
        {
            Console.WriteLine("This is a static constructor");
        }

        public static string companyAddress()
        {
            return "Taazaa Noida";
        }
    }
}