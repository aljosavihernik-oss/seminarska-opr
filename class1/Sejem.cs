using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Sejem : Dogodek, IUpravljanje
    {
        private int[] stojnice;
        public const int ObremenitevNaStojnico = 3;

        public Sejem(string naziv, string hala,
            DateTime zacetek, int trajanje,
            int st, int zased)
            : base(naziv, hala, zacetek, zacetek.AddDays(trajanje),
                  TimeSpan.Zero, TimeSpan.Zero)
        {
            stojnice = new int[st];
        }
        public void Dodaj()
        {
            for (int i = 0; i < stojnice.Length; i++)
            {
                if (stojnice[i] == 0)
                {
                    stojnice[i] = ObremenitevNaStojnico;

                    SproziDodajanje("Dodana stojnica");
                    SproziZapolnitev();
                    PreveriObremenitev(100);

                    return;
                }
            }
            SproziPreobremenitev("Sejem je poln!");
        }
        public void Odstrani(int i)
        {
            if (i >= 0 && i < stojnice.Length && stojnice[i] != 0)
            {
                stojnice[i] = 0;

                SproziOdstranitev("Odstranjena stojnica");
                SproziZapolnitev();
                PreveriObremenitev(100);
            }
        }
        public int SteviloElementov()
        {
            int c = 0;
            foreach (var s in stojnice)
                if (s != 0) c++;
            return c;
        }
        public override int SkupnaObremenitev()
        {
            int vsota = 0;
            foreach (var s in stojnice)
                vsota += s;
            return vsota;
        }

        public override int ObremenitevHale()
        {
            return SkupnaObremenitev();
        }
        public override string Opis()
        {
            return "Sejem";
        }

        public override string KratekOpis()
        {
            return "Sejem";
        }
        public static Sejem operator +(Sejem s, int x)
        {
            s.Dodaj();
            return s;
        }
    }
}