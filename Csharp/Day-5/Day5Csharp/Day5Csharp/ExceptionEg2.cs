using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Csharp
{
    class ExceptionEg2
    {
        static void Main()
        {
            try
            {
                int[] marks = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter marks for subject {i + 1}: ");
                    string input = Console.ReadLine();
                    bool x = int.TryParse(input, out marks[i]);

                    if (!x)
                        throw new FormatException("Input must be a valid integer.");

                    if (marks[i] < 0 || marks[i] > 100)
                        throw new ArgumentOutOfRangeException(
                            $"Subject {i + 1}", marks[i], "Mark must be between 0 and 100.");
                }

                double average = marks.Average();
             
                Console.WriteLine($"Average:{average}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input Error: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Range Error: {ex.ParamName} - {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Grade calculation complete.");
            }
            Console.Read();
        }
    }
}
