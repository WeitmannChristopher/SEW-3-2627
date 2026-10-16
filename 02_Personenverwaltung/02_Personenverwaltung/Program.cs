using System;
using System.Collections.Generic;

namespace _02_Personenverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adresse a1 = new Adresse("Hauptstraße", "12a", 3340, "Waidhofen an der Ybbs", "Niederösterreich");

            Adresse a2 = new Adresse("Mariahilfer Straße", "45", 1060, "Wien", "Wien");

            Adresse a3 = new Adresse("Herrengasse", "8", 8010, "Graz", "Steiermark");

            Adresse a4 = new Adresse("Maria-Theresien-Straße", "21", 6020, "Innsbruck", "Tirol");

            List<Person> personen = new List<Person>()
            {
                new Person(1, "Anna", "Huber", a1, new DateTime(2009, 3, 12), "anna.huber@example.at"),
                new Person(2, "Markus", "Huber", a1, new DateTime(1980, 7, 5), "markus.huber@example.at"),
                new Person(3, "Sabine", "Huber", a1, new DateTime(1982, 11, 19), "sabine.huber@example.at"),
                new Person(4, "Lukas", "Gruber", a2, new DateTime(2001, 1, 23), "lukas.gruber@example.at"),
                new Person(5, "Mira", "Yilmaz", a2, new DateTime(1999, 9, 14), "mira.yilmaz@example.at"),
                new Person(6, "Thomas", "Bauer", a3, new DateTime(1975, 4, 30), "thomas.bauer@example.at"),
                new Person(7, "Julia", "Steiner", a4, new DateTime(2004, 12, 8), "julia.steiner@example.at"),
                new Person(8, "Felix", "Moser", a4, new DateTime(2003, 6, 17), "felix.moser@example.at")
            };
            List<Adresse> adressen = new List<Adresse>()
            {
                a1, a2, a3, a4
            };
            //Aufgaben bei Teil C anfangen
        }
    }
}
