using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagbok
{

    internal class Menuhandler
    {
        // Metod för huvudmenyn i dagboksapplikationen.
        public static bool MainMenu()
        {
            
            Console.Clear(); // Rensa konsolfönstret för att visa den nya menyn.


            // Visa huvudmenyalternativ för användaren.
            Console.WriteLine();
            Console.WriteLine("1. skriv Dagboks inlägg ");
            Console.WriteLine("2. Se alla Dagboks inlägg");
            Console.WriteLine("3. sök Dagboks inlägg ");
            Console.WriteLine("4. tabort Dagboks inlägg");
            Console.WriteLine("5. Exit ");
            Console.WriteLine("\n~välj någon av alternativen:~\n ");


            // Läs in användarens val och dirigera till motsvarande funktion.
            switch (Console.ReadLine())
            {
                case "1":
                case "one":
                case "ett":
                    Diary.AddPost(); // Lägg till ett nytt inlägg
                    return true;

                case "2":
                case "two":
                case "två":
                    Diary.ListAll();// Lista alla inlägg.
                    return true;

                case "3":
                case "three":
                case "tre":
                    Diary.Search();// Sök efter inlägg.
                    return true;

                case "4":
                    Diary.Remove();// Ta bort ett inlägg.
                    return true;

                case "5":
                case "exit":
                case "quit":
                case "avsluta":
                    return false;// Avsluta applikationen

                default:
                    Console.WriteLine("Faulty input, try again!");// Felhantering för ogiltigt val.
                    Console.ReadLine();
                    return true;

            }

        }
    }
}