using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //
            //{

            Console.WriteLine("valitse alta:");

            Console.WriteLine("1: uusi");

            Console.WriteLine("2: muokkaa");

            Console.WriteLine("3: lue");

            string valinta = Console.ReadLine();

            string vastaus1a = "1";
            string vastaus2a = "2";
            string vastaus3a = "3";
            int nimiLaskin = 1;


            if (valinta == vastaus1a)
            {
                Console.WriteLine("test1 = " + valinta);
                string ydin = Console.ReadLine();
                Console.WriteLine("Day: " + nimiLaskin);
                Console.WriteLine(ydin);
                string odotus = Console.ReadLine();
            }
            //Uuden päivän luonti

            else if (valinta == vastaus2a)
            {
                Console.WriteLine("test2 = " + valinta);
            }
            //Vanhan päivän muokkaus

            else if (valinta == vastaus3a)
            {
                Console.WriteLine("test3 = " + valinta);
            }
            //Vanhan päivän lukeminen
        }
    }
}
