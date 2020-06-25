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
            HistoricalStatsBox.Items.Add(TeamList.SelectedItems.ToString());
        }
    }
}
