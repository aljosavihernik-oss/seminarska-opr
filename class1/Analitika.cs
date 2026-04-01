using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public static class Analitika
    {
        public static int Skupna(List<Dogodek> dogodki)
        {
            int vsota = 0;

            foreach (var d in dogodki)
            {
                vsota += d.ObremenitevHale();
            }

            return vsota;
        }

        public static double Povprecje(List<Dogodek> dogodki)
        {
            if (dogodki.Count == 0) return 0;

            return (double)Skupna(dogodki) / dogodki.Count;
        }
    }
}
