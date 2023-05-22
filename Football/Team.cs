namespace Football
{
    class Team
    {
        private FootballPlayer[] players;

        public string TeamName { get; set; }
        public Coach Coach { get; set; }
        public FootballPlayer[] Players 
        {
            get => this.players;
            set
            {
                if (value.Length < 11 || value.Length > 22)
                    throw new ArgumentException("The team must have between 11 and 22 players.");

                this.players = value;
            }
        }
        public double AverageAge { get => Players.Average(player => player.Age); }
    }
}
