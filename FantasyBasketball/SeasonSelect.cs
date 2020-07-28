using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace FantasyBasketball
{
    public partial class SeasonSelect : Form
    {
        Game game = new Game();
        public static string Season = "";
        /*
        public SeasonSelect()
        
        NAME: 
            SeasonSelect
        SYNOPSIS:
            
            public SeasonSelect();

        DESCRIPTION:
            
          Constructor for the SeasonSelect class  
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/15/2020
        */
        public SeasonSelect()
        {
            InitializeComponent();
            ShowAvailableSeasons();
        }

        /*
       private void SubmitButton_Click(object sender, EventArgs e)
        
        NAME: 
            SubmitButton_Click
        SYNOPSIS:
            
            private void SubmitButton_Click(object sender, EventArgs e);

        DESCRIPTION:
            
            Event handler for the SubmitButton, shows the drafting phase
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/15/2020
        */
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Season = SeasonEntry.Text;
            ShowDrafting showDrafting = new ShowDrafting(Season);
            if(game.LoadSeasonStats(game, Season) == true)
            {
                Hide();
                showDrafting.StartGame(game, Season);
                showDrafting.Show();
                showDrafting.PlayerSelect();
            }
            
        }

        /*
        private void ShowAvailableSeasons()
        
        NAME: 
            ShowAvailableSeasons
        SYNOPSIS:
            
            private void ShowAvailableSeasons();

        DESCRIPTION:
            
            Displays all the seasons available to simulate
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/15/2020
        */
        private void ShowAvailableSeasons()
        {
            string IndexSeason = "2018-2019";
            int SeasonIndex = 1;
            int FirstPartSeason = 2018;
            bool AvailableSeason;
            do
            {
                AvailableSeason = false;

                StreamReader reader = new StreamReader(File.OpenRead(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Seasons\" + IndexSeason + ".csv"));
                if(File.Exists(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Seasons\" + IndexSeason + ".csv"))
                {
                    AvailableSeason = true;
                    SeasonListBox.Items.Add(IndexSeason);
                }
                SeasonIndex++;
                IndexSeason = (FirstPartSeason - SeasonIndex).ToString() + "-" + (FirstPartSeason - (SeasonIndex - 1)).ToString();
                if (!File.Exists(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Seasons\" + IndexSeason + ".csv"))
                {
                    break;
                }

            } while (AvailableSeason == true);
        }

        /*
        private void QuitGameButton_Click(object sender, EventArgs e)
        
        NAME: 
            QuitGameButton_Click
        SYNOPSIS:
            
            private void QuitGameButton_Click(object sender, EventArgs e)
              sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
            Exits the application
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/15/2020
        */
        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
