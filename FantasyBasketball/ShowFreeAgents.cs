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
        LeaugeTeam __player1;
        bool FASelected = false;
        bool PlayerSelected = false;
        string Catagory;
        string ForPicture;
        public ShowFreeAgents(Game g, ShowGame sg, LeaugeTeam p1)
        {
            InitializeComponent();
            _game = g;
            _showGame = sg;
            __player1 = p1;
            //https://stackoverflow.com/questions/19300044/button-performclick-not-working-in-form-load/19300323 6/29/20
            Load += ShowFreeAgents_Load;
            AddDropButton.Enabled = false;
            foreach(int player in __player1.team)
            {
                PlayersTeamList.Items.Add(_game._PlayerName[player]);
            }
        }

        private void ShowFreeAgents_Load(object sender, EventArgs e)
        {
            AutoLoadAll();
        }

        private void BackFromFreeAgents_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
        }

        private void AllPosButton_Click(object sender, EventArgs e)
        {
            FreeAgentsList.Items.Clear();
            Catagory = "all";
            foreach (int players in _game.ShowFreeAgentList(__player1, "all"))
            {
                FreeAgentsList.Items.Add(_game._PlayerName[players]);
            }
        }

        private void GuardPosButton_Click(object sender, EventArgs e)
        {
            FreeAgentsList.Items.Clear();
            Catagory = "G";
            foreach (int players in _game.ShowFreeAgentList(__player1, "G"))
            {
                FreeAgentsList.Items.Add(_game._PlayerName[players]);
            }
        }

        private void ForwardPosButton_Click(object sender, EventArgs e)
        {
            FreeAgentsList.Items.Clear();
            Catagory = "F";
            foreach (int players in _game.ShowFreeAgentList(__player1, "F"))
            {
                FreeAgentsList.Items.Add(_game._PlayerName[players]);
            }
        }

        private void CentersPosButton_Click(object sender, EventArgs e)
        {
            FreeAgentsList.Items.Clear();
            Catagory = "C";
            foreach (int players in _game.ShowFreeAgentList(__player1, "C"))
            {
                FreeAgentsList.Items.Add(_game._PlayerName[players]);
            }
        }

        private void AddDropButton_Click(object sender, EventArgs e)
        {
            string PlayerDropping;
            string PlayerAdding;
            try
            {
                if(PlayersTeamList.SelectedIndex == -1 || FreeAgentsList.SelectedIndex == -1)
                {
                    throw new Exception();
                }
                else
                {
                    PlayerDropping = _game._PlayerName[__player1.team[PlayersTeamList.SelectedIndex]];
                    PlayerAdding = _game._PlayerName[_game.TopTenFree[FreeAgentsList.SelectedIndex]];
                    try
                    {
                        if (_game.AddDropFreeAgents(__player1, PlayersTeamList.SelectedIndex, FreeAgentsList.SelectedIndex) == true)
                        {
                            AddDropBox.Items.Clear();
                            AddDropBox.Items.Add("Dropped " + PlayerDropping + " for " + PlayerAdding);
                            FreeAgentsList.Items.Clear();
                            PlayersTeamList.Items.Clear();
                            foreach (int player in __player1.team)
                            {
                                PlayersTeamList.Items.Add(_game._PlayerName[player]);
                            }
                            foreach (int player in _game.ShowFreeAgentList(__player1, Catagory))
                            {
                                FreeAgentsList.Items.Add(_game._PlayerName[player]);
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Too many players of the same position on the team");
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Please select one player from each list");
            }

            AddDropButton.Enabled = false;
        }

        private void FreeAgentsList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            FABox.Items.Clear();
            ForPicture = _game._PlayerPhoto[_game.TopTenFree[FreeAgentsList.SelectedIndex] - 1];
            pictureBox1.Load("https://d2cwpp38twqe55.cloudfront.net/req/202006192/images/players/" + ForPicture + ".jpg");
            FABox.Items.Add(_game._PlayerName[_game.TopTenFree[FreeAgentsList.SelectedIndex]] +  " " + _game._Playerpos[_game.TopTenFree[FreeAgentsList.SelectedIndex]]);
            FASelected = true;
            if (FreeAgentsList.CheckedItems.Count != 0)
            {
                AddDropButton.Enabled = false;
                FASelected = false;
            }
            else if (PlayerSelected == true)
            {
                AddDropButton.Enabled = true;
            }
        }

        private void PlayersTeamList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            PlayerBox.Items.Clear();
            ForPicture = _game._PlayerPhoto[__player1.team[PlayersTeamList.SelectedIndex] - 1];
            pictureBox2.Load("https://d2cwpp38twqe55.cloudfront.net/req/202006192/images/players/" + ForPicture + ".jpg");
            PlayerBox.Items.Add(_game._PlayerName[__player1.team[PlayersTeamList.SelectedIndex]] + " " + _game._Playerpos[__player1.team[PlayersTeamList.SelectedIndex]]);
            PlayerSelected = true;
            if (PlayersTeamList.CheckedItems.Count != 0)
            {
               
                AddDropButton.Enabled = false;
                PlayerSelected = false;
            }
            else if (FASelected == true)
            {
                AddDropButton.Enabled = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (int checkedItem in PlayersTeamList.CheckedIndices)
            {
                PlayersTeamList.SetItemChecked(checkedItem, false);
            }
            foreach (int checkedItem in FreeAgentsList.CheckedIndices)
            {
                FreeAgentsList.SetItemChecked(checkedItem, false);
            }
        }

        private void AutoLoadAll()
        {
            AllPosButton.PerformClick();
        }
    }
}
