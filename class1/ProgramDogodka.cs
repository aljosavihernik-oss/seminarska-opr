using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class ProgramDogodka
    {
        public string Naziv { get; set; }
        public TimeSpan Od { get; set; }
        public TimeSpan Do { get; set; }

        public override string ToString()
        {
            return $"{Naziv} ({Od}-{Do})";
        }
    }
}
