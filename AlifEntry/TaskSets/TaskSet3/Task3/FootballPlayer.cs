using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AlifEntry.TaskSets.TaskSet3.Task3
{
    public class FootballPlayer : IPlayer
    {

        public string Name { get; protected set; }
        public int Number { get; protected set; }
        public string Team { get; protected set; }
        public string Position { get; protected set; }
        public int Score { get; protected set; }
        public int Assists { get; protected set; }


        public FootballPlayer(string name, int number, string team, string position)
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
            Console.WriteLine("GOOOOOOOL!");
            Score += 1;
        }

        public void AssistTo(IPlayer player)
        {
            if (player is FootballPlayer teammate)
            {
                teammate.Score += 1;
                Assists += 1;
                Console.WriteLine($"Helped {teammate.Name} with number {teammate.Number} to score.");
            }
        }
    }
}
