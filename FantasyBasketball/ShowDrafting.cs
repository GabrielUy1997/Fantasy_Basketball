using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace FantasyBasketball
{
    public partial class ShowDrafting : Form
    {
        Game _game;
        Human player1 = new Human("Player");
        CPU cpu1 = new CPU("CPU1");
        CPU cpu2 = new CPU("CPU2");
        CPU cpu3 = new CPU("CPU3");
        string _season;
        string ForPicture = " ";
        int playerindex;
        bool hasFlipped = false;
        bool stop = false;
        int SelectionNumber = 1;
        public ShowDrafting(string season)
        {
            InitializeComponent();
            test.Text = "Drafting for the " + season + " season";
            _season = season;
        }

        public void StartGame(Game game, string a_season)
        {
            int pID;
            _game = game;
            _game.Teams.Add(player1);
            _game.Teams.Add(cpu1);
            _game.Teams.Add(cpu2);
            _game.Teams.Add(cpu3);
            //This is the closest thing I could find for randomizing
            //a list found at https://stackoverflow.com/questions/273313/randomize-a-listt/1262619#1262619 5/20/20
            _game.RandomizingDraftOrder();
            DraftingOrder.Text = " ";
            foreach (LeaugeTeam team in _game.Teams)
            {
                DraftingOrder.Text += " " + (_game.Teams.IndexOf(team) + 1) + "." + team.GetName();
            }
            Console.WriteLine(DraftingOrder.Text);
            foreach (string player in _game._PlayerName)
            {
                pID = _game.AddPlayersToDraftList();
                DraftCheckList.Items.Add(_game.GetPlayerName(pID));
            }
          
        }

        public void PlayerSelect()
        {
            int pID;
            playerindex = _game.Teams.IndexOf(player1);
            foreach (LeaugeTeam team in _game.Teams)
            {
                if(_game.Teams.IndexOf(team) < playerindex && team.team.Count <= 5)
                {
                    pID = _game.ComputerTeamDraft(team, team.GetName());
                    DraftCheckList.Items.Remove(_game.GetPlayerName(pID));
                    DraftedList.Items.Add(_game.GetPlayerName(pID) + " Drafted by " + team.GetName() + " with the #" + SelectionNumber + " over all pick");
                    SelectionNumber++;
                    string test = _game.GetPlayerName(pID);
                }
            }
            hasFlipped = true;
        }

        private void DraftButton_Click(object sender, EventArgs e)
        {
            int pID;
            string tessst;
            string player;
            bool invalidSelect = false;

            //Getting the selection the player made on the checklist
            foreach (int checkd in DraftCheckList.CheckedIndices)
            {
                player = DraftCheckList.SelectedItem.ToString();
                tessst = Array.Find(_game._PlayerName,
                 element => element.StartsWith(player, StringComparison.Ordinal));
                pID = Array.FindIndex(_game._PlayerName, item => item == tessst);
                try
                {
                    if (player1.CanDraftPosition(_game._Playerpos, pID) == false)
                    {
                        invalidSelect = true;
                        throw new Exception();
                    }
                    else
                    {
                        _game.AddTakenPlayer(pID);
                        player1.AddingPlayer(pID);
                        if(_game._Playerpos[pID].Contains("G") == true)
                        {
                            player1.AddGuard();
                        }
                        else if (_game._Playerpos[pID].Contains("F") == true)
                        {
                            player1.AddForward();
                        }
                        else if (_game._Playerpos[pID].Contains("C") == true)
                        {
                            player1.AddCenters();
                        }                       
                        DraftCheckList.Items.RemoveAt(checkd);
                        DraftedList.Items.Add(_game.GetPlayerName(pID) + " Drafted by " + player1.GetName() + " with the #" + SelectionNumber + " over all pick");
                        SelectionNumber++;
                        PlayerSelectionsBox.Items.Add(_game.GetPlayerName(pID) + " " + _game.GetPlayerPos(pID));
                        invalidSelect = false;
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Too many players of the same position on the team");
                }
            }
            
            if(invalidSelect == false)
            {
                playerindex = _game.Teams.IndexOf(player1);
                //if the draft order hasnt flipped
                if (hasFlipped == false)
                {
                    foreach (LeaugeTeam team in _game.Teams)
                    {
                        if (_game.Teams.IndexOf(team) > playerindex && team.team.Count < 6)
                        {
                            pID = _game.ComputerTeamDraft(team, team.GetName());
                            DraftCheckList.Items.Remove(_game.GetPlayerName(pID));
                            DraftedList.Items.Add(_game.GetPlayerName(pID) + " Drafted by " + team.GetName() + " with the #" + SelectionNumber + " over all pick");
                            SelectionNumber++;
                            string test = _game.GetPlayerName(pID);
                        }
                    }
                }
                if (hasFlipped == false)
                {
                    _game.Teams.Reverse();
                    PlayerSelect();

                    hasFlipped = true;
                }

                //when all the player has drafted a full team
                if (player1.team.Count == 5)
                {
                    EndDraftButton.Enabled = true;
                    stop = true;
                }


                playerindex = _game.Teams.IndexOf(player1);
                //if the draft order has flipped
                if (hasFlipped == true)
                {
                    foreach (LeaugeTeam team in _game.Teams)
                    {
                        if (_game.Teams.IndexOf(team) > playerindex && team.team.Count < 6)
                        {
                            pID = _game.ComputerTeamDraft(team, team.GetName());
                            DraftCheckList.Items.Remove(_game.GetPlayerName(pID));
                            DraftedList.Items.Add(_game.GetPlayerName(pID) + " Drafted by " + team.GetName() + " with the #" + SelectionNumber + " over all pick");
                            SelectionNumber++;
                            string test = _game.GetPlayerName(pID);
                        }
                    }
                }
                if (stop == false)
                {
                    _game.Teams.Reverse();
                    PlayerSelect();
                }

                DraftButton.Enabled = false;
            }   
        }

        private void DraftCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            PlayerPos.Items.Clear();
            if (DraftCheckList.CheckedItems.Count == 0 && stop == false)
            {
                string player;
                string ss;
                int pID;
                DraftButton.Enabled = true;
                player = DraftCheckList.SelectedItem.ToString();
                ss = Array.Find(_game._PlayerName,
                 element => element.StartsWith(player, StringComparison.Ordinal));
                pID = Array.FindIndex(_game._PlayerName, item => item == ss);
                ForPicture = _game._PlayerPhoto[pID - 1];
                pictureBox1.Load("https://d2cwpp38twqe55.cloudfront.net/req/202006192/images/players/" + ForPicture + ".jpg");
                PlayerPos.Items.Add(_game.GetPlayerPos(pID));
            }
            else
            {
                DraftButton.Enabled = false;
            }
        }

        private void EndDraftButton_Click(object sender, EventArgs e)
        {
            Hide();
            ShowGame showGame = new ShowGame(_game, player1, cpu1, cpu2, cpu3, _season);
            showGame.Show();
            
        }

    }
}
