using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.BL
{
    public class LeagueTable
    {
        // Use constructor chaining ': this(0)' to use constructor chaining to call the parameterized constructor with a leagueTableId of 0
        // which always initializes TeamList - giving a composition relationship
        public LeagueTable() : this(0)
        {

        }

        public LeagueTable(int leagueTableId)
        {
            LeagueId = leagueTableId;
            // To prevent a null value exception to TeamList create an instance of TeamList
            TeamList = new List<Team>();

        }

        public int LeagueTableId { get; set; }
        public int LeagueId { get; set; }
        public string Name { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int WonHome { get; set; }
        public int WonAway { get; set; }
        public int Drawn { get; set; }
        public int DrawnHome { get; set; }
        public int DrawnAway { get; set; }
        public int Lost { get; set; }
        public int LostHome { get; set; }
        public int LostAway { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsForHome { get; set; }
        public int GoalsForAway { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalsAgainstHome { get; set; }
        public int GoalsAgainstAway { get; set; }
        public int GoalDifference { get; set; }
        public int GoalDifferenceHome { get; set; }
        public int GoalDifferenceAway { get; set; }
        public int Points { get; set; }

        public List<Team> TeamList { get; set; }

        /// <summary>
        /// Validates the team data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;

            return isValid;
        }

    }
}
