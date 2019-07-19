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
                fixtureTeams.HomeTeamList = playerRepository.RetrieveByTeamId(1).ToList();
                fixtureTeams.AwayTeamList = playerRepository.RetrieveByTeamId(2).ToList();
            }

            return fixtureTeams;
        }

        /// <summary>
        /// Retrieve all fixture teams.
        /// </summary>
        /// <returns></returns>
        public List<FixtureTeams> Retrieve()
        {
            // Code that retrieves all of the fixture teams

            return new List<FixtureTeams>();
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
