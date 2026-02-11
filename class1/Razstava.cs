using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Razstava : Dogodek
    {
        public readonly int SteviloEksponatov;
        public bool PosebniPogoji { get; }

        public static int DodatekPosebniPogoji = 20;

        private Eksponat[] eksponati;

        public Razstava(string naziv, string hala,
                        DateTime zacetek, int trajanjeVDneh,
                        int steviloEksponatov, bool posebniPogoji)
            : base(naziv, hala, zacetek, trajanjeVDneh)
        {
            SteviloEksponatov = steviloEksponatov;
            PosebniPogoji = posebniPogoji;
            eksponati = new Eksponat[steviloEksponatov];
        }
        public Eksponat this[int index]
        {
            get { return eksponati[index]; }
            set { eksponati[index] = value; }
        }

        public override string Opis()
        {
            return "Razstava s " + SteviloEksponatov + " eksponati.";
        }

        public override string KratekOpis()
        {
            return "Razstava: " + SteviloEksponatov + " eksponatov";
        }

        public override int SkupnaObremenitev()
        {
            int vsota = 0;

            foreach (Eksponat e in eksponati)
                if (e != null)
                    vsota += e.Obremenitev();

            if (PosebniPogoji)
                vsota += DodatekPosebniPogoji;

            return vsota;
        }

        public override int ObremenitevHale()
        {
            return SkupnaObremenitev();
        }
        ~Razstava()
        {
            Console.WriteLine("Razstava odstranjena.");
        }
    }
}