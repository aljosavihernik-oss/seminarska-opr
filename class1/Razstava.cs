using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Razstava : Dogodek, IUpravljanje
    {
        private Eksponat[] eksponati;

        public Razstava(string naziv, string hala,
            DateTime zacetek, int trajanje,
            int kapaciteta, bool posebni)
            : base(naziv, hala, zacetek, zacetek.AddDays(trajanje),
                  TimeSpan.Zero, TimeSpan.Zero)
        {
            eksponati = new Eksponat[kapaciteta];
        }
        public void Dodaj(Eksponat e)
        {
            for (int i = 0; i < eksponati.Length; i++)
            {
                if (eksponati[i] == null)
                {
                    eksponati[i] = e;
                    SproziDodajanje("Dodan: " + e.Naziv);
                    SproziZapolnitev();
                    PreveriObremenitev(100);
                    if (e is InteraktivniEksponat ie)
                    {
                        ie.OnUporaba += (msg) =>
                        {
                            SproziZapolnitev(msg);
                        };
                    }

                    return;
                }
            }
            SproziPreobremenitev("Razstava je polna!");
        }
        public void Dodaj()
        {
            Dodaj(new Kip("Auto", 5));
        }
        public void Odstrani(int index)
        {
            if (index >= 0 && index < eksponati.Length && eksponati[index] != null)
            {
                string naziv = eksponati[index].Naziv;

                eksponati[index] = null;

                SproziOdstranitev("Odstranjen: " + naziv);
                SproziZapolnitev();
                PreveriObremenitev(100);
            }
        }
        public int SteviloElementov()
        {
            int c = 0;
            foreach (var e in eksponati)
                if (e != null) c++;
            return c;
        }

        public override int SkupnaObremenitev()
        {
            int vsota = 0;
            foreach (var e in eksponati)
                if (e != null)
                    vsota += e.Obremenitev();
            return vsota;
        }

        public override int ObremenitevHale()
        {
            return SkupnaObremenitev();
        }

        public override string Opis()
        {
            return "Razstava";
        }

        public override string KratekOpis()
        {
            return "Razstava";
        }

        public static Razstava operator +(Razstava r, Eksponat e)
        {
            r.Dodaj(e);
            return r;
        }
    }
}