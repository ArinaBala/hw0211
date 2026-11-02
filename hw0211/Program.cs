namespace hw0211
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Oceanarium myAquaPark = new Oceanarium();

            Shark mrBitey = new Shark("Зубастик", 350);
            Dolphin flipperBro = new Dolphin("Флер", 42.0);
            Octopus tentaclesBro = new Octopus("Пауль", 8);

            myAquaPark.AddCreature(mrBitey);
            myAquaPark.AddCreature(flipperBro);
            myAquaPark.AddCreature(tentaclesBro);

            myAquaPark.PrintAllCreatures();

            Console.WriteLine();

       
            FootballTeam dreamTeam = new FootballTeam("Реал Макарони");

            Player goalKeeper = new Player("Жора Вратарь", 1, "Вратарь");
            Player topForward = new Player("Вася Голеадор", 9, "Нападающий");
            Player midfieldBoss = new Player("Иван Пас", 10, "Полузащитник");

            dreamTeam.HirePlayer(goalKeeper);
            dreamTeam.HirePlayer(topForward);
            dreamTeam.HirePlayer(midfieldBoss);

            dreamTeam.ShowLineup();
        }
    }
}
