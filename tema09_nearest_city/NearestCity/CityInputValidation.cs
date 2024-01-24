using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestCity
{
    static class CityInputValidation
    {
        public static bool CityValidation(string cityInput)
        {
            bool validationStatus = true;
            if (String.IsNullOrEmpty(cityInput))
            {
                validationStatus = false;
            } 
            else
            {
                foreach (char c in cityInput)   //removing white spaces and all not-letter characters from input string
                {
                    int currentElem = (int)c;
                    if ( !(((65 <= currentElem) && (currentElem <= 90)) || ((97 <= currentElem) && (currentElem <= 122))) )
                    {
                        validationStatus = false;
                        break;
                    }
                }
            }
            return validationStatus;
        }

        public static bool CoordonateValidation(byte cityCoordonate)
        {
            bool validationStatus = ((byte)0 <= cityCoordonate && cityCoordonate <= (byte)10) ? true : false;
            return validationStatus;
        }
        
        public static bool ExistingCoordinates(byte cityCoordonateX, byte cityCoordonateY, City[] existingCities )
        {

            bool validationStatus = true;
            foreach (City existingCity in existingCities)
            {
                if (existingCity != null && existingCity.X == cityCoordonateX && existingCity.Y == cityCoordonateY)
                {
                    validationStatus = false;
                    break;
                }
            }
            return validationStatus;
        }
    }
}
