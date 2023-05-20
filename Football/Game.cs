namespace Football
{
    class Game
    {
        private Team teamOne, teamTwo;

        public Team TeamOne 
        {
            get => this.teamOne;
            set
            {
                if (value.Players.Count != 11)
                    throw new ArgumentException("The players should be exactly 11.");

                this.teamOne = value;
            }
        }
        public Team TeamTwo
        {
            get => this.teamTwo;
            set
            {
                if (value.Players.Count != 11)
                    throw new ArgumentException("The players should be exactly 11.");

                this.teamTwo = value;
            }
        }
        public Referee Referee { get; set; }
        public Referee AssistantOne { get; set; }
        public Referee AssistantTwo { get; set; }
        public Dictionary<int, FootballPlayer> Goals { get; set; }
        public string GameResult 
        { 
            get => $"{Goals.Where(player => TeamOne.Players.Contains(player.Value)).Count()}" +
                $" - " +
                $"{Goals.Where(player => TeamTwo.Players.Contains(player.Value)).Count()}";
        }
        public Team Winner { get; set; }

        public Game()
        {
            Goals = new Dictionary<int, FootballPlayer>();
        }

        public void DisplayGoalsHistory()
        {
            Console.WriteLine(new string('-', 10));
            Console.WriteLine($"{TeamOne.TeamName} vs {TeamTwo.TeamName}");
            Console.WriteLine(new string('-', 10));

            foreach (var goal in Goals)
            {
                Console.WriteLine($"In the {goal.Key} minute {goal.Value.Name} with number {goal.Value.Number} scored a goal for {FindTeamName(goal.Value)}");
            }

            Console.WriteLine(new string('-', 10));
            Console.WriteLine($"Final result: {GameResult}");
            Console.WriteLine($"The winner is {Winner.TeamName}");
            Console.WriteLine(new string('-', 10));
        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            Goals.Add(minute, player);
        }

        private string FindTeamName(FootballPlayer player)
        {
            if (TeamOne.Players.Contains(player))
                return TeamOne.TeamName;
            else if (TeamTwo.Players.Contains(player))
                return TeamTwo.TeamName;
            else return "There is something wrong with this goal...";
        }
    }
}
