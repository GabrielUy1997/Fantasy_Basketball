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
        public LeaugeTeam()
        
        NAME: 
            LeaugeTeam
        SYNOPSIS:
            
            public LeaugeTeam()

        DESCRIPTION:
            
            Constructor for the LeaugeTeam class, initializes the lists
            that hold each individual player's scores for each week and
            past weeks.
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
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
        public void AddingPlayer(int a_player)
        
        NAME: 
        SYNOPSIS:
            
            public void AddingPlayer(int a_player);
            a_player --> the id of player being added to the team

        DESCRIPTION:
            
            This is used when a player is being added to the team
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
        */
        public void AddingPlayer(int a_player)
        {
            team.Add(a_player);
            NumPlayers++;
        }

        /*
        public void DroppingPlayer(int a_player)
        
        NAME: 
            DroppingPlayer
        SYNOPSIS:
            
            public void DroppingPlayer(int a_player);
            a_player --> the id of the player being removed from team

        DESCRIPTION:
            
            This is used to remove players from the team
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
        */
        public void DroppingPlayer(int a_player)
        {
            team.RemoveAt(a_player);
            NumPlayers--;
        }

        /*
        public String GetName()
        
        NAME: 
            GetName
        SYNOPSIS:
            
            public String GetName()

        DESCRIPTION:
            
            used to get the name of the team
        
        RETURNS:
            string, the teams name
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
        */
        public String GetName()
        {
            return TeamName;
        }

        /*
        public virtual bool CanDraftPosition(String[] a_PlayerPos, int a_pID)
        
        NAME: 
            CanDraftPosition
        SYNOPSIS:
            
            public virtual bool CanDraftPosition(String[] a_PlayerPos, int a_pID);
            a_PlayerPos --> array of all the players postions
            a_pID --> the id of the player whos postions being checked

        DESCRIPTION:
            
            This makes sure the player being chosen is a valid choice based
            on the number of players the team has in a position
        
        RETURNS:
            bool, whether it was a valid selection or not
        AUTHOR:
            Gabriel Uy
        DATE:
            07/23/2020
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

        public virtual bool AssessTrade(int a_recieve, int a_send, string[] a_Points, string[] a_OReb, string[] a_DReb, string[] a_Ast,
            string[] a_Block, string[] a_Steal, string[] a_Tov)
        {
            return true;
        }

        
        public virtual bool CanDraft()
        {
            return false;
        }

        /*
        public void AddGuard()
        
        NAME:
            AddGuard
        SYNOPSIS:
            
            public void AddGuard();

        DESCRIPTION:
            
            This is used when a team is adding a player that is a
            guard to the team   
        
        RETURNS:
            None 
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
        */
        public void AddGuard()
        {
            Guards++;
        }

        /*
        public void AddForward()
        
        NAME: 
            AddForward
        SYNOPSIS:
            
            public void AddForward();

        DESCRIPTION:
            
            This is used when a team is adding a player that is a
            guard to the team           
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
        */
        public void AddForward()
        {
            Forwards++;
        }

        /*
        public void AddCenters()
        
        NAME: 
            AddCenters
        SYNOPSIS:
            
            public void AddCenters();

        DESCRIPTION:
            
            This is used when a team is adding a player that is a
            centers to the team           
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
        */
        public void AddCenters()
        {
            Center++;
        }

        /*
        public void RemoveGuard()
        
        NAME: 
        SYNOPSIS:
            
            public void RemoveGuard();

        DESCRIPTION:
            
            This is used for when a guard is being dropped from a
            team
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
        */
        public void RemoveGuard()
        {
            Guards--;
        }

        /*
        public void RemoveForward()
        
        NAME: 
            RemoveForward
        SYNOPSIS:
            
            public void RemoveForward();

        DESCRIPTION:
            
            This is used for when a forward is being dropped from a
            team            
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
        */
        public void RemoveForward()
        {
            Forwards--;
        }

        /*
        public void RemoveCenter()
        
        NAME: 
            RemoveCenter
        SYNOPSIS:
            
            public void RemoveCenter();

        DESCRIPTION:
            
            This is used for when a center is being dropped from a
            team           
        
        RETURNS:
           None
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

        public Human(String Name)
        {
            TeamName = Name;
            IsHuman = true;
        }

        /*
        public override bool CanDraft()
        
        NAME: 
            CanDraft
        SYNOPSIS:
            
            public override bool CanDraft();

        DESCRIPTION:
            
            Used to tell if the team is the users team
        
        RETURNS:
            bool, whether if the team is a run by a computer
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
        */
        public override bool CanDraft()
        {
            return IsHuman;
        }


        /*
        public override bool CanDraftPosition(String[] a_PlayerPos, int a_pID);
        
        NAME: 
            CanDraftPosition
        SYNOPSIS:
            
            public override bool CanDraftPosition(String[] a_PlayerPos, int a_pID);
            a_PlayPos --> the list of all player positions
            a_pID --> a players ID

        DESCRIPTION:
            
            This is used to check if the player selected can be drafted
            based on what position they are
        
        RETURNS:
            bool, if the player can be drafted or not
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
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
    }

    class CPU : LeaugeTeam
    {

        public CPU(String Name)
        {
            TeamName = Name;
            IsHuman = false;
        }

        /*
        public override bool CanDraft()
        
        NAME: 
            CanDraft
        SYNOPSIS:
            
            public override bool CanDraft();

        DESCRIPTION:
            
            Used to tell if the team is the users team
        
        RETURNS:
            bool, whether if the team is a run by a computer
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
        */
        public override bool CanDraft()
        {
            return IsHuman;
        }

        /*
        public override bool CanDraftPosition(String[] a_PlayerPos, int a_pID);
        
        NAME: 
            CanDraftPosition
        SYNOPSIS:
            
            public override bool CanDraftPosition(String[] a_PlayerPos, int a_pID);
            a_PlayPos --> the list of all player positions
            a_pID --> a players ID

        DESCRIPTION:
            
            This is used to check if the player selected can be drafted
            based on what position they are
        
        RETURNS:
            bool, if the player can be drafted or not
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
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
        public override bool AssessTrade(int a_recieve, int a_send, string[] a_Points, string[] a_OReb, string[] a_DReb, string[] a_Ast,
            string[] a_Block, string[] a_Steal, string[] a_Tov)
        
        NAME: 
        SYNOPSIS:
            
            public override bool AssessTrade(int a_recieve, int a_send, string[] a_Points, string[] a_OReb, string[] a_DReb, string[] a_Ast,
            string[] a_Block, string[] a_Steal, string[] a_Tov);

            a_recieve --> the id of the player being recieved in the trade
            a_send --> the id of the player being sent in the trade
            a_Points --> list of all players points
            a_OReb --> list of all players offensive rebounds
            a_DReb --> list of all players defensive rebounds
            a_Ast --> list of all players assists
            a_Block -->  list of all players blocks
            a_Steal --> list of all players steals
            a_Tov -->  list of all players turnovers

        DESCRIPTION:
            
            This is is used for the computer to asess a trade when the user requests one 
        
        RETURNS:
            bool, whether the computer is going to take the trade or not
        AUTHOR:
            Gabriel Uy
        DATE:
            07/27/2020
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
