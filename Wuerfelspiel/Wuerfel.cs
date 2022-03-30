using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private bool gesichert;

        public Wuerfel()
        {

        }

        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
        }


        public int AnzahlSeiten
        {
            get { return anzahlSeiten; }
        }


        public bool Gesichert
        {
            get { return gesichert; }
            set { gesichert = value; }
        }

        public void SicherungUmschalten()
        {
            throw new NotImplementedException();
        }

        public int Wuerfeln()
        {
            throw new NotImplementedException();
        }
    }
}
