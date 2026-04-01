using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Sejem : Dogodek, IUpravljanje
    {
        public int SteviloStojnic { get; }

        private Stojnica[] stojnice;

        public Sejem(string naziv, string hala,
            DateTime zacetek, int trajanjeVDneh,
            int steviloStojnic, int zasedenostHale)
            : base(
                naziv,
                hala,
                zacetek,
                zacetek.AddDays(trajanjeVDneh - 1), 
                TimeSpan.Zero,                
                TimeSpan.Zero                    
            )
        {
            SteviloStojnic = steviloStojnic;
            stojnice = new Stojnica[steviloStojnic];
        }
        public void DodajStojnico(Stojnica s)
        {
            for (int i = 0; i < stojnice.Length; i++)
            {
                if (stojnice[i] == null)
                {
                    stojnice[i] = s;

                    SproziDodajanje("Dodana stojnica: " + s.Naziv);
                    SproziZapolnitev();
                    if (SkupnaObremenitev() > 100)
                        SproziPreobremenitev("Hala je preobremenjena!");

                    return;
                }
            }

            SproziPreobremenitev("Ni prostora za več stojnic!");
        }
        public void Dodaj()
        {
            DodajStojnico(new Stojnica("Privzeta", 3));
        }

        public void Odstrani(int index)
        {
            if (index >= 0 && index < stojnice.Length && stojnice[index] != null)
            {
                SproziOdstranitev("Odstranjena stojnica: " + stojnice[index].Naziv);
                stojnice[index] = null;
                SproziZapolnitev();
            }
        }

        public int SteviloElementov()
        {
            int count = 0;
            foreach (var s in stojnice)
                if (s != null) count++;
            return count;
        }
        public override int SkupnaObremenitev()
        {
            int vsota = 0;

            foreach (var s in stojnice)
                if (s != null)
                    vsota += s.Obremenitev;

            return vsota;
        }
        public override int ObremenitevHale()
        {
            return SkupnaObremenitev();
        }

        public override string Opis()
        {
            return "Sejem s " + SteviloElementov() + " stojnicami.";
        }

        public override string KratekOpis()
        {
            return "Sejem: " + SteviloElementov() + " stojnic";
        }
        public static Sejem operator +(Sejem s, Stojnica st)
        {
            s.DodajStojnico(st);
            return s;
        }
    }
}