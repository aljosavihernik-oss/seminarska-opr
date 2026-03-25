using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public interface IOpisi
    {
        string KratekOpis();
        string Opis();
        string PodrobenOpis();
    }

    public interface IObremenitev
    {
        int SkupnaObremenitev();
        int ObremenitevHale();
        bool JePreobremenjeno(int max);
        int RezervaDoMeje(int max);
    }

    public interface IUpravljanje
    {
        void Dodaj();
        void Odstrani(int index);
        int SteviloElementov();
    }
}
