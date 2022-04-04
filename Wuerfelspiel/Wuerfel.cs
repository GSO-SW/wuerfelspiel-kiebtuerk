using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private bool gesichert;
        Random rnd = new Random();

        public Wuerfel()
        {

        }

        public Wuerfel(int anzahlSeiten)
        {
            if (anzahlSeiten < 6)
            {
                throw new Exception("anzahl der Seite muss über 6 sein");
            }
            else
            {
                this.anzahlSeiten = anzahlSeiten;
            }
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
            bool temp = gesichert;
            if (temp)
            {
                gesichert = false;
            }
            else
            {
                gesichert = true;
            }
        }

        public int Wuerfeln()
        {
            return rnd.Next(1, 6);
        }
    }
}
