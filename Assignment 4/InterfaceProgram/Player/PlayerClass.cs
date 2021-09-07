using System;
using InterfaceProgram.Sport;

namespace InterfaceProgram.Player
{
    public class PlayerClass : ISport
    {
        public void sport()
        {
            Console.WriteLine("Football");
        }

    }
}