using System;
using dal.MyClass;

delegate void DelArea(double d1,double d2); 

namespace dal
{
    class Program
    {
        static void Main()
        {
            //Delegate Method
            DelArea Object = new DelArea(Area.Square);
            Object.Invoke(5,6);
            
            //Anonymous Method
            DelArea Object2 = delegate(double d1,double d2)
            {
                Console.WriteLine(d1*d2);
            };

            //Lamda Function
            DelArea Object3 = (double d1,double d2)=>
            {
                Console.WriteLine(d1*d2);
            };

            Object2(4,5);
            Object3(6,3);
        }
    }
}
