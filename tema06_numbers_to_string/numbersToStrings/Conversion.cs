using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersToStrings
{
    public class Conversion
    {
        public int _digits;
        public int _tens;
        public int _hundreds;
        public int _thousands;

        public int Digits
        {
            get { return _digits; }
            set { _digits = value; }
        }

        public int Tens
        {
            get { return _tens; }
            set { _tens = value; }
        }

        public int Hundreds
        {
            get { return _hundreds; }
            set { _hundreds = value; }
        }

        public int Thousands
        {
            get { return _thousands; }
            set { _thousands = value; }
        }

        public Conversion(int a, int b, int c, int d)
        {
            _digits = a;
            _tens = b;
            _hundreds = c;
            _thousands = d;
        }

        public static string FindDigits(int elem)
        {
            string tempStr;
            switch (elem)
            {
                case 0:
                    tempStr = "";
                    break;
                case 1:
                    tempStr = "one";
                    break;
                case 2:
                    tempStr = "two";
                    break;
                case 3:
                    tempStr = "three";
                    break;
                case 4:
                    tempStr = "four";
                    break;
                case 5:
                    tempStr = "five";
                    break;
                case 6:
                    tempStr = "six";
                    break;
                case 7:
                    tempStr = "seven";
                    break;
                case 8:
                    tempStr = "eight";
                    break;
                case 9:
                    tempStr = "nine";
                    break;
                default:
                    tempStr = "Please provide as input 0...9";
                    break;
            }
            return tempStr;
        }
        public static string FindTensSmall(int elem)
        {
            string tempStr;

            if (elem < 10)
            {
                tempStr = FindDigits(elem);
            }
            else
            {
                switch (elem)
                {
                    case 10:
                        tempStr = "ten";
                        break;
                    case 11:
                        tempStr = "eleven";
                        break;
                    case 12:
                        tempStr = "twelve";
                        break;
                    case 13:
                        tempStr = "thirteen";
                        break;
                    case 14:
                        tempStr = "fourteen";
                        break;
                    case 15:
                        tempStr = "fifteen";
                        break;
                    case 16:
                        tempStr = "sixteen";
                        break;
                    case 17:
                        tempStr = "seventeen";
                        break;
                    case 18:
                        tempStr = "eightteen";
                        break;
                    case 19:
                        tempStr = "nineteen";
                        break;
                    default:
                        tempStr = "Please provide as input 10...19";
                        break;
                }
            }

            return tempStr;
        }

        public static string FindTensLarge(int elem)
        {
            int teensPart = elem / 10;

            string tempStr;
            string tempStr1;
            string tempStr2;

            switch (teensPart)
            {
                case 2:
                    tempStr1 = "twenty";
                    break;
                case 3:
                    tempStr1 = "thirdy";
                    break;
                case 4:
                    tempStr1 = "forthy";
                    break;
                case 5:
                    tempStr1 = "fifthy";
                    break;
                case 6:
                    tempStr1 = "sixthy";
                    break;
                case 7:
                    tempStr1 = "seventhy";
                    break;
                case 8:
                    tempStr1 = "eighty";
                    break;
                case 9:
                    tempStr1 = "ninethy";
                    break;
                default:
                    tempStr1 = "";
                    break;
            }
            
            if ((elem % 10 == 0) && (elem > 10))
            {
                tempStr = tempStr1;
            }
            else
            {
                tempStr2 = FindDigits(elem - teensPart * 10);
                if (tempStr1 == "")
                {
                    tempStr = FindTensSmall(elem);
                } 
                else
                {
                    tempStr = tempStr1 + "-" + tempStr2;
                }
            }

            return tempStr;
        }

        public static string FindHundreds(int elem)
        {
            int hundredsPart = elem / 100;

            string tempStr;
            string tempStr1;
            string tempStr2;

            tempStr1 = FindDigits(hundredsPart);

            if (elem < 100)
            {
                tempStr = FindTensLarge(elem);
            }
            else if (elem % 100 == 0)
            {
                if (hundredsPart == 1)
                {
                    tempStr = tempStr1 + " " + "hundred";
                } 
                else 
                {
                    tempStr = tempStr1 + " " + "hundreds";
                }
            }
            else
            {
                if (hundredsPart == 1)
                {
                    tempStr2 = FindTensLarge(elem - hundredsPart * 100);
                    tempStr = tempStr1 + " " + "hundred" + " " + tempStr2;
                } 
                else
                {
                    tempStr2 = FindTensLarge(elem - hundredsPart * 100);
                    tempStr = tempStr1 + " " + "hundreds" + " " + tempStr2;
                }
            }

            return tempStr;
        }

        public static string FindThousands(int elem)
        {
            int thousandsPart = elem / 1000;

            string tempStr;
            string tempStr1;
            string tempStr2;

            tempStr1 = FindDigits(thousandsPart);

            if (elem % 1000 == 0)
            {
                if (thousandsPart == 1)
                {
                    tempStr = tempStr1 + " " + "thousand";
                } 
                else
                {
                    tempStr = tempStr1 + " " + "thousands";
                } 
            }
            else
            {
                if (thousandsPart == 1)
                {
                    tempStr2 = FindHundreds(elem - thousandsPart * 1000);
                    tempStr = tempStr1 + " " + "thousand" + " " + tempStr2;
                } 
                else
                {
                    tempStr2 = FindHundreds(elem - thousandsPart * 1000);
                    tempStr = tempStr1 + " " + "thousands" + " " + tempStr2;
                }
                
            }

            return tempStr;
        }
    }
}
