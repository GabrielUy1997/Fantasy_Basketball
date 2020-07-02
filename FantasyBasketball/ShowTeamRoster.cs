using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyBasketball
{
    public partial class ShowTeamRoster : Form
    {
        Game __game;
        LeaugeTeam __player1;
        ShowGame _showGame;
        public ShowTeamRoster(Game g, LeaugeTeam p1, ShowGame sg)
        {
            InitializeComponent();
            __player1 = p1;
            __game = g;
            _showGame = sg;
            foreach (int player in __player1.team)
            {
                TeamList.Items.Add((__player1.team.IndexOf(player) + 1 )+ ". "  + __game.GetPlayerName(player));
            }
           
        }

        private void BackFromTeamRoster_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
        }

        private void TeamList_Click(object sender, EventArgs e)
        {
            HistoricalStatsBox.Items.Clear();
            PlayerInfo.Items.Clear();
            FantasyScore.Items.Clear();
            LoadHistoricalStats();
        }

        private void LoadHistoricalStats()
        {
            string Name;
            string Pos;
            string Age;
            string Team;
            string GamesPlayed;
            string GamesStarted;
            string FG;
            string FGA;
            string ThreePointers;
            string TwoPointers;
            string FT;
            string FTA;
            string ORB;
            string DRB;
            string AST;
            string STL;
            string BLK;
            string TOV;
            string PF;
            string PTS;
            string SeasonPath = @"C:\Users\Gabe\source\repos\ConsoleApp1\Seasons\";
            int ActiveSeasons = 1;
            bool IsInSeason = false;
            int HistoricalSeason;
            string IndexSeason;
            string s;
            string ForPicture = " ";
            string[] seasons;
            string[] name;
            seasons = _showGame.__season.Split('-');
            HistoricalSeason = Int32.Parse(seasons[0]);
            IndexSeason = (HistoricalSeason - ActiveSeasons).ToString() + "-" + HistoricalSeason.ToString();
            HistoricalStatsBox.Items.Add("Season" + " POS" + " Age" + " TM" + " GP" + " GS" + " FG" + " FGA" + " 3PT" + " 2PT" + " FT" + " FTA" + " ORB" + " DRB" + " AST" + " STL" + " BLK" + " TOV" + " PF" + " PTS");
            HistoricalStatsBox.Items.Add(" ");
           
            do
            {
                IsInSeason = false;

                StreamReader reader = new StreamReader(File.OpenRead(SeasonPath + IndexSeason + ".csv"));
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(',');
                        if(values[1].Contains("\\") && values[1].Contains(__game._PlayerName[__player1.team[TeamList.SelectedIndex]]))
                        {
                            name = values[1].Split('\\');
                            s = name[0];
                            ForPicture = name[1];
                        }
                        else
                        {
                            s = values[1];
                            if (s == __game._PlayerName[__player1.team[TeamList.SelectedIndex]])
                            {
                                ForPicture = __game._PlayerPhoto[__player1.team[TeamList.SelectedIndex]];
                            }           
                        }
                        if (values.Length >= 4 && s == __game._PlayerName[__player1.team[TeamList.SelectedIndex]])
                        {
                            Name = s;
                            Pos = values[2];
                            Age = values[3];
                            Team = values[4];
                            GamesPlayed = values[5];
                            GamesStarted = values[6];
                            FG = values[8];
                            FGA = values[9];
                            ThreePointers = values[11];
                            TwoPointers = values[14];
                            FT = values[18];
                            FTA = values[19];
                            ORB = values[21];
                            DRB = values[22];
                            AST = values[24];
                            STL = values[25];
                            BLK = values[26];
                            TOV = values[27];
                            PF = values[28];
                            PTS = values[29];
                            IsInSeason = true;
                            HistoricalStatsBox.Items.Add(IndexSeason + ":" + Pos + " " + Age + " " + Team + " " + GamesPlayed + " " + GamesStarted + " " + FG + " " + FGA + " " + ThreePointers + " " + TwoPointers + " " + FT + " " + FTA 
                                + " " + ORB + " " + DRB + " " + AST + " " + STL + " " + BLK + " " + TOV + " " + PF + " " + PTS);
                            break;
                        }
                    }
                   
                }
                ActiveSeasons++;
                IndexSeason = (HistoricalSeason - ActiveSeasons).ToString() + "-" + (HistoricalSeason - (ActiveSeasons - 1)).ToString();
                if(!File.Exists(SeasonPath + IndexSeason + ".csv"))
                {
                    break;
                }
            } while (IsInSeason == true);
            pictureBox1.Load("https://d2cwpp38twqe55.cloudfront.net/req/202006192/images/players/" + ForPicture + ".jpg");
            PlayerInfo.Items.Add("Name: " + __game._PlayerName[__player1.team[TeamList.SelectedIndex]]);
            PlayerInfo.Items.Add("Age: " + __game.GetPlayerAge(__player1.team[TeamList.SelectedIndex]));
            PlayerInfo.Items.Add("Current Team: " + __game.GetPlayerTeam(__player1.team[TeamList.SelectedIndex]));
            for(int i = 0; i < __game.CurrentWeek; i++)
            {
                FantasyScore.Items.Add("Week " + (i+1) + " Stats:" +  __player1.WeeklyScores[TeamList.SelectedIndex][i].ToString());
            }
            
        }
    }
}
