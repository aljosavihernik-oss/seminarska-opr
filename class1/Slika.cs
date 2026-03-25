using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Slika : Eksponat
    {
        public Slika(string naziv, int povrsina)
            : base(naziv, povrsina)
        { }

        public override int Obremenitev()
        {
            return Povrsina;
        }
    }
}
