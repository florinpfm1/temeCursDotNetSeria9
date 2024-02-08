using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    public class Candelabru
    {
        private BecReglabil[] _becuriCandelabru;

        public bool Aprins
        {
            get 
            { 
                bool stareAprins = false;
                foreach (BecReglabil bec in _becuriCandelabru)
                {
                    if (bec.PutereCurenta > 0)
                    {
                        stareAprins = true;
                        break;
                    }
                }
                return stareAprins; 
            }
        }

        public int PutereCurenta
        {
            get
            {
                int putereCurentaTotala = 0;
                foreach (BecReglabil bec in _becuriCandelabru)
                {
                    putereCurentaTotala += bec.PutereCurenta;
                }
                return putereCurentaTotala;
            }
        }

        public int PutereMaxima
        {
            get
            {
                int putereMaximaTotala = 0;
                foreach (BecReglabil bec in _becuriCandelabru)
                {
                    putereMaximaTotala += bec.PutereMax;
                }
                return putereMaximaTotala;
            }
        }

        public Candelabru(byte nrBecuri, params int[] puteriMaxBecuri) //constructor
        {
            _becuriCandelabru = new BecReglabil[nrBecuri];
            for (int i = 0; i < nrBecuri; i++)
            {
                _becuriCandelabru[i] = new BecReglabil();
                _becuriCandelabru[i].PutereMax = puteriMaxBecuri[i];
                _becuriCandelabru[i].PutereCurenta = 0;
            }
        }

        public void Aprinde()
        {
            foreach (BecReglabil bec in _becuriCandelabru)
            {
                bec.Aprinde();
            }
        }

        public void Stinge()
        {
            foreach (BecReglabil bec in _becuriCandelabru)
            {
                bec.Stinge();
            }
        }

        public void MaresteLumina(int putereAdaugata)
        {
            foreach(BecReglabil bec in _becuriCandelabru)
            {
                bec.MaresteLumina(putereAdaugata);
            }
        }

        public void ReduceLumina(int putereScoasa)
        {
            foreach (BecReglabil bec in _becuriCandelabru)
            {
                bec.ReduceLumina(putereScoasa);
            }
        }

        public void Afiseaza()
        {
            foreach (BecReglabil bec in _becuriCandelabru)
            {
                bec.Afiseaza();
            }
        }
    }
}
