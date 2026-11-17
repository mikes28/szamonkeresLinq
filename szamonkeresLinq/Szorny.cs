using System;
using System.Collections.Generic;
using System.Text;

namespace szamonkeresLinq
{
    internal class Szorny
    {

        //private data fields
        private int id { get; set; }
        private string nev { get; set; }
        private int veszelyessegiSzint { get; set; }
        private string elohely { get; set; }
        private string foGyengeseg { get; set; }
        private string leggyakoribbZsakmany { get; set; }
        private bool veszelyesE { get; set; }


        //public read properties

        public int Id { get { return id; } }
        public string Nev { get { return nev; } }
        public int VeszelyessegiSzint { get { return veszelyessegiSzint; } }
        public string Elohely { get { return elohely; } }
        public string FoGyengeseg { get { return foGyengeseg; } }
        public string LeggyakoribbZsakmany { get { return leggyakoribbZsakmany; } }
        public bool VeszelyesE { get { return veszelyesE; } }


        //constructor

        public Szorny(int id, string nev, int veszelyessegiSzint, string elohely, string foGyengeseg, string leggyakoribbZsakmany, bool veszelyesE)
        {
            this.id = id;
            this.nev = nev;
            this.veszelyessegiSzint = veszelyessegiSzint;
            this.elohely = elohely;
            this.foGyengeseg = foGyengeseg;
            this.leggyakoribbZsakmany = leggyakoribbZsakmany;
            this.veszelyesE = veszelyesE;
        }





    }
}
