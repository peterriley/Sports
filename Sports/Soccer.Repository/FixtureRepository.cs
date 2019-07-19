using Soccer.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.Repository
{
    public class FixtureRepository
    {
        public Fixture Retrieve(int fixtureId)
        {
            // Create the instance of the Fixture class
            // Pass in the requested id
            Fixture fixture = new Fixture(fixtureId);

            // Code that retrieves the defined fixture

            // Temporary hard-coded values to return
            // a populated fixture
            if (fixtureId == 1)
            {
                //fixture.FixtureTeamsList = fixtureTeamsRepository.Retrieve(1);
            }

            return fixture;
        }
    }
}
