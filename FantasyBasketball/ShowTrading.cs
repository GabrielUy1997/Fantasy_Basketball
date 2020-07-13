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

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
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

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void BackFromTrading_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
            TradeButton.Enabled = false;
            TradeResultBox.Items.Clear();
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
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

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
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

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
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

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void TradeButton_Click(object sender, EventArgs e)
        {
            int pPlayer = PlayersPlayerBox.SelectedIndex;
            int cPlayer = CPUPlayerBox.SelectedIndex;
            string pTradedName = __game._PlayerName[__player1.team[pPlayer]];
            string cTradedName = __game._PlayerName[__game.Teams[(__game.Teams.FindIndex(x => x.GetName() == tradingTeam))].team[cPlayer]];
            try
            {
                if(_showGame.Traded == true)
                {
                    throw new Exception();
                }
                else
                {
                    if (__game.Trade(__player1, __game.Teams[(__game.Teams.FindIndex(x => x.GetName() == tradingTeam))], pPlayer, cPlayer) == false)
                    {
                        TradeResultBox.Items.Clear();
                        TradeResultBox.Items.Add("The trade was Denied");
                    }
                    else
                    {
                        TradeResultBox.Items.Clear();
                        TradeResultBox.Items.Add("The trade was accepted:");
                        TradeResultBox.Items.Add("You traded " + pTradedName + " for " + cTradedName);
                        PlayersPlayerBox.Items.Clear();
                        CPUPlayerBox.Items.Clear();
                        foreach (int player in __player1.team)
                        {
                            PlayersPlayerBox.Items.Add(__game._PlayerName[player]);
                        }
                        foreach (int player in __game.Teams[(__game.Teams.FindIndex(x => x.GetName() == tradingTeam))].team)
                        {
                            CPUPlayerBox.Items.Add(__game._PlayerName[player]);
                        }

                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("You have reached the limit of available Add/Drops this week");
            }
            computerSelected = false;
            playerSelected = false;
        }

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
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

        /*
       
        
        NAME: 
        SYNOPSIS:
            
            

        DESCRIPTION:
            
            
        
        RETURNS:
            
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
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
