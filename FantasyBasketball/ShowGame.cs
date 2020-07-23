using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyBasketball
{
    public partial class ShowGame : Form
    {
        Game _game;
        LeaugeTeam _player1;
        LeaugeTeam _cpu1;
        LeaugeTeam _cpu2;
        LeaugeTeam _cpu3;
        public string __season;
        public bool AddDropped = false;
        public bool Traded = false;
        List<string> _winners;
        /*
        public ShowGame(Game g, LeaugeTeam p1, LeaugeTeam c1, LeaugeTeam c2, LeaugeTeam c3, string seas)
        
        NAME: 
            ShowGame
        SYNOPSIS:
            
             public ShowGame(Game g, LeaugeTeam p1, LeaugeTeam c1, LeaugeTeam c2, LeaugeTeam c3, string seas);
             g --> current Game object being used
             p1 --> The human players LeaugeTeam object
             c1 --> CPU1's LeaugeTeam object
             c2 --> CPU2's LeaugeTeam object
             c3 --> CPU3's LeaugeTeam object
             seas --> The season that the user selected to be simulated

        DESCRIPTION:
            
            Constructor for the ShowGame class
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public ShowGame(Game g, LeaugeTeam p1, LeaugeTeam c1, LeaugeTeam c2, LeaugeTeam c3, string seas)
        {
            InitializeComponent();
            _game = g;
            _player1 = p1;
            _cpu1 = c1;
            _cpu2 = c2;
            _cpu3 = c3;
            __season = seas;
            pictureBox1.Load("https://d2p3bygnnzw9w3.cloudfront.net/req/202006171/tlogo/bbr/NBA-2019.png");
            SeasonLabel.Text = "The " + __season + " Season";
            ShowSchedule();
            _game.ShowStandings(_game.Teams);

        }

        /*
        public void ShowOpp(int teamIndex)
        
        NAME: 
            public void ShowOpp
        SYNOPSIS:
            
            public void ShowOpp(int teamIndex)
            teamIndex --> the index of the team that the player is matched
            up against in the list of teams.

        DESCRIPTION:
            
            Used to display the opponents team and the players fantasy scores
            for the current week
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void ShowOpp(int teamIndex)
        {
            MatchUpBox.Items.Add(_game.Teams.ElementAt(teamIndex).GetName() + "'s team: ");
            string scores = " ";
            double totalscore = 0;
            int j = 0;
            foreach (int player in _game.Teams.ElementAt(teamIndex).team)
            {
                Console.Write("{0}.{1}:", (j + 1), _game._PlayerName[player]);

                for (int i = 0; i < 7; i++)
                {
                    Console.Write("{0} ", _game.Teams.ElementAt(teamIndex).PlayersScores[j][i]);
                    scores += " " + _game.Teams.ElementAt(teamIndex).PlayersScores[j][i];
                    totalscore += _game.Teams.ElementAt(teamIndex).PlayersScores[j][i];
                }
                MatchUpBox.Items.Add((j + 1) + "." + _game._PlayerName[player] + scores + " Total: " + totalscore.ToString());
                totalscore = 0;
                scores = " ";
                j++;
                Console.WriteLine("");
            }
        }

        /*
        public void ShowSchedule()
        
        NAME: 
            ShowSchedule
        SYNOPSIS:
            
            public void ShowSchedule();

        DESCRIPTION:
            
            Used to display all the matchups for the whole season
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        public void ShowSchedule()
        {
            ScheduleBox.Items.Clear();
            //https://stackoverflow.com/questions/16572362/rearrange-a-list-based-on-given-order-in-c-sharp 5/20/20
            foreach (int week in _game.Week)
            {
                if(week < 20)
                {
                    Console.WriteLine("{0}.", week);
                    if (_game._matchup == 3)
                    {
                        _game.Teams = _game.MatchupType4.Select(i => _game.Teams[i]).ToList();
                        _game._matchup = 0;
                    }
                    if (_game._matchup == 0)
                    {
                        _game.Teams = _game.MatchupType1.Select(i => _game.Teams[i]).ToList();
                        _game._matchup = 1;
                    }
                    else if (_game._matchup == 1)
                    {
                        _game.Teams = _game.MatchupType2.Select(i => _game.Teams[i]).ToList();
                        _game._matchup = 2;
                    }
                    else if (_game._matchup == 2)
                    {
                        _game.Teams = _game.MatchupType3.Select(i => _game.Teams[i]).ToList();
                        _game._matchup = 3;
                    }
                   
                    Console.WriteLine("{0} vs. {1}, {2} vs. {3}", _game.Teams[0].GetName(), _game.Teams[1].GetName(), _game.Teams[2].GetName(), _game.Teams[3].GetName());
                    ScheduleBox.Items.Add(week + ". " + _game.Teams[0].GetName() + " vs. " + _game.Teams[1].GetName() + " , " + _game.Teams[2].GetName() + " vs. " + _game.Teams[3].GetName());
                   
                }
            }
            _game._matchup = 0;
        }

        /*
        private void AdvanceWeekButton_Click(object sender, EventArgs e)
        
        NAME: 
            private void AdvanceWeekButton_Click
        SYNOPSIS:
            
             private void AdvanceWeekButton_Click(object sender, EventArgs e);
             sender --> reference to object that raised event.
             e --> event data

        DESCRIPTION:
            
            Button event handler when the user clicks the Advance week button,
            its sets the matchup for the new week and displays all the stats
            for the new week and past weeks.
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void AdvanceWeekButton_Click(object sender, EventArgs e)
        {
            if (_game._matchup == 0)
            {
                _game.Teams = _game.MatchupType1.Select(i => _game.Teams[i]).ToList();
                _game._matchup = 1;
            }
            else if (_game._matchup == 1)
            {
                _game.Teams = _game.MatchupType2.Select(i => _game.Teams[i]).ToList();
                _game._matchup = 2;
            }
            else if (_game._matchup == 2)
            {
                _game.Teams = _game.MatchupType3.Select(i => _game.Teams[i]).ToList();
                _game._matchup = 3;
            }
            else if (_game._matchup == 3)
            {
                _game.Teams = _game.MatchupType4.Select(i => _game.Teams[i]).ToList();
                _game._matchup = 1;
            }
            _winners = _game.SetUpWeekMatchup(_player1, _cpu1, _cpu2, _cpu3);
            MatchUpBox.Items.Clear();
            ThisWeeksStats.Items.Clear();
            ThisWeeksStats.Items.Add("Week " + (_game.CurrentWeek + 1) + ":");
            ThisWeeksStats.Items.Add(_game.Teams[0].GetName() + " vs. " + _game.Teams[1].GetName() + " || " + _game.Teams[2].GetName() + " vs. " + _game.Teams[3].GetName());
            ThisWeeksStats.Items.Add(_game.Teams[0].GetName() + ": " + _game.Teams[0].WeekScore + " vs. " + _game.Teams[1].GetName() + ": " + _game.Teams[1].WeekScore);
            ThisWeeksStats.Items.Add(_game.Teams[2].GetName() + ": " + _game.Teams[2].WeekScore + " vs. " + _game.Teams[3].GetName() + ": " + _game.Teams[3].WeekScore);
            string[] twoWinners = _winners.ElementAt(_game.CurrentWeek).Split(' ');
            ThisWeeksStats.Items.Add(twoWinners[0] + " wins with " + _game.Teams.ElementAt(_game.Teams.FindIndex(x => x.GetName() == twoWinners[0])).WeekScore + " points and " 
                + twoWinners[1] + " wins with " + _game.Teams.ElementAt(_game.Teams.FindIndex(x => x.GetName() == twoWinners[1])).WeekScore + " points");
            Winners.Items.Add("Winners of week " + (_game.CurrentWeek + 1) + ": " + _game.winners[_game.CurrentWeek]);
            string scores = " ";
            double total = 0;
            int j = 0;
            MatchUpBox.Items.Add("Player's team: ");
            foreach (int player in _player1.team)
            {
                Console.Write("{0}.{1}:", (j + 1), _game._PlayerName[player]);

                for (int i = 0; i < 7; i++)
                {
                    Console.Write("{0} ", _player1.PlayersScores[j][i]);
                    total += _player1.PlayersScores[j][i];
                    scores += " " + _player1.PlayersScores[j][i];
                }
                MatchUpBox.Items.Add((j + 1) + "." + _game._PlayerName[player] + scores + " Total: " + total);

                scores = " ";
                total = 0;
                j++;
                Console.WriteLine("");
            }
            MatchUpBox.Items.Add("Vs.");
            switch (_game.Teams.FindIndex(x => x.GetName() == "Player"))
            {
                case 0:
                    ShowOpp(1);
                    break;
                case 1:
                    ShowOpp(0);
                    break;
                case 2:
                    ShowOpp(3);
                    break;
                case 3:
                    ShowOpp(2);
                    break;
            }
            _game.ResetPlayerScores();
           
            StandingsBox.Items.Clear();
            foreach(LeaugeTeam team in _game.ShowStandings(_game.Teams))
            {
                StandingsBox.Items.Add(team.GetName() + " " + team._Wins + "-" + team._Losses);
            }
            if (_game.CurrentWeek == 18)
            {
                System.Windows.Forms.MessageBox.Show(_game._Champion + " is the " + __season + " season Champion!!");
                SeasonSelect NewSeason = new SeasonSelect();
                Hide();
                NewSeason.Show();

            }
            else
            {
                _game.CurrentWeek++;
            }
            AddDropped = false;
        }

        /*
        private void ShowPlayerTeam_Click(object sender, EventArgs e)
        
        NAME: 
            ShowPlayerTeam_Click
        SYNOPSIS:
            
            private void ShowPlayerTeam_Click(object sender, EventArgs e);
             sender --> reference to object that raised event.
             e --> event data

        DESCRIPTION:
            
            ShowPlayerTeam button event handler
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void ShowPlayerTeam_Click(object sender, EventArgs e)
        {
            Hide();
            ShowTeamRoster team = new ShowTeamRoster(_game, _player1, this);
            team.Show();
        }

        /*
       private void FreeAgentButton_Click(object sender, EventArgs e)
        
        NAME: 
            FreeAgentButton_Click
        SYNOPSIS:
            
             private void FreeAgentButton_Click(object sender, EventArgs e);
              sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
            FreeAgentButton event handler
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void FreeAgentButton_Click(object sender, EventArgs e)
        {
            Hide();
            ShowFreeAgents ShowFA = new ShowFreeAgents(_game, this, _player1);
            ShowFA.Show();
        }

        /*
        private void TradingButton_Click(object sender, EventArgs e)
        
        NAME: 
            TradingButton_Click
        SYNOPSIS:
            
            private void TradingButton_Click(object sender, EventArgs e);
             sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
            TradingButton event handler
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void TradingButton_Click(object sender, EventArgs e)
        {
            Hide();
            ShowTrading ShowTrade = new ShowTrading(_game, _player1, _cpu1, _cpu2, _cpu3, this);
            ShowTrade.Show();
        }
    }
}
