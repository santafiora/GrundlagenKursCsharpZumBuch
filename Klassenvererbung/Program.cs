/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenvererbung
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

// Basisklasse
public class Person
{
    public string Vorname { get; set; }
    public string Nachname { get; set; }

    public Person(string vorname, string nachname)
    {
        this.Vorname = vorname;
        this.Nachname = nachname;
    }

    public override string ToString()
    {
        return String.Format("Person: {0} {1}", Vorname, Nachname);
    }
}

// Unterklasse
public class Mitarbeiter : Person
{
    public int MitarbeiterId { get; set; }
    public DateTime Wirkungsdatum { get; set; }

    public Mitarbeiter(string vorname, string nachname, int mitarbeiterId, DateTime wirkungsdatum)
       : base(vorname, nachname)
    {
        this.MitarbeiterId = mitarbeiterId;
        this.Wirkungsdatum = wirkungsdatum;
    }

    public override string ToString()
    {
        return String.Format("Mitarbeiter: {0} {1}, ID: {2}, Wirkungsdatum: {3:d}",
           Vorname, Nachname, MitarbeiterId, Wirkungsdatum);
    }
}

// Programm
public class Programm
{
    static void Main()
    {
        Person person = new Person("Mandy", "McDonald");
        Console.WriteLine(person.ToString());

        Mitarbeiter mitarbeiter = new Mitarbeiter("Marco", "Roth", 3, new DateTime(2000, 2, 1));
        Console.WriteLine(mitarbeiter.ToString());

        Console.ReadKey();
    }
}