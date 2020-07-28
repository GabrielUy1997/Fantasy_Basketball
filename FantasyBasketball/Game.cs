using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FantasyBasketball
{
    public class Game
    {
        private string[] PlayerID;
        private string[] PlayerPhoto;
        private string[] PlayerName;
        private string[] PlayerPos;
        private string[] PlayerAge;
        private string[] PlayerTeam;
        private string[] PlayerGames;
        private string[] PlayerGamesStart;
        private string[] PlayerFieldGoal;
        private string[] PlayerFieldGoalAttempt;
        private string[] Player3Point;
        private string[] Player2Point;
        private string[] PlayerFreeThow;
        private string[] PlayerFreeThrowAttempt;
        private string[] PlayerOffensReb;
        private string[] PlayerDefenceReb;
        private string[] PlayerAssist;
        private string[] PlayerSteal;
        private string[] PlayerBlock;
        private string[] PlayerTurnover;
        private string[] PlayerPersFoul;
        private string[] PlayerPoints;
        private double Points;
        private double Asists;
        private double Block;
        private double Steal;
        private double DRebound;
        private double ORebound;
        private double FreeThrows;
        private double FieldGoalsMissed;
        private double FreeThrowsMissed;
        private double Turnovers;
        private double Fouls;
        private string Champion;
        private String Season;
        public List<string> winners;
        public List<LeaugeTeam> Teams;
        public List<int> drafted;
        public List<int> printed;
        public List<int> Week;
        public List<int> MatchupType1;
        public List<int> MatchupType2;
        public List<int> MatchupType22;
        public List<int> MatchupType3;
        public List<int> MatchupType4;
        private int matchup = 0;
        public int WinnerMatch1;
        public int WinnerMatch2;
        public decimal PlayerGamesPlayed;
        public decimal Totalgames = 82;
        public decimal ChanceMissing;
        private double PlayerGameScore;
        public static Random RandomGen;
        public int CurrentWeek = 0;
        public int PlayerIndex = 0;
        public List<int> TopTenFree;

        /*
        public Game()
        
        NAME: 
            Game
        SYNOPSIS:
            
          public Game();  

        DESCRIPTION:
            
            Constructor for the Game class, it creates a the lists that
            hold the drafted players, players that have already been printed 
            on the draft list, the weekly winners, the teams, and a the list of top
            free agents available. It also populates the weeks and creates the matchup
            orders.
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public Game()
        {
            drafted = new List<int>(1);
            printed = new List<int>(1);
            winners = new List<string>(19);
            Teams = new List<LeaugeTeam>(4);
            Week = new List<int>(20);
            TopTenFree = new List<int>(15);
            matchup = 0;
            Week.Add(1);
            Week.Add(2);
            Week.Add(3);
            Week.Add(4);
            Week.Add(5);
            Week.Add(6);
            Week.Add(7);
            Week.Add(8);
            Week.Add(9);
            Week.Add(10);
            Week.Add(11);
            Week.Add(12);
            Week.Add(13);
            Week.Add(14);
            Week.Add(15);
            Week.Add(16);
            Week.Add(17);
            Week.Add(18);
            Week.Add(19);
            Week.Add(20);
            MatchupType1 = new List<int> { 0, 1, 2, 3 };
            MatchupType2 = new List<int> { 0, 2, 1, 3 };
            MatchupType22 = new List<int> { 0, 2, 1, 3 };
            MatchupType3 = new List<int> { 0, 3, 2, 1 };
            MatchupType4 = new List<int> { 0, 2, 3, 1 };
        }


        /*
        public void AddTakenPlayer(int a_player)
        
        NAME: 
            AddTakenPlayer
        SYNOPSIS:
            
            public void AddTakenPlayer(int a_player)
            a_player --> The ID of the player that was just drafted

        DESCRIPTION:
            
            Adding the name of the player that was drafted to a 
            list to make sure they are not drafted again
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public void AddTakenPlayer(int a_player)
        {
            drafted.Add(a_player);
        }

        /*
        public bool CheckIfPlayerTaken(int a_player)
        
        NAME: 
            CheckIfPlayerTaken
        SYNOPSIS:
            
            public bool CheckIfPlayerTaken(int a_player);
            a_player --> the ID of the player that the current team is trying to 
            pick
        DESCRIPTION:
            
            This checks if the player that was selected to be drafted has 
            already been drafted earlier by comparing the player to the 
            list of drafted players
        
        RETURNS:
            A bool whether that player has already been drafted
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public bool CheckIfPlayerTaken(int a_player)
        {
            foreach (int b_player in drafted)
            {
                if (b_player == a_player)
                {
                    return true;
                }
            }
            return false;
        }

        /*
        public bool CheckIfPrinted(int a_player)
        
        NAME: 
            CheckIfPrinted
        SYNOPSIS:
            
            public bool CheckIfPrinted(int a_player);
            a_player --> a players ID

        DESCRIPTION:
            
            This checks if the player has already been shown on
            the list of available players.
        
        RETURNS:
            A bool of whether they have already appeared on the list
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public bool CheckIfPrinted(int a_player)
        {
            foreach (int b_player in printed)
            {
                if (b_player == a_player)
                {
                    return true;
                }
            }
            return false;
        }

        /*
        public int ComputerTeamDraft(LeaugeTeam a_team, String a_name)
        
        NAME: 
            ComputerTeamDraft
        SYNOPSIS:
            
             public int ComputerTeamDraft(LeaugeTeam a_team, String a_name);
             a_team --> the computer team that is drafting
        DESCRIPTION:
            
            This is used for when it is a computer teams turn to pick,
            it takes in the team that is currently picking and goes through
            the list of available players and selects the best player that
            they can put on their team
        
        RETURNS:
            int, the ID of the player
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public int ComputerTeamDraft(LeaugeTeam a_team)
        {
            int BestPick = 0;
            int MostPoints = 0;
            int index = 0;
            int totalPoints;
            foreach (string player in PlayerPoints.Skip(1))
            {
                index++;
                totalPoints = Int32.Parse(player);
                if (totalPoints > MostPoints && CheckIfPlayerTaken(index) == false && a_team.CanDraftPosition(PlayerPos, index) == true)
                {
                    MostPoints = totalPoints;
                    BestPick = index;
                }
            }
            String[] aPick = PlayerName[BestPick].Split('\\');
            PlayerName[BestPick] = aPick[0];
           
            if (PlayerPos[BestPick].Contains('G'))
            {
                a_team.AddGuard();
            }
            else if (PlayerPos[BestPick].Contains('F'))
            {
                a_team.AddForward();
            }
            else if (PlayerPos[BestPick].Contains('C'))
            {
                a_team.AddCenters();
            }
            AddTakenPlayer(BestPick);
            a_team.AddingPlayer(BestPick);
            return BestPick;
        }

        /*
        public int AddPlayersToDraftList(string a_Position)
        
        NAME: 
            AddPlayersToDraftList
        SYNOPSIS:
            
          public int AddPlayersToDraftList(string a_Position);   
          a_Position--> the position the user wants the draftlist 
          to be displayed in

        DESCRIPTION:
            
            This changes the draft list to show either all the available
            players or only available players in a certain position
        
        RETURNS:
            int, id of the player
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public int AddPlayersToDraftList(string a_Position)
        {
            int BestPick = 0;
            int MostPoints = 0;
            int index = 0;
            int totalPoints;
            if(a_Position == "all")
            {
                foreach (string player in PlayerPoints.Skip(1))
                {
                    index++;
                    totalPoints = Int32.Parse(player);
                    if (totalPoints > MostPoints && CheckIfPrinted(index) == false && CheckIfPlayerTaken(index) == false)
                    {
                        MostPoints = totalPoints;
                        BestPick = index;
                    }
                }
                String[] aPick = PlayerName[BestPick].Split('\\');
                PlayerName[BestPick] = aPick[0];
                printed.Add(BestPick);
            }
            else if (a_Position == "Guard")
            {
                foreach (string player in PlayerPoints.Skip(1))
                {
                    index++;
                    totalPoints = Int32.Parse(player);
                    if (totalPoints > MostPoints && CheckIfPrinted(index) == false && GetPlayerPos(index).Contains("G")
                        && CheckIfPlayerTaken(index) == false)
                    {
                        MostPoints = totalPoints;
                        BestPick = index;
                    }
                }
                String[] aPick = PlayerName[BestPick].Split('\\');
                PlayerName[BestPick] = aPick[0];
                printed.Add(BestPick);
            }
            else if (a_Position == "Forward")
            {
                foreach (string player in PlayerPoints.Skip(1))
                {
                    index++;
                    totalPoints = Int32.Parse(player);
                    if (totalPoints > MostPoints && CheckIfPrinted(index) == false && GetPlayerPos(index).Contains("F")
                        && CheckIfPlayerTaken(index) == false)
                    {
                        MostPoints = totalPoints;
                        BestPick = index;
                    }
                }
                String[] aPick = PlayerName[BestPick].Split('\\');
                PlayerName[BestPick] = aPick[0];
                printed.Add(BestPick);
            }
            else if (a_Position == "Center")
            {
                foreach (string player in PlayerPoints.Skip(1))
                {
                    index++;
                    totalPoints = Int32.Parse(player);
                    if (totalPoints > MostPoints && CheckIfPrinted(index) == false && GetPlayerPos(index).Contains("C")
                        && CheckIfPlayerTaken(index) == false)
                    {
                        MostPoints = totalPoints;
                        BestPick = index;
                    }
                }
                String[] aPick = PlayerName[BestPick].Split('\\');
                PlayerName[BestPick] = aPick[0];
                printed.Add(BestPick);
            }
            return BestPick;
        }

        /*
        public void RandomizingDraftOrder()
        
        NAME: 
            RandomizingDraftOrder
        SYNOPSIS:
            
           public void RandomizingDraftOrder(); 

        DESCRIPTION:
            
            Randomizes the order of the teams to simulate
            the drafting order
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public void RandomizingDraftOrder()
        {
            Random rng = new Random();
            int n = Teams.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                LeaugeTeam value = Teams[k];
                Teams[k] = Teams[n];
                Teams[n] = value;
            }
        }

        /*
        public List<string> SetUpWeekMatchup(LeaugeTeam a_player, LeaugeTeam a_CPU1, LeaugeTeam a_CPU2, LeaugeTeam a_CPU3)
        
        NAME: 
            SetUpWeekMatchup
        SYNOPSIS:
            
            public List<string> SetUpWeekMatchup(LeaugeTeam a_player, LeaugeTeam a_CPU1, LeaugeTeam a_CPU2, LeaugeTeam a_CPU3);
            a_player --> The user's team
            a_CPU1 --> cpu1's team
            a_CPU2 --> cpu2's team
            a_CPU3 --> cpu3's team

        DESCRIPTION:
            
            This does all the calculations for each team during the week, it gives each player
            their daily scores based on a random chance of having an average game, good game, bad
            game, or missing the game. It also compares the teams matched up and returns the winner
            of both match ups
        
        RETURNS:
            List of strings, the name of the winners of both matchups in the current week
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public List<string> SetUpWeekMatchup(LeaugeTeam a_player, LeaugeTeam a_CPU1, LeaugeTeam a_CPU2, LeaugeTeam a_CPU3)
        {

            int week = Week[CurrentWeek];
            RandomGen = new Random();
            
            foreach (LeaugeTeam teams in Teams)
            {
                for (int DayOfWeek = 0; DayOfWeek < 7; DayOfWeek++)
                {
                    PlayerIndex = 0;
                    //https://stackoverflow.com/questions/37858551/implement-percent-chance-in-c-sharp 5/25/20
                    foreach (int player in teams.team)
                    {
                        PlayerGamesPlayed = Int32.Parse(GetPlayerGamesPlayed(player));
                        ChanceMissing = (Math.Round((PlayerGamesPlayed / Totalgames) * 100, MidpointRounding.AwayFromZero));
                        int RandomVal = RandomGen.Next(125);
                        //chance of missing a game
                        if (RandomVal < ChanceMissing)
                        {
                            RandomVal = RandomGen.Next(100);
                            //average game
                            if (15 < RandomVal && RandomVal < 85)
                            {
                                RandomVal = RandomGen.Next(-10, 10);
                                PlayerGameScore += RandomVal;
                                RandomVal = RandomGen.Next(-2, 3);
                                Points = Math.Round(Double.Parse(GetPlayerPoints(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Points;
                                Asists = Math.Round(Double.Parse(GetPlayerAssist(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Asists;
                                Block = Math.Round(Double.Parse(GetPlayerBlock(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Block;
                                Steal = Math.Round(Double.Parse(GetPlayerSteal(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Steal;
                                DRebound = Math.Round(Double.Parse(GetPlayerDefenceReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += DRebound;
                                ORebound = Math.Round(Double.Parse(GetPlayerOffensiveReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += ORebound;
                                FreeThrows = Math.Round(Double.Parse(GetPlayerFt(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += FreeThrows;
                                FieldGoalsMissed = Math.Round((Double.Parse(GetPlayerFieldGoalAtt(player)) - Double.Parse(GetPlayerFieldGoal(player))) / Double.Parse(GetPlayerGamesPlayed(player)),
                                    MidpointRounding.ToEven);
                                PlayerGameScore -= FieldGoalsMissed;
                                FreeThrowsMissed = Math.Round((Double.Parse(GetPlayerFtAtt(player)) - Double.Parse(GetPlayerFt(player))) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore -= FreeThrowsMissed;
                                Turnovers = Math.Round(Double.Parse(GetPlayerTurnover(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore -= Turnovers;
                                Fouls = Math.Round((Double.Parse(GetPlayerPersFoul(player)) / Double.Parse(GetPlayerGamesPlayed(player))) + RandomVal, MidpointRounding.ToEven);
                                //foul out
                                if (Fouls >= 5)
                                {
                                    PlayerGameScore -= 4;
                                }
                            }
                            //below average
                            else if (RandomVal < 15)
                            {
                                RandomVal = RandomGen.Next(-10, 5);
                                PlayerGameScore += RandomVal;
                                RandomVal = RandomGen.Next(-2, 3);
                                Points = Math.Round((Double.Parse(GetPlayerPoints(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Points;
                                Asists = Math.Round((Double.Parse(GetPlayerAssist(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Asists;
                                Block = Math.Round((Double.Parse(GetPlayerBlock(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Block;
                                Steal = Math.Round((Double.Parse(GetPlayerSteal(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Steal;
                                DRebound = Math.Round((Double.Parse(GetPlayerDefenceReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += DRebound;
                                ORebound = Math.Round((Double.Parse(GetPlayerOffensiveReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += ORebound;
                                FreeThrows = Math.Round((Double.Parse(GetPlayerFt(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += FreeThrows;
                                FieldGoalsMissed = Math.Round(((Double.Parse(GetPlayerFieldGoalAtt(player)) - Double.Parse(GetPlayerFieldGoal(player))) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.15),
                                    MidpointRounding.ToEven);
                                PlayerGameScore -= FieldGoalsMissed;
                                FreeThrowsMissed = Math.Round(((Double.Parse(GetPlayerFtAtt(player)) - Double.Parse(GetPlayerFt(player))) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.15),
                                    MidpointRounding.ToEven);
                                PlayerGameScore -= FreeThrowsMissed;
                                Turnovers = Math.Round((Double.Parse(GetPlayerTurnover(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.15), MidpointRounding.ToEven);
                                PlayerGameScore -= Turnovers;
                                Fouls = Math.Round((Double.Parse(GetPlayerPersFoul(player)) / Double.Parse(GetPlayerGamesPlayed(player))) + RandomVal, MidpointRounding.ToEven);
                                if (Fouls >= 5)
                                {
                                    PlayerGameScore -= 4;
                                }
                            }
                            //above average
                            else if (RandomVal >= 85)
                            {
                                RandomVal = RandomGen.Next(-5, 15);
                                PlayerGameScore += RandomVal;
                                RandomVal = RandomGen.Next(-2, 3);
                                Points = Math.Round((Double.Parse(GetPlayerPoints(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Points;
                                Asists = Math.Round((Double.Parse(GetPlayerAssist(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Asists;
                                Block = Math.Round((Double.Parse(GetPlayerBlock(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Block;
                                Steal = Math.Round((Double.Parse(GetPlayerSteal(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Steal;
                                DRebound = Math.Round((Double.Parse(GetPlayerDefenceReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += DRebound;
                                ORebound = Math.Round((Double.Parse(GetPlayerOffensiveReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += ORebound;
                                FreeThrows = Math.Round((Double.Parse(GetPlayerFt(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += FreeThrows;
                                FieldGoalsMissed = Math.Round(((Double.Parse(GetPlayerFieldGoalAtt(player)) - Double.Parse(GetPlayerFieldGoal(player))) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75),
                                    MidpointRounding.ToEven);
                                PlayerGameScore -= FieldGoalsMissed;
                                FreeThrowsMissed = Math.Round(((Double.Parse(GetPlayerFtAtt(player)) - Double.Parse(GetPlayerFt(player))) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore -= FreeThrowsMissed;
                                Turnovers = Math.Round((Double.Parse(GetPlayerTurnover(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore -= Turnovers;
                                Fouls = Math.Round((Double.Parse(GetPlayerPersFoul(player)) / Double.Parse(GetPlayerGamesPlayed(player))) + RandomVal, MidpointRounding.ToEven);
                                if (Math.Round((Double.Parse(GetPlayerPersFoul(player)) / Double.Parse(GetPlayerGamesPlayed(player))) + RandomVal, MidpointRounding.ToEven) >= 5)
                                {
                                    PlayerGameScore -= 4;
                                }
                            }

                        }
                        //missing game
                        else
                        {
                            PlayerGameScore += 0;
                        }
                        //Console.WriteLine("{0}: {1}", PlayerName[player], PlayerGameScore);
                        teams.PlayersScores[PlayerIndex][DayOfWeek] = PlayerGameScore;
                        teams.WeeklyStatLines[PlayerIndex][week - 1] += PlayerGameScore.ToString() + " ";
                        teams.WeekScore += PlayerGameScore;
                        teams.WeeklyScores[PlayerIndex][week-1] += PlayerGameScore;
                        PlayerGameScore = 0;
                        PlayerIndex++;
                    }
                }
                
            }
            WinnerMatch1 = (Teams.ElementAt(0).WeekScore < Teams.ElementAt(1).WeekScore) ? 1 : 0;
            WinnerMatch2 = (Teams.ElementAt(2).WeekScore < Teams.ElementAt(3).WeekScore) ? 3 : 2;
            winners.Add(Teams.ElementAt(WinnerMatch1).GetName() + " " + Teams.ElementAt(WinnerMatch2).GetName());
            foreach (LeaugeTeam team in Teams)
            {
                if (WinnerMatch1 == Teams.IndexOf(team) || WinnerMatch2 == Teams.IndexOf(team))
                {
                    team._Wins++;
                }
                else
                {
                    team._Losses++;
                }
            }
            Console.WriteLine("{0}: {1} vs. {2}: {3}", Teams.ElementAt(0).GetName(), Teams.ElementAt(0).WeekScore, Teams.ElementAt(1).GetName(), Teams.ElementAt(1).WeekScore);
            Console.WriteLine("{0}: {1} vs. {2}: {3}", Teams.ElementAt(2).GetName(), Teams.ElementAt(2).WeekScore, Teams.ElementAt(3).GetName(), Teams.ElementAt(3).WeekScore);
            Console.WriteLine("{0} _Wins with {1} points", Teams.ElementAt(WinnerMatch1).GetName(), Teams.ElementAt(WinnerMatch1).WeekScore);
            Console.WriteLine("{0} _Wins with {1} points", Teams.ElementAt(WinnerMatch2).GetName(), Teams.ElementAt(WinnerMatch2).WeekScore);
            Console.WriteLine("week {0}", week);

            return winners;
        }

        /*
        public void ResetPlayerScores()
        
        NAME:
            ResetPlayerScores
        SYNOPSIS:
            
            public void ResetPlayerScores()

        DESCRIPTION:
            
            Resets all the scores each player has for 
            the current week
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public void ResetPlayerScores()
        {
            foreach (LeaugeTeam teams in Teams)
            {
                teams.WeekScore = 0;
                for (int DayOfWeek = 0; DayOfWeek < 7; DayOfWeek++)
                {
                    PlayerIndex = 0;
                    foreach (int player in teams.team)
                    {
                        teams.PlayersScores[PlayerIndex][DayOfWeek] = 0;
                        PlayerIndex++;
                    }
                }
            }
        }

        /*
        public List<int> ShowFreeAgentList(LeaugeTeam a_player, string _position)
        
        NAME: 
            ShowFreeAgentList
        SYNOPSIS:
            
            public List<int> ShowFreeAgentList(string _position)
            _position --> The Position the user would like to filter
            the list into

        DESCRIPTION:
            
            Displays the free agents available based on the catagory
            the user selects
        
        RETURNS:
            List of int, the id's of the best available free agents
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public List<int> ShowFreeAgentList(string _position)
        {
            int BestPick = 0;
            int MostPoints = 0;
            int index = 0;
            int totalPoints;
            string input;
            TopTenFree.Clear();
            input = _position;
            for (int i = 0; i < 15; i++)
            {
                foreach (string player in PlayerPoints.Skip(1))
                {
                    index++;
                    totalPoints = Int32.Parse(player);
                    String[] PlayerNames = PlayerName[index].Split('\\');
                    if (input == "all")
                    {
                        if (totalPoints > MostPoints && CheckIfPlayerTaken(index) != true && TopTenFree.Contains(index) != true)
                        {
                            MostPoints = totalPoints;
                            BestPick = index;
                        }
                    }
                    else if (PlayerPos[index].Contains(input))
                    {
                        if (totalPoints > MostPoints && CheckIfPlayerTaken(index) != true && TopTenFree.Contains(index) != true)
                        {
                            MostPoints = totalPoints;
                            BestPick = index;
                        }
                    }

                }
                String[] FreeAgent = PlayerName[BestPick].Split('\\');
                PlayerName[BestPick] = FreeAgent[0];
                TopTenFree.Add(BestPick);
                BestPick = 0;
                MostPoints = 0;
                index = 0;
                totalPoints = 0;
            }
            foreach (int player in TopTenFree)
            {
                Console.Write("{0}.", index);
                index++;
            }
            return TopTenFree;
        }

        /*
        public bool AddDropFreeAgents(LeaugeTeam a_player, int _PlayerIndex, int _FAIndex)
        
        NAME: 
            AddDropFreeAgents
        SYNOPSIS:
            
            public bool AddDropFreeAgents(LeaugeTeam a_player, int _PlayerIndex, int _FAIndex);
            a_player --> the user's LeaugeTeam
            _PlayerIndex --> The id of the player they are dropping in their team list
            _FAIndex --> The id of the player they are adding in the free agents list

        DESCRIPTION:
            
            This is used for adding and dropping players, it recieves the player the user
            wants to add and the player the user wants to drop then it checks if the move
            is legal
        
        RETURNS:
            bool, whether the move is legal
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public bool AddDropFreeAgents(LeaugeTeam a_player, int _PlayerIndex, int _FAIndex)
        {
            int playerAdding;
            int playerDropping;
            string input;
            Console.WriteLine("Who would you like to add?");
            input = Console.ReadLine();
            playerAdding = _FAIndex;
            Console.WriteLine("Who would you like to drop?");
            input = Console.ReadLine();
            playerDropping = _PlayerIndex;
            Console.WriteLine("{0} for {1}", PlayerName[TopTenFree[playerAdding]], PlayerName[a_player.team[playerDropping]]);
            if (a_player.CanDraftPosition(_Playerpos, a_player.team.ElementAt(playerDropping)) == true)
            {
                a_player.AddingPlayer(TopTenFree[playerAdding]);
                AddTakenPlayer(TopTenFree[playerAdding]);
                drafted.RemoveAt(drafted.IndexOf(a_player.team[playerDropping]));
                a_player.DroppingPlayer(playerDropping);
                return true;
            }
            else if(GetPlayerPos(a_player.team.ElementAt(playerDropping)) == GetPlayerPos(TopTenFree[playerAdding]) || 
                GetPlayerPos(a_player.team.ElementAt(playerDropping)).Substring(1,1) == GetPlayerPos(TopTenFree[playerAdding]).Substring(1, 1))
            {
                a_player.AddingPlayer(TopTenFree[playerAdding]);
                AddTakenPlayer(TopTenFree[playerAdding]);
                drafted.RemoveAt(drafted.IndexOf(a_player.team[playerDropping]));
                a_player.DroppingPlayer(playerDropping);
                return true;
            }
            else
            {
                return false;
            }

        }

        /*
        public bool Trade(LeaugeTeam a_player, LeaugeTeam a_CPU, int a_pPlayer, int a_cPlayer)
        
        NAME: 
            Trade
        SYNOPSIS:
            
            public bool Trade(LeaugeTeam a_player, LeaugeTeam a_CPU, int a_pPlayer, int a_cPlayer);
            a_player --> The User's team
            a_CPU --> the team that the user is trading with
            a_pPlayer --> the player that the user is trading
            a_cPlayer --> the player the Cpu is trading

        DESCRIPTION:
            
            This is used for the user to trade with the CPU teams, they select the 
            player they would like to trade and recieve on the display and this checks 
            whether the trade is possible or if it would make sense for the CPU team
        
        RETURNS:
            bool, if the trade was approved or not
        AUTHOR:
            Gabriel Uy
        DATE:
            07/20/2020
        */
        public bool Trade(LeaugeTeam a_player, LeaugeTeam a_CPU, int a_pPlayer, int a_cPlayer)
        {
            int playerPlayer;
            int cpuPlayer;
            bool tradeApprove = false;
           
            Console.WriteLine("Who would you like to offer?");
            string input = Console.ReadLine();
            playerPlayer = a_pPlayer;
            Console.WriteLine("Who would you like to get?");
            input = Console.ReadLine();
            cpuPlayer = a_cPlayer;
            if (a_player.CanDraftPosition(PlayerPos, a_CPU.team[cpuPlayer]) == true && a_CPU.CanDraftPosition(PlayerPos, a_player.team[playerPlayer]) == true)
            {
                tradeApprove = true;
            }
            else if (PlayerPos[a_player.team[playerPlayer]] == "C" && PlayerPos[a_CPU.team[cpuPlayer]] == "C")
            {
                tradeApprove = true;
            }
            else if (PlayerPos[a_player.team[playerPlayer]].Contains("G") == true && PlayerPos[a_CPU.team[cpuPlayer]].Contains("G") == true)
            {
                tradeApprove = true;
            }
            else if (PlayerPos[a_player.team[playerPlayer]].Contains("F") == true && PlayerPos[a_CPU.team[cpuPlayer]].Contains("F") == true)
            {
                tradeApprove = true;
            }
            else
            {
                tradeApprove = false;
            }
            if (tradeApprove == true && a_CPU.AssessTrade(a_player.team[playerPlayer], a_CPU.team[cpuPlayer], PlayerPoints, PlayerOffensReb, PlayerDefenceReb, PlayerAssist, PlayerBlock, PlayerSteal, PlayerTurnover) == true)
            {
                Console.WriteLine("{0} for {1}", PlayerName[a_player.team[playerPlayer]], PlayerName[a_CPU.team[cpuPlayer]]);
                a_player.AddingPlayer(a_CPU.team[cpuPlayer]);
                a_CPU.AddingPlayer(a_player.team[playerPlayer]);
                a_player.DroppingPlayer(playerPlayer);
                a_CPU.DroppingPlayer(cpuPlayer);
                UpdatePosCount(a_player,a_CPU,playerPlayer,cpuPlayer);
            }
            else
            {
                tradeApprove = false;
            }
            return tradeApprove;
        }

        /*
        public void UpdatePosCount(LeaugeTeam a_player, LeaugeTeam a_CPU, int a_pPlayer, int a_cPlayer)
        
        NAME: 
            UpdatePosCount
        SYNOPSIS:
            
            public void UpdatePosCount(LeaugeTeam a_player, LeaugeTeam a_CPU, int a_pPlayer, int a_cPlayer); 
            a_player --> The User's team
            a_CPU --> the team that the user is trading with
            a_pPlayer --> the player that the user is trading
            a_cPlayer --> the player the Cpu is trading

        DESCRIPTION:
            
            This function updates the user and cpu teams count for the postions to make sure 
            they have 2 or less in each postion
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/21/2020
        */
        public void UpdatePosCount(LeaugeTeam a_player, LeaugeTeam a_CPU, int a_pPlayer, int a_cPlayer)
        {
            if(PlayerPos[a_player.team[a_pPlayer]] == "C")
            {
                a_CPU.AddCenters();
            }
            else if (PlayerPos[a_player.team[a_pPlayer]].Contains("G") == true)
            {
                a_CPU.AddGuard();
            }
            else if (PlayerPos[a_player.team[a_pPlayer]].Contains("F") == true)
            {
                a_CPU.AddForward();
            }

            if (PlayerPos[a_CPU.team[a_cPlayer]] == "C")
            {
                a_player.AddCenters();
            }
            else if (PlayerPos[a_CPU.team[a_cPlayer]].Contains("G") == true)
            {
                a_player.AddGuard();
            }
            else if (PlayerPos[a_CPU.team[a_cPlayer]].Contains("F") == true)
            {
                a_player.AddForward();
            }

            if (PlayerPos[a_player.team[a_pPlayer]] == "C")
            {
                a_CPU.RemoveCenter();
            }
            else if (PlayerPos[a_player.team[a_pPlayer]].Contains("G") == true)
            {
                a_CPU.RemoveGuard();
            }
            else if (PlayerPos[a_player.team[a_pPlayer]].Contains("F") == true)
            {
                a_CPU.RemoveForward();
            }
            if (PlayerPos[a_CPU.team[a_cPlayer]] == "C")
            {
                a_player.RemoveCenter();
            }
            else if (PlayerPos[a_CPU.team[a_cPlayer]].Contains("G") == true)
            {
                a_player.RemoveGuard();
            }
            else if (PlayerPos[a_CPU.team[a_cPlayer]].Contains("F") == true)
            {
                a_player.RemoveForward();
            }
        }

        /*
        public List<LeaugeTeam> ShowStandings(List<LeaugeTeam> a_Teams)
        
        NAME: 
            ShowStandings
        SYNOPSIS:
            
            public List<LeaugeTeam> ShowStandings(List<LeaugeTeam> a_Teams);
            a_Teams --> the list of all teams 

        DESCRIPTION:
            
            This is used to display the wins and losses for all the teams on
            the display
        
        RETURNS:
            List of LeaugeTeams, the teams in order of who has the best record
        AUTHOR:
            Gabriel Uy
        DATE:
            07/21/2020
        */
        public List<LeaugeTeam> ShowStandings(List<LeaugeTeam> a_Teams)
        {
            int top1;
            int top2;
            int bottom1;
            int bottom2;
            List<LeaugeTeam> Standings;
            Standings = new List<LeaugeTeam>(4);
            if (a_Teams[0]._Wins > a_Teams[1]._Wins)
            {
                top1 = 0;
                bottom1 = 1;
            }
            else
            {
                top1 = 1;
                bottom1 = 0;
            }
            if (a_Teams[2]._Wins > a_Teams[3]._Wins)
            {
                top2 = 2;
                bottom2 = 3;
            }
            else
            {
                top2 = 3;
                bottom2 = 2;
            }
            if (a_Teams[top1]._Wins < a_Teams[top2]._Wins)
            {
                top1 = top1 + top2;
                top2 = top1 - top2;
                top1 = top1 - top2;
            }
            if (a_Teams[bottom1]._Wins < a_Teams[bottom2]._Wins)
            {
                bottom1 = bottom1 + bottom2;
                bottom2 = bottom1 - bottom2;
                bottom1 = bottom1 - bottom2;
            }
            if (a_Teams[top2]._Wins < a_Teams[bottom1]._Wins)
            {
                top2 = top2 + bottom1;
                bottom1 = top2 - bottom1;
                top2 = top2 - bottom1;
            }
            Standings.Add(a_Teams[top1]);
            Standings.Add(a_Teams[top2]);
            Standings.Add(a_Teams[bottom1]);
            Standings.Add(a_Teams[bottom2]);
            Champion = a_Teams[top1].GetName();
            Console.WriteLine("1. {0} {1} {2}", a_Teams[top1].GetName(), a_Teams[top1]._Wins, a_Teams[top1]._Losses);
            Console.WriteLine("2. {0} {1} {2}", a_Teams[top2].GetName(), a_Teams[top2]._Wins, a_Teams[top2]._Losses);
            Console.WriteLine("3. {0} {1} {2}", a_Teams[bottom1].GetName(), a_Teams[bottom1]._Wins, a_Teams[bottom1]._Losses);
            Console.WriteLine("4. {0} {1} {2}", a_Teams[bottom2].GetName(), a_Teams[bottom2]._Wins, a_Teams[bottom2]._Losses);
            return Standings;
        }

      
        public string[] _PlayerName
        {
            get { return PlayerName; }
        }

        public string[] _Playerpos
        {
            get { return PlayerPos; }
        }

        public string[] _PlayerPhoto
        {
            get { return PlayerPhoto; }
        }
        public int _matchup
        {
            get { return matchup; }
            set { matchup = value; }
        }

        public string _Champion
        {
            get { return Champion; }
        }

        /*
        public int GetPlayerID(string a_player)
        
        NAME: 
            GetPlayerID
        SYNOPSIS:
            
            public int GetPlayerID(string a_player);
            a_player --> the player whos id is being fetched

        DESCRIPTION:
            
            Used to find a players ID using their name
        
        RETURNS:
            int, the id of the player 
        AUTHOR:
            Gabriel Uy
        DATE:
            07/21/2020
        */
        public int GetPlayerID(string a_player)
        {
            int count = 0;
            foreach(string player in PlayerName)
            {
                if(a_player == player)
                {
                    return count;
                }
                count++;
            }
            return 0;

        }
        /*
        public string GetPlayerName(int a_player)
        
        NAME: 
            GetPlayerName
        SYNOPSIS:
            
            public string GetPlayerName(int a_player);
            a_player --> the id of the player

        DESCRIPTION:
            
            Used to get the name of a player using an id
        
        RETURNS:
            string, the name of the player
        AUTHOR:
            Gabriel Uy
        DATE:
            07/21/2020
        */
        public string GetPlayerName(int a_player)
        {
            return PlayerName[a_player];
        }

        /*
        public string GetPlayerPos(int a_player)
        
        NAME: 
            GetPlayerPos
        SYNOPSIS:
            
            public string GetPlayerPos(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
            Used to get a players position using their id
        
        RETURNS:
            string, the players postion on the court
        AUTHOR:
            Gabriel Uy
        DATE:
            07/21/2020
        */
        public string GetPlayerPos(int a_player)
        {
            return PlayerPos[a_player];
        }

        /*
        public string GetPlayerAge(int a_player)
        
        NAME: 
            GetPlayerAge
        SYNOPSIS:
            
            public string GetPlayerAge(int a_player);
            a_player --> player's id
        DESCRIPTION:
            
            Used to get a players age using their id
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/21/2020
        */
        public string GetPlayerAge(int a_player)
        {
            return PlayerAge[a_player];
        }

        /*
        public string GetPlayerTeam(int a_player)
        
        NAME: 
            GetPlayerTeam
        SYNOPSIS:
            
            public string GetPlayerTeam(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
            Used to get a players team using their id
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/21/2020
        */
        public string GetPlayerTeam(int a_player)
        {
            return PlayerTeam[a_player];
        }

        /*
        public string GetPlayerGamesPlayed(int a_player)
        
        NAME: 
            GetPlayerGamesPlayed
        SYNOPSIS:
            
            public string GetPlayerGamesPlayed(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
            Used to get the total games the real player actually played in
            the current season being simulated
        
        RETURNS:
            string, the number of games they played
        AUTHOR:
            Gabriel Uy
        DATE:
            07/21/2020
        */
        public string GetPlayerGamesPlayed(int a_player)
        {
            return PlayerGames[a_player];
        }

        /*
        public string GetPlayerGamesStart(int a_player)
        
        NAME: 
            GetPlayerGamesStart
        SYNOPSIS:
            
            public string GetPlayerGamesStart(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
            Used to get the ammount of games a player has started
            using their id
        
        RETURNS:
            String, number of games started
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerGamesStart(int a_player)
        {
            return PlayerGamesStart[a_player];
        }

        /*
        public string GetPlayerFieldGoal(int a_player)
        
        NAME: 
            GetPlayerFieldGoal
        SYNOPSIS:
            
            public string GetPlayerFieldGoal(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
            Used to get the ammount of field goals a player made during the
            real season using their id
        
        RETURNS:
            String, number of field goals made
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerFieldGoal(int a_player)
        {
            return PlayerFieldGoal[a_player];
        }

        /*
        public string GetPlayerFieldGoalAtt(int a_player)
        
        NAME: 
            GetPlayerFieldGoalAtt
        SYNOPSIS:
            
            public string GetPlayerFieldGoalAtt(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the ammount of field goals a player attempted during the
          real season using their id   
        
        RETURNS:
            string, number of field goals a player has attempted
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerFieldGoalAtt(int a_player)
        {
            return PlayerFieldGoalAttempt[a_player];
        }

        /*
        public string GetPlayer3Point(int a_player)
        
        NAME: 
        SYNOPSIS:
            
            public string GetPlayer3Point(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the ammount of 3 point shots a player made during the
          real season using their id           
        
        RETURNS:
          string, the number of 3 pointers the player has made
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayer3Point(int a_player)
        {
            return Player3Point[a_player];
        }

        /*
        public string GetPlayer2Point(int a_player)
        
        NAME: 
            GetPlayer2Point
        SYNOPSIS:
            
            public string GetPlayer2Point(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the ammount of 2 point shots a player made during the
          real season using their id 
        
        RETURNS:
            string, the number of 2 pointers the player has made
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayer2Point(int a_player)
        {
            return Player2Point[a_player];
        }

        /*
        public string GetPlayerFt(int a_player)
        
        NAME: 
            GetPlayerFt
        SYNOPSIS:
            
            public string GetPlayerFt(int a_player)
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the ammount of free throw shots a player made during the
          real season using their id             
        
        RETURNS:
            string, the number of free throws the player has made
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerFt(int a_player)
        {
            return PlayerFreeThow[a_player];
        }

        /*
        public string GetPlayerFtAtt(int a_player)
        
        NAME: 
            GetPlayerFtAtt
        SYNOPSIS:
            
            public string GetPlayerFtAtt(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the ammount of free throw shots a player attempted during the
          real season using their id
        
        RETURNS:
            string, the number of free throws the player has attempted
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerFtAtt(int a_player)
        {
            return PlayerFreeThrowAttempt[a_player];
        }

        /*
        public string GetPlayerOffensiveReb(int a_player)
        
        NAME: 
            GetPlayerOffensiveReb
        SYNOPSIS:
            
            public string GetPlayerOffensiveReb(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the ammount of offensive rebounds a player got during the
          real season using their id
        
        RETURNS:
            string, the number of offensive rebounds the player got
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerOffensiveReb(int a_player)
        {
            return PlayerOffensReb[a_player];
        }

        /*
        public string GetPlayerDefenceReb(int a_player)
        
        NAME: 
            GetPlayerDefenceReb
        SYNOPSIS:
            
            public string GetPlayerDefenceReb(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the ammount of defensive rebounds a player got during the
          real season using their id            
        
        RETURNS:
            string, the number of defensive rebounds the player got
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerDefenceReb(int a_player)
        {
            return PlayerDefenceReb[a_player];
        }

        /*
        public string GetPlayerAssist(int a_player)
        
        NAME: 
            GetPlayerAssist
        SYNOPSIS:
            
            public string GetPlayerAssist(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the number of assists a player got during the
          real season using their id           
        
        RETURNS:
            string, number of assists
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerAssist(int a_player)
        {
            return PlayerAssist[a_player];
        }

        /*
        public string GetPlayerSteal(int a_player)
        
        NAME: 
            GetPlayerSteal
        SYNOPSIS:
            
            public string GetPlayerSteal(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the number of steals a player got during the
          real season using their id            
        
        RETURNS:
            string, number of steals
        AUTHOR:
            Gabriel Uy
        DATE:
            07/22/2020
        */
        public string GetPlayerSteal(int a_player)
        {
            return PlayerSteal[a_player];
        }

        /*
        public string GetPlayerBlock(int a_player)
        
        NAME: 
            GetPlayerBlock
        SYNOPSIS:
            
            public string GetPlayerBlock(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the number of blocks a player got during the
          real season using their id           
        
        RETURNS:
             string, number of blocks
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
        */
        public string GetPlayerBlock(int a_player)
        {
            return PlayerBlock[a_player];
        }

        /*
        public string GetPlayerTurnover(int a_player)
        
        NAME: 
            GetPlayerTurnover
        SYNOPSIS:
            
            public string GetPlayerTurnover(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the number of turnovers a player had during the
          real season using their id           
        
        RETURNS:
             string, number of turnovers
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
        */
        public string GetPlayerTurnover(int a_player)
        {
            return PlayerTurnover[a_player];
        }

        /*
        public string GetPlayerPersFoul(int a_player)
        
        NAME: 
            GetPlayerPersFoul
        SYNOPSIS:
            
            public string GetPlayerPersFoul(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the number of personal fouls a player had during the
          real season using their id           
        
        RETURNS:
             string, number of personal fouls
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
        */
        public string GetPlayerPersFoul(int a_player)
        {
            return PlayerPersFoul[a_player];
        }

        /*
        public string GetPlayerPoints(int a_player)
        
        NAME:
            GetPlayerPoints
        SYNOPSIS:
            
            public string GetPlayerPoints(int a_player);
            a_player --> player's id

        DESCRIPTION:
            
          Used to get the number of points a player had during the
          real season using their id           
        
        RETURNS:
             string, number of points
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
        */
        public string GetPlayerPoints(int a_player)
        {
            return PlayerPoints[a_player];
        }

        /*
        public bool LoadSeasonStats(Game game, string a_entry)
        
        NAME: 
            LoadSeasonStats
        SYNOPSIS:
            
            public bool LoadSeasonStats(Game game, string a_entry);
            game --> the current game object
            a_entry --> the season the user selected to simulate

        DESCRIPTION:
            
            This is used to get the statistics for all players in
            the season the user selected.
        
        RETURNS:
            bool, whether if the season selected was valid
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
        */
        public bool LoadSeasonStats(Game game, string a_entry)
        {
            //found how to find the file location of the program using a method from this website 7/27/20
            //https://www.delftstack.com/howto/csharp/how-to-get-current-folder-path-in-csharp/
            System.IO.DirectoryInfo path = System.IO.Directory.GetParent(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            path = System.IO.Directory.GetParent(path.FullName);
            string SeasonPath = path.FullName;
            SeasonPath = SeasonPath + @"\Seasons\";
            String SeasonSelection;
            Console.WriteLine("What season would you like to simulate? (ex. 2018-2019)");
            Season = a_entry;
            SeasonSelection = SeasonPath + Season + ".csv";
            //If the season is valid it opens the file, reads it, and stores all the statistics
            //in alphebetical order and the number they are in the list is the players id 
            //(ex. 1st person in the list has an id of 1) this way all the stats are in the 
            //same index as the players id and it makes it simple to find them.
            try
            {
                if(!File.Exists(SeasonSelection))
                {
                    throw new Exception();
                }
                else
                {
                    StreamReader reader = new StreamReader(File.OpenRead(SeasonSelection));
                    List<string> pID = new List<String>();
                    List<string> pPhoto = new List<string>();
                    List<string> pName = new List<String>();
                    List<string> pPos = new List<String>();
                    List<string> pAge = new List<String>();
                    List<string> pTm = new List<String>();
                    List<string> pG = new List<String>();
                    List<string> pGS = new List<String>();
                    List<string> pFG = new List<String>();
                    List<string> pFGA = new List<String>();
                    List<string> p3P = new List<String>();
                    List<string> p2P = new List<String>();
                    List<string> pFT = new List<String>();
                    List<string> pFTA = new List<String>();
                    List<string> pORB = new List<String>();
                    List<string> pDRB = new List<String>();
                    List<string> pAST = new List<String>();
                    List<string> pSTL = new List<String>();
                    List<string> pBLK = new List<String>();
                    List<string> pTOV = new List<String>();
                    List<string> pPF = new List<String>();
                    List<string> pPTS = new List<String>();
                    //removing a * that the stat website has attatched to player names
                    
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            string[] values = line.Split(',');
                            if (values.Length >= 4)
                            {
                                if (values[1] != "Player")
                                {
                                    pPhoto.Add((values[1].Split('\\')[1]));
                                }
                                //removing a * that the stat website has attatched to player names
                                if (values[1].Contains("*"))
                                {
                                    values[1] = values[1].Replace("*", string.Empty);
                                }
                                pID.Add(values[0]);
                                pName.Add(values[1]);
                                pPos.Add(values[2]);
                                pAge.Add(values[3]);
                                pTm.Add(values[4]);
                                pG.Add(values[5]);
                                pGS.Add(values[6]);
                                pFG.Add(values[8]);
                                pFGA.Add(values[9]);
                                p3P.Add(values[11]);
                                p2P.Add(values[14]);
                                pFT.Add(values[18]);
                                pFTA.Add(values[19]);
                                pORB.Add(values[21]);
                                pDRB.Add(values[22]);
                                pAST.Add(values[24]);
                                pSTL.Add(values[25]);
                                pBLK.Add(values[26]);
                                pTOV.Add(values[27]);
                                pPF.Add(values[28]);
                                pPTS.Add(values[29]);

                            }
                        }
                    }
                    PlayerID = pID.ToArray();
                    PlayerPhoto = pPhoto.ToArray();
                    PlayerName = pName.ToArray();
                    PlayerPos = pPos.ToArray();
                    PlayerAge = pAge.ToArray();
                    PlayerTeam = pTm.ToArray();
                    PlayerGames = pG.ToArray();
                    PlayerGamesStart = pGS.ToArray();
                    PlayerFieldGoal = pFG.ToArray();
                    PlayerFieldGoalAttempt = pFGA.ToArray();
                    Player3Point = p3P.ToArray();
                    Player2Point = p2P.ToArray();
                    PlayerFreeThow = pFT.ToArray();
                    PlayerFreeThrowAttempt = pFTA.ToArray();
                    PlayerOffensReb = pORB.ToArray();
                    PlayerDefenceReb = pDRB.ToArray();
                    PlayerAssist = pAST.ToArray();
                    PlayerSteal = pSTL.ToArray();
                    PlayerBlock = pBLK.ToArray();
                    PlayerTurnover = pTOV.ToArray();
                    PlayerPersFoul = pPF.ToArray();
                    PlayerPoints = pPTS.ToArray();
                    return true;
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Cannot simulate that season");
                return false;
            }
            
        }
    }
}
