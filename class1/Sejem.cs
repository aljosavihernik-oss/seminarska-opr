using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Sejem : Dogodek
    {
        public int SteviloStojnic { get; }
        public int ZasedenostHale { get; }

        public const int ObremenitevNaStojnico = 3;

        private int[] stojnice;

        public Sejem(string naziv, string hala,
                     DateTime zacetek, int trajanjeVDneh,
                     int steviloStojnic, int zasedenostHale)
            : base(naziv, hala, zacetek, trajanjeVDneh)
        {
            SteviloStojnic = steviloStojnic;
            ZasedenostHale = zasedenostHale;

            stojnice = new int[steviloStojnic];
            for (int i = 0; i < stojnice.Length; i++)
                stojnice[i] = ObremenitevNaStojnico;
        }
        public int this[int index]
        {
            get { return stojnice[index]; }
            set { stojnice[index] = value; }
        }

        public override string Opis()
        {
            return "Sejem s " + SteviloStojnic + " stojnicami.";
        }

        public override string KratekOpis()
        {
            return "Sejem: " + SteviloStojnic + " stojnic";
        }

        public override int SkupnaObremenitev()
        {
            int vsota = 0;
            foreach (int s in stojnice)
                vsota += s;
            return vsota;
        }

        public override int ObremenitevHale()
        {
            return SkupnaObremenitev();
        }

        ~Sejem()
        {
            Console.WriteLine("Sejem odstranjen.");
        }
    }
}
