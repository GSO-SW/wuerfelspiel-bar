using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten = 6;
        public Wuerfel()
        {
        }
        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
        }

        public int Wuerfeln()
        {
            Random r = new Random();
            return r.Next(1, this.anzahlSeiten+1);

        }

        public int AnzahlSeiten
        {
            get 
            { 
                return this.anzahlSeiten;
            }
        }
    }
}
