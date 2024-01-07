using System.Text;

namespace ROT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   ROT3 cypher    %%%%%%%%%%%%%%%%%%%");

            Console.WriteLine("Enter the text you want to cypher with ROT3:");
            StringBuilder input = new StringBuilder(Console.ReadLine());    //save input as StringBuilder

            int length = input.Length;  //save length of text
            for (int i = 0;  i < length; i++)
            {

                int currentElem = (int)input[i];
                //Console.WriteLine(currentElem);       //current processed character as integer
                //Console.WriteLine(currentElem + 3);   //transformed current processed character
                switch (currentElem)
                {
                    case 88:                        //exception characters because they are at the back of alpfabeth
                        input.Append((char)65);     //use Append to add transformed characters
                        break;
                    case 89:
                        input.Append((char)66);
                        break;
                    case 90:
                        input.Append((char)67);
                        break;
                    case 120:
                        input.Append((char)97);
                        break;
                    case 121:
                        input.Append((char)98);
                        break;
                    case 122:
                        input.Append((char)99);
                        break;
                    default:
                        if (((65 <= currentElem) && (currentElem <= 87)) || ((97 <= currentElem) && (currentElem <= 119)))     //all characters transformation without exception characters from above
                        {
                            input.Append((char)(currentElem + 3));
                        }
                        else           //for all non-letter characters to be exempted from transformation
                        {
                            input.Append((char)currentElem);
                        }
                        break;
                }
            }

            input.Remove(0, length);    //use Remove to remove original text
            Console.WriteLine($"Your text transformed with ROT3 cypher is:\n{input.ToString()}");

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of ROT3 cypher     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
