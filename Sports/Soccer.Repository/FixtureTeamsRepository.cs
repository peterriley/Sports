using Soccer.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.Repository
{
    public class FixtureTeamsRepository
    {
        private List<Team> PremierTeamList = new List<Team>() {
                new Team(){TeamId = 1, Name = "Arsenal"},
                new Team(){TeamId = 2, Name = "Aston Villa"},
                new Team(){TeamId = 3, Name = "Bournemouth"},
                new Team(){TeamId = 4, Name = "Brighton"},
                new Team(){TeamId = 5, Name = "Burnley"},
                new Team(){TeamId = 6, Name = "Chelsea"},
                new Team(){TeamId = 7, Name = "Crystal Palace"},
                new Team(){TeamId = 8, Name = "Everton"},
                new Team(){TeamId = 9, Name = "Leicester"},
                new Team(){TeamId = 10, Name = "Liverpool"},
                new Team(){TeamId = 11, Name = "Manchester City"},
                new Team(){TeamId = 12, Name = "Manchester United"},
                new Team(){TeamId = 13, Name = "Newcastle"},
                new Team(){TeamId = 14, Name = "Norwich"},
                new Team(){TeamId = 15, Name = "Sheffield United"},
                new Team(){TeamId = 16, Name = "Southampton"},
                new Team(){TeamId = 17, Name = "Tottenham"},
                new Team(){TeamId = 18, Name = "Watford"},
                new Team(){TeamId = 19, Name = "West Ham"},
                new Team(){TeamId = 20, Name = "Wolves"}
            };

        public FixtureTeamsRepository()
        {
            playerRepository = new PlayerRepository();
        }

        private PlayerRepository playerRepository { get; set; }

        public FixtureTeams Retrieve(int fixtureTeamsId)
        {
            // Create the instance of the FixtureTeams class
            // Pass in the requested id
            FixtureTeams fixtureTeams = new FixtureTeams(fixtureTeamsId);

            // Code that retrieves the defined fixture teams

            // Temporary hard-coded values to return
            // a populated fixture teams
            if (fixtureTeamsId == 1)
            {
                fixtureTeams.HomeTeamName = "Arsenal";
                fixtureTeams.AwayTeamName = "Aston Villa";
                fixtureTeams.HomeTeamPlayerList = playerRepository.RetrieveByTeamId(1).ToList();
                fixtureTeams.AwayTeamPlayerList = playerRepository.RetrieveByTeamId(2).ToList();
            }

            return fixtureTeams;
        }

        /// <summary>
        /// Retrieve all fixture teams.
        /// </summary>
        /// <returns></returns>
        public FixtureTeams Retrieve()
        {
            // Code that retrieves all of the fixture teams
            List<string> homeTeamName = PremierTeamList.Select(ht => ht.Name).ToList();
            List<string> awayTeamName = PremierTeamList.Select(ht => ht.Name).ToList();

            FixtureTeams fixtureTeams = new FixtureTeams()
            {
                FixtureTeamsId = 1,
                HomeTeamList = PremierTeamList,
                AwayTeamList = PremierTeamList
            };
            


            return fixtureTeams;
        }

        /// <summary>
        /// Saves the current fixture teams.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined fixture teams

            return true;
        }
    }
}
