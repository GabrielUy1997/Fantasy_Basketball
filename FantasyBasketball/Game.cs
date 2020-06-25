﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyBasketball
{
    public class Game
    {
        private string[] PlayerID;
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
        private string Champion;
        private String Season;
        public List<string> winners;
        public List<LeaugeTeam> Teams;
        public List<int> drafted;
        public List<int> printed;
        public List<int> Week;
        public List<int> MatchupType1;
        public List<int> MatchupType2;
        public List<int> MatchupType3;
        public List<int> MatchupType4;
        private int matchup = 0;
        public int WinnerMatch1;
        public int WinnerMatch2;
        public decimal PlayerGamesPlayed;
        public decimal Totalgames;
        public decimal ChanceMissing;
        private double PlayerGameScore;
        public static Random RandomGen;
        public int CurrentWeek = 0;
        public int indexX = 0;
        List<int> TopTenFree;

        public Game()
        {
            drafted = new List<int>(1);
            printed = new List<int>(1);
            winners = new List<string>(19);
            Teams = new List<LeaugeTeam>(4);
            Week = new List<int>(20);
            TopTenFree = new List<int>(10);
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
            MatchupType3 = new List<int> { 0, 3, 2, 1 };
            MatchupType4 = new List<int> { 0, 2, 3, 1 };
            Totalgames = 82;
        }

        public void PrintPlayer(int pID)
        {
            Console.WriteLine("{0}: {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19} {20}",
                        GetPlayerName(pID), GetPlayerPos(pID), GetPlayerAge(pID), GetPlayerTeam(pID), GetPlayerGamesPlayed(pID), GetPlayerGamesStart(pID), GetPlayerFieldGoal(pID), GetPlayerFieldGoalAtt(pID),
                        GetPlayer3Point(pID), GetPlayer2Point(pID), GetPlayerFt(pID), GetPlayerFtAtt(pID), GetPlayerOffensiveReb(pID), GetPlayerDefenceReb(pID), GetPlayerAssist(pID),
                        GetPlayerSteal(pID), GetPlayerBlock(pID), GetPlayerTurnover(pID), GetPlayerPersFoul(pID), GetPlayerPoints(pID), pID);
        }

        public void AddTakenPlayer(int a_player)
        {
            drafted.Add(a_player);
        }

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

        public int ComputerTeamDraft(LeaugeTeam a_team, String a_name)
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
            Console.WriteLine("{0} Drafted: {1}", a_name, PlayerName[BestPick]);
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

        public int AddPlayersToDraftList()
        {
            int BestPick = 0;
            int MostPoints = 0;
            int index = 0;
            int totalPoints;
            foreach (string player in PlayerPoints.Skip(1))
            {
                index++;
                totalPoints = Int32.Parse(player);
                if (totalPoints > MostPoints && CheckIfPrinted(index) == false)
                {
                    MostPoints = totalPoints;
                    BestPick = index;
                }
            }
            String[] aPick = PlayerName[BestPick].Split('\\');
            PlayerName[BestPick] = aPick[0];
            printed.Add(BestPick);
            return BestPick;
        }
        

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


        public List<string> SetUpWeekMatchup(LeaugeTeam a_player, LeaugeTeam a_CPU1, LeaugeTeam a_CPU2, LeaugeTeam a_CPU3)
        {
            
            
            int week = Week[CurrentWeek];
            RandomGen = new Random();
            
            foreach (LeaugeTeam teams in Teams)
            {
                //index = 0;
                for (int indexY = 0; indexY < 7; indexY++)
                {
                    indexX = 0;
                    //https://stackoverflow.com/questions/37858551/implement-percent-chance-in-c-sharp 5/25/20
                    foreach (int player in teams.team)
                    {
                        PlayerGamesPlayed = Int32.Parse(GetPlayerGamesPlayed(player));
                        ChanceMissing = (Math.Round((PlayerGamesPlayed / Totalgames) * 100, MidpointRounding.AwayFromZero));
                        int RandomVal = RandomGen.Next(100);
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
                                PlayerGameScore += Math.Round(Double.Parse(GetPlayerPoints(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round(Double.Parse(GetPlayerAssist(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round(Double.Parse(GetPlayerBlock(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round(Double.Parse(GetPlayerSteal(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round(Double.Parse(GetPlayerDefenceReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round(Double.Parse(GetPlayerOffensiveReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round(Double.Parse(GetPlayerFt(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore -= Math.Round((Double.Parse(GetPlayerFieldGoalAtt(player)) - Double.Parse(GetPlayerFieldGoal(player))) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore -= Math.Round((Double.Parse(GetPlayerFtAtt(player)) - Double.Parse(GetPlayerFt(player))) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                PlayerGameScore -= Math.Round(Double.Parse(GetPlayerTurnover(player)) / Double.Parse(GetPlayerGamesPlayed(player)), MidpointRounding.ToEven);
                                //foul out
                                if (Math.Round((Double.Parse(GetPlayerPersFoul(player)) / Double.Parse(GetPlayerGamesPlayed(player))) + RandomVal, MidpointRounding.ToEven) >= 5)
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
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerPoints(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerAssist(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerBlock(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerSteal(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerDefenceReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerOffensiveReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerFt(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore -= Math.Round(((Double.Parse(GetPlayerFieldGoalAtt(player)) - Double.Parse(GetPlayerFieldGoal(player))) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.15), MidpointRounding.ToEven);
                                PlayerGameScore -= Math.Round((Double.Parse(GetPlayerTurnover(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.15), MidpointRounding.ToEven);
                                if (Math.Round((Double.Parse(GetPlayerPersFoul(player)) / Double.Parse(GetPlayerGamesPlayed(player))) + RandomVal, MidpointRounding.ToEven) >= 5)
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
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerPoints(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerAssist(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerBlock(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerSteal(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerDefenceReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerOffensiveReb(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore += Math.Round((Double.Parse(GetPlayerFt(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 1.75), MidpointRounding.ToEven);
                                PlayerGameScore -= Math.Round(((Double.Parse(GetPlayerFieldGoalAtt(player)) - Double.Parse(GetPlayerFieldGoal(player))) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
                                PlayerGameScore -= Math.Round((Double.Parse(GetPlayerTurnover(player)) / Double.Parse(GetPlayerGamesPlayed(player)) * 0.75), MidpointRounding.ToEven);
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
                        teams.PlayersScores[indexX][indexY] = PlayerGameScore;
                        teams.WeekScore += PlayerGameScore;
                        PlayerGameScore = 0;
                        indexX++;
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
                    team.Wins++;
                }
                else
                {
                    team.Losses++;
                }
            }
            Console.WriteLine("{0}: {1} vs. {2}: {3}", Teams.ElementAt(0).GetName(), Teams.ElementAt(0).WeekScore, Teams.ElementAt(1).GetName(), Teams.ElementAt(1).WeekScore);
            Console.WriteLine("{0}: {1} vs. {2}: {3}", Teams.ElementAt(2).GetName(), Teams.ElementAt(2).WeekScore, Teams.ElementAt(3).GetName(), Teams.ElementAt(3).WeekScore);
            Console.WriteLine("{0} wins with {1} points", Teams.ElementAt(WinnerMatch1).GetName(), Teams.ElementAt(WinnerMatch1).WeekScore);
            Console.WriteLine("{0} wins with {1} points", Teams.ElementAt(WinnerMatch2).GetName(), Teams.ElementAt(WinnerMatch2).WeekScore);
            Console.WriteLine("week {0}", week);

            ShowStandings(Teams);
            return winners;
            //return Champion;
        }


        public void ResetPlayerScores()
        {
            foreach (LeaugeTeam teams in Teams)
            {
                teams.WeekScore = 0;
                for (int indexY = 0; indexY < 7; indexY++)
                {
                    indexX = 0;
                    foreach (int player in teams.team)
                    {
                        teams.PlayersScores[indexX][indexY] = 0;
                        indexX++;
                    }
                }
            }
        }
        public void ShowFreeAgents(LeaugeTeam a_player)
        {
            int BestPick = 0;
            int MostPoints = 0;
            int index = 0;
            int totalPoints;
            string input;
            Console.WriteLine("What Positon? (all,G,F,C)");
            input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
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
                PrintPlayer(player);
                index++;
            }
            Console.WriteLine("Would you like to add/drop a player? (y/n)");
            input = Console.ReadLine();
            if (input == "y")
            {
                AddDrop(a_player);
            }
            TopTenFree.Clear();
        }

        public void AddDrop(LeaugeTeam a_player)
        {
            int playerAdding;
            int playerDropping;
            string input;
            do
            {
                Console.WriteLine("Who would you like to add?");
                input = Console.ReadLine();
                playerAdding = Int32.Parse(input);
                a_player.ShowTeam(PlayerName);
                Console.WriteLine("Who would you like to drop?");
                input = Console.ReadLine();
                playerDropping = Int32.Parse(input);
            } while (PlayerPos[TopTenFree[playerAdding]] != PlayerPos[TopTenFree[playerDropping]] && a_player.CanDraftPosition(PlayerPos, TopTenFree[playerAdding]) == false);
            Console.WriteLine("{0} for {1}", PlayerName[TopTenFree[playerAdding]], PlayerName[a_player.team[playerDropping]]);
            a_player.AddingPlayer(TopTenFree[playerAdding]);
            AddTakenPlayer(TopTenFree[playerAdding]);
            drafted.RemoveAt(drafted.IndexOf(a_player.team[playerDropping]));
            a_player.DroppingPlayer(playerDropping);

        }

        public void AskForTrade(LeaugeTeam a_player, LeaugeTeam a_CPU, LeaugeTeam a_CPU2, LeaugeTeam a_CPU3)
        {
            foreach (LeaugeTeam team in Teams)
            {
                Console.WriteLine(team.GetName());
                team.ShowTeam(PlayerName);
            }
            Console.WriteLine("Who would you like to trade with?");
            string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "CPU1":
            //        Trade(a_player, a_CPU);
            //        break;
            //    case "CPU2":
            //        Trade(a_player, a_CPU2);
            //        break;
            //    case "CPU3":
            //        Trade(a_player, a_CPU3);
            //        break;
            //    default:
            //        Console.WriteLine("invalid");
            //        break;
            //}

        }

        public bool Trade(LeaugeTeam a_player, LeaugeTeam a_CPU, int a_pPlayer, int a_cPlayer)
        {
            int playerPlayer;
            int cpuPlayer;
            bool tradeApprove = false;
            a_player.ShowTeam(PlayerName);
            a_CPU.ShowTeam(PlayerName);
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

        public void ShowStandings(List<LeaugeTeam> a_Teams)
        {
            int top1;
            int top2;
            int bottom1;
            int bottom2;

            if (a_Teams[0].Wins > a_Teams[1].Wins)
            {
                top1 = 0;
                bottom1 = 1;
            }
            else
            {
                top1 = 1;
                bottom1 = 0;
            }
            if (a_Teams[2].Wins > a_Teams[3].Wins)
            {
                top2 = 2;
                bottom2 = 3;
            }
            else
            {
                top2 = 3;
                bottom2 = 2;
            }
            if (a_Teams[top1].Wins < a_Teams[top2].Wins)
            {
                top1 = top1 + top2;
                top2 = top1 - top2;
                top1 = top1 - top2;
            }
            if (a_Teams[bottom1].Wins < a_Teams[bottom2].Wins)
            {
                bottom1 = bottom1 + bottom2;
                bottom2 = bottom1 - bottom2;
                bottom1 = bottom1 - bottom2;
            }
            if (a_Teams[top2].Wins < a_Teams[bottom1].Wins)
            {
                top2 = top2 + bottom1;
                bottom1 = top2 - bottom1;
                top2 = top2 - bottom1;
            }
            Champion = a_Teams[top1].GetName();
            Console.WriteLine("1. {0} {1} {2}", a_Teams[top1].GetName(), a_Teams[top1].Wins, a_Teams[top1].Losses);
            Console.WriteLine("2. {0} {1} {2}", a_Teams[top2].GetName(), a_Teams[top2].Wins, a_Teams[top2].Losses);
            Console.WriteLine("3. {0} {1} {2}", a_Teams[bottom1].GetName(), a_Teams[bottom1].Wins, a_Teams[bottom1].Losses);
            Console.WriteLine("4. {0} {1} {2}", a_Teams[bottom2].GetName(), a_Teams[bottom2].Wins, a_Teams[bottom2].Losses);
        }

      
        public string[] _PlayerName
        {
            get { return PlayerName; }
        }

        public string[] _Playerpos
        {
            get { return PlayerPos; }
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

        public string GetPlayerID(int a_player)
        {
            return PlayerID[a_player];
        }

        public string GetPlayerName(int a_player)
        {
            return PlayerName[a_player];
        }

        public string GetPlayerPos(int a_player)
        {
            return PlayerPos[a_player];
        }

        public string GetPlayerAge(int a_player)
        {
            return PlayerAge[a_player];
        }

        public string GetPlayerTeam(int a_player)
        {
            return PlayerTeam[a_player];
        }

        public string GetPlayerGamesPlayed(int a_player)
        {
            return PlayerGames[a_player];
        }

        public string GetPlayerGamesStart(int a_player)
        {
            return PlayerGamesStart[a_player];
        }

        public string GetPlayerFieldGoal(int a_player)
        {
            return PlayerFieldGoal[a_player];
        }

        public string GetPlayerFieldGoalAtt(int a_player)
        {
            return PlayerFieldGoalAttempt[a_player];
        }

        public string GetPlayer3Point(int a_player)
        {
            return Player3Point[a_player];
        }

        public string GetPlayer2Point(int a_player)
        {
            return Player2Point[a_player];
        }

        public string GetPlayerFt(int a_player)
        {
            return PlayerFreeThow[a_player];
        }

        public string GetPlayerFtAtt(int a_player)
        {
            return PlayerFreeThrowAttempt[a_player];
        }

        public string GetPlayerOffensiveReb(int a_player)
        {
            return PlayerOffensReb[a_player];
        }
        public string GetPlayerDefenceReb(int a_player)
        {
            return PlayerDefenceReb[a_player];
        }

        public string GetPlayerAssist(int a_player)
        {
            return PlayerAssist[a_player];
        }

        public string GetPlayerSteal(int a_player)
        {
            return PlayerSteal[a_player];
        }

        public string GetPlayerBlock(int a_player)
        {
            return PlayerBlock[a_player];
        }

        public string GetPlayerTurnover(int a_player)
        {
            return PlayerTurnover[a_player];
        }
        public string GetPlayerPersFoul(int a_player)
        {
            return PlayerPersFoul[a_player];
        }

        public string GetPlayerPoints(int a_player)
        {
            return PlayerPoints[a_player];
        }
        public bool LoadSeasonStats(Game game, string a_entry)
        {
            String SeasonPath = @"C:\Users\Gabe\source\repos\ConsoleApp1\Seasons\";
            String SeasonSelection;
            Console.WriteLine("What season would you like to simulate? (ex. 2018-2019)");
            Season = a_entry;
            SeasonSelection = SeasonPath + Season + ".csv";
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
                    //string vara1, vara2, vara3, vara4;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            string[] values = line.Split(',');
                            if (values.Length >= 4)
                            {
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
