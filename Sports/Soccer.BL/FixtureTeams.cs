using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.BL
{
    public class FixtureTeams
    {
        // Use constructor chaining ': this(0)' to use constructor chaining to call the parameterized constructor with a fixtureTeamsId of 0
        // which always initializes HomeTeamList & AwayTeamList - giving a composition relationship
        public FixtureTeams() : this(0)
        {

        }

        public FixtureTeams(int fixtureTeamsId)
        {
            FixtureTeamsId = fixtureTeamsId;
            // To prevent a null value exception to FixtureEventList, create an instance of HomeTeamList & AwayTeamList
            HomeTeamList = new List<Team>();
            AwayTeamList = new List<Team>();
            HomeTeamPlayerList = new List<Player>();
            AwayTeamPlayerList = new List<Player>();
        }

        public int FixtureTeamsId { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public List<Team> HomeTeamList { get; set; }
        public List<Team> AwayTeamList { get; set; }
        public List<Player> HomeTeamPlayerList { get; set; }
        public List<Player> AwayTeamPlayerList { get; set; }


        /// <summary>
        /// Validates the fixtureTeams data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (HomeTeamList == null) isValid = false;
            if (AwayTeamList == null) isValid = false;
            if (HomeTeamPlayerList == null) isValid = false;
            if (AwayTeamPlayerList == null) isValid = false;

            return isValid;
        }
    }
}
