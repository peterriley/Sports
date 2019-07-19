using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.BL
{
    public class Fixture
    {
        // Use constructor chaining ': this(0)' to use constructor chaining to call the parameterized constructor with a fixtureId of 0
        // which always initializes FixtureEventList - giving a composition relationship
        public Fixture() : this(0)
        {

        }

        public Fixture(int fixtureId)
        {
            FixtureId = fixtureId;
            // To prevent a null value exception to FixtureEventList, create an instance of FixtureEventList
            FixtureEventList = new List<FixtureEvent>();
            FixtureTeamsList = new List<FixtureTeams>();
        }

        public int FixtureId { get; private set; }
        public DateTime? FixtureDateTime { get; set; }
        public int HomeTeamId { get; set; }
        public string HomeTeamName { get; set; }
        public int AwayTeamId { get; set; }
        public string AwayTeamName { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }

        public List<FixtureTeams> FixtureTeamsList { get; set; }
        public List<FixtureEvent> FixtureEventList { get; set; }

        /// <summary>
        /// Validates the fixture data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(HomeTeamName)) isValid = false;
            if (string.IsNullOrWhiteSpace(AwayTeamName)) isValid = false;

            return isValid;
        }
    }
}
