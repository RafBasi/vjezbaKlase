using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaKlase
{
    internal class zrakoplov
    {
        string naziv;
        double snagaMotora;
        int dosegLeta;

        public zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public double SnagaMotora { get => snagaMotora; set => snagaMotora = value; }
        public int DosegLeta { get => dosegLeta; set => dosegLeta = value; }

        public override string ToString()
        {
            string ispis = "Naziv aviona: " + this.Naziv + "\n"
                + "Snaga motora: " + this.SnagaMotora + "kW\n"
                + "Doseg leta: " + this.DosegLeta + "km\n";
            return ispis;
        }
    }
}
