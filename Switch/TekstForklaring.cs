using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class TekstForklaring
    {
        // Dersom man har flere enn to betingelser kan man også bruke else if ELLER switch - statement
        // Eks.

        // Else if:
        void ElseIf()
        {
            string menuChoice = Console.ReadLine();
            if (menuChoice == "1")
            {
               // doSomethingFun();
            }
            else if(menuChoice == "2")
            {
                // doSomethingMoreFun();
            }
            else
            {
                // doSomethingElse();
            }
        }

        // Switch 

        void Switch()
        {
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    // doSomethingFun();
                    break;
                case "2":
                    // doSomethingMoreFun();
                    break;
                default:
                    // doSomethingElse();
                    break;
            }
        }

        // En switch sammenlikner valuen i switch()-parantesene i forhold til case - valuen.
        // Under hver case står det break, der er for at den skal stoppe programmet for å lese videre på de andre case'ne,
        // siden den har da har funnet et match.

        // Default kjører hvis den ikke finner en match. (litt som else)


        // Switch kan også skrives på en ekspressiv måte:
        public void SwitchExpressive()
        {
            int number = 3;
            string result = number switch
            {
                1 => "Wrong number",
                2 => "Wrong number",
                3 => "Right number!",
                _ => "Unknown input",
            };
            Console.WriteLine($"{result}");
        }
    }
}
