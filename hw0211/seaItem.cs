using System;
using System.Collections.Generic;
using System.Text;

namespace hw0211
{
    
        public class seaItem
        {
            public string Nickname 
        {
            get;
            set; 
        }
            public string WhatKind 
        {
            get;
            set;
        }

            public seaItem(string nickname, string whatKind)
            {
                Nickname = nickname;
                WhatKind = whatKind;
            }

            public virtual void ShowInfo()
            {
                Console.WriteLine($"{WhatKind}: {Nickname}");
            }
        }

        public class Shark : seaItem
        {
            public int SharpTeeth 
        {
            get;
            set;
        }

            public Shark(string nickname, int sharpTeeth) : base(nickname, "Акула")
            {
                SharpTeeth = sharpTeeth;
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"Акула по кличке {Nickname}, количество зубов: {SharpTeeth}");
            }
        }

        public class Dolphin : seaItem
        {
            public double SwimSpeed 
        {
            get;
            set;
        }

            public Dolphin(string nickname, double swimSpeed) : base(nickname, "Дельфин")
            {
                SwimSpeed = swimSpeed;
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"Дельфин {Nickname}, разгоняется до {SwimSpeed} км/ч");
            }
        }

        public class Octopus : seaItem
        {
        public int TentaclesCount
        {
            get;
            set;
        }


        public Octopus(string nickname, int tentaclesCount) : base(nickname, "Осьминог")

        {
            TentaclesCount = tentaclesCount;
        }

            public override void ShowInfo()
            {
                Console.WriteLine($"Осьминог {Nickname}, имеет {TentaclesCount} щупалец");
            }
        }
}

