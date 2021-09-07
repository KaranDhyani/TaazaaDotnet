using System;
using System.Collections;

namespace hashtablep
{
    class Program
    {
        static void Main()
        {
            Hashtable karan = new Hashtable();

            karan.Add(100,"Eat");
            karan.Add(200,"Sleep");
            karan.Add(300,"Study");
            karan.Add(400,"Bath");

            Console.WriteLine(karan.ContainsKey(200));
            Console.WriteLine(karan.ContainsKey(500));

            karan.Remove(200);

            Console.WriteLine(karan.ContainsKey(200));

            foreach(DictionaryEntry k1 in karan)
            {
                System.Console.WriteLine("Key is "+ k1.Key + " and value is " + k1.Value);
            }
        }
    }
}
