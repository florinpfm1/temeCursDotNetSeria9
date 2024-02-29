using System.Xml.Linq;

namespace DogWithExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   dog with exceptions assignment    %%%%%%%%%%%%%%%%%%%");

            Console.WriteLine("Enter the name of the dog:");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Enter the age of the dog:");
            string ageInput = Console.ReadLine();

            try
            {
                sbyte ageInputAsSByte = Convert.ToSByte(ageInput);
                Dog myDog = new Dog { Name = nameInput, Age = ageInputAsSByte };
                Console.WriteLine("No validation errors are present.");
                Console.WriteLine($"Name for dog is: {myDog.Name}");
                Console.WriteLine($"Age for dog is: {myDog.Age}");
            }
            catch (ApplicationException ex1)
            {
                Console.WriteLine("Error: " + ex1.Message);
            }
            catch (ArgumentException ex2)
            {
                Console.WriteLine("Error: " + ex2.Message);
            }
            catch
            {
                Console.WriteLine("Error: unexpected type. Contact admin.");
                throw;
            }

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of dog with exceptions assignment    %%%%%%%%%%%%%%%%%%%");
        }
    }
}
