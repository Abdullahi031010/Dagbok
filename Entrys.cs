namespace Dagbok
{
    public class Entry
    {
        private string titel;// Variabel för att lagra rubriken på inlägget.
        private string text;// Variabel för att lagra textinnehållet i inlägget.
        private DateTime date;// Variabel för att lagra datumet då inlägget skapades.

        // Konstruktor för att initialisera inläggets titel, datum och text.
        public Entry(string titel, DateTime date, string text)
        {
            this.titel = titel;
            this.date = date;
            this.text = text;
        }

        // Överskuggad ToString-metod för att returnera en strängrepresentation av inlägget.
        public override string ToString()
        {
            // Returnerar en formaterad sträng med inläggets titel, datum och text.
            return $"Titel:{titel}\nDate:{date.ToString("yyyy/MM/dd")}\nText:{text}\n";
        }
    }
}