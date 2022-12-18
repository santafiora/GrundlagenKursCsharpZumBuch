/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromCheck_001_APP
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

namespace PalindromCheck_001_APP
{
    public class Palindrome
    {
        public static void Main()
        {
            String Palindrome;

            Console.Write("Geben Sie ein Wort ein: ");
            Palindrome = Console.ReadLine();

            int len = Palindrome.Length;

            Boolean palindromeCheck = true;

            for (int i = 0; i < len / 2; i++)
            {
                if (Palindrome[i] != Palindrome[len - 1 - i])
                {
                    palindromeCheck = false;
                    break;
                }
            }

            if (palindromeCheck)
                Console.WriteLine("Das Wort ist ein Palindrom!");
            else
                Console.WriteLine("Das Wort ist kein Palindrom!");

            Console.ReadLine();
        }
    }
}

// Beispiel: 
// Geben Sie ein Wort ein: otto
// Das Wort ist ein Palindrom!