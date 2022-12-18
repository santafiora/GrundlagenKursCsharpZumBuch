/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}*/


using System;

namespace ForeachLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "Ein", "Zwei", "Drei", "Vier" };

            // Ein foreach-Schleife wird genutzt, um jedes Element im Array zu durchlaufen 
            foreach (string element in myArray)
            {
                Console.WriteLine(element);


            }
            Console.ReadKey();
        }
    }
}