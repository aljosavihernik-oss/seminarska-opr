using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class InteraktivniEksponat : Eksponat
    {
        public int SteviloUporabnikov { get; private set; }
        public bool Aktiven { get; private set; } = true;

        public event Action<string> OnUporaba;

        public InteraktivniEksponat(string naziv, int povrsina)
            : base(naziv, povrsina)
        { }

        public void Uporabi()
        {
            if (!Aktiven)
                return;

            SteviloUporabnikov++;
            OnUporaba?.Invoke("Eksponat '" + Naziv + "' uporabljen!");
        }

        public void Izklopi()
        {
            Aktiven = false;
        }

        public override int Obremenitev()
        {
            return 5 + SteviloUporabnikov;
        }
    }
}
