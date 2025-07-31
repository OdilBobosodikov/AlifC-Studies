using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.TaskSet3.Task3
{
    public class BasketballPlayer : IPlayer
    {
        public string Name { get; protected set; }
        public int Number { get; protected set; }
        public string Team { get; protected set; }
        public string Position { get; protected set; }
        public int Score { get; protected set; }
        public int Assists { get; protected set; }

        public BasketballPlayer(string name, int number, string team, string position)
        {
            Name = name;
            Number = number;
            Team = team;
            Position = position;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nTeam: {Team}\nNumber: {Number}\nPosition: {Position}\nScore: {Score}\nAssists: {Assists}");
        }

        public void ScorePoint()
        {
            Console.WriteLine("2 points scored!");
            Score += 2;
        }

        public void AssistTo(IPlayer player)
        {
            if (player is BasketballPlayer teammate)
            {
                teammate.Score += 2;
                Assists += 1;
                Console.WriteLine($"Assisted {teammate.Name} (#{teammate.Number}) for a basket.");
            }
        }
    }
}
