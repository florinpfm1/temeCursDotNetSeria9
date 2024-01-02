namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   Array with min and max elements - singledimension array     %%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Please enter how many items the array has:");
            int arrItems = int.Parse(Console.ReadLine());

            int[] array1 = new int[arrItems];

            Console.WriteLine($"Next please enter the elements of the array:");
            for (int i = 0; i < arrItems; i++)
            {
                Console.WriteLine($"Please enter element {i+1}");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements of the array entered are:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            int minItemValue = array1[0];
            int maxItemValue = array1[0];

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < minItemValue)
                {
                    minItemValue = array1[i];
                }

                if (array1[i] > maxItemValue)
                {
                    maxItemValue = array1[i];
                }
            }
            Console.WriteLine($"Max value for array elements is {maxItemValue}");
            Console.WriteLine($"Min value for array elements is {minItemValue}");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of - Array with min and max elements - singledimension array     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
