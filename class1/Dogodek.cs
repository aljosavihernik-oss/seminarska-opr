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

        public TimeSpan ZacetekUra { get; }
        public TimeSpan KonecUra { get; }

        public static int StevecDogodkov = 0;

        public delegate void DogodekHandler(string msg);

        public event DogodekHandler OnPreobremenitev;
        public event DogodekHandler OnElementDodan;
        public event DogodekHandler OnElementOdstranjen;
        public event DogodekHandler OnZapolnitevSpremenjena;

        public List<ProgramDogodka> Program { get; } = new List<ProgramDogodka>();

        protected Dogodek(string naziv, string hala,
            DateTime zacetek, DateTime konec,
            TimeSpan zacetekUra, TimeSpan konecUra)
        {
            this.naziv = naziv;
            this.hala = hala;
            Zacetek = zacetek;
            Konec = konec;
            ZacetekUra = zacetekUra;
            KonecUra = konecUra;

            StevecDogodkov++;
        }

        protected void SproziDodajanje(string msg)
        {
            OnElementDodan?.Invoke(msg);
        }

        protected void SproziOdstranitev(string msg)
        {
            OnElementOdstranjen?.Invoke(msg);
        }

        protected void SproziZapolnitev()
        {
            OnZapolnitevSpremenjena?.Invoke("Zapolnitev spremenjena");
        }

        protected void SproziZapolnitev(string msg)
        {
            OnZapolnitevSpremenjena?.Invoke(msg);
        }

        protected void SproziPreobremenitev(string msg)
        {
            OnPreobremenitev?.Invoke(msg);
        }

        protected void PreveriObremenitev(int max)
        {
            if (ObremenitevHale() > max)
                SproziPreobremenitev("Hala je preobremenjena!");
        }

        public bool JePreobremenjeno(int max)
        {
            return ObremenitevHale() > max;
        }

        public int RezervaDoMeje(int max)
        {
            return max - ObremenitevHale();
        }

        public abstract string Opis();
        public abstract string KratekOpis();
        public abstract int SkupnaObremenitev();
        public abstract int ObremenitevHale();

        public override string ToString()
        {
            return $"{naziv} ({hala}) {Zacetek:dd.MM} - {Konec:dd.MM}";
        }

        public virtual string PodrobenOpis()
        {
            return ToString();
        }
    }
}