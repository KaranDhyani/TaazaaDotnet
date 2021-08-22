using System;

namespace ExcHandling
{
    class Program
    {
        int result;
        public Program()
        {
            result = 0;
        }
        public void division(int num1, int num2) 
        {
            try 
            {
                result = num1 / num2;
            } 
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        static void Main()
        {
            Program d = new Program();
            d.division(12, 0);

        }
    }    
}
