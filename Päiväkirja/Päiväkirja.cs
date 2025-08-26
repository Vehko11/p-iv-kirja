using System;

namespace Numbers
{
  class Program
  {
        static void Main(string[] args)
        {
            Console.WriteLine("valitse alta:");

            Console.WriteLine("1: uusi");
            
            Console.WriteLine("2: muokkaa");

            Console.WriteLine("3: lue");
            
            string valinta = Console.ReadLine();
            
            string vastaus1a = "1";
            string vastaus2a = "2";
            string vastaus3a = "3";
            string vastaus1b = "uusi";
            string vastaus2b = "muokkaa";
            string vastaus3b = "lue";
            int nimiLaskin = 1;
            
            if (valinta == vastaus1a)
            {
                Console.WriteLine("test1 = " + valinta);
                string ydin = Console.ReadLine();
                Console.WriteLine("Day: " + nimiLaskin);
                Console.WriteLine(ydin);
            }
            else if (valinta == vastaus1b)
            {
                Console.WriteLine("test1 = " + valinta);
                string ydin = Console.ReadLine();
                Console.WriteLine("Day: " + nimiLaskin);
                Console.WriteLine(ydin);
            }
            //Uuden päivän luonti
            
            else if (valinta == vastaus2a)
            {
                Console.WriteLine("test2 = " + valinta);
            }
            else if (valinta == vastaus2b)
            {
                Console.WriteLine("test2 = " + valinta);
            }
            //Vanhan päivän muokkaus
            
            else if (valinta == vastaus3a)
            {
                Console.WriteLine("test3 = " + valinta);
            }
            else if (valinta == vastaus3b)
            {
                Console.WriteLine("test3 = " + valinta);
            }
            //Vanhan päivän lukeminen
        }
  }
}
