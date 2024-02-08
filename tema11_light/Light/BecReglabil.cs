using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    public class BecReglabil
    {
        private int _putereCurenta;
        private int _putereMax;

        public int PutereCurenta
        {
            get { return _putereCurenta; }
            set { _putereCurenta = value; }
        }

        public int PutereMax
        {
            get { return _putereMax;}
            set { _putereMax = value;}
        }
        public bool Aprins
        {
            get { return _putereMax > 0 ? true : false; }
        }

        public BecReglabil() //constructor
        {
            this._putereCurenta = 15;
            this._putereMax = 25;
        }

        public void Aprinde()
        {
            _putereCurenta = _putereMax;
        }

        public void Stinge()
        {
            _putereCurenta = 0;
        }

        public void MaresteLumina(int putereAdunata)
        {
            if (_putereCurenta + putereAdunata < _putereMax)
            {
                _putereCurenta += putereAdunata;
            }
            else
            {
                _putereCurenta = _putereMax;
            }
        }

        public void ReduceLumina(int putereScazuta)
        {
            if (_putereCurenta - putereScazuta > 0)
            {
                _putereCurenta -= putereScazuta;
            }
            else
            {
                _putereCurenta = 0;
            }
        }

        public void Afiseaza()
        {
            Console.WriteLine($"putere curenta in bec este: {PutereCurenta}");
            Console.WriteLine($"putere maxima in bec este: {PutereMax}");
            Console.WriteLine($"becul este aprins: {Aprins}");
        }
    }
}
