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
    public partial class ShowTrading : Form
    {
        Game __game;
        LeaugeTeam __player1;
        LeaugeTeam __cpu1;
        LeaugeTeam __cpu2;
        LeaugeTeam __cpu3;
        ShowGame _showGame;
        public ShowTrading(Game g, LeaugeTeam p1, LeaugeTeam c1, LeaugeTeam c2, LeaugeTeam c3, ShowGame sg)
        {
            InitializeComponent();
            __game = g;
            __player1 = p1;
            __cpu1 = c1;
            __cpu2 = c2;
            __cpu3 = c3;
            _showGame = sg;
            Team1Button.Text = __cpu1.GetName();
            Team2Button.Text = __cpu2.GetName();
            Team3Button.Text = __cpu3.GetName();
        }

        private void BackFromTrading_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
        }
    }
}
