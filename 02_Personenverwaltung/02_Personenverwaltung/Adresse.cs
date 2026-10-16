using System;

namespace _02_Personenverwaltung
{
    internal class Adresse
    {
        public string Strasse { get; private set; }
        public string Hausnummer { get; private set; }
        public int PLZ { get; private set; }
        public string Ort { get; private set; }
        public string Bundesland { get; private set; }
        public string Land { get; private set; }

        public Adresse(string strasse, string hausnummer, int plz, string ort, string bundesland, string land = "Österreich")
        {
            if (string.IsNullOrWhiteSpace(strasse))
            {
                throw new ArgumentException("Strasse darf nicht leer sein.");
            }
            if (string.IsNullOrWhiteSpace(hausnummer))
            {
                throw new ArgumentException("Hausnummer darf nicht leer sein.");
            }
            if (plz < 1000 || plz > 9999)
            {
                throw new ArgumentException("PLZ muss zwischen 1000 und 9999 liegen.");
            }
            if (string.IsNullOrWhiteSpace(ort))
            {
                throw new ArgumentException("Ort darf nicht leer sein.");
            }
            if (string.IsNullOrWhiteSpace(bundesland))
            {
                throw new ArgumentException("Bundesland darf nicht leer sein.");
            }
            if (string.IsNullOrWhiteSpace(land))
            {
                throw new ArgumentException("Land darf nicht leer sein.");
            }

            Strasse = strasse;
            Hausnummer = hausnummer;
            PLZ = plz;
            Ort = ort;
            Bundesland = bundesland;
            Land = land;
        }

        public override string ToString()
        {
            return $"{Strasse} {Hausnummer}, {PLZ} {Ort}, {Bundesland}, {Land}";
        }
    }
}
