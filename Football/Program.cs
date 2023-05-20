// See https://aka.ms/new-console-template for more information
using Football;

Game game = new Game
{
    Referee = new Referee
    {
        Name = "Referee",
        Age = 34
    },
    AssistantOne = new Referee
    {
        Name = "Referee",
        Age = 34
    },
    AssistantTwo = new Referee
    {
        Name = "Referee",
        Age = 34
    }
};
game.TeamOne = new Team
{
    TeamName = "Barcelona",
    Coach = new Coach
    {
        Name = "Dimitar",
        Age = 41
    },
    Players = new List<FootballPlayer> 
    { 
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        }
    }
};

game.TeamTwo = new Team
{
    TeamName = "Manchester",
    Coach = new Coach
    {
        Name = "Dimitar",
        Age = 41
    },
    Players = new List<FootballPlayer>
    {
        new Striker
        {
            Name = "Georgi",
            Age = 23,
            Number = 2,
            Height = 178
        },
        new Striker
        {
            Name = "ALex",
            Age = 25,
            Number = 29,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        },
        new Striker
        {
            Name = "Petur",
            Age = 25,
            Number = 4,
            Height = 167
        },
        new Striker
        {
            Name = "Ivan",
            Age = 23,
            Number = 1,
            Height = 178
        }
    }
};

game.Winner = game.TeamTwo;

game.AddGoal(1, game.TeamTwo.Players[0]);
game.AddGoal(14, game.TeamOne.Players[0]);
game.AddGoal(45, game.TeamTwo.Players[1]);
game.AddGoal(67, game.TeamTwo.Players[1]);
game.AddGoal(89, game.TeamOne.Players[1]);

game.DisplayGoalsHistory();
