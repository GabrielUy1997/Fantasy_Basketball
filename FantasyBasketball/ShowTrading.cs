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
        string tradingTeam;
        bool playerSelected = false;
        bool computerSelected = false;

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

            foreach (int player in __player1.team)
            {
                PlayersPlayerBox.Items.Add(__game._PlayerName[player]);
            }
        }

        private void BackFromTrading_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
            TradeButton.Enabled = false;
        }

        private void Team1Button_Click(object sender, EventArgs e)
        {
            CPUPlayerBox.Items.Clear();
            foreach(int player in __cpu1.team)
            {
                CPUPlayerBox.Items.Add(__game._PlayerName[player]);
            }
            tradingTeam = __cpu1.GetName();
            CPUteamLabel.Text = __cpu1.GetName() + "'s Team:";
            TradeButton.Enabled = false;
        }

        private void Team2Button_Click(object sender, EventArgs e)
        {
            CPUPlayerBox.Items.Clear();
            foreach (int player in __cpu2.team)
            {
                CPUPlayerBox.Items.Add(__game._PlayerName[player]);
            }
            tradingTeam = __cpu2.GetName();
            CPUteamLabel.Text = __cpu2.GetName() + "'s Team:";
            TradeButton.Enabled = false;
        }

        private void Team3Button_Click(object sender, EventArgs e)
        {
            CPUPlayerBox.Items.Clear();
            foreach (int player in __cpu3.team)
            {
                CPUPlayerBox.Items.Add(__game._PlayerName[player]);
            }
            tradingTeam = __cpu3.GetName();
            CPUteamLabel.Text = __cpu3.GetName() + "'s Team:";
            TradeButton.Enabled = false;
        }

        private void TradeButton_Click(object sender, EventArgs e)
        {
            __game.Trade(__player1, __game.Teams[(__game.Teams.FindIndex(x => x.GetName() == tradingTeam))]);
            computerSelected = false;
            playerSelected = false;
        }

        private void PlayersPlayerBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            playerSelected = true;
            if(PlayersPlayerBox.CheckedItems.Count != 0)
            {
                TradeButton.Enabled = false;
                playerSelected = false;
            }
            else if(computerSelected == true)
            {
                TradeButton.Enabled = true;
            }
        }

        private void CPUPlayerBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            computerSelected = true;
            if (CPUPlayerBox.CheckedItems.Count != 0)
            {
                TradeButton.Enabled = false;
                computerSelected = false;
            }
            else if(playerSelected == true)
            {
                TradeButton.Enabled = true;
            }
        }

        private void resetTradeBox_Click(object sender, EventArgs e)
        {
            foreach(int checkedItem in PlayersPlayerBox.CheckedIndices)
            {
                PlayersPlayerBox.SetItemChecked(checkedItem, false);
            }
            foreach (int checkedItem in CPUPlayerBox.CheckedIndices)
            {
                CPUPlayerBox.SetItemChecked(checkedItem, false);
            }
        }
    }
}
