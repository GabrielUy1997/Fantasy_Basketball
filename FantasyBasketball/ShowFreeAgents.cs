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
    public partial class ShowFreeAgents : Form
    {
        Game _game;
        ShowGame _showGame;
        public ShowFreeAgents(Game g, ShowGame sg)
        {
            InitializeComponent();
            _game = g;
            _showGame = sg;
        }

        private void BackFromFreeAgents_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
        }
    }
}
