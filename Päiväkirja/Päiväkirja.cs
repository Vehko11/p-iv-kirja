using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int count = 0;
        int nimiLaskin = 0;
        string vastaus1a = "1";
        string vastaus2a = "2";
        string vastaus3a = "3";
        while (count < 1)
        {
            Console.WriteLine("valitse alta:");

            Console.WriteLine("1: uusi");

            Console.WriteLine("2: muokkaa");

            Console.WriteLine("3: lue");

            Console.WriteLine("0: sulje");

            string valinta = Console.ReadLine();

            if (valinta == vastaus1a)
            {
                Console.WriteLine("Anna teksti, jonka haluat tallentaa:");
                string ydin = Console.ReadLine();
                nimiLaskin = nimiLaskin + 1;
                Console.WriteLine("Day: " + nimiLaskin);
                string day = "Day: " + nimiLaskin;

                string createText = day + Environment.NewLine + ydin; //
                string filePath = @"C:\Users\Arttu V\source\repos\Päiväkirja\Days\" + nimiLaskin + ".txt";
                File.WriteAllText(filePath, createText);

                Console.WriteLine($"Teksti on tallennettu tiedostoon: {filePath}");
                Console.WriteLine("Any: Poistu");
                string poistu = Console.ReadLine();
            }
            //Uuden päivän luonti

            else if (valinta == vastaus2a)
            {
                Console.WriteLine("Haluatko muokata vai poistaa?");
                Console.WriteLine("1: Muokkaa");
                Console.WriteLine("2: Poista");

                string valinta2 = Console.ReadLine();

                if (valinta2 == "1")
                {
                    Console.WriteLine("Päivän numero");
                    string tiedostonNumero = Console.ReadLine();
                    string filePath = @"C:\Users\Arttu V\source\repos\Päiväkirja\Days\" + tiedostonNumero + ".txt";

                    if (File.Exists(filePath))
                    {
                        Console.WriteLine("Anna teksti, jonka haluat tallentaa:");
                        string uusiSisalto = Console.ReadLine();
                        File.WriteAllText(filePath, uusiSisalto);
                        Console.WriteLine($"Teksti päivitetty");
                    }
                    else
                    {
                        Console.WriteLine("Tiedostoa ei löytynyt.");
                    }
                }
                // Muokkaus

                else if (valinta2 == "2")
                {
                    Console.WriteLine("Anna poistettavan tiedoston numero:");
                    string tiedostonNumero = Console.ReadLine();
                    string filePath = @"C:\Users\Arttu V\source\repos\Päiväkirja\Days\" + tiedostonNumero + ".txt";

                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        Console.WriteLine($"Tiedosto '{filePath}' on poistettu.");
                    }
                    else
                    {
                        Console.WriteLine("Tiedostoa ei löytynyt. Poistoa ei suoritettu.");
                    }
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta.");
                }

                Console.WriteLine("\nPaina mitä tahansa näppäintä jatkaaksesi...");
                Console.ReadKey();
            }
            // Poisto
            //Vanhan päivän muokkaus

            else if (valinta == vastaus3a)
            {
                Console.WriteLine("Päivän numero");
                string tiedostonNumero = Console.ReadLine();
                string filePath = @"C:\Users\Arttu V\source\repos\Päiväkirja\Days\" + tiedostonNumero + ".txt";

                if (File.Exists(filePath))
                {
                    string readText = File.ReadAllText(filePath);
                    Console.WriteLine(readText);
                }
                else
                {
                    Console.WriteLine("Ei kelpaa");
                }

                Console.WriteLine("\nAny: Poistu");
                Console.ReadKey();
            }
            //Vanhan päivän lukeminen

            else if (valinta == "0")
            {
                count = count + 1;
            }
            //While loopin rikkoja
        }

    }
}
