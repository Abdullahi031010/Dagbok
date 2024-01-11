using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Dagbok
{
    internal class Program
    {

        // Huvudinmatningspunkt för applikationen.x
        static void Main()
        {
            // Initialisera variabeln showMenu till true för att visa menyn initialt.
            bool showMenu = true;

            // Loop för att fortsätta visa menyn tills användaren väljer att avsluta.
            while (showMenu) 
            {
                // Anropa MainMenu-metoden från Menuhandler-klassen och tilldela det returnerade värdet till showMenu.
                showMenu = Menuhandler.MainMenu(); 

            }

         
    }
       
    }
}

    

    
















