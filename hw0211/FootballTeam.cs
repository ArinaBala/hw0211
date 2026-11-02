using System;
using System.Collections.Generic;
using System.Text;

namespace hw0211
{
    public class FootballTeam
    {
        public string TeamTitle
        {
            get;
            set;
        }
        private List<Player> ballKickers = new List<Player>();

        public FootballTeam(string teamTitle)
        {
            TeamTitle = teamTitle;
        }

        public void HirePlayer(Player guy)
        {
            ballKickers.Add(guy);
        }

        public void ShowLineup()
        {
            Console.WriteLine($"СОСТАВ КОМАНДЫ \"{TeamTitle}\"");
            if (ballKickers.Count == 0)
            {
                Console.WriteLine("Xa B команде пока нет игроков");
                return;
            }

            foreach (var guy in ballKickers)
            {
                guy.PrintPlayerCard();
            }
        }
    }
}
