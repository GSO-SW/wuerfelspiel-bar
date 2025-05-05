using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
        public Wuerfel(int anzahlSeiten) { this.anzahlSeiten = anzahlSeiten; }

        public int Wuerfeln()
        {
            return 1; 
        }
    }
}
