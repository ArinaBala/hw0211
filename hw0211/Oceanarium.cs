using System;
using System.Collections.Generic;
using System.Net.ServerSentEvents;
using System.Text;

namespace hw0211
{
    public class Oceanarium
    {
        private List<seaItem> waterBrothers = new List<seaItem>();

        public void AddCreature(seaItem creature)
        {
            waterBrothers.Add(creature);
        }

        public void PrintAllCreatures()
        {
            Console.WriteLine(" ВСЕ ЖИТЕЛИ ОКЕАНАРИУМА");
            if (waterBrothers.Count == 0)
            {
                Console.WriteLine("Тут пока никого нет, вода пустая, xaxaxax");
                return;
            }

            foreach (var creature in waterBrothers)
            {
                creature.ShowInfo();
            }
        }
    }
}
