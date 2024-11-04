/* Uppgift 1 using System;

namespace Hi
{
    class Program
   {

      public static void Main(string[] args)
        {
           Random randomerare = new Random();
           int tal = randomerare.Next(0, 50); // Skapar ett slumpmässigt tal mellan 0 och 49
           Console.WriteLine(tal);
        }
    }
}
*/
/*

namespace Hi
{
    class Program
   {

        public static void Main(string[] args)
        {
           Random randomerare = new Random();
           int tal = randomerare.Next(50); // Skapar ett slumpmässigt tal mellan 0 och 49
           Console.WriteLine(tal);
        }
    }
}


*/
/* Uppgift 2 */

/* using System;

class Program
{
  static void Main()
  {
      decimal saldo = 500m;
      bool avsluta = false;

      while (!avsluta)
      {
          Console.WriteLine("Välj ett alternativ:");
          Console.WriteLine("1. Sätt in pengar");
          Console.WriteLine("2. Ta ut pengar");
          Console.WriteLine("3. Visa saldo");
          Console.WriteLine("4. Avsluta");
          string val = Console.ReadLine();

          switch (val)
          {
              case "1":
                  Console.Write("Ange belopp att sätta in: ");
                  decimal insättning = decimal.Parse(Console.ReadLine());
                  saldo += insättning;
                  Console.WriteLine($"Du har satt in {insättning} kr. Nytt saldo: {saldo} kr.");
                  break;
              case "2":
                  Console.Write("Ange belopp att ta ut: ");
                  decimal uttag = decimal.Parse(Console.ReadLine());
                  if (uttag <= saldo)
                  {
                      saldo -= uttag;
                      Console.WriteLine($"Du har tagit ut {uttag} kr. Nytt saldo: {saldo} kr.");
                  }
                  else
                  {
                      Console.WriteLine("Otillräckligt saldo.");
                  }
                  break;
              case "3":
                  Console.WriteLine($"Ditt nuvarande saldo är: {saldo} kr.");
                  break;
              case "4":
                  avsluta = true;
                  Console.WriteLine("Programmet avslutas.");
                  break;
              default:
                  Console.WriteLine("Ogiltigt val, försök igen.");
                  break;
          }
      }
  }
} */
/*Uppgift 3, en liten bugg. Datorn gissar alltid 50 */
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tänk på ett tal mellan 1 och 100, och datorn kommer att försöka gissa det.");
        int min = 1;
        int max = 100;
        bool gissatRätt = false;

        while (!gissatRätt)
        {
            int gissning = (min + max) / 2;
            Console.WriteLine($"Datorn gissar: {gissning}");
            Console.WriteLine("Är det rätt (r), högre (h) eller lägre (l)?");
            string svar = Console.ReadLine();

            switch (svar)
            {
                case "r":
                    Console.WriteLine("Datorn gissade rätt!");
                    gissatRätt = true;
                    break;
                case "h":
                    min = gissning + 1;
                    break;
                case "l":
                    max = gissning - 1;
                    break;
                default:
                    Console.WriteLine("Ogiltigt svar, försök igen.");
                    break;
            }
        }
    }
}*/
/*Uppgift 4*/
/*using System;

class Program
{
    static void Main()
    {
        int aktuelltVärde = 0;
        bool spelare1Tur = true;

        while (aktuelltVärde < 21)
        {
            Console.WriteLine($"Aktuellt värde: {aktuelltVärde}");
            Console.WriteLine(spelare1Tur ? "Spelare 1, välj ett tal (1, 2 eller 3):" : "Spelare 2, välj ett tal (1, 2 eller 3):");
            int val = int.Parse(Console.ReadLine());

            if (val < 1 || val > 3)
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
                continue;
            }

            aktuelltVärde += val;

            if (aktuelltVärde >= 21)
            {
                Console.WriteLine(spelare1Tur ? "Spelare 1 förlorar! Spelare 2 vinner!" : "Spelare 2 förlorar! Spelare 1 vinner!");
                break;
            }

            spelare1Tur = !spelare1Tur;
        }
    }
}*/
/*Uppgift 5*/
/*using System;
using System.Diagnostics;
using System.Threading;

class Reaktionsspel
{
    static void Main()
    {
        Random random = new Random();
        Console.WriteLine("Ok, Get ready...");
        
        // Vänta slumpvis mellan 3 och 10 sekunder
        int väntetid = random.Next(3000, 10000);
        Thread.Sleep(väntetid);
        
        Console.WriteLine("NOW!");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while (!Console.KeyAvailable) { }
        
        stopwatch.Stop();
        var key = Console.ReadKey(true);
        
        if (stopwatch.ElapsedMilliseconds < 10)
        {
            Console.WriteLine("Fusk! Du tryckte för tidigt.");
        }
        else
        {
            Console.WriteLine($"Din reaktionstid: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}*/
/*Uppgift 6*/
/*using System;
using System.Collections.Generic;

class Godisautomat
{
    static void Main()
    {
        // Skapa en dictionary för att lagra godisbitar och deras antal
        Dictionary<int, int> godis = new Dictionary<int, int>
        {
            { 1, 5 }, // 5 godisbitar i lucka 1
            { 2, 3 }, // 3 godisbitar i lucka 2
            { 3, 7 }  // 7 godisbitar i lucka 3
        };

        while (true)
        {
            Console.WriteLine("Välj en lucka (1, 2, 3) för att köpa godis eller skriv 'exit' för att avsluta:");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int lucka) && godis.ContainsKey(lucka))
            {
                if (godis[lucka] > 0)
                {
                    godis[lucka]--;
                    Console.WriteLine($"Du köpte en godisbit från lucka {lucka}. Kvar: {godis[lucka]}");
                }
                else
                {
                    Console.WriteLine($"Godisbitarna i lucka {lucka} är slut.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Försök igen.");
            }
        }
    }
}*/
/*Uppgift 7 
using System.ComponentModel.DataAnnotations.Schema;
*/
/*class Program{
    static void Main(string [] args)
    {
        Dog myDog = new Dog[];
        myDog.name = "Fido";
        myDog.age = 4;
        myDog.race = "Tax";

       Dog yourDOg = new myDog [];
        yourDog.name = "Lassie";
        yourDog.age = 4;

    }
}
*/







