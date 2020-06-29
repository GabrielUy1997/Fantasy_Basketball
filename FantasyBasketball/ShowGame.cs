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
        List<string> _winners;
        public ShowGame(Game g, LeaugeTeam p1, LeaugeTeam c1, LeaugeTeam c2, LeaugeTeam c3, string seas)
        {
            InitializeComponent();
            _game = g;
            _player1 = p1;
            _cpu1 = c1;
            _cpu2 = c2;
            _cpu3 = c3;
            __season = seas;
            

            ShowSchedule();
            _game.ShowStandings(_game.Teams);

        }

        public void ShowOpp(int teamIndex)
        {
            MatchUpBox.Items.Add(_game.Teams.ElementAt(teamIndex).GetName() + "'s team: ");
            string scores = " ";
            int j = 0;
            foreach (int player in _game.Teams.ElementAt(teamIndex).team)
            {
                Console.Write("{0}.{1}:", (j + 1), _game._PlayerName[player]);

                for (int i = 0; i < 7; i++)
                {
                    Console.Write("{0} ", _game.Teams.ElementAt(teamIndex).PlayersScores[j][i]);
                    scores += " " + _game.Teams.ElementAt(teamIndex).PlayersScores[j][i];
                }
                MatchUpBox.Items.Add((j + 1) + "." + _game._PlayerName[player] + scores);

                scores = " ";
                j++;
                Console.WriteLine("");
            }
        }
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
            ThisWeeksStats.Items.Add(twoWinners[0] + " wins with " + _game.Teams.ElementAt(_game.Teams.FindIndex(x => x.GetName() == twoWinners[0])).WeekScore + " points");
            ThisWeeksStats.Items.Add(twoWinners[1] + " wins with " + _game.Teams.ElementAt(_game.Teams.FindIndex(x => x.GetName() == twoWinners[1])).WeekScore + " points");
            Winners.Items.Add("Winners of week " + (_game.CurrentWeek + 1) + ": " + _game.winners[_game.CurrentWeek]);
            string scores = " ";
            int j = 0;
            MatchUpBox.Items.Add("Player's team: ");
            foreach (int player in _player1.team)
            {
                Console.Write("{0}.{1}:", (j + 1), _game._PlayerName[player]);

                for (int i = 0; i < 7; i++)
                {
                    Console.Write("{0} ", _player1.PlayersScores[j][i]);
                    scores += " " + _player1.PlayersScores[j][i];
                }
                MatchUpBox.Items.Add((j + 1) + "." + _game._PlayerName[player] + scores);

                scores = " ";
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

            //ShowSchedule();


        }

        private void ShowPlayerTeam_Click(object sender, EventArgs e)
        {
            Hide();
            ShowTeamRoster team = new ShowTeamRoster(_game, _player1, this);
            team.Show();
        }

        private void FreeAgentButton_Click(object sender, EventArgs e)
        {
            Hide();
            ShowFreeAgents ShowFA = new ShowFreeAgents(_game, this, _player1);
            ShowFA.Show();
        }

        private void TradingButton_Click(object sender, EventArgs e)
        {
            Hide();
            ShowTrading ShowTrade = new ShowTrading(_game, _player1, _cpu1, _cpu2, _cpu3, this);
            ShowTrade.Show();
        }
    }
}
