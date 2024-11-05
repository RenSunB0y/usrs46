using System.Text.RegularExpressions;

namespace ExemplePOO {
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCotesClotures;
        public bool Riviere;

        public Terrain(string adresse, float superficie, int nbCotesClotures, bool riviere)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbCotesClotures = nbCotesClotures;
            Riviere = riviere;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0} ", this.Adresse);
            toString += String.Format("Superficie = {0} ", this.Superficie);
            toString += String.Format("NbCotesClotures = {0} ", this.NbCotesClotures);
            toString += String.Format("Riviere = {0} ", this.Riviere ? "oui" : "non");
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Riviere) { facteur += 500; }
            if (this.NbCotesClotures > 3) { facteur += 200; }

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }

        public int  CoutFinirCloture()
        {
            int cout = 0;
            this.NbCotesClotures = NbCotesClotures >= 4? cout : cout += 1000;
            return cout;
        }
    }
}
