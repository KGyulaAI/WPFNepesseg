using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFNepesseg.Model
{
    public class Telepules
    {
        String megye;
        String telepulesNev;
        String telepulesTipus; //község, nagyközség, város, ...
        int ferfiLakosokSzama;
        int noiLakosokSzama;

        private List<Telepules> AdatokBetoltese(string fajlNeve)
        {
            List<Telepules> ujLista = new List<Telepules>();
            string[] beolvasottSorok = File.ReadAllLines(fajlNeve);

            foreach (string CSVsor in beolvasottSorok.Skip(1))
            {
                string[] mezok = CSVsor.Split(";");
                Telepules ujTelepules = new Telepules(mezok[2],
                    mezok[3],
                    mezok[4],
                    int.Parse(mezok[5].Replace(" ", "")),
                    int.Parse(mezok[6].Replace(" ", "")));
                ujLista.Add(ujTelepules);
            }
            return ujLista;
        }

        public Telepules(string megye, string telepulesNev, string telepulesTipus, int ferfiLakosokSzama, int noiLakosokSzama)
        {
            this.megye = megye;
            this.telepulesNev = telepulesNev;
            this.telepulesTipus = telepulesTipus;
            this.ferfiLakosokSzama = ferfiLakosokSzama;
            this.noiLakosokSzama = noiLakosokSzama;
        }

        public string Megye { get => megye; set => megye = value; }
        public string TelepulesNev { get => telepulesNev; set => telepulesNev = value; }
        public string TelepulesTipus { get => telepulesTipus; set => telepulesTipus = value; }
        public int FerfiLakosokSzama { get => ferfiLakosokSzama; set => ferfiLakosokSzama = value; }
        public int NoiLakosokSzama { get => noiLakosokSzama; set => noiLakosokSzama = value; }
    }
}
