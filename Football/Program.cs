using Football;

try
{
    FootballPlayer[] playersFromTeamOne =
    {
        new Striker
        {
            Name = "Ivan Ivanov",
            Age = 24,
            Number = 1,
            Height = 174
        },
        new Striker
        {
            Name = "Petur Ivanov",
            Age = 27,
            Number = 2,
            Height = 168
        },
        new Striker
        {
            Name = "Ivan Nikolov",
            Age = 21,
            Number = 3,
            Height = 172
        },
        new Midfield
        {
            Name = "Nikolay Ivanov",
            Age = 29,
            Number = 4,
            Height = 182
        },
        new Midfield
        {
            Name = "Nikolay Nikolov",
            Age = 29,
            Number = 5,
            Height = 181
        },
        new Midfield
        {
            Name = "Petur Petrov",
            Age = 31,
            Number = 6,
            Height = 166
        },
        new Defender
        {
            Name = "Teodor Tonev",
            Age = 22,
            Number = 7,
            Height = 169
        },
        new Defender
        {
            Name = "Rosen Tonev",
            Age = 25,
            Number = 8,
            Height = 169
        },
        new Defender
        {
            Name = "Teodor Ivanov",
            Age = 22,
            Number = 9,
            Height = 171
        },
        new Defender
        {
            Name = "Georgi Alekseevich",
            Age = 26,
            Number = 10,
            Height = 161
        },
        new Goalkeeper
        {
            Name = "Asparuh Nikolov",
            Age = 20,
            Number = 11,
            Height = 166
        }
    };
    
    FootballPlayer[] playersFromTeamTwo =
    {
        new Striker
        {
            Name = "Ivan Ivanov",
            Age = 24,
            Number = 13,
            Height = 174
        },
        new Striker
        {
            Name = "Petur Ivanov",
            Age = 27,
            Number = 44,
            Height = 168
        },
        new Striker
        {
            Name = "Ivan Nikolov",
            Age = 21,
            Number = 12,
            Height = 172
        },
        new Midfield
        {
            Name = "Nikolay Ivanov",
            Age = 29,
            Number = 87,
            Height = 182
        },
        new Midfield
        {
            Name = "Nikolay Nikolov",
            Age = 54,
            Number = 5,
            Height = 181
        },
        new Midfield
        {
            Name = "Petur Petrov",
            Age = 11,
            Number = 6,
            Height = 166
        },
        new Defender
        {
            Name = "Teodor Tonev",
            Age = 22,
            Number = 7,
            Height = 169
        },
        new Defender
        {
            Name = "Rosen Tonev",
            Age = 25,
            Number = 81,
            Height = 169
        },
        new Defender
        {
            Name = "Teodor Ivanov",
            Age = 22,
            Number = 19,
            Height = 171
        },
        new Defender
        {
            Name = "Georgi Alekseevich",
            Age = 26,
            Number = 10,
            Height = 161
        },
        new Goalkeeper
        {
            Name = "Tervel Tervelov",
            Age = 20,
            Number = 51,
            Height = 166
        }
    };
    
    Coach[] coaches =
    {
        new Coach
        {
            Name = "Aleksei Ivanov",
            Age = 45
        },
        new Coach
        {
            Name = "Teodora Karastoycheva",
            Age = 39
        }
    };
    
    Referee[] referees =
    {
        new Referee
        {
            Name = "Ivan Ivanov",
            Age = 34
        },
        new Referee
        {
            Name = "Ivan Nikolov",
            Age = 35
        },
        new Referee
        {
            Name = "Nikolay Ivanov",
            Age = 36
        }
    };
    
    Team[] teams =
    {
        new Team
        {
            TeamName = "Gotinite",
            Players = playersFromTeamOne,
            Coach = coaches[0]
        },
        new Team
        {
            TeamName = "Barcelona AliExpress",
            Players = playersFromTeamTwo,
            Coach = coaches[1]
        }
    };
    
    Game[] games =
    {
        new Game
        {
            TeamOne = teams[0],
            TeamTwo = teams[1],
            Referee = referees[0],
            AssistantOne = referees[1],
            AssistantTwo = referees[2]
        }
    };

    games[0].AddGoal(14, playersFromTeamOne[2]);
    games[0].AddGoal(28, playersFromTeamTwo[4]);
    games[0].AddGoal(49, playersFromTeamOne[1]);
    games[0].AddGoal(64, playersFromTeamTwo[0]);
    games[0].AddGoal(87, playersFromTeamTwo[0]);

    games[0].DisplayGoalsHistory();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}