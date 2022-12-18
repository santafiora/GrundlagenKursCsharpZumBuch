using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace BetriebsdatenErfassung
{
    // Klasse zur Repräsentation eines Datensatzes der Betriebsdaten
    class Betriebsdaten
    {
        public string IdentNr { get; set; }
        public string RMNr { get; set; }
        public int Zaehler { get; set; }
        public string Vbt { get; set; }
        public string Typ { get; set; }
        public DateTime AnlDatum { get; set; }
        public DateTime AnlZt { get; set; }
        public string Benutzername { get; set; }
    }

    // Hauptklasse der Betriebsdatenerfassung
    class BetriebsdatenErfassung
    {
        // Singleton-Instanz der BetriebsdatenErfassung
        private static BetriebsdatenErfassung instance;

        // Pfad zur Datendatei
        private readonly string datenDateiPfad = @"C:\temp\_betriebsdaten\betriebsdaten.csv";

        // Nummer des aktuellen Prüflaufs
        private int prueflaufNummer;

        // Verhindert, dass mehrere Instanzen der Klasse erstellt werden
        private BetriebsdatenErfassung() { }

        // Statische Methode zum Holen der Singleton-Instanz
        public static BetriebsdatenErfassung Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BetriebsdatenErfassung();
                }
                return instance;
            }
        }

        // Hauptmenü anzeigen
        public void HauptmenueAnzeigen()
        {
            Console.WriteLine("Betriebsdatenerfassung - Hauptmenü");
            Console.WriteLine("1) Prüflauf starten");
            Console.WriteLine("2) Beenden");
            Console.Write("Auswahl: ");
        }

      
        private void ProtokollErstellen(List<Betriebsdaten> daten)
        {
            // Dateiname erstellen
            var dateiname = $"protokoll_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}_{prueflaufNummer}.csv";

            // Datei erstellen/öffnen
            using (var writer = new StreamWriter(dateiname))
            {
                // Spaltenüberschriften schreiben
                writer.WriteLine("IdentNr,RMNr,Zähler,vbt,Typ,AnlDatum,AnlZt,Benutzername");

                // Daten schreiben
                foreach (var datensatz in daten)
                {
                    writer.WriteLine($"{datensatz.IdentNr},{datensatz.RMNr},{datensatz.Zaehler},{datensatz.Vbt},{datensatz.Typ},{datensatz.AnlDatum},{datensatz.AnlZt},{datensatz.Benutzername}");
                }
            }
        }
    

        public void PrueflaufStarten()
        {
            Console.WriteLine("Prüflauf gestartet. Drücken Sie Escape, um zum Hauptmenü zurückzukehren.");

            // Schleife solange ausführen, bis der Benutzer Escape drückt
            ConsoleKey key;
            do
            {
                // Versuchen, die Daten einzulesen
                List<Betriebsdaten> daten = null;
                while (daten == null)
                {
                    try
                    {
                        daten = DatenEinlesen();
                    }
                    catch (IOException)
                    {
                        // Wenn die Datei gesperrt ist, Meldung ausgeben und 5 Minuten warten
                        Console.WriteLine("Datei gesperrt. Versuche es in 5 Minuten erneut.");
                        Thread.Sleep(TimeSpan.FromMinutes(5));
                    }
                }

                // Daten ausgeben
                foreach (var datensatz in daten)
                {
                    Console.WriteLine($"IdentNr: {datensatz.IdentNr}");
                    Console.WriteLine($"RMNr: {datensatz.RMNr}");
                    Console.WriteLine($"Zähler: {datensatz.Zaehler}");
                    Console.WriteLine($"vbt: {datensatz.Vbt}");
                    Console.WriteLine($"Typ: {datensatz.Typ}");
                    Console.WriteLine($"AnlDatum: {datensatz.AnlDatum}");
                    Console.WriteLine($"AnlZt: {datensatz.AnlZt}");
                    Console.WriteLine($"Benutzername: {datensatz.Benutzername}");
                    Console.WriteLine();
                }

                // Prüflaufnummer erhöhen
                prueflaufNummer++;

                // Protokoll erstellen
                ProtokollErstellen(daten);

                // Taste abfragen
                key = Console.ReadKey(true).Key;
            }
            while (key != ConsoleKey.Escape);
        }


        // Daten aus der Datei einlesen
        private List<Betriebsdaten> DatenEinlesen()
        {
            var daten = new List<Betriebsdaten>();

            // Datei öffnen und Zeilen einlesen
            var zeilen = File.ReadAllLines(datenDateiPfad);

            // Zeilen parsen und Betriebsdaten-Objekte erstellen
            foreach (var zeile in zeilen.Skip(1)) // Überspringen der Kopfzeile
            {
                var spalten = zeile.Split(',');
                //var datumUhrzeit = DateTime.Parse(spalten[5] + " " + spalten[6]);
                var datumUhrzeit = DateTime.Parse(spalten[5] + " " + spalten[6].Insert(2, ":").Insert(5, ":"));
                daten.Add(new Betriebsdaten
                {
                    IdentNr = spalten[0],
                    RMNr = spalten[1],
                    Zaehler = int.Parse(spalten[2]),
                    Vbt = spalten[3],
                    Typ = spalten[4],
                    AnlDatum = datumUhrzeit.Date,
                    AnlZt = datumUhrzeit,
                    Benutzername = spalten[7]
                });
            }

            return daten;
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Hauptmenü anzeigen und Benutzereingabe verarbeiten
                while (true)
                {
                    BetriebsdatenErfassung.Instance.HauptmenueAnzeigen();
                    var auswahl = Console.ReadLine();
                    if (auswahl == "1")
                    {
                        BetriebsdatenErfassung.Instance.PrueflaufStarten();
                    }
                    else if (auswahl == "2")
                    {
                        break;
                    }
                }
            }
        }
    }
}


// Protokolldatei erstellen
/*private void ProtokollErstellen(List<Betriebsdaten> daten)
{
    // Dateiname erstellen
    var dateiname = $"protokoll_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}_Prueflauf{prueflaufNummer}.csv";

    // Datei erstellen und Kopfzeile schreiben
    using (var writer = new StreamWriter(dateiname))
    {
        writer.WriteLine("IdentNr,RMNr,Zähler,vbt,Typ,AnlDatum,AnlZt,Benutzername");

        // Daten schreiben
        foreach (var datenSatz in daten)
        {
            writer.WriteLine($"{datenSatz.IdentNr},{datenSatz.RMNr},{datenSatz.Zaehler},{datenSatz.Vbt},{datenSatz.Typ},{datenSatz.AnlDatum:yyyy-MM-dd},{datenSatz.AnlZt:HH:mm:ss},{datenSatz.Benutzername}");
        }
    }
}
}*/

// Prüflauf starten
/*public void PrueflaufStarten()
{
    Console.WriteLine("Prüflauf gestartet. Drücken Sie Escape, um zum Hauptmenü zurückzukehren.");

    // Schleife solange ausführen, bis der Benutzer Escape drückt
    while (true)
    {
        // Taste ab
        var key = Console.ReadKey().Key;
        if (key == ConsoleKey.Escape)
        {
            break;
        }

        // Versuchen, die Daten einzulesen
        List<Betriebsdaten> daten = null;
        while (daten == null)
        {
            try
            {
                daten = DatenEinlesen();
            }
            catch (IOException)
            {
                Console.WriteLine("Die Datendatei konnte nicht geöffnet werden. Neuer Versuch in 5 Minuten.");
                Thread.Sleep(300000); // 5 Minuten warten
            }
        }

        // Protokolldatei erstellen
        ProtokollErstellen(daten);

        // Prüflaufnummer erhöhen
        prueflaufNummer++;
    }
}*/

/* public void PrueflaufStarten()
     {
         Console.WriteLine("Prüflauf gestartet. Drücken Sie Escape, um zum Hauptmenü zurückzukehren.");

         // Schleife solange ausführen, bis der Benutzer Escape drückt
         ConsoleKey key;
         do
         {
             // Versuchen, die Daten einzulesen
             List<Betriebsdaten> daten = null;
             while (daten == null)
             {
                 try
                 {
                     daten = DatenEinlesen();
                 }
                 catch (IOException)
                 {
                     Console.WriteLine("Die Datendatei konnte nicht geöffnet werden. Neuer Versuch in 5 Minuten.");
                     Thread.Sleep(300000); // 5 Minuten warten
                 }
             }

             // Protokolldatei erstellen
             ProtokollErstellen(daten);

             // Prüflaufnummer erhöhen
             prueflaufNummer++;

             // Taste abfragen
             key = Console.ReadKey().Key;
         } while (key != ConsoleKey.Escape);
     }*/