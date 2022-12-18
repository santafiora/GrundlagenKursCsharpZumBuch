using System;
using System.Collections.Generic;

namespace CinemaReservationSystem
{
    class Cinema
    {
        // Eigenschaften für ein Kino
        public string Location { get; set; }
        public string Name { get; set; }
        public int NumberOfScreens { get; set; }
        public int NumberOfSeatsPerScreen { get; set; }

        public Cinema(string location, string name, int numberOfScreens, int numberOfSeatsPerScreen)
        {
            Location = location;
            Name = name;
            NumberOfScreens = numberOfScreens;
            NumberOfSeatsPerScreen = numberOfSeatsPerScreen;
        }
    }

    class Reservation
    {
        // Eigenschaften für eine Reservierung
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public int Screen { get; set; }
        public int Seat { get; set; }

        public Reservation(string userName, DateTime dateTime, int screen, int seat)
        {
            UserName = userName;
            DateTime = dateTime;
            Screen = screen;
            Seat = seat;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Liste der Kinos
            List<Cinema> cinemas = new List<Cinema>
            {
                new Cinema("Baden-Württemberg", "Kino 1", 2, 100),
                new Cinema("Bayern", "Kino 2", 2, 100),
                new Cinema("Berlin", "Kino 3", 2, 100),
                new Cinema("Brandenburg", "Kino 4", 2, 100),
                new Cinema("Bremen", "Kino 5", 2, 100),
                new Cinema("Hamburg", "Kino 6", 2, 100),
                new Cinema("Hessen", "Kino 7", 2, 100),
                new Cinema("Mecklenburg-Vorpommern", "Kino 8", 2, 100),
                new Cinema("Niedersachsen", "Kino 9", 2, 100),
                new Cinema("Nordrhein-Westfalen", "Kino 10", 2, 100),
                new Cinema("Rheinland-Pfalz", "Kino 11", 2, 100),
                new Cinema("Saarland", "Kino 12", 2, 100),
                new Cinema("Sachsen", "Kino 13", 2, 100),
                new Cinema("Sachsen-Anhalt", "Kino 14", 2, 100),
                new Cinema("Schleswig-Holstein", "Kino 15", 2, 100),
                new Cinema("Thüringen", "Kino 16", 2, 100)
            };

            // Liste der Reservierungen
            List<Reservation> reservations = new List<Reservation>();

            while (true)
            {
                // Benutzer auffordern, Bundesland auszuwählen
                Console.WriteLine("Bitte wählen Sie das Bundesland aus, in dem Sie eine Reservierung vornehmen möchten:");
                for (int i = 0; i < cinemas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {cinemas[i].Location}");
                }

                // Bundesland auswählen
                Console.Write("Bundesland: ");
                int selectedLocation = int.Parse(Console.ReadLine());

                // Verfügbare Kinos im ausgewählten Bundesland anzeigen
                Console.WriteLine("Verfügbare Kinos:");
                for (int i = 0; i < cinemas.Count; i++)
                {
                    if (cinemas[i].Location == cinemas[selectedLocation - 1].Location)
                    {
                        Console.WriteLine($"{i + 1}. {cinemas[i].Name}");
                    }
                }

                // Benutzer auffordern, Kino auszuwählen
                Console.Write("Kino: ");
                int selectedCinema = int.Parse(Console.ReadLine());

                // Verfügbare Kinosäle im ausgewählten Kino anzeigen
                Console.WriteLine("Verfügbare Kinosäle:");
                for (int i = 1; i <= cinemas[selectedCinema - 1].NumberOfScreens; i++)
                {
                    Console.WriteLine(i);
                }

                // Benutzer auffordern, Kinosal auszuwählen
                Console.Write("Kinosal: ");
                int selectedScreen = int.Parse(Console.ReadLine());

                // Verfügbare Sitzplätze im ausgewählten Kinosal anzeigen
                Console.WriteLine("Verfügbare Sitzplätze:");
                for (int row = 1; row <= 10; row++)
                {
                    for (int seat = 1; seat <= 10; seat++)
                    {
                        // Überprüfen, ob Sitzplatz bereits reserviert ist
                        bool isSeatTaken = false;
                        foreach (Reservation reservation in reservations)
                        {
                            if (reservation.Screen == selectedScreen && reservation.Seat == seat + (row - 1) * 10)
                            {
                                Console.Write("X ");
                                isSeatTaken = true;
                                break;
                            }
                        }

                        if (!isSeatTaken)
                        {
                            Console.Write("O ");
                        }
                    }
                    Console.WriteLine();
                }

                // Benutzer auffordern, Sitzplatz auszuwählen
                Console.Write("Bitte wählen Sie einen Sitzplatz aus (Reihe Sitzplatz): ");
                string selectedSeatInput = Console.ReadLine();
                int selectedSeatRow = int.Parse(selectedSeatInput.Split(' ')[0]);
                int selectedSeatSeat = int.Parse(selectedSeatInput.Split(' ')[1]);
                int selectedSeat = selectedSeatSeat + (selectedSeatRow - 1) * 10;

                // Reservierung vornehmen
                Console.Write("Bitte geben Sie Ihren Namen ein: ");
                string userName = Console.ReadLine();
                Console.Write("Bitte geben Sie das Datum und die Uhrzeit Ihrer Reservierung ein (dd.mm.yyyy hh:mm): ");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                reservations.Add(new Reservation(userName, dateTime, selectedScreen, selectedSeat));
                Console.WriteLine("Ihre Reservierung wurde erfolgreich vorgenommen.");
            }
        }
    }
}
