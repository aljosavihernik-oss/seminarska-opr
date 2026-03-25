using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace class1
{
    public abstract class Dogodek : IOpisi, IObremenitev
    {
        protected readonly string naziv;
        protected string hala;

        public DateTime Zacetek { get; }
        public DateTime Konec { get; }

        public static int StevecDogodkov = 0;

        public delegate void ObremenitevHandler(string sporocilo);
        public event ObremenitevHandler OnPreobremenitev;

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

        protected void PreveriObremenitev(int max)
        {
            if (ObremenitevHale() > max)
            {
                OnPreobremenitev?.Invoke("Pozor: hala je preobremenjena!");
            }
        }

        public bool JePreobremenjeno(int max)
        {
            return ObremenitevHale() > max;
        }

        public int RezervaDoMeje(int max)
        {
            return max - ObremenitevHale();
        }

        public virtual string PodrobenOpis()
        {
            return ToString() + ", trajanje: " + Trajanje() + " dni.";
        }

        public bool JeAktiven()
        {
            DateTime danes = DateTime.Today;
            return danes >= Zacetek && danes <= Konec;
        }

        public abstract string Opis();
        public abstract string KratekOpis();
        public abstract int SkupnaObremenitev();
        public abstract int ObremenitevHale();

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
