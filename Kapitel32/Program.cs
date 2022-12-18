/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitel32
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

namespace ConstructorChaining
{
    class Address
    {
        // Adressfeld-Variablen
        public string Street;
        public string City;
        public string State;

        // Default Konstruktor mit Default-Werten
        public Address()
            : this("unbekannt", "unbekannt", "unbekannt") { }

        // Parametrisierter Konstruktor
        public Address(string street, string city, string state)
        {
            Street = street;
            City = city;
            State = state;
        }
    }

    class Person
    {
        // Personen-Variablen
        public string FirstName;
        public string LastName;
        public int Age;
        public Address Address;

        // Default Konstruktor mit Default-Werten
        public Person()
            : this("John", "Doe", 0,
                    new Address())
        { }

        // Objektinitialisierungs-Syntax zum Definieren der Eigenschaften der Person
        public Person(string firstName, string lastName, int age, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
        }

        // Konstruktorverkettung
        public Person(string firstName, string lastName)
            : this(firstName, lastName, 0,
                    new Address())
        { }

        // Eine Methode die den vollständigen Namen der Person zurückgibt
        public string getFullName()
        {
            return FirstName + " " + LastName;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Erstelle eine neue 'Person' Instanz mit dem parametrierten Konstruktor
            Person person = new Person("John", "Smith", 32,
                                        new Address("67 E Jefferson St",
                                                    "Orlando", "FL"));

            // Erhalte den vollständigen Namen der Person
            string fullName = person.getFullName();

            // Ausgeben von Daten
            Console.WriteLine("Personname: {0}", fullName);
            Console.WriteLine("Alter: {0}", person.Age);
            Console.WriteLine("Adresse: {0} {1}, {2}",
                                person.Address.Street,
                                person.Address.City,
                                person.Address.State);

            Console.ReadKey();

        }
        
    }
}
