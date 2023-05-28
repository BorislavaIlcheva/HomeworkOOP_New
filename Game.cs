using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees { get; set; }
        public List<(int Minute, FootballPlayer Player)> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Game()
        {
            AssistantReferees = new List<Referee>();
            Goals = new List<(int Minute, FootballPlayer Player)>();
        }
    }
   

}
