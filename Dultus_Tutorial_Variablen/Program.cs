namespace Dultus_Tutorial_Variablen                             // Name unter dem Variablen, Klassen und Methoden zugeordnet werden können.
{
    internal class Program                                      // Programmbasisklasse
    {
        private static void Main(string[] args)                 // Haupteinstiegspunkt - args sind die übergebenen Argumente der Anwendung
        {
            // Tutorial Nr. 1
            // Ausgabe
            Console.WriteLine("Hello, World!");

            // Zahlenvariablen
            int i = 0;                                          // Ganzzahliger int32
            long l = 0;                                         // Ganzzahliger int64
            uint ui = 0;                                        // Ganzzahliger int32 ohne negative Zahlen
            ulong ul = 0;                                       // Ganzzahliger int64 ohne negative Zahlen

            float f = 0.0f;                                     // Gleitkommazahl 32 Bit
            double d = 0.0;                                     // Gleitkommazahl 64 Bit

            // Textvariablen
            char c = 'a';                                       // Buchstabe
            string s = "Text!";                                 // Text

            // Wahrheitswert
            bool b = true;                                      // Wahrheitswert

            string str = Console.ReadLine();                    // Eingabe in einen String legen

            if (str == "dultus")                                // if-Abfrage. Das in den Klammern muss der Wahrheit entsprechen.
            {                                                   // Die Klammern definieren das, was passieren soll, wenn das if stimmt.
                Console.WriteLine("Der Text stimmt!");
            }

            while (Console.ReadLine() != "dultus")              // Solange der Text der Konsole nicht "dultus" ist...
            {
                Console.WriteLine("Bitte schreibe \"dultus\""); // ...gibt es eine Ausgabe, dass sie "dultus" sein soll!
            }
        }
    }
}