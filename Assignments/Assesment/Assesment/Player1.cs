using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    class Player1
    {
        public int Score { get; set; }
        public Player1(int score)
        {
            Score = score;
        }
    }
    class PlayerTest
    {
        static void Main()
        {
            Player1 score1 = new Player1(10);
            Player1 score2 = new Player1(10);

            Console.WriteLine($"The score is equal{score1 == score2}");
            Console.WriteLine($"The score is equal  {score1.Equals(score2)}");

            Console.WriteLine($"The score is equal {Object.ReferenceEquals(score1, score2)}");

            Console.WriteLine("--------------------------------");
            int str1 = 10;
            int str2 = 20;
            Console.WriteLine($"str1==str2 :{str1 == str2}"); 
            Console.WriteLine($"str1.Equals(str2) :{str1.Equals(str2)}");
            Console.WriteLine(Object.ReferenceEquals(str1, str2));
            Console.WriteLine(str1.CompareTo(str2));

            Console.ReadLine();


        }
    }
}
