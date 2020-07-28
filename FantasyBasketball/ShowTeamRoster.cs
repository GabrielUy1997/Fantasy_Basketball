using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        /*
        public ShowTeamRoster(Game g, LeaugeTeam p1, ShowGame sg)
        
        NAME: ShowTeamRoster - constructor for the ShowTeamRoster class

        SYNOPSIS:
            
            public ShowTeamRoster(Game g, LeaugeTeam p1, ShowGame sg);
            g --> The current game object to be able to use its public functions
            p1 --> the human players LeaugeTeam object to used to access the 
            team roster.
            sg--> The form object used to display the information on the GUI

        DESCRIPTION:
            
            This is the constructor for the ShowTeamRoster form class, it takes in the 
            current game's object, human player's LeaugeTeam object, and the ShowGame object.
            it creates a local object for all the parameters so that no unwanted changes are made to the 
            original objects since they are just used to get information.

        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:  
            07/08/2020
        */
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

        /*
        private void BackFromTeamRoster_Click(object sender, EventArgs e)
        
        NAME: 
            BackFromTeamRoster_Click
        SYNOPSIS:
            
            private void BackFromTeamRoster_Click(object sender, EventArgs e);
            sender --> reference to object that raised event.
            e --> event data

        DESCRIPTION:
            
            Button event handler to return from the Team Roster page back to 
            the seasons home page.
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void BackFromTeamRoster_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
        }

        /*
       private void TeamList_Click(object sender, EventArgs e)
        
        NAME: 
            TeamList_Click
        SYNOPSIS:
            
            private void TeamList_Click(object sender, EventArgs e);
            sender --> reference to object that raised event.
            e --> event data

        DESCRIPTION:
            
            Button event handler when one of the players on the team list 
            is selected, when selected the HistoricalStatBox, PlayerInfo,
            Fantasyscore text boxes are cleared and the LocalHistoricalStats()
            is called to populate the text boxes with the selected players 
            information.
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void TeamList_Click(object sender, EventArgs e)
        {
            HistoricalStatsBox.Items.Clear();
            PlayerInfo.Items.Clear();
            FantasyScore.Items.Clear();
            LoadHistoricalStats();
        }

        /*
        private void LoadHistoricalStats()
        
        NAME: 
            LoadHistoricalStats
        SYNOPSIS:
            
            private void LoadHistoricalStats();

        DESCRIPTION:
            
            Used to load the selected players historical stats
            and the players photo
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
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
            string FullPath;
            int ActiveSeasons = 1;
            bool IsInSeason = false;
            bool FileFound = false;
            int HistoricalSeason;
            string IndexSeason;
            string SelectedPlayer;
            string ForPicture = " ";
            string[] seasons;
            string[] name;
            seasons = _showGame.__season.Split('-');
            HistoricalSeason = Int32.Parse(seasons[0]);
            IndexSeason = (HistoricalSeason - ActiveSeasons).ToString() + "-" + HistoricalSeason.ToString();
            HistoricalStatsBox.Items.Add("Season" + " POS" + " Age" + " TM" + " GP" + " GS" + " FG" + " FGA" + " 3PT" + " 2PT" + " FT" + " FTA" + " ORB" + " DRB" + " AST" + " STL" + " BLK" + " TOV" + " PF" + " PTS");
            HistoricalStatsBox.Items.Add(" ");
            //this is getting all the stats from past years
            do
            {
                FileFound = false;
                IsInSeason = false;
                //found how to find the file location of the program using a method from this website 7/27/20
                //https://www.delftstack.com/howto/csharp/how-to-get-current-folder-path-in-csharp/
                System.IO.DirectoryInfo path = System.IO.Directory.GetParent(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
                path = System.IO.Directory.GetParent(path.FullName);
                FullPath = path.FullName + @"\Seasons\" + IndexSeason + ".csv";
              
                StreamReader reader = new StreamReader(File.OpenRead(FullPath));
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        //splitting the csv
                        string[] values = line.Split(',');
                        //splitting the player name and id
                        if (values[1].Contains("\\") && values[1].Contains(__game._PlayerName[__player1.team[TeamList.SelectedIndex]]))
                        {
                            name = values[1].Split('\\');
                            SelectedPlayer = name[0];
                            ForPicture = name[1];
                        }
                        else
                        {
                            SelectedPlayer = values[1];
                            if (SelectedPlayer == __game._PlayerName[__player1.team[TeamList.SelectedIndex]])
                            {
                                ForPicture = __game._PlayerPhoto[__player1.team[TeamList.SelectedIndex]];
                            }           
                        }
                        //getting the players stats for current indexSeason
                        //removing a * that the stat website has attatched to player names
                        if (SelectedPlayer.Contains("*"))
                        {
                            SelectedPlayer = SelectedPlayer.Replace("*", string.Empty);
                        }
                        if (values.Length >= 4 && SelectedPlayer == __game._PlayerName[__player1.team[TeamList.SelectedIndex]])
                        {
                            Name = SelectedPlayer;
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
                            HistoricalStatsBox.Items.Add(IndexSeason + ":" + Pos + " " + Age + " " + Team + " " + GamesPlayed + " " + GamesStarted + " " + FG + " " + FGA 
                                + " " + ThreePointers + " " + TwoPointers + " " + FT + " " + FTA + " " + ORB + " " + DRB + " " + AST + " " + STL + " " + BLK + " " + TOV 
                                + " " + PF + " " + PTS);
                            break;
                        }
                    }
                   
                }
                ActiveSeasons++;
                IndexSeason = (HistoricalSeason - ActiveSeasons).ToString() + "-" + (HistoricalSeason - (ActiveSeasons - 1)).ToString();
                //had to use this to see if a season file exists 7/28/20
                //https://www.techiedelight.com/determine-file-exists-csharp/
                DirectoryInfo directory = new DirectoryInfo(path.FullName + @"\Seasons\");
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (string.Compare(file.Name, IndexSeason + ".csv") == 0)
                    {
                        FileFound = true;
                        IsInSeason = true;
                        break;
                    }
                }
                if (FileFound == false)
                {
                    break;
                }
            } while (IsInSeason == true);
            try
            {
                pictureBox1.Load("https://d2cwpp38twqe55.cloudfront.net/req/202006192/images/players/" + ForPicture + ".jpg");
            }
            catch
            {
                System.IO.DirectoryInfo path = System.IO.Directory.GetParent(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
                path = System.IO.Directory.GetParent(path.FullName);
                //this is when the players photo cannot be found
                pictureBox1.Load(path.FullName + @"\Photos\missing.jpg");
            }
            PlayerInfo.Items.Add("Name: " + __game._PlayerName[__player1.team[TeamList.SelectedIndex]]);
            PlayerInfo.Items.Add("Age: " + __game.GetPlayerAge(__player1.team[TeamList.SelectedIndex]));
            PlayerInfo.Items.Add("Current Team: " + __game.GetPlayerTeam(__player1.team[TeamList.SelectedIndex]));
            for(int i = 0; i < __game.CurrentWeek; i++)
            {
                FantasyScore.Items.Add("Week " + (i + 1) + " Stats:" + __player1.WeeklyStatLines[TeamList.SelectedIndex][i].ToString() + " Total:" + __player1.WeeklyScores[TeamList.SelectedIndex][i].ToString());
            }
            
        }
    }
}
