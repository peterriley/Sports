using Soccer.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.Repository
{
    public class TeamRepository
    {
        public TeamRepository()
        {
            playerRepository = new PlayerRepository();
        }

        private PlayerRepository playerRepository { get; set; }

        /// <summary>
        /// Retrieve one team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public Team Retrieve(int teamId)
        {
            // Create the instance of the Team class
            // Pass in the requested Id
            Team team = new Team(teamId);

            // Code that retrieves the defined team

            // Temporary hard-coded values to return
            // a populated team
            if (teamId == 1)
            {
                team.Name = "Arsenal";
                team.PlayerList = playerRepository.RetrieveByTeamId(teamId).ToList();
            }

            return team;
        }

        /// <summary>
        /// Retrieve all teams.
        /// </summary>
        /// <returns></returns>
        public List<Team> Retrieve()
        {
            // Code that retrieves all of the teams

            return new List<Team>();
        }

        /// <summary>
        /// Saves the current team.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined team

            return true;
        }
    }
}
