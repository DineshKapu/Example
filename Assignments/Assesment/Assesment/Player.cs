using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assesment
{

    public class Player
    {
        public int Score { get; set; }
        public Player(int score)
        {
            Score = score;
        }
        public static bool operator ==(Player x1, Player x2)
        {
            if (ReferenceEquals(x1, x2)) 
                return true;
            if (x1 is null || x2 is null)
                return false;
            return x1.Score == x2.Score;
        }
        public static bool operator !=(Player x1, Player x2)
        {
            return !(x1 == x2);
        }
        public override bool Equals(object obj)
        {
            if (obj is  Player other)
             return this.Score == other.Score;
            return false;
        }
        public int CompareTo(Player other)
        {
            if (other == null)
                return 1; 
            return Score.CompareTo(other.Score);
        }

       public override string ToString()
        {
            return $"{Score}";
        }
    }

    class ScoreCompare
    {
        static void Main()
        {
            Player p1 = new Player(100);
            Player p2 = new Player(100);
            Player p3 = new Player(200);
            Player p4 = new Player(50);
            Console.WriteLine($"Is p1 == p2 :{p1 == p2}"); // True (same score)
            Console.WriteLine($"Is p1 == p3 :{p1 == p3}"); // False (different score)
            Console.WriteLine($"Is p1!= p4 :{p1!=p4}"); // True(different score)
            Console.WriteLine($"Is p1.Equals(p2):{p1.Equals(p2)}"); // True
            Console.WriteLine($"Is p1.Equals(p3): {p1.Equals(p3)}"); // False
            List<Player> leaderboard = new List<Player> {p1,p2,p3,p4};
            leaderboard.Sort((x1, x2) => x2.CompareTo(x1));
            Console.WriteLine("------Leaderboard(High Score-Low Score)------");
            foreach (var i in leaderboard)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
   
}
