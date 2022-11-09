using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class ExceptionMessages
    {
        public const string NameCantBeNullOrWhiteSpace = "A name should not be empty.";
        public const string StatBetween0And100 = "{0} should be between 0 and 100.";
        public const string NameCantBeFound = "Player {0} is not in {1} team.";
        public const string InexistingTeamName = "Team {0} does not exist.";

    }
}
