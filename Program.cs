using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Goalkeeper { Name = "Boris", Number = 2, Age = 26, Height = 189 };
            var player2 = new Defender { Name = "Kris", Number = 18, Age = 22, Height = 190 };
            var player3 = new Midfield { Name = "Ivan", Number = 5, Age = 28, Height = 179 };
            var player4 = new Striker { Name = "Anton", Number = 11, Age = 25, Height = 184 };

            var coach = new Coach { Name = "Alex", Age = 45 };
            var team = new Team { Coach = coach, Players = new List<FootballPlayer> { player1, player2, player3, player4 } };
            double averageAge = team.AverageAge();


            var referee = new Referee { Name = "Mark", Age = 40 };



            var assistantReferee1 = new Referee { Name = "Nikolay", Age = 33 };
            var assistantReferee2 = new Referee { Name = "Pavel", Age = 30 };
            var assistantReferees = new List<Referee> { assistantReferee1, assistantReferee2 };

            var game = new Game
            {
                Team1 = team,
                Team2 = team,
                Referee = referee,
                AssistantReferees = assistantReferees
            };


            
            game.Result = "2-1";

            game.Winner = game.Team1;
            Console.WriteLine("Game result: " + game.Result);
            Console.WriteLine("Winner: " + game.Winner);
            Console.ReadKey();
        }
        
    }
}
