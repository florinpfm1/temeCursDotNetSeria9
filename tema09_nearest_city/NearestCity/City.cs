using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestCity
{
    public class City
    {
        private string _name;
        private byte _x, _y;
        private static byte lowLimit = 0; // defined here in case later we want to change this value, so we don't search all over the class where was used as a hardcoded "0" byte value
        private static byte highLimit = 10;

        public string Name
        {
            get { return _name; }
            set { _name = String.IsNullOrEmpty(value) ? null : value; }
        }

        public byte X
        {
            get { return _x; }
            set { _x = ( City.lowLimit <= (byte)value && (byte)value <= City.highLimit ) ? (byte)value : (byte)0; }
        }

        public byte Y
        {
            get { return _y; }
            set { _y = (City.lowLimit <= (byte)value && (byte)value <= City.highLimit) ? (byte)value : (byte)0; }
        }

        public  City(string cityName, byte coordX, byte coordY)
        {
            _name = cityName;
            _x = coordX;
            _y = coordY;
        }

        public void Afiseaza()
        {
            Console.WriteLine($"Oras = {_name}, X = {_x}, Y = {_y}");
        }
    }
}
