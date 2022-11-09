using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        private static List<Team> teamList;
        static void Main(string[] args)
        {
            teamList = new List<Team>();

            RunEngine();
        }

        static void RunEngine()
        {
            string cmd = Console.ReadLine();

            while (cmd != "END")
            {
                string[] cmdArgs = cmd.Split(";");
                string teamName = cmdArgs[1];
                try
                {
                    if (cmdArgs[0] == "Team")
                    {
                        AddNewTeam(teamName);
                    }
                    else if (cmdArgs[0] == "Add")
                    {
                        AddPlayerToTeam(teamName, cmdArgs);
                    }
                    else if (cmdArgs[0] == "Remove")
                    {
                        string playerName = cmdArgs[2];
                        RemovePlayer(teamName, playerName);
                    }
                    else if (cmdArgs[0] == "Rating")
                    {
                        TeamRating(teamName);
                    }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                cmd = Console.ReadLine();
            }
        }
        static void AddNewTeam(string teamName)
        {
            Team team = new Team(teamName);
            teamList.Add(team);
        }
        static Player CreateNewPlayer(string[] cmdArgs)
        {
            string playerName = cmdArgs[2];
            int endurance = int.Parse(cmdArgs[3]);
            int sprint = int.Parse(cmdArgs[4]);
            int dribble = int.Parse(cmdArgs[5]);
            int passing = int.Parse(cmdArgs[6]);
            int shooting = int.Parse(cmdArgs[7]);

            Player newPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);
            return newPlayer;
        }
        static void AddPlayerToTeam(string teamName, string[] cmdArgs)
        {
            Team joiningTeam = teamList
                .FirstOrDefault(t => t.Name == teamName);

            if (joiningTeam == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InexistingTeamName, teamName));
            }

            Player joiningPlayer = CreateNewPlayer(cmdArgs);
            joiningTeam.AddPlayer(joiningPlayer);
        }

        static void RemovePlayer(string teamName, string playerName)
        {
            Team leavingTeam = teamList
                 .FirstOrDefault(t => t.Name == teamName);

            if (leavingTeam == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InexistingTeamName, teamName));
            }

            leavingTeam.RemovePlayer(playerName);
        }

        static void TeamRating(string teamName)
        {
            Team teamRating = teamList
                .FirstOrDefault(t => t.Name == teamName);

            if (teamRating == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InexistingTeamName, teamName));
            }

            Console.WriteLine(teamRating);
        }
    }
}
