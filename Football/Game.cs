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
                if (value.Players.Length != 11)
                    throw new ArgumentException("The players should be exactly 11.");

                this.teamOne = value;
            }
        }
        public Team TeamTwo
        {
            get => this.teamTwo;
            set
            {
                if (value.Players.Length != 11)
                    throw new ArgumentException("The players should be exactly 11.");

                this.teamTwo = value;
            }
        }
        public Referee Referee { get; set; }
        public Referee AssistantOne { get; set; }
        public Referee AssistantTwo { get; set; }
        public Dictionary<int, FootballPlayer> Goals { get; private set; }
        public string GameResult 
        { 
            get => $"{GoalsOfTeamOne}" +
                $" - " +
                $"{GoalsOfTeamTwo}";
        }
        public Team Winner 
        {
            get => GoalsOfTeamOne > GoalsOfTeamTwo ? TeamOne : TeamTwo;
        }

        public int GoalsOfTeamOne { get => Goals.Where(player => TeamOne.Players.Contains(player.Value)).Count(); }
        public int GoalsOfTeamTwo { get => Goals.Where(player => TeamTwo.Players.Contains(player.Value)).Count(); }

        public Game()
        {
            Goals = new Dictionary<int, FootballPlayer>();
        }

        public void DisplayGoalsHistory()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"{TeamOne.TeamName} vs {TeamTwo.TeamName}");
            Console.WriteLine(new string('-', 50));

            foreach (var goal in Goals)
            {
                Console.WriteLine($"In the {goal.Key} minute {goal.Value.Name} with number {goal.Value.Number} scored a goal for {FindTeamName(goal.Value)}");
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Final result: {GameResult}");


            Console.WriteLine(GoalsOfTeamOne == GoalsOfTeamTwo
                ? "There is no winner, there is draw"
                : $"The winner is {Winner.TeamName}");

            Console.WriteLine(new string('-', 50));
        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            if (!TeamOne.Players.Contains(player) && !TeamTwo.Players.Contains(player))
                throw new ArgumentException("This player is not a part of neither of the teams.");

            Goals.Add(minute, player);
        }

        private string FindTeamName(FootballPlayer player)
        {
            if (TeamOne.Players.Contains(player))
                return TeamOne.TeamName;
            
            return TeamTwo.TeamName;
        }
    }
}
