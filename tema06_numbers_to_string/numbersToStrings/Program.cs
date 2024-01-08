using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace numbersToStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   numbers to strings    %%%%%%%%%%%%%%%%%%%");

            Console.WriteLine("Please enter a positive number between 0 and 9999 without \'+\' sign or group separator \'.\' or white spaces:");
            int input = int.Parse(Console.ReadLine());    //save input

            if (input < 0) {
                Console.WriteLine("Invalid number. Error description: \'Value must be positive\'");
            } else if (input == 0) {
                Console.WriteLine("zero");
            } else if (input < 10) {
                string finalName = Conversion.FindDigits(input);
                Console.WriteLine(finalName);
            } else if (input < 20) {
                string finalName = Conversion.FindTensSmall(input);
                Console.WriteLine(finalName);
            } else if (input < 100) {
                string finalName = Conversion.FindTensLarge(input);
                Console.WriteLine(finalName);
            } else if (input < 1000) {
                string finalName = Conversion.FindHundreds(input);
                Console.WriteLine(finalName);
            } else if (input <= 9999) {
                string finalName = Conversion.FindThousands(input);
                Console.WriteLine(finalName);
            } else {
                Console.WriteLine("Invalid number. Error description: \'Value must be smaller than 10000\'");
            }

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of numbers to strings     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
