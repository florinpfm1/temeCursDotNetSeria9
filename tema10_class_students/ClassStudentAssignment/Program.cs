using System.Collections;

namespace ClassStudentAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   class student assignment    %%%%%%%%%%%%%%%%%%%");
            List<Student> myCollection = new List<Student>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please insert student's name and age (18...99) with a white space between them: ");
                string inputStr = Console.ReadLine();
                string trimmedInputStr = inputStr.Trim();
                string[] studentDetails = trimmedInputStr.Split(' ');
                Student person = new Student(int.Parse(studentDetails[1]), studentDetails[0]);
                myCollection.Add(person);
            }

            foreach (Student item in myCollection)
            {
                Console.WriteLine(item.Info);
            }

            foreach (Student item in myCollection)
            {
                Console.WriteLine($"Please insert student's {item.Name} mark or write 'pass' to move to next student: ");
                string input = Console.ReadLine();
                if (input == "pass")
                {
                    item.Mark = null;
                }
                else
                {
                    item.Mark = int.Parse(input);
                }
            }

            int counter = 0;
            int sum = 0;
            foreach (Student item in myCollection)
            {
                if (item.Mark.HasValue)
                {
                    counter++;
                    sum += (int)item.Mark;

                }
            }

            Console.WriteLine($"Average mark of all students is {sum/counter}");

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of class student assignment     %%%%%%%%%%%%%%%%%%%");
        }
    }
}
