namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   Array with min and max elements - multidimension array     %%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Please enter how many rows the array has:");
            int arrRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many columns the array has:");
            int arrColumns = int.Parse(Console.ReadLine());

            int[,] array1 = new int[arrRows, arrColumns];

            
            for (int i = 0; i < arrRows; i++)
            {
                Console.WriteLine($"Next please enter the elements of the array with space between them for row {i+1}");
                string[] itemsRow = Console.ReadLine().Split(' ');
                for (int j = 0; j < arrColumns; j++)
                {
                    array1[i,j] = int.Parse(itemsRow[j]);
                }
            }

            Console.WriteLine("The elements of the array entered are:");
            for (int i = 0; i < arrRows; i++)
            {
                for (int j = 0; j < arrColumns; j++)
                {
                    Console.WriteLine(array1[i,j]);
                }
            }

            int minItemValue = array1[0,0];
            int maxItemValue = array1[0,0];

            for (int i = 0; i < arrRows; i++)
            {
                for (int j = 0; j < arrColumns; j++)
                {
                    if (array1[i,j] < minItemValue)
                    {
                        minItemValue = array1[i,j];
                    }

                    if (array1[i, j] > maxItemValue)
                    {
                        maxItemValue = array1[i, j];
                    }
                }
            }
            Console.WriteLine($"Max value for array elements is {maxItemValue}");
            Console.WriteLine($"Min value for array elements is {minItemValue}");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of - Array with min and max elements - multidimension array     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
