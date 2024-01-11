using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Dagbok
{
    public class Diary
    {
        private const string path = "EnfilL.txt";// Sökväg till filen där inlägg sparas.
        private static List<Entry> entries = new List<Entry>();// Lista för att lagra inlägg.

        // Metod för att ta bort ett inlägg baserat på index.
        public static void Remove()
        {
            Console.WriteLine("Välj inlägg du vill ta bort, baserat på indexposition:");
            // Kontrollera om användarens inmatning är giltig.
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < entries.Count)
            {
                entries.RemoveAt(index);
                Console.WriteLine("Inlägget har tagits bort.");
            }
            else
            {
                Console.WriteLine("Ogiltigt index. Vänligen försök igen!");
            }
            Console.ReadLine();
        }

        // Metod för att lägga till ett nytt inlägg i dagboken.
        public static void AddPost()
        {
            bool addEntry = true;
            while (addEntry)
            {
                // Inmatning av inläggets detaljer.
                Console.WriteLine("Dagbok\n");
                Console.WriteLine("Enter Titel: ");
                string titel = Console.ReadLine();

                Console.WriteLine("Enter Date (yyyy-MM-dd): ");
                string dateInput = Console.ReadLine();
                DateTime date;
                // Validering av datumformatet.
                while (!DateTime.TryParseExact(dateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date (yyyy-MM-dd): ");
                    dateInput = Console.ReadLine();
                }

                Console.WriteLine("Enter Text: ");
                string text = Console.ReadLine();

                // Skapa ett nytt inlägg och lägg till det i listan.
                Entry entry = new Entry(titel, date, text);
                entries.Add(entry);
                entries = entries.OrderBy(e => e.date).ToList();

                // Fråga användaren om de vill lägga till ett nytt inlägg.
                Console.WriteLine("Do you want to add another entry? (input Y for yes and N for no): ");
                string addNew = Console.ReadLine().ToUpper();
                addEntry = addNew == "Y";
            }
        }
        // Metod för att söka efter inlägg baserat på en sökterm.
        public static void Search()
        {
            bool search = true;
            while (search)
            {
                Console.WriteLine("Vad vill du söka efter?");
                string searchTerm = Console.ReadLine();

                // Sök efter inlägg som matchar söktermen.
                List<Entry> results = entries.FindAll(e => e.Titel.Contains(searchTerm));
                if (results.Count == 0)
                {
                    Console.WriteLine("Inga matchande inlägg hittades.");
                }
                else
                {
                    foreach (Entry entry in results)
                    {
                        Console.WriteLine(entry.ToString());
                    }
                }
                // Fråga användaren om de vill fortsätta söka.
                Console.WriteLine("Do you want to continue searching? (input Y for yes and N for no): ");
                string continueSearch = Console.ReadLine().ToUpper();
                search = continueSearch == "Y";
            }
        }

        // Metod för att lista alla inlägg i dagboken.
        public static void ListAll()
        {
            Console.WriteLine("\n~~~~~Alla dagboksinlägg~~~~~\n");
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
             catch (Exception ex)
            {
                Console.WriteLine($"Ett fel inträffade: {ex.Message}");
            }
        }
    }
}