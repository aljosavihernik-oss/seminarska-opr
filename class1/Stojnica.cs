using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Stojnica
    {
        public string Naziv { get; set; }
        public int Obremenitev { get; set; }

        public Stojnica(string naziv, int obremenitev)
        {
            Naziv = naziv;
            Obremenitev = obremenitev;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
