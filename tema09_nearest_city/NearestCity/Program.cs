namespace NearestCity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   nearest city    %%%%%%%%%%%%%%%%%%%");

            Console.WriteLine("How many cities do you want to define ? Please enter a number between 5 and 255.");
            byte number = 0;
            string numString = Console.ReadLine();
            bool canConvert = byte.TryParse(numString, out number);

            if ( canConvert == true && byte.Parse(numString) >= (byte)5 )
            {
                byte numberOfCities = byte.Parse(numString);
                City[] citiesArr = new City[numberOfCities];

                for (int i = 0; i < numberOfCities; i++)
                {
                    Console.WriteLine("Enter details of each city in format <city_name><SPACE><coordinate_x><SPACE><coordinate_y>. At least 5 cities are needed. Each name should contain only english alphabet small or capital letters without spaces or special symbols. Each coordinate is between 0 and 10");

                    string input = Console.ReadLine();    //save input+

                    if (CityInputValidation.CityValidation(input))
                    {
                        Console.WriteLine("Validation Error: City details cannot be empty string or null.");
                        i--;
                    }
                    else
                    {
                        string[] detailsOfCity = input.Split(' ');
                        bool myBool = detailsOfCity.Length < 2;
                        if (detailsOfCity.Length < 3)
                        {
                            Console.WriteLine("Validation Error: City does not have enough infos. Try again.");
                            i--;
                        }
                        else if (detailsOfCity.Length > 3)
                        {
                            Console.WriteLine("Validation Error: City does not have enough infos. Try again.");
                            i--;
                        }
                        else
                        {
                            var name = detailsOfCity[0];
                            var x = detailsOfCity[1];
                            var y = detailsOfCity[2];

                            if (CityInputValidation.CityValidation(name) && CityInputValidation.CoordonateValidation(Convert.ToByte(x)) && CityInputValidation.CoordonateValidation(Convert.ToByte(y)))
                            {
                                if (CityInputValidation.ExistingCoordinates(Convert.ToByte(x), Convert.ToByte(y), citiesArr) )
                                {
                                    City city = new City(name, Convert.ToByte(x), Convert.ToByte(y));
                                    citiesArr[i] = city;
                                }
                                else
                                {
                                    Console.WriteLine("Validation Error: City coordinates already exist in table. Try again.");
                                    i--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Validation Error: City details format is invalid. Try again.");
                                i--;
                            }
                        }
                    }
                }

                Console.WriteLine("The cities entered are:");
                foreach (City currentCity in citiesArr)
                {
                    currentCity.Afiseaza();
                }

                Console.WriteLine("Choose the reference city to calculate distances:");
                string refCity = Console.ReadLine();
                City finalRefCity = null;

                for (int i = 0; i < citiesArr.Length; i++)
                {
                    if (refCity == citiesArr[i].Name)
                    {
                        finalRefCity = citiesArr[i];
                        break;
                    }
                    else
                    {
                        finalRefCity = null;
                    }
                }

                if (finalRefCity == null)
                {
                    Console.WriteLine("Validation Error: The city you entered is not part of the existing cities in the table.");
                }
                else
                {
                    double distMin = 1000;
                    string closestCity = citiesArr[0].Name;
                    foreach (City currentCity in citiesArr)
                    {
                        double distance = DistanceCalculator.CalculeazaDistanta(finalRefCity, currentCity);

                        if (distance != 0)
                        {
                            Console.WriteLine($"Distance between {finalRefCity.Name} and {currentCity.Name} is: {distance}");
                        }

                        if (distance != 0 && distance < distMin)
                        {
                            distMin = distance;
                            closestCity = currentCity.Name;
                        }
                    }

                    Console.WriteLine($"The nearest city to {refCity} is: {closestCity}");
                }
            }
            else
            {
                Console.WriteLine("Validation Error: Please choose a number of cities to define between 5 and 255.");
            }
            
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of nearest city     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
