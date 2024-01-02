namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   Array of strings - min and max elements - singledimension array     %%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Please enter how many items the array has:");
            int arrItems = int.Parse(Console.ReadLine());

            string[] array2 = new string[arrItems];

            Console.WriteLine($"Next please enter the elements of the array:");
            for (int i = 0; i < arrItems; i++)
            {
                Console.WriteLine($"Please enter element {i+1}:");
                array2[i] = Console.ReadLine();
            }

            Console.WriteLine("The elements of the array entered are:");
            foreach (string item in array2)
            {
                Console.Write(item + " ");
            }

            int minItemValue = array2[0].Length;
            int maxItemValue = array2[0].Length;

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i].Length < minItemValue)
                {
                    minItemValue = array2[i].Length;
                }

                if (array2[i].Length > maxItemValue)
                {
                    maxItemValue = array2[i].Length;
                }
            }
            Console.WriteLine($"\nMax length for an array elements is: {maxItemValue}");
            Console.WriteLine($"Min length for an array elements is: {minItemValue}");

            int counterForMin = 0;
            int counterForMax = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i].Length == minItemValue)
                {
                    counterForMin++;
                }

                if (array2[i].Length == maxItemValue)
                {
                    counterForMax++;
                }
            }

            Console.WriteLine($"Total number for elements with max length is: {counterForMax}");
            Console.WriteLine($"Total number for elements with min length is: {counterForMin}");

            string[] itemsWithMaxLength = new string[counterForMax];
            string[] itemsWithMinLength = new string[counterForMin];

            int cnt1 = 0;
            int cnt2 = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i].Length != minItemValue)
                {
                    continue;
                }
                itemsWithMinLength[cnt1] = array2[i];
                cnt1++;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i].Length != maxItemValue)
                {
                    continue;
                }
                itemsWithMaxLength[cnt2] = array2[i];
                cnt2++;
            }

            Console.WriteLine("Array elements with max length are:");
            foreach (string item in itemsWithMaxLength)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nArray elements with min length are:");
            foreach (string item in itemsWithMinLength)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%%   End of - Array of strings - min and max elements - singledimension array     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
