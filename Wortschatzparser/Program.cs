/*using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pfad zur Eingabedatei
            string inputFilePath = @"D:\wortliste\deu-de_web-public_2019_1M\deu-de_web-public_2019_1M-words.txt";

            // Pfad zur Ausgabedatei
            string outputFilePath = @"c:\temp\output.txt";

            // Öffne den Stream zur Eingabedatei
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                // Erstelle einen TextReader, der Zeilen aus der Datei liest
                using (TextReader reader = new StreamReader(inputStream))
                {
                    // Lese solange Zeilen aus der Datei, bis keine mehr verfügbar sind
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into fields
                        string[] fields = line.Split('\t');

                        // Get the counter field
                        string counter = fields[0];

                        // Get the text field
                        string text = fields[1];

                        // Write the counter and text to the output file
                        File.AppendAllText(outputFilePath, counter + "\t" + text + Environment.NewLine);
                    }
                }
            }
        }
    }
}
*/



/*using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"D:\wortliste\deu-de_web-public_2019_1M\deu-de_web-public_2019_1M-words.txt";

            // Pfad zur Ausgabedatei
            string outputFilePath = @"c:\temp\output.txt";

            // Öffne den Stream zur Eingabedatei im asynchronen Modus mit einer Puffergröße von 1024 KB
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, 1024 * 1024, true))
            {
                // Erstelle einen TextReader, der Zeilen aus der Datei liest
                using (TextReader reader = new StreamReader(inputStream))
                {
                    // Verwende eine while-Schleife, um die Verarbeitung von Datensätzen zu verzögern, bis sie tatsächlich benötigt werden
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into fields
                        string[] fields = line.Split('\t');

                        // Get the counter field
                        string counter = fields[0];

                        // Get the text field
                        string text = fields[1];

                        // Process the data (in this case, simply concatenate the counter and text fields)
                        string processedData = counter + "\t" + text;

                        // Write the processed data to the output file
                        File.AppendAllText(outputFilePath, processedData + Environment.NewLine);
                    }
                }
            }
        }
    }
}
*/

/*
using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Pfad zur Eingabedatei
            string inputFilePath = @"D:\wortliste\deu-de_web-public_2019_1M\deu-de_web-public_2019_1M-words.txt";

            // Pfad zur Ausgabedatei
            string outputFilePath = @"c:\temp\output.txt";

            // Öffne den Stream zur Eingabedatei im asynchronen Modus mit einer Puffergröße von 1024 KB
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, 1024 * 1024, true))
            {
                // Erstelle einen TextReader, der Zeilen aus der Datei liest
                using (TextReader reader = new StreamReader(inputStream))
                {
                    // Verwende eine while-Schleife, um die Verarbeitung von Datensätzen zu verzögern, bis sie tatsächlich benötigt werden
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        // Split the line into fields
                        string[] fields = line.Split('\t');

                        // Get the counter field
                        string counter = fields[0];

                        // Get the text field
                        string text = fields[1];

                        // Process the data (in this case, simply concatenate the counter and text fields)
                        string processedData = counter + "\t" + text;

                        // Write the processed data to the output file in the background
                        await Task.Run(() => File.AppendAllText(outputFilePath, processedData + Environment.NewLine));
                    }
                }
            }
        }
    }
}*/

/*using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Pfad zur Eingabedatei
            // string inputFilePath = @"D:\wortliste\deu-de_web-public_2019_1M\deu-de_web-public_2019_1M-words.txt";
            //string inputFilePath = @"D:\wortliste\deu-de_web-public_2019_10K\deu-de_web-public_2019_10K-words.txt";
            string inputFilePath = "deu-de_web-public_2019_10K-words.txt";


            // Pfad zur Ausgabedatei
            //string outputFilePath = @"c:\temp\output.txt";
            string outputFilePath = "output.txt";


            try
            {
                // Überprüfe, ob die Eingabedatei vorhanden ist
                if (!File.Exists(inputFilePath))
                {
                    Console.WriteLine($"Die Eingabedatei {inputFilePath} wurde nicht gefunden.");
                    return;
                }

                // Überprüfe, ob die Ausgabedatei vorhanden ist. Wenn ja, lösche sie.
                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath);
                }

                // Öffne den Stream zur Eingabedatei im asynchronen Modus mit einer Puffergröße von 1024 KB
                using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, 1024 * 1024, true))
                {
                    // Erstelle einen TextReader, der Zeilen aus der Datei liest
                    using (TextReader reader = new StreamReader(inputStream))
                    {
                        // Verwende eine while-Schleife, um die Verarbeitung von Datensätzen zu verzögern, bis sie tatsächlich benötigt werden
                        string line;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            // Split the line into fields
                            string[] fields = line.Split('\t');

                            // Get the counter field
                            string counter = fields[0];

                            // Get the text field
                            string text = fields[1];

                            // Process the data (in this case, simply concatenate the counter and text fields)
                            string processedData = counter + "\t" + text;

                            // Write the processed data to the output file in the background
                            await Task.Run(() => File.AppendAllText(outputFilePath, processedData + Environment.NewLine));

                            // Debugging output
                            Console.WriteLine($"Verarbeitete Daten: {processedData}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Verarbeiten der Datei: {ex.Message}");
            }
        }
    }
}

*/

/*
using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Pfad zur Eingabedatei
            // string inputFilePath = @"D:\wortliste\deu-de_web-public_2019_1M\deu-de_web-public_2019_1M-words.txt";
            //string inputFilePath = @"D:\wortliste\deu-de_web-public_2019_10K\deu-de_web-public_2019_10K-words.txt";
            string inputFilePath = "deu-de_web-public_2019_10K-words.txt";


            // Pfad zur Ausgabedatei
            //string outputFilePath = @"c:\temp\output.txt";
            string outputFilePath = "output.txt";


            try
            {
                // Überprüfe, ob die Eingabedatei vorhanden ist
                if (!File.Exists(inputFilePath))
                {
                    Console.WriteLine($"Die Eingabedatei {inputFilePath} wurde nicht gefunden.");
                    return;
                }

                // Überprüfe, ob die Ausgabedatei vorhanden ist. Wenn ja, lösche sie.
                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath);
                }

                // Öffne den Stream zur Eingabedatei im asynchronen Modus mit einer Puffergröße von 1024 KB
                using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, 1024 * 1024, true))
                {
                    // Erstelle einen TextReader, der Zeilen aus der Datei liest
                    using (TextReader reader = new StreamReader(inputStream))
                    {
                        // Verwende eine while-Schleife, um die Verarbeitung von Datensätzen zu verzögern, bis sie tatsächlich benötigt werden
                        string line;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            // Split the line into fields
                            string[] fields = line.Split('\t');

                            // Get the counter field
                            string counter = fields[0];

                            // Get the text field
                            string text = fields[1];

                            // Process the data (in this case, simply concatenate the counter and text fields)
                            string processedData = counter + "\t" + text;


                            if (File.Exists(outputFilePath))
                            {
                                Console.WriteLine("Die Ausgabedatei ist bereits geöffnet. Versuche, sie zu schließen.");

                                // Versuche, die Ausgabedatei zu schließen
                                try
                                {
                                    File.Close(outputFilePath);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Fehler beim Schließen der Ausgabedatei: {ex.Message}
                                }
                         *//*   if (File.Exists(outputFilePath))
                            {
                                Console.WriteLine("Die Ausgabedatei ist bereits geöffnet.");
                                Console.ReadKey();
                            }

                            try
                            {
                                await Task.Run(() => File.AppendAllText(outputFilePath, processedData + Environment.NewLine));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Fehler beim Schreiben in die Ausgabedatei: {ex.Message}");
                            }
*//*
                                    // Write the processed data to the output file in the background
                                    //await Task.Run(() => File.AppendAllText(outputFilePath, processedData + Environment.NewLine));

                                    // Debugging output
                                    Console.WriteLine($"Verarbeitete Daten: {processedData}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Verarbeiten der Datei: {ex.Message}");
            }
        }
    }
}



*/


/*using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Prüfen, ob die Datei "Output.txt" bereits existiert
            if (File.Exists("Output.txt"))
            {
                Console.WriteLine("Die Datei 'Output.txt' existiert bereits. Bitte löschen Sie die Datei und starten Sie das Programm erneut.");
                return;
            }

            // Asynchron die Datei "input.txt" öffnen und Zeile für Zeile in die Datei "Output.txt" schreiben
            using (StreamReader reader = new StreamReader("deu-de_web-public_2019_10K-words.txt"))
            using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    await writer.WriteLineAsync(line);
                }
            }

            Console.WriteLine("Die Datei 'input.txt' wurde erfolgreich in die Datei 'Output.txt' kopiert.");
        }
    }
}*/

/*
using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Asynchron die Datei "input.txt" öffnen und Zeile für Zeile in die Datei "Output.txt" schreiben
            using (StreamReader reader = new StreamReader("deu-de_web-public_2019_10K-words.txt"))
            using (StreamWriter writer = new StreamWriter("Output.txt", append: true))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    await writer.WriteLineAsync(line);
                }
            }

            Console.WriteLine("Die Datei 'input.txt' wurde erfolgreich in die Datei 'Output.txt' kopiert.");
        }
    }
}
*/

/*using System;
using System.IO;
using System.Text;

namespace TerraByteApp
{
    class ReadLargeFile
    {
        static void Main(string[] args)
        {
           // const int chunkSize = 0;
            using (FileStream sourceStream = new FileStream("deu-de_web-public_2019_10K-words.txt", FileMode.Open))
            {
               // sourceStream.ReadTimeout = 10000; // 10 seconds

                using (FileStream outputStream = new FileStream("Output.txt", FileMode.Create))
                {
                   // outputStream.WriteTimeout = 10000; // 10 seconds

                    byte[] buffer = new byte[chunkSize];
                    int bytesRead;
                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}*/


/*using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chunk-Größe festlegen
            const int chunkSize = 1024 * 1024; // 1 MB

            // Öffne die Eingabedatei und die Ausgabedatei
            using (FileStream sourceStream = new FileStream("deu-de_web-public_2019_10K-words.txt", FileMode.Open))
            using (FileStream outputStream = new FileStream("Output.txt", FileMode.Append))
            {
                byte[] buffer = new byte[chunkSize];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputStream.Write(buffer, 0, bytesRead);
                }
            }

            Console.WriteLine("Die Datei 'input.txt' wurde erfolgreich in die Datei 'Output.txt' kopiert.");
        }
    }
}*/

/*
using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // open the input file for reading
            using (FileStream stream = File.OpenRead("a.txt"))
            {
                // open the output file for writing
                using (FileStream writeStream = File.OpenWrite("b.txt"))
                {
                    // create a BinaryReader and BinaryWriter to read and write the file
                    BinaryReader reader = new BinaryReader(stream);
                    BinaryWriter writer = new BinaryWriter(writeStream);

                    // create a buffer to hold the bytes 
                    byte[] buffer = new Byte[1024];
                    int bytesRead;

                    // while the read method returns bytes, keep writing them to the output stream
                    while ((bytesRead = stream.Read(buffer, 0, 1024)) > 0)
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}*/

using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("a.txt"))
            {
                string line;
                Console.WriteLine("Content before append:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine("Enter text to append into file:");
                string s = Console.ReadLine();

                using (StreamWriter writer = new StreamWriter("a.txt", true))
                {
                    writer.WriteLine(s);
                }

                Console.WriteLine("Content after append:");
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                reader.DiscardBufferedData();
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}