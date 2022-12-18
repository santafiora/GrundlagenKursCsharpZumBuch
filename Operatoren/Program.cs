/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoren
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

namespace Operatoren
{
    public class Program
    {
        public static void Main()
        {
            // Beispiele für unäre Operatoren
            int number1 = 7;
            int number2 = -7;
            int result1 = -number1;
            int result2 = +number2;
            Console.WriteLine($"Ergebnis des unären Minusoperators: {result1}");
            Console.WriteLine($"Ergebnis des unären Plusoperators: {result2}");

            // Beispiele für gerade Operatoren
            int number3 = 5;
            int number4 = 4;
            int result3 = number3 + number4;
            int result4 = number3 - number4;
            int result5 = number3 * number4;
            int result6 = number3 / number4;
            Console.WriteLine($"Ergebnis des Addition-Operators: {result3}");
            Console.WriteLine($"Ergebnis des Subtraction-Operators: {result4}");
            Console.WriteLine($"Ergebnis des Multiplikation-Operators: {result5}");
            Console.WriteLine($"Ergebnis des Division-Operators: {result6}");

            // Beispiele für logische Operatoren
            bool number5 = true;
            bool number6 = false;
            bool result7 = number5 && number6;
            bool result8 = number5 || number6;
            bool result9 = !number5;
            Console.WriteLine($"Das Ergebnis des logischen UND-Operators ist: {result7}");
            Console.WriteLine($"Das Ergebnis des logischen ODER-Operators ist: {result8}");
            Console.WriteLine($"Das Ergebnis des logischen Negations-Operators ist: {result9}");

            // Beispiele für Vergleichsoperatoren
            int number7 = 3;
            int number8 = 3;
            bool result10 = number7 == number8;
            bool result11 = number7 != number8;
            bool result12 = number7 > number8;
            bool result13 = number7 < number8;
            Console.WriteLine($"Das Ergebnis des Vergleichs-Operators Gleich = ist: {result10}");
            Console.WriteLine($"Das Ergebnis des Vergleichs-Operators Ungleich ≠ ist: {result11}");
            Console.WriteLine($"Das Ergebnis des Vergleichs-Operators Größer als > ist: {result12}");
            Console.WriteLine($"Das Ergebnis des Vergleichs-Operators Kleiner als < ist: {result13}");

            Console.ReadKey();
        }
    }
}