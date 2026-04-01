using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Avto : Eksponat
    {
        public string Znamka { get; set; }

        public Avto(string naziv, int povrsina, string znamka)
            : base(naziv, povrsina)
        {
            Znamka = znamka;
        }

        public override int Obremenitev()
        {
            return Povrsina;
        }

        public override string Opis()
        {
            return $"{Naziv} ({Znamka}), površina: {Povrsina}";
        }
    }
}

