using System;

namespace day3
{
    class boxunbox
    {
        public static void Main()
        {
            int i = 10;
            int x = new int();
            x = i;                                  /*boxing i.e. converting value type into
                                                    reference type*/
            Console.WriteLine(x);
            object z = 30;
            int p = (int)z;                          /*unboxing i.e. converting reference type
                                                      into value type*/        
            Console.WriteLine(p);
        }
    
    }
}
