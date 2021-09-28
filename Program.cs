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

            // Ber användaren om input som sedan sparas i en variabel
            Console.WriteLine("Skriv in ett tal");
            int tal = int.Parse(Console.ReadLine());

            // Tre if-satser med olika villkor
            if (tal > slump_tal)
            {
                Console.WriteLine("Du gissade för högt!");
            }
            else if (tal < slump_tal)
            {
                Console.WriteLine("Du gissade för lågt!");
            }
            else
            {
                Console.WriteLine("Grattis du gissade rätt!");
            }

        }
    }
}


