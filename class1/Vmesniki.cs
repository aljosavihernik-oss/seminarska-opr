using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class Vmesniki
    {
        public interface IOpisi
        {
            string KratekOpis();
        }

        public interface IObremenitev
        {
            int SkupnaObremenitev();
        }
    }
}
