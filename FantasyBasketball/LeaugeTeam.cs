﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyBasketball
{
    public class LeaugeTeam
    {
        public List<int> team;
        public double[][] PlayersScores;
        public double[][] WeeklyScores;
        public string[][] WeeklyStatLines;
        int NumPlayers;
        protected Boolean IsHuman;
        protected String TeamName;
        public Double WeekScore;
        private int Wins;
        private int Losses;
        protected int Guards;
        protected int Forwards;
        protected int Center;

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public LeaugeTeam()
        {
            team = new List<int>(5);
            
            PlayersScores = new double[5][];
            PlayersScores[0] = new double[7];
            PlayersScores[1] = new double[7];
            PlayersScores[2] = new double[7];
            PlayersScores[3] = new double[7];
            PlayersScores[4] = new double[7];
            WeeklyScores = new double[5][];
            WeeklyScores[0] = new double[19];
            WeeklyScores[1] = new double[19];
            WeeklyScores[2] = new double[19];
            WeeklyScores[3] = new double[19];
            WeeklyScores[4] = new double[19];
            WeeklyStatLines = new string[5][];
            WeeklyStatLines[0] = new string[19];
            WeeklyStatLines[1] = new string[19];
            WeeklyStatLines[2] = new string[19];
            WeeklyStatLines[3] = new string[19];
            WeeklyStatLines[4] = new string[19];
            NumPlayers = 0;
            WeekScore = 0;
            Wins = 0;
            Losses = 0;
            Guards = 0;
            Forwards = 0;
            Center = 0;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void AddingPlayer(int a_player)
        {
            team.Add(a_player);
            NumPlayers++;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void DroppingPlayer(int a_player)
        {
            team.RemoveAt(a_player);
            NumPlayers--;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public String GetName()
        {
            return TeamName;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void ShowTeam(string[] a_playerList)
        {
            
            int j = 0;
            foreach (int player in team)
            {
                Console.Write("{0}.{1}:", j, a_playerList[player]);
                
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("{0} ", PlayersScores[j][i]);
                }
                j++;
                Console.WriteLine("");
            }
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public virtual bool CanDraftPosition(String[] a_PlayerPos, int a_pID)
        {
            string Position = a_PlayerPos[a_pID];
            if (Position.Contains('G') == true && Guards < 2)
            {
                Guards++;
                return true;
            }
            else if (Position.Contains('F') == true && Forwards < 2)
            {
                Forwards++;
                return true;
            }
            else if (Position.Contains('C') == true && Center < 2)
            {
                Center++;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public virtual bool AssessTrade(int a_recieve, int a_send, string[] a_Points, string[] a_OReb, string[] a_DReb, string[] a_Ast,
            string[] a_Block, string[] a_Steal, string[] a_Tov)
        {
            return true;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public virtual bool CanDraft()
        {
            return false;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public virtual int Menu(string[] a_playerList, List<LeaugeTeam> a_teams)
        {
            return 1;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void AddGuard()
        {
            Guards++;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void AddForward()
        {
            Forwards++;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void AddCenters()
        {
            Center++;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void RemoveGuard()
        {
            Guards--;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void RemoveForward()
        {
            Forwards--;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void RemoveCenter()
        {
            Center--;
        }


        public int _Wins
        {
            get { return Wins; }
            set { Wins = value; }
        }

        public int _Losses
        {
            get { return Losses; }
            set { Losses = value; }
        }
    }
    class Human : LeaugeTeam
    {
        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public Human(String Name)
        {
            TeamName = Name;
            IsHuman = true;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public override bool CanDraft()
        {
            return IsHuman;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public override int Menu(string[] a_playerList, List<LeaugeTeam> a_teams)
        {
            string input;
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Advance to Next week");
                Console.WriteLine("2. See your team");
                Console.WriteLine("3. Check Standings");
                Console.WriteLine("4. See the schedule");
                Console.WriteLine("5. See available players");
                Console.WriteLine("6. Inquire trade");
                input = Console.ReadLine();
                if (input == "1")
                {
                    return 1;
                }
                else if (input == "2")
                {
                    ShowTeam(a_playerList);
                }
                else if (input == "3")
                {
                    return 3;
                }
                else if (input == "4")
                {
                    return 4;
                }
                else if (input == "5")
                {
                    return 5;
                }
                else if (input == "6")
                {
                    return 6;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            } while (input != "1");
            return 0;
        }

        public override bool CanDraftPosition(String[] a_PlayerPos, int a_pID)
        {
            string Position = a_PlayerPos[a_pID];
            if (Position.Contains('G') == true && Guards < 2)
            {
                
                return true;
            }
            else if (Position.Contains('F') == true && Forwards < 2)
            {
               
                return true;
            }
            else if (Position.Contains('C') == true && Center < 2)
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class CPU : LeaugeTeam
    {
        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public CPU(String Name)
        {
            TeamName = Name;
            IsHuman = false;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public override bool CanDraft()
        {
            return IsHuman;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public override bool CanDraftPosition(String[] a_PlayerPos, int a_pID)
        {
            string Position = a_PlayerPos[a_pID];
            if (Position.Contains('G') == true && Guards < 2)
            {
                return true;
            }
            else if (Position.Contains('F') == true && Forwards < 2)
            {
                return true;
            }
            else if (Position.Contains('C') == true && Center < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public override bool AssessTrade(int a_recieve, int a_send, string[] a_Points, string[] a_OReb, string[] a_DReb, string[] a_Ast,
            string[] a_Block, string[] a_Steal, string[] a_Tov)
        {
            int betterStats = 0;
            if (Int32.Parse(a_Points[a_recieve]) >= Int32.Parse(a_Points[a_send]))
            {
                betterStats++;
            }
            if (Int32.Parse(a_OReb[a_recieve]) >= Int32.Parse(a_OReb[a_send]))
            {
                betterStats++;
            }
            if (Int32.Parse(a_DReb[a_recieve]) >= Int32.Parse(a_DReb[a_send]))
            {
                betterStats++;
            }
            if (Int32.Parse(a_Ast[a_recieve]) >= Int32.Parse(a_Ast[a_send]))
            {
                betterStats++;
            }
            if (Int32.Parse(a_Block[a_recieve]) >= Int32.Parse(a_Block[a_send]))
            {
                betterStats++;
            }
            if (Int32.Parse(a_Steal[a_recieve]) >= Int32.Parse(a_Steal[a_send]))
            {
                betterStats++;
            }
            if (Int32.Parse(a_Tov[a_recieve]) <= Int32.Parse(a_Tov[a_send]))
            {
                betterStats++;
            }
            if (betterStats >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
