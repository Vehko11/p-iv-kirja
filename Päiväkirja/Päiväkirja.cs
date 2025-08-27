using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int count = 0;
        while (count < 1)
        {
            Console.WriteLine("valitse alta:");

            Console.WriteLine("1: uusi");

            Console.WriteLine("2: muokkaa");

            Console.WriteLine("3: lue");
            
            Console.WriteLine("0: sulje");

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
                Console.WriteLine("Any: Poistu");
                string poistu = Console.ReadLine();
            }
            //Uuden päivän luonti

            else if (valinta == vastaus2a)
            {
                Console.WriteLine("test2 = " + valinta);
                Console.WriteLine("Any: Poistu");
                string poistu = Console.ReadLine();
            }
            //Vanhan päivän muokkaus

            else if (valinta == vastaus3a)
            {
                Console.WriteLine("test3 = " + valinta);
                Console.WriteLine("Any: Poistu");
                string poistu = Console.ReadLine();
            }
            //Vanhan päivän lukeminen
            
            else if (valinta == "0")
            {
                count = count + 1;
            }
        }

    }
}
