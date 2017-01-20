using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> players = new Dictionary<string, int>();
            InputPlayers(players);
            players = CalcScore(players);
            var player = players.OrderByDescending(p => p.Value).First();
            Console.WriteLine("The winner is {0} - {1} points",player.Key, player.Value);
        }

        private static Dictionary<string,int> CalcScore(Dictionary<string, int> players)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var player in players)
            {
                int score = 0;
                for (int i = 0; i < player.Key.Length; i++)
                {
                    if (player.Key[i] % 2 == 0)
                    {
                        score += (int)player.Key[i]; 
                    }
                    else
                    {
                        score -= (int)player.Key[i];

                    }
                }
                result[player.Key] = score+player.Value;
            }
            return result;
        }

        private static void InputPlayers(Dictionary<string, int> players)
        {
            int numOfPlayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfPlayers; i++)
            {
                string name = Console.ReadLine();
                int score = int.Parse(Console.ReadLine());
                players[name] = score;
            }
        }
    }
}
