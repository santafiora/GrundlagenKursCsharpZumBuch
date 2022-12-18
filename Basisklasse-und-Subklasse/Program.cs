/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basisklasse_und_Subklasse
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

public abstract class Person
{
    // Basisklasse für Personendaten
    protected string name;
    protected int alter;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Alter
    {
        get { return alter; }
        set { alter = value; }
    }

    public abstract void PrintData();
}

public class HausArzt : Person
{
    protected string spezialisierung;
    protected int zertifizierung;

    public string Spezialisierung
    {
        get { return spezialisierung; }
        set { spezialisierung = value; }
    }

    public int Zertifizierung
    {
        get { return zertifizierung; }
        set { zertifizierung = value; }
    }

    public override void PrintData()
    {
        Console.WriteLine("Name: {0} ", name);
        Console.WriteLine("Alter: {0}", alter);
        Console.WriteLine("Spezialisierung: {0}", spezialisierung);
        Console.WriteLine("Zertifizierung: {0}", zertifizierung);
    }
}

public class Program
{
    public static void Main()
    {
        HausArzt michael = new HausArzt();
        michael.Name = "Dr. Michael Neumeyer";
        michael.Alter = 44;
        michael.Spezialisierung = "Allgemeinmediziner";
        michael.Zertifizierung = 5;

        michael.PrintData();
    }
}