/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/

using System;

namespace ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ein einfaches Beispiel, wo wir eine 
            // for Schleife verwenden, um durch eine 
            // Liste von Einkäufen zu iterieren

            // Wir legen ein Array von Einkäufen an 
            string[] purchases = { "Brot", "Milch", "Käse", "Äpfel", "Möhren" };

            // Wir beginnen mit dem Index 0 und iterieren über
            // alle Einträge im Array
            for (int i = 0; i < purchases.Length; i++)
            {
                // Jetzt können wir über jeden Kauf iterieren
                // und die Einzelheiten ausgeben
                Console.WriteLine("Einkauf: {0}", purchases[i]);
            }

            Console.ReadKey();
        }
    }
}