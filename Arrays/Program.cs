/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
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

namespace ArrayProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array deklarieren und initialisieren
            int[] myArray = new int[] { 10, 20, 30, 40, 50 };

            // for-Schleife verwenden
            Console.WriteLine("for-Schleife:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Element {i}: {myArray[i]}");
            }

            Console.WriteLine();

            // foreach-Schleife verwenden
            Console.WriteLine("foreach-Schleife:");
            foreach (int i in myArray)
            {
                Console.WriteLine($"Element: {i}");
            }

            Console.ReadKey();
        }
    }
}