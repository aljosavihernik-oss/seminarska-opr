using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Razstava : Dogodek, IUpravljanje
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

        public void Dodaj()
        {
            for (int i = 0; i < eksponati.Length; i++)
            {
                if (eksponati[i] == null)
                {
                    eksponati[i] = new Slika("Privzeta slika", 5);
                    return;
                }
            }
        }

        public void Odstrani(int index)
        {
            if (index >= 0 && index < eksponati.Length)
                eksponati[index] = null;
        }

        public int SteviloElementov()
        {
            int count = 0;
            foreach (var e in eksponati)
                if (e != null) count++;
            return count;
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
            int obremenitev = SkupnaObremenitev();
            PreveriObremenitev(100);
            return obremenitev;
        }

        public override string Opis()
        {
            return "Razstava s " + SteviloEksponatov + " eksponati.";
        }

        public override string KratekOpis()
        {
            return "Razstava: " + SteviloEksponatov + " eksponatov";
        }
    }
}