using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class VideoForklaring
    {
        public void Run()
        {
            Console.WriteLine("Hva er 2 + 2?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "3": 
                    Console.WriteLine("Feil");
                    break;
                case "4":
                    Console.WriteLine("Riktig!");
                    break;
                default:
                    Run();
                    break;
            }

        }



    }
}
