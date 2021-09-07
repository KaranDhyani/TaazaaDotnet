using System;

namespace structure
{
    class Program
    {
        struct Movie 
        {
            public string title;
            public string actor;
            public string language;
            public int budget;
        };  
        public static void Main(string[] args) 
        {
        Movie Movie1; 
        Movie Movie2; 

        Movie1.title = "Free Guy";
        Movie1.actor = "Ryan Reynolds"; 
        Movie1.language = "English";
        Movie1.budget = 300000000;

        Movie2.title = "3 Idiots";
        Movie2.actor = "Aamir Khan"; 
        Movie2.language = "Hindi";
        Movie2.budget = 50000000;

        Console.WriteLine("Movie 1 title : {0}", Movie1.title);
        Console.WriteLine("Movie 1 actor : {0}", Movie1.actor);
        Console.WriteLine("Movie 1 language : {0}", Movie1.language);
        Console.WriteLine("Movie 1 budget :{0}", Movie1.budget);

      
   
        }
    }
}
