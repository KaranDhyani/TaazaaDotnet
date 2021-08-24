namespace miscellaneous.IT
{
    public class Taazaa
    {
        double salary;
        readonly int empid;
        static string cafeteria;
        public Taazaa(int eid, double sal)
        {
            salary = sal;
            empid = eid;
        }
        static Taazaa()
        {
            cafeteria = "100 Sqft";
        }
        public int EmployeeID()            //member function
        {
            return empid;
        }
        public static string CoffeeHouse()
        {
            return cafeteria;
        }

        public double EmpSalary()          //member function
        {
            return salary;
        }
    }
}