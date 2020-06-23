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
    public partial class TeamRoster : Form
    {
        Game _game;
        LeaugeTeam _player1;
        ShowGame _showGame;
        public TeamRoster(Game g, LeaugeTeam p1, ShowGame sg)
        {
            InitializeComponent();
            _player1 = p1;
            _game = g;
            _showGame = sg;
            foreach (int player in _player1.team)
            {
                TeamList.Items.Add((_player1.team.IndexOf(player) + 1 )+ ". "  + _game.GetPlayerName(player));
            }
        }

        private void BackFromTeamRoster_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
        }
    }
}
