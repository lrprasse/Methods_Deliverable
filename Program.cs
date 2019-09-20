using System;

namespace Methods_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter your first and last name: ");
                String name = Console.ReadLine();

                string modifiedname = LAST_Name(name);
                Print_Name(modifiedname);
            }
            catch
            {
                Console.WriteLine("Uh oh! It looks like something didn't go as planned. Please" +
                    "restart the program and try again.");
            }
        }

        // this method capitalizes only the last name and returns as a single string
        private static string LAST_Name(string name)
        {
            string[] first_last = new string[1];
            first_last = name.Split(' ');

            first_last[1] = first_last[1].ToUpper();

            string fullname = first_last[0];
            fullname += " ";
            fullname += first_last[1];

            return fullname;
        }
        private static void Print_Name(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }
    }
}
