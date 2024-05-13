using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Oppgaver
    {
        public void Run()
        {
            GetDay();
        }

        // Oppgave 1
        // Ha en variabel med datatypen int og gi den en value med et tall mellom 1 og 7. 
        // Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print ut dagen med Console.WriteLine();
        // Eksempel: 1 er mandag, 2 er tirsdag, osv. 

        // Oppgave 2 
        // Ta utgangspunkt fra oppgave 1, men istedenfor å bruke en int med en fastsatt value,
        // bruker du Console.ReadLine() for at man kan skrive inn et tall i konsollen. 
        // Hvis man ikke får inn et tall, sakl switch-en kjøre programment på nytt.


        void GetDay()
        {
            Console.WriteLine("Skriv inn ett tall fra 1-7, for å få dagen som tilsvarer");
            //int day = Convert.ToInt32(Console.ReadLine());
            // Hadde casene som int's før, men byttet til string fordi, da kan ikke programmet crashe hvis du ikke putter inn et tall.
            string day = Console.ReadLine();
            switch (day)
            {
                case "1":
                    Console.WriteLine("Mandag");
                    break;
                case "2":
                    Console.WriteLine("Tirsdag");
                    break;
                case "3":
                    Console.WriteLine("Onsdag");
                    break;
                case "4":
                    Console.WriteLine("Torsdag");
                    break;
                case "5":
                    Console.WriteLine("Fredag");
                    break;
                case "6":
                    Console.WriteLine("Lørdag");
                    break;
                case "7":
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Console.WriteLine("rar input retry");
                    GetDay();
                    break;
            }
        }

        void GetDay2()
        {
            Console.WriteLine("Skriv inn ett tall fra 1-7, for å få dagen som tilsvarer");
            //int day = Convert.ToInt32(Console.ReadLine());
            // Hadde casene som int's før, men byttet til string fordi, da kan ikke programmet crashe hvis du ikke putter inn et tall.
            string day = Console.ReadLine();
            string result = day switch
            {
               "1" => "Mandag",
               "2" => "Tirsdag",
               "3" => "Onsdag",
               "4" => "Torsdag",
               "5" => "Fredag",
               "6" => "Lørdag",
               "7" => "Søndag",
               _ => "rar input retry",
            };
            Console.WriteLine(result);
            if(result == "rar input retry")GetDay2();
        }

    }
}
