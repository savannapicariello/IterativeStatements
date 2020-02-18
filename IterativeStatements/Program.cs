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

                    for (int i = 0; i < n+1; i++)
                    {
                        Console.WriteLine(i.ToString()+"." + "You entered an even number.");

                    }

                }
                else
                {
                    for (int i = 0; i < n-1; i++)
                    {
                        Console.WriteLine(i.ToString()+ "." + "You entered an odd number.");

                    }
                }
            }
            catch
            {
               
            }
        }
    }
}
