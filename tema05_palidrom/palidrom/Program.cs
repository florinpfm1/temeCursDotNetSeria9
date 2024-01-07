using System.Text;

namespace palidrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   palidrom    %%%%%%%%%%%%%%%%%%%");

            Console.WriteLine("Enter the text you want to check for palidrom:");
            string input = Console.ReadLine();    //save input
            
            foreach (char c in input)   //removing white spaces and all not-letter characters from input string
            {
                int currentElem = (int)c;
                if (!(((65 <= currentElem) && (currentElem <= 87)) || ((97 <= currentElem) && (currentElem <= 119)))) {
                    input = input.Remove(input.IndexOf(c), 1);
                }
            }

            int length = input.Length;  //save length of text without special characters

            string input1;              //splitting input text in two equal strings
            string input2;
            if (length % 2 == 0)
            {
                input1 = input.Substring(0, length/2);
                input2 = input.Substring(length / 2);
            } else
            {
                input1 = input.Substring(0, length/2);
                input2 = input.Substring(length / 2 + 1);
            }

            StringBuilder sbinput2 = new StringBuilder();   //reversing string input2
            for (int i = input2.Length-1; i>= 0; i--)
            {
                sbinput2.Append(input2[i]);
            }

            string input2reversed = sbinput2.ToString();

            //Console.WriteLine($"Your input without white spaces and special characters is: \n{input}");
            //Console.WriteLine($"input1 is: {input1}");
            //Console.WriteLine($"input2 is: {input2}");
            //Console.WriteLine($"input2 reversed is: {input2reversed}");

            if (input1.Equals(input2reversed))          //comparing first half of text with reversed second half of text
            {
                Console.WriteLine("Congratulations! Your text is indeed a palidrom !");
            }
            else
            {
                Console.WriteLine("Sorry, your text is not a palidrom.");
            }

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of palidrom     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
