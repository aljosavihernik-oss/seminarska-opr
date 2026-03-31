using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public abstract class Eksponat
    {
        public string Naziv { get; }
        public int Povrsina { get; }

        protected Eksponat(string naziv, int povrsina)
        {
            Naziv = naziv;
            Povrsina = povrsina;
        }

        public abstract int Obremenitev();

        public virtual string Opis()
        {
            return $"{Naziv}, povrsina: {Povrsina}";
        }
    }
}
