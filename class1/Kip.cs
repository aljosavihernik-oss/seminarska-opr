using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Kip : Eksponat
    {
        public Kip(string naziv, int povrsina)
            : base(naziv, povrsina)
        { }

        public override int Obremenitev()
        {
            return 5;
        }
    }
}
