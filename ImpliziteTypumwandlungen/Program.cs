/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpliziteTypumwandlungen
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}*/


using System;

namespace ImplicitTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implicit type conversions
            int i = 170;
            double d = i; // Implizite Konvertierung von Int zu Double
            Console.WriteLine(d);

            double dou = 3.14;
            int j = (int)dou; //Explizite Konvertierung von Double zu Int
            Console.WriteLine(j);

            float f = 3.14f; //Explicit für float
            int k = (int)f;
            Console.WriteLine(k);

            char ch = 'a';
            int l = ch; // Implizite Konvertierung von Char zu Int
            Console.WriteLine(l);

            int m = 98;
            char ch1 = (char)m; //Explizite Konvertierung von Int zu Char
            Console.WriteLine(ch1);

            long lon = 123567234234;
            int n = (int)lon; //Explizite Konvertierung von Long zu Int
            Console.WriteLine(n);

            int p = 124;
            long lon1 = p; // Implizite Konvertierung von Int zu Long
            Console.WriteLine(lon1);
            Console.ReadKey();
        }
    }
}