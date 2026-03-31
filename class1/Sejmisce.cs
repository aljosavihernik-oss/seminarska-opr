using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Sejmisce
    {
        public List<Dogodek> Dogodki { get; } = new List<Dogodek>();

        public void DodajDogodek(Dogodek d)
        {
            Dogodki.Add(d);
        }
    }
}
