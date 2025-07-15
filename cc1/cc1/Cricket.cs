using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    public class Cricket
    {
        public static void CalculatePoints(int No_Of_Matches)
        {
            var Scores = new List<int>();

            for (int i = 1; i <= No_Of_Matches; i++)
            {
                Console.Write($"Enter Score for Match {i}: ");

                if (int.TryParse(Console.ReadLine(), out int score))
                {
                    Scores.Add(score);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please Enter a Valid Integer Score.");
                    i--; // Retry current match
                }
            }

            int TotalScore = 0;
            foreach (int score in Scores)
            {
                TotalScore += score;
            }

            double averageScore = No_Of_Matches > 0 ? (double)TotalScore / No_Of_Matches : 0;

            Console.WriteLine($"Total Score: {TotalScore}");
            Console.WriteLine($"Average Score: {averageScore:F3}"); //It Displays Output Upto 3 Decimals.Eg:3.333
        }
        class Question2
        {
            public static void Main(string[] args)
            {
            Check: //label
                Console.Write("Enter the number of matches: ");
                if (int.TryParse(Console.ReadLine(), out int No_Of_Matches) && No_Of_Matches >= 0)
                {
                    Cricket.CalculatePoints(No_Of_Matches);
                }
                else
                {
                    Console.WriteLine("Invalid Number of Matches.Try Again!..");
                    goto Check; //goto statement
                }

                Console.WriteLine("Press Any Key to exit...");
                Console.Read();
            }
        }
    }
}
