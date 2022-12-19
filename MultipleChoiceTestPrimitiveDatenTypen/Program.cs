using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTestPrimitiveDatenTypen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fragenkatalog mit Erklärungstexten und Lösungen
            var questions = new Dictionary<string, Tuple<string, char>>
            {
                {
                    "Welcher der folgenden Datentypen ist in C# für ganze Zahlen ohne Nachkommastellen verfügbar?",
                    Tuple.Create(
                        "Der Datentyp int (short für integer) ist in C# für ganze Zahlen ohne Nachkommastellen verfügbar.",
                        'a')
                },
                {
                    "Welcher der folgenden Datentypen ist in C# für ganze Zahlen mit Nachkommastellen verfügbar?",
                    Tuple.Create(
                        "Der Datentyp double (short für double-precision floating-point) ist in C# für ganze Zahlen mit Nachkommastellen verfügbar.",
                        'c')
                },
                {
                    "Welcher der folgenden Datentypen ist in C# für ganze Zahlen mit Nachkommastellen und hoher Genauigkeit verfügbar?",
                    Tuple.Create(
                        "Der Datentyp decimal ist in C# für ganze Zahlen mit Nachkommastellen und hoher Genauigkeit verfügbar.",
                        'd')
                },
                {
                    "Welcher der folgenden Datentypen ist in C# für Zeichen verfügbar?",
                    Tuple.Create(
                        "Der Datentyp char (short für character) ist in C# für Zeichen verfügbar.",
                        'a')
                },
                {
                    "Welcher der folgenden Datentypen ist in C# für boolesche Werte (true oder false) verfügbar?",
                    Tuple.Create(
                        "Der Datentyp bool (short für boolean) ist in C# für boolesche Werte (true oder false) verfügbar.",
                        'c')
                },
                {
                    "Welcher der folgenden Datentypen ist in C# für den Wert null verfügbar?",
                    Tuple.Create(
                        "Der Datentyp nullable ist in C# für den Wert null verfügbar. Nullable ist ein spezieller Datentyp, der einen Wert auf null setzen kann.",
                        'd')
                },
                {
                    "Welcher der folgenden Datentypen ist in C# für hexadezimale Werte verfügbar?",
Tuple.Create(
"Der Datentyp int (short für integer) ist in C# für hexadezimale Werte verfügbar. Hexadezimale Werte können in C# als int-Werte dargestellt werden, indem sie mit dem Präfix '0x' angegeben werden.",
'a')
}
};
            // Test wiederholen, solange der Benutzer es wünscht
            bool repeat = true;
            while (repeat)
            {
                int correct = 0;

                // Test durchführen
                foreach (var question in questions)
                {
                    Console.WriteLine(question.Key);
                    Console.WriteLine("a) int");
                    Console.WriteLine("b) float");
                    Console.WriteLine("c) double");
                    Console.WriteLine("d) decimal");
                    Console.Write("Ihre Wahl: ");
                    char choice = Console.ReadLine().ToLower()[0];

                    if (choice == question.Value.Item2)
                    {
                        Console.WriteLine("Korrekt!");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine("Falsch!");
                    }
                    Console.WriteLine(question.Value.Item1);
                    Console.WriteLine();
                }

                // Statistik ausgeben
                Console.WriteLine("Sie haben {0} von {1} Fragen richtig beantwortet.", correct, questions.Count);

                // Abfragen, ob der Test wiederholt werden soll
                Console.Write("Möchten Sie den Test wiederholen (j/n)? ");
                repeat = Console.ReadLine().ToLower()[0] == 'j';
            }
        }
    }
}
                   