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

namespace FantasyBasketball
{
    public partial class SeasonSelect : Form
    {
        Game game = new Game();
        public static string Season = "";
        public SeasonSelect()
        {
            InitializeComponent();
            ShowAvailableSeasons();
        }
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

        private void ShowAvailableSeasons()
        {
            string IndexSeason = "2018-2019";
            int SeasonIndex = 1;
            int FirstPartSeason = 2018;
            bool AvailableSeason;
            do
            {
                AvailableSeason = false;

                StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\Gabe\source\repos\ConsoleApp1\Seasons\" + IndexSeason + ".csv"));
                if(File.Exists(@"C:\Users\Gabe\source\repos\ConsoleApp1\Seasons\" + IndexSeason + ".csv"))
                {
                    AvailableSeason = true;
                    SeasonListBox.Items.Add(IndexSeason);
                }
                SeasonIndex++;
                IndexSeason = (FirstPartSeason - SeasonIndex).ToString() + "-" + (FirstPartSeason - (SeasonIndex - 1)).ToString();
                if (!File.Exists(@"C:\Users\Gabe\source\repos\ConsoleApp1\Seasons\" + IndexSeason + ".csv"))
                {
                    break;
                }

            } while (AvailableSeason == true);
        } 

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
