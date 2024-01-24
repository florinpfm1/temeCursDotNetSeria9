using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestCity
{
    static class DistanceCalculator //is a helper class
    {
        public static double CalculeazaDistanta(City city1, City city2)
        {
            return Math.Sqrt(Math.Pow(city1.X - city2.X, 2) + Math.Pow(city1.Y - city2.Y, 2)); 
        }
    }
}
