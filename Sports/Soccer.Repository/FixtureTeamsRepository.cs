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
                fixtureTeams.HomeTeamName = "Fulchester United";
                fixtureTeams.AwayTeamName = "Viz FC";
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
            List<Team> homeTeamList = new List<Team>() {
                new Team(){TeamId = 1, Name = "Arsenal"},
                new Team(){TeamId = 2, Name = "Aston Villa"},
                new Team(){TeamId = 3, Name = "Chelsea"},
                new Team(){TeamId = 4, Name = "Liverpool"},
                new Team(){TeamId = 5, Name = "Manchester City"},
                new Team(){TeamId = 6, Name = "Manchester United"},
            };
            List<string> homeTeamName = homeTeamList.Select(ht => ht.Name).ToList();
            List<Team> awayTeamList = new List<Team>() {
                new Team(){TeamId = 1, Name = "Arsenal"},
                new Team(){TeamId = 2, Name = "Aston Villa"},
                new Team(){TeamId = 3, Name = "Chelsea"},
                new Team(){TeamId = 4, Name = "Liverpool"},
                new Team(){TeamId = 5, Name = "Manchester City"},
                new Team(){TeamId = 6, Name = "Manchester United"},
            };
            List<string> awayTeamName = awayTeamList.Select(ht => ht.Name).ToList();

            FixtureTeams fixtureTeams = new FixtureTeams()
            {
                FixtureTeamsId = 1,
                HomeTeamList = homeTeamList,
                AwayTeamList = awayTeamList
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
