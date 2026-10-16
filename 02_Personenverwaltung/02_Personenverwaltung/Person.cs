using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Personenverwaltung
{
    internal class Person
    {
        public int Id { get; private set; }
        public string Vorname { get; private set; }
        public string Nachname { get; private set; }
        public Adresse Hauptwohnsitz { get; private set; }
        public DateTime Geburtsdatum { get; private set; }
        public string EMail { get; private set; }

        public Person(int id, string vorname, string nachname, Adresse hauptwohnsitz, DateTime geburtsdatum, string eMail)
        {
            if(id <= 0)
            {
                throw new ArgumentException("ID muss positiv sein.");
            }
            if(string.IsNullOrWhiteSpace(vorname))
            {
                throw new ArgumentException("Vorname darf nicht leer sein.");
            }
            if (string.IsNullOrWhiteSpace(nachname))
            {
                throw new ArgumentException("Nachname darf nicht leer sein.");
            }
            if (hauptwohnsitz == null)
            {
                throw new ArgumentNullException("Hauptwohnsitz darf nicht null sein.");
            }
            if (geburtsdatum.Date > DateTime.Today)
            {
                throw new ArgumentException("Geburtsdatum darf nicht in der Zukunft liegen.");
            }
            if(string.IsNullOrWhiteSpace(eMail)|| !eMail.Contains("@"))
            {
                throw new ArgumentException("Ungültige E-Mail-Adresse.");
            }

            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Hauptwohnsitz = hauptwohnsitz;
            Geburtsdatum = geburtsdatum;
            EMail = eMail;
        }
        public int BerechneAlter()
        {
            int alter = DateTime.Today.Year - Geburtsdatum.Year;
            if(DateTime.Today < Geburtsdatum.Date.AddYears(alter))
            {
                alter--;
            }
            return alter;
        }
        public string VollerName()
        {
            return $"{Vorname} {Nachname}";
        }
        /* Brauchen wir dann später, wenn wir die Person umziehen lassen wollen
        public void Umziehen(Adresse neueAdresse)
        {
            if (neueAdresse == null)
            {
                throw new ArgumentException("Neue Adresse darf nicht null sein.");
            }
            Hauptwohnsitz = neueAdresse;
        }*/
        public override string ToString()
        {
            return $"{Id}: {VollerName()}, Alter: {BerechneAlter()}, E-Mail: {EMail}, Hauptwohnsitz: {Hauptwohnsitz}";
        }
    }
}
