/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherCracker
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/
/*
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the secret message to decrypt.
            Console.Write("Enter the secret message: ");
            char[] secretMessage = Console.ReadLine().ToCharArray();

            // Prompt the user for the decryption key.
            Console.Write("Enter the decryption key: ");
            int key = int.Parse(Console.ReadLine());

            // Decrypt the secret message using the provided key.
            string decryptedMessage = Decryption(secretMessage, key);

            // Print the decrypted message to the console.
            Console.WriteLine("Decrypted message: " + decryptedMessage);
        }

       
    }
}*/

using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the secret message to decrypt.
            Console.Write("Enter the secret message: ");
            char[] secretMessage = Console.ReadLine().ToCharArray();

            // Prompt the user for the decryption key.
            Console.Write("Enter the decryption key: ");
            int key = int.Parse(Console.ReadLine());

            // Decrypt the secret message using the provided key.
            string decryptedMessage = Decryption(secretMessage, key);

            // Print the decrypted message to the console.
            Console.WriteLine("Decrypted message: " + decryptedMessage);
        }

        static public string Decryption(char[] vsecretMessage, int vkey)
        {
            // Create a lookup table where the decrypted character
            // can be found directly from the encrypted character
            // and the shift value.
            char[,] lookupTable = new char[26, 26];
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    lookupTable[i, j] = alphabet[(i + j) % 26];
                }
            }

            string decryptedMessage = "";
            for (int i = 0; i < vsecretMessage.Length; i++)
            {
                char c = vsecretMessage[i];
                if (alphabet.Contains(c))
                {
                    // Use the lookup table to find the decrypted character directly.
                    int encryptedCharIndex = Array.IndexOf(alphabet, c);
                    decryptedMessage += lookupTable[encryptedCharIndex, vkey];
                }
                else
                {
                    decryptedMessage += c;
                }
            }

            return decryptedMessage;
        }
    }
}