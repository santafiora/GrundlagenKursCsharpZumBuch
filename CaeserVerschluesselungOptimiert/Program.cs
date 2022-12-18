/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserVerschluesselungOptimiert
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/

/*using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Willkommen bei der Caesar-Verschlüsselung.");
                Console.WriteLine("Bitte wählen Sie eine der folgenden Optionen:");
                Console.WriteLine("1. Verschlüsselung");
                Console.WriteLine("2. Entschlüsselung");
                Console.WriteLine("3. Beenden");

                int choice;
                Int32.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.Write("Bitte geben Sie den Text zum Verschlüsseln ein: ");
                        string textToEncrypt = Console.ReadLine();

                        Console.Write("Bitte geben Sie den Schlüssel ein (1 - 25): ");
                        int key;
                        Int32.TryParse(Console.ReadLine(), out key);

                        Console.WriteLine("Der verschlüsselte Text lautet: " + Encrypt(textToEncrypt, key));
                        break;

                    case 2:
                        Console.Write("Bitte geben Sie den Text zum Entschlüsseln ein: ");
                        string textToDecrypt = Console.ReadLine();

                        Console.Write("Bitte geben Sie den Schlüssel ein (1 - 25): ");
                        Int32.TryParse(Console.ReadLine(), out key);

                        Console.WriteLine("Der entschlüsselte Text lautet: " + Decrypt(textToDecrypt, key));
                        break;

                    case 3:
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe! Bitte versuchen Sie es erneut.");
                        break;
                }
            }
        }

        static string Encrypt(string plainText, int key)
        {
            string cipherText = "";

            foreach (char ch in plainText)
            {
                int ascii = (int)ch;

                if (char.IsUpper(ch))
                {
                    int encryptedChar = (ascii - 65 + key) % 26 + 65;
                    cipherText += (char)encryptedChar;
                }
                else if (char.IsLower(ch))
                {
                    int encryptedChar = (ascii - 97 + key) % 26 + 97;
                    cipherText += (char)encryptedChar;
                }
                else
                {
                    cipherText += ch;
                }
            }

            return cipherText;
        }

        static string Decrypt(string cipherText, int key)
        {
            string plainText = "";

            foreach (char ch in cipherText)
            {
                int ascii = (int)ch;

                if (char.IsUpper(ch))
                {
                    int decryptedChar = (ascii - 65 - key + 26) % 26 + 65;
                    plainText += (char)decryptedChar;
                }
                else if (char.IsLower(ch))
                {
                    int decryptedChar = (ascii - 97 - key + 26) % 26 + 97;
                    plainText += (char)decryptedChar;
                }
                else
                {
                    plainText += ch;
                }
            }

            return plainText;
        }
    }
}*/
/*

using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Willkommen bei der Caesar-Verschlüsselung.");
                Console.WriteLine("Bitte wählen Sie eine der folgenden Optionen:");
                Console.WriteLine("1. Verschlüsselung");
                Console.WriteLine("2. Entschlüsselung");
                Console.WriteLine("3. Beenden");

                int choice;
                Int32.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.Write("Bitte geben Sie den Text zum Verschlüsseln ein: ");
                        string textToEncrypt = Console.ReadLine();

                        Console.Write("Bitte geben Sie den Schlüssel ein (1 - 25): ");
                        int key;
                        Int32.TryParse(Console.ReadLine(), out key);

                        Console.WriteLine("Der verschlüsselte Text lautet: " + EncryptDecrypt(textToEncrypt, key, true));
                        break;

                    case 2:
                        Console.Write("Bitte geben Sie den Text zum Entschlüsseln ein: ");
                        string textToDecrypt = Console.ReadLine();

                        Console.Write("Bitte geben Sie den Schlüssel ein (1 - 25): ");
                        Int32.TryParse(Console.ReadLine(), out key);

                        Console.WriteLine("Der entschlüsselte Text lautet: " + EncryptDecrypt(textToDecrypt, key, false));
                        break;

                    case 3:
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe! Bitte versuchen Sie es erneut.");
                        break;
                }
            }
        }*/



/*      static string EncryptDecrypt(string text, int key, bool encrypt)
      {
          string result = "";

          foreach (char ch in text)
          {
              int ascii = (int)ch;

              if (char.IsUpper(ch))
              {
                  int encryptedChar = (ascii - 65 + key * (encrypt ? 1 : -1) + 26) % 26 + 65;
                  result += (char)encryptedChar;
              }
              else if (char.IsLower(ch))
              {
                  int encryptedChar = (ascii - 97 + key * (encrypt ? 1 : -1) + 26) % 26 + 97;
                  result += (char)encryptedChar;
              }
              else
              {
                  result += ch;
              }
          }

          return result;
      }*/

/* static string EncryptDecrypt(string text, int key, bool encrypt)
 {
     string result = "";

     // Convert the entire text string to uppercase or lowercase
     text = encrypt ? text.ToUpper() : text.ToLower();

     foreach (char ch in text)
     {
         int ascii = (int)ch;

         // Use either the uppercase or lowercase ASCII range
         int offset = encrypt ? 65 : 97;

         int encryptedChar = (ascii - offset + key * (encrypt ? 1 : -1) + 26) % 26 + offset;
         result += (char)encryptedChar;
     }

     return result;
 }*//*


}
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CaesarEncryption
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int MenueAuswahl = SetStartMenue();

            while (MenueAuswahl != 0)
            {
                switch (MenueAuswahl)
                {
                    case 1:

                        Console.WriteLine("Bitte den Verschlüsselungstext eingeben: ");

                        string klartext = Console.ReadLine();
                        klartext = klartext.ToUpper();
                        char[] secretMessage = klartext.ToCharArray();
                        Console.WriteLine("Bitte Positions Key eingeben: ");
                        int Key = Convert.ToInt32(Console.ReadLine());

                        //Aufruf der statischen Encryption Methode

                        Encryption(secretMessage, Key);
                        string secret = Encryption(secretMessage, Key);
                        Console.WriteLine(secret);

                        //Aufruf der Menue Methode
                        MenueAuswahl = SetStartMenue();
                        break;

                    case 2:
                        Console.WriteLine("Bitte den Verschlüsselten Text eingeben: ");
                        string vklartext = Console.ReadLine();
                        vklartext = vklartext.ToUpper();
                        char[] vsecretMessage = vklartext.ToCharArray();
                        Console.WriteLine("Bitte Positions Key eingeben: ");
                        int vKey = Convert.ToInt32(Console.ReadLine());

                        //Aufruf der statischen Decryption Methode
                        Decryption(vsecretMessage, vKey);
                        string vksecret = Decryption(vsecretMessage, vKey);
                        Console.WriteLine(vksecret);
                        //Aufruf der Menue Methode
                        MenueAuswahl = SetStartMenue();
                        break;

                    case 0:

                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();
                        //Aufruf der Menue Methode
                        MenueAuswahl = SetStartMenue();

                        break;
                }

            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="secretMessage"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        static public string Encryption(char[] secretMessage, int key)
        {

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string verschluesselteNachricht = "";

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char c = secretMessage[i];
                if (alphabet.Contains(c))
                {
                    int position = Array.IndexOf(alphabet, c);
                    int position_new = position + key;
                    int rest = position_new % 26;
                    verschluesselteNachricht += alphabet[rest];
                }
                else
                {
                    verschluesselteNachricht += c;
                }

            }

            return verschluesselteNachricht;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="vsecretMessage"></param>
        /// <param name="vkey"></param>
        /// <returns></returns>
        static public string Decryption(char[] vsecretMessage, int vkey)
        {

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string verschluesselteNachricht = "";


            for (int i = 0; i < vsecretMessage.Length; i++)
            {
                char c = vsecretMessage[i];

                if (alphabet.Contains(c))
                {
                    int position = Array.IndexOf(alphabet, c);
                    int position_new = position - vkey;
                    int rest = position_new % 26;
                    verschluesselteNachricht += alphabet[rest];
                }
                else
                {
                    verschluesselteNachricht += c;
                }
            }

            return verschluesselteNachricht;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public int SetStartMenue()
        {
            Console.WriteLine("Willkommen zur Cäsar Verschlüsselung");
            Console.WriteLine("1. Für Text Verschlüsseln:");
            Console.WriteLine("2. Für Text Entschlüsseln:");
            Console.WriteLine("0. Für Programmende:");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}

