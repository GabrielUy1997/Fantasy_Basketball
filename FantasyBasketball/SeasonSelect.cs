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
    public partial class SeasonSelect : Form
    {
        Game game = new Game();
        public static string Season = "";
        public SeasonSelect()
        {
            InitializeComponent();
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

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
