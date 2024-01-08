namespace FindNumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   find number in array    %%%%%%%%%%%%%%%%%%%");

            Console.WriteLine("Enter a number:");
            double input = Convert.ToDouble(Console.ReadLine());    //save input

            double[] myArr = new double[] { 5, -101.99, 0.596, -55.5, 8889.5982, 25, 8554629885631.5874122 };


            int counter = 0;
            foreach (double d in myArr)
            {
                counter++;
                //Console.WriteLine(counter);
                if (d != input)
                {
                    if (counter == myArr.Length)
                    {
                        Console.WriteLine("Your number was NOT found in the array.");
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine($"Your number was found at index {counter - 1} in the array.");
                    break;
                }
            }   

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of find number in array    %%%%%%%%%%%%%%%%%%%");
        }
    }
}
