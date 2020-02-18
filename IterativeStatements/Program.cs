using System;

namespace IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 2 and 10:");

            try
            {
                string input = Console.ReadLine();
                int n = int.Parse(input);

                if (n % 2 == 0)
                {

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("You entered an even number." + i.ToString());

                    }

                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("You entered an odd number." + i.ToString());

                    }
                }
            }
            catch
            {
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
