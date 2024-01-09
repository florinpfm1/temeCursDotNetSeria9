namespace HideEmail
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   hide email   %%%%%%%%%%%%%%%%%%%");

            Console.WriteLine("Enter your email:");
            string input = Console.ReadLine();    //save input

            string[] separatorOccurences = input.Split('@');

            if (input.Length == 0)
            {
                Console.WriteLine("Try again. Validation error: no email was entered.");
            }
            else if (input.IndexOf(' ') >= 0)
            {
                Console.WriteLine("Try again. Validation error: email should not contain any white spaces.");
            }
            else if (separatorOccurences.Length != 2 )
            {
                Console.WriteLine("Try again. Validation error: email should contain only one @ separator.");
            }
            else
            {
                int separatorIndex = input.IndexOf("@");
                string username = input.Substring(0, separatorIndex);
                string domain = input.Substring(separatorIndex);

                StringBuilder usernameHidden = new StringBuilder(username);

                for (int i = 0; i < separatorIndex; i++)
                {
                    usernameHidden.Append('*');
                    usernameHidden.Remove(0, 1);
                }

                Console.WriteLine($"Your email with hidden username is: \n{string.Concat(usernameHidden.ToString(), domain)}");
            }

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of hide email   %%%%%%%%%%%%%%%%%%%");
        }
    }
}
