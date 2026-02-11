using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static class1.Vmesniki;

namespace class1
{
    public abstract class Dogodek : IOpisi, IObremenitev
    {
        protected readonly string naziv;
        protected string hala;

        public DateTime Zacetek { get; }
        public DateTime Konec { get; }

        public static int StevecDogodkov = 0;

        protected Dogodek(string naziv, string hala,
                          DateTime zacetek, DateTime konec)
        {
            this.naziv = naziv;
            this.hala = hala;
            Zacetek = zacetek;
            Konec = konec;
            StevecDogodkov++;
        }

        protected Dogodek(string naziv)
            : this(naziv, "Neznana",
                   DateTime.Today, DateTime.Today)
        { }

        protected Dogodek(string naziv, string hala,
                          DateTime zacetek, int trajanjeVDneh)
            : this(naziv, hala,
                   zacetek,
                   zacetek.AddDays(trajanjeVDneh - 1))
        { }

        public static bool operator ==(Dogodek a, Dogodek b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.naziv == b.naziv;
        }

        public static bool operator !=(Dogodek a, Dogodek b)
        {
            return !(a == b);
        }

        public abstract string Opis();
        public abstract int ObremenitevHale();
        public abstract string KratekOpis();
        public abstract int SkupnaObremenitev();

        public int Trajanje()
        {
            return (Konec - Zacetek).Days + 1;
        }

        public override string ToString()
        {
            return naziv + " (hala " + hala + "), od " +
                   Zacetek.ToString("dd.MM.yyyy") + " do " +
                   Konec.ToString("dd.MM.yyyy");
        }
    }
}
