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

        /*
       public ShowFreeAgents(Game g, ShowGame sg, LeaugeTeam p1)
        
        NAME: 
            ShowFreeAgents
        SYNOPSIS:
            
            public ShowFreeAgents(Game g, ShowGame sg, LeaugeTeam p1);
             g --> The current game object to be able to use its public functions
            p1 --> the human players LeaugeTeam object to used to access the 
            team roster.
            sg--> The form object used to display the information on the GUI

        DESCRIPTION:
            
            Contstructor for the ShowFreeAgents class
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
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

        /*
        private void ShowFreeAgents_Load(object sender, EventArgs e)
        
        NAME: 
            ShowFreeAgents_Load
        SYNOPSIS:
            
             private void ShowFreeAgents_Load(object sender, EventArgs e);
             sender --> reference to object that raised event.
             e --> event data


        DESCRIPTION:
            
            This calls the AutoLoadAll() function so when the free agents page
            is loaded all players are showed automatically in the free agents box
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void ShowFreeAgents_Load(object sender, EventArgs e)
        {
            AutoLoadAll();
        }

        /*
         private void BackFromFreeAgents_Click(object sender, EventArgs e)
        
        NAME: 
            BackFromFreeAgents_Click
        SYNOPSIS:
            
              private void BackFromFreeAgents_Click(object sender, EventArgs e);
              sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
            Hides the free agent page and shows the home page
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void BackFromFreeAgents_Click(object sender, EventArgs e)
        {
            Hide();
            _showGame.Show();
        }

        /*
       private void AllPosButton_Click(object sender, EventArgs e)
        
        NAME: 
            AllPosButton_Click
        SYNOPSIS:
            
            private void AllPosButton_Click(object sender, EventArgs e);
              sender --> reference to object that raised event.
              e --> event data


        DESCRIPTION:
            
            Clears the FreeAgentList and repopulates it to show the user
            all the avaialable players regardless of their position
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void AllPosButton_Click(object sender, EventArgs e)
        {
            FreeAgentsList.Items.Clear();
            Catagory = "all";
            foreach (int players in _game.ShowFreeAgentList("all"))
            {
                FreeAgentsList.Items.Add(_game._PlayerName[players]);
            }
        }

        /*
        private void GuardPosButton_Click(object sender, EventArgs e)
        
        NAME: 
            GuardPosButton_Click
        SYNOPSIS:
            
             private void GuardPosButton_Click(object sender, EventArgs e);
              sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
            Clears the FreeAgentList and repopulates it to show the user
            all the avaialable players that are either point guards or 
            shooting guards
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/08/2020
        */
        private void GuardPosButton_Click(object sender, EventArgs e)
        {
            FreeAgentsList.Items.Clear();
            Catagory = "G";
            foreach (int players in _game.ShowFreeAgentList( "G"))
            {
                FreeAgentsList.Items.Add(_game._PlayerName[players]);
            }
        }

        /*
        private void ForwardPosButton_Click(object sender, EventArgs e)
        
        NAME: 
            ForwardPosButton_Click
        SYNOPSIS:
            
            private void ForwardPosButton_Click(object sender, EventArgs e);
              sender --> reference to object that raised event.
              e --> event data
        DESCRIPTION:
            
            Clears the FreeAgentList and repopulates it to show the user
            all the avaialable players that are either power forwards or
            small forwards
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/10/2020
        */
        private void ForwardPosButton_Click(object sender, EventArgs e)
        {
            FreeAgentsList.Items.Clear();
            Catagory = "F";
            foreach (int players in _game.ShowFreeAgentList( "F"))
            {
                FreeAgentsList.Items.Add(_game._PlayerName[players]);
            }
        }

        /*
        private void CentersPosButton_Click(object sender, EventArgs e)
        
        NAME: 
            CentersPosButton_Click
        SYNOPSIS:
            
             private void CentersPosButton_Click(object sender, EventArgs e)
              sender --> reference to object that raised event.
              e --> event data
        DESCRIPTION:
            
            Clears the FreeAgentList and repopulates it to show the user
            all the avaialable players that are centers
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/10/2020
        */
        private void CentersPosButton_Click(object sender, EventArgs e)
        {
            FreeAgentsList.Items.Clear();
            Catagory = "C";
            foreach (int players in _game.ShowFreeAgentList("C"))
            {
                FreeAgentsList.Items.Add(_game._PlayerName[players]);
            }
        }

        /*
       private void AddDropButton_Click(object sender, EventArgs e)
        
        NAME: 
            AddDropButton_Click
        SYNOPSIS:
            
            private void AddDropButton_Click(object sender, EventArgs e);
              sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
            The event handler for the AddDropButton. After the user has selected 
            who they would like to add to their team from the free agents list and 
            who they would like to drop from their team list the event handler makes sure
            they have one selected from each list. Then it checks if their team is at the 
            maximum number of players at that positon.
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/10/2020
        */
        private void AddDropButton_Click(object sender, EventArgs e)
        {
            string PlayerDropping;
            string PlayerAdding;
            try
            {
                if(_showGame.AddDropped == true)
                {
                    throw new Exception();
                }
                else
                {
                    try
                    {
                        if (PlayersTeamList.SelectedIndex == -1 || FreeAgentsList.SelectedIndex == -1)
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
                                    _showGame.AddDropped = true;
                                    AddDropBox.Items.Clear();
                                    AddDropBox.Items.Add("Dropped " + PlayerDropping + " for " + PlayerAdding);
                                    FreeAgentsList.Items.Clear();
                                    PlayersTeamList.Items.Clear();
                                    foreach (int player in __player1.team)
                                    {
                                        PlayersTeamList.Items.Add(_game._PlayerName[player]);
                                    }
                                    foreach (int player in _game.ShowFreeAgentList(Catagory))
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
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("You have reached the limit of available Add/Drops this week");
            }
            AddDropButton.Enabled = false;
        }

        /*
        private void FreeAgentsList_ItemCheck(object sender, ItemCheckEventArgs e)
        
        NAME: 
            FreeAgentsList_ItemCheck
        SYNOPSIS:
            
             private void FreeAgentsList_ItemCheck(object sender, ItemCheckEventArgs e);
              sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
           When the user selects a player from the FreeAgentsList that players image
           is loaded and shown in a pictureBox

        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/11/2020
        */
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

        /*
        private void PlayersTeamList_ItemCheck(object sender, ItemCheckEventArgs e)
        
        NAME: 
            PlayersTeamList_ItemCheck
        SYNOPSIS:
            
            private void PlayersTeamList_ItemCheck(object sender, ItemCheckEventArgs e);
              sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
           When the user selects a player from the PlayersTeamList that players image
           is loaded and shown in a pictureBox
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/11/2020
        */
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

        /*
       private void ResetButton_Click(object sender, EventArgs e)
        
        NAME: 
            ResetButton_Click
        SYNOPSIS:
            
          private void ResetButton_Click(object sender, EventArgs e); 
              sender --> reference to object that raised event.
              e --> event data

        DESCRIPTION:
            
           Resets the PlayerTeamList and FreeAgentsList indexes that
           are checked
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/11/2020
        */
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

        /*
        private void AutoLoadAll()
        
        NAME: 
            AutoLoadAll
        SYNOPSIS:
            
           private void AutoLoadAll(); 

        DESCRIPTION:
            
            Automatically clicks the AllPosButton button to 
            show all free agents when the page loads
        
        RETURNS:
            None
        AUTHOR:
            Gabriel Uy
        DATE:
            07/11/2020
        */
        private void AutoLoadAll()
        {
            //https://stackoverflow.com/questions/19300044/button-performclick-not-working-in-form-load/19300323 6/29/20
            AllPosButton.PerformClick();
        }
    }
}
