using System;

namespace Det_hemliga_talet__del_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // En kod som slumpar fram ett tal mellan ett och hundra som sedan skrivs ut
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 101);

            // Skriver ut talet till användaren
            Console.WriteLine(slump_tal);
        }
    }
}
