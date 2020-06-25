namespace FantasyBasketball
{
    partial class ShowFreeAgents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackFromFreeAgents = new System.Windows.Forms.Button();
            this.FreeAgentGroupBox = new System.Windows.Forms.GroupBox();
            this.CentersPosButton = new System.Windows.Forms.Button();
            this.ForwardPosButton = new System.Windows.Forms.Button();
            this.GuardPosButton = new System.Windows.Forms.Button();
            this.AllPosButton = new System.Windows.Forms.Button();
            this.FreeAgentsList = new System.Windows.Forms.CheckedListBox();
            this.PlayersTeamList = new System.Windows.Forms.CheckedListBox();
            this.AddDropButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddDropBox = new System.Windows.Forms.ListBox();
            this.FreeAgentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackFromFreeAgents
            // 
            this.BackFromFreeAgents.Location = new System.Drawing.Point(12, 12);
            this.BackFromFreeAgents.Name = "BackFromFreeAgents";
            this.BackFromFreeAgents.Size = new System.Drawing.Size(75, 23);
            this.BackFromFreeAgents.TabIndex = 2;
            this.BackFromFreeAgents.Text = "Back";
            this.BackFromFreeAgents.UseVisualStyleBackColor = true;
            this.BackFromFreeAgents.Click += new System.EventHandler(this.BackFromFreeAgents_Click);
            // 
            // FreeAgentGroupBox
            // 
            this.FreeAgentGroupBox.Controls.Add(this.AddDropBox);
            this.FreeAgentGroupBox.Controls.Add(this.ResetButton);
            this.FreeAgentGroupBox.Controls.Add(this.AddDropButton);
            this.FreeAgentGroupBox.Controls.Add(this.PlayersTeamList);
            this.FreeAgentGroupBox.Controls.Add(this.FreeAgentsList);
            this.FreeAgentGroupBox.Controls.Add(this.CentersPosButton);
            this.FreeAgentGroupBox.Controls.Add(this.ForwardPosButton);
            this.FreeAgentGroupBox.Controls.Add(this.GuardPosButton);
            this.FreeAgentGroupBox.Controls.Add(this.AllPosButton);
            this.FreeAgentGroupBox.Location = new System.Drawing.Point(29, 61);
            this.FreeAgentGroupBox.Name = "FreeAgentGroupBox";
            this.FreeAgentGroupBox.Size = new System.Drawing.Size(900, 440);
            this.FreeAgentGroupBox.TabIndex = 3;
            this.FreeAgentGroupBox.TabStop = false;
            this.FreeAgentGroupBox.Text = "Free Agent Add/Drop";
            // 
            // CentersPosButton
            // 
            this.CentersPosButton.Location = new System.Drawing.Point(329, 32);
            this.CentersPosButton.Name = "CentersPosButton";
            this.CentersPosButton.Size = new System.Drawing.Size(75, 23);
            this.CentersPosButton.TabIndex = 4;
            this.CentersPosButton.Text = "Centers";
            this.CentersPosButton.UseVisualStyleBackColor = true;
            this.CentersPosButton.Click += new System.EventHandler(this.CentersPosButton_Click);
            // 
            // ForwardPosButton
            // 
            this.ForwardPosButton.Location = new System.Drawing.Point(247, 32);
            this.ForwardPosButton.Name = "ForwardPosButton";
            this.ForwardPosButton.Size = new System.Drawing.Size(75, 23);
            this.ForwardPosButton.TabIndex = 3;
            this.ForwardPosButton.Text = "Forwards";
            this.ForwardPosButton.UseVisualStyleBackColor = true;
            this.ForwardPosButton.Click += new System.EventHandler(this.ForwardPosButton_Click);
            // 
            // GuardPosButton
            // 
            this.GuardPosButton.Location = new System.Drawing.Point(165, 32);
            this.GuardPosButton.Name = "GuardPosButton";
            this.GuardPosButton.Size = new System.Drawing.Size(75, 23);
            this.GuardPosButton.TabIndex = 2;
            this.GuardPosButton.Text = "Guards";
            this.GuardPosButton.UseVisualStyleBackColor = true;
            this.GuardPosButton.Click += new System.EventHandler(this.GuardPosButton_Click);
            // 
            // AllPosButton
            // 
            this.AllPosButton.Location = new System.Drawing.Point(83, 32);
            this.AllPosButton.Name = "AllPosButton";
            this.AllPosButton.Size = new System.Drawing.Size(75, 23);
            this.AllPosButton.TabIndex = 1;
            this.AllPosButton.Text = "All";
            this.AllPosButton.UseVisualStyleBackColor = true;
            this.AllPosButton.Click += new System.EventHandler(this.AllPosButton_Click);
            // 
            // FreeAgentsList
            // 
            this.FreeAgentsList.CheckOnClick = true;
            this.FreeAgentsList.FormattingEnabled = true;
            this.FreeAgentsList.Location = new System.Drawing.Point(23, 61);
            this.FreeAgentsList.Name = "FreeAgentsList";
            this.FreeAgentsList.Size = new System.Drawing.Size(492, 259);
            this.FreeAgentsList.TabIndex = 5;
            this.FreeAgentsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FreeAgentsList_ItemCheck);
            // 
            // PlayersTeamList
            // 
            this.PlayersTeamList.CheckOnClick = true;
            this.PlayersTeamList.FormattingEnabled = true;
            this.PlayersTeamList.Location = new System.Drawing.Point(555, 61);
            this.PlayersTeamList.Name = "PlayersTeamList";
            this.PlayersTeamList.Size = new System.Drawing.Size(318, 124);
            this.PlayersTeamList.TabIndex = 6;
            this.PlayersTeamList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PlayersTeamList_ItemCheck);
            // 
            // AddDropButton
            // 
            this.AddDropButton.Location = new System.Drawing.Point(633, 191);
            this.AddDropButton.Name = "AddDropButton";
            this.AddDropButton.Size = new System.Drawing.Size(155, 55);
            this.AddDropButton.TabIndex = 7;
            this.AddDropButton.Text = "Add/Drop Selected";
            this.AddDropButton.UseVisualStyleBackColor = true;
            this.AddDropButton.Click += new System.EventHandler(this.AddDropButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(662, 252);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 36);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddDropBox
            // 
            this.AddDropBox.FormattingEnabled = true;
            this.AddDropBox.Location = new System.Drawing.Point(575, 294);
            this.AddDropBox.Name = "AddDropBox";
            this.AddDropBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.AddDropBox.Size = new System.Drawing.Size(268, 56);
            this.AddDropBox.TabIndex = 9;
            // 
            // ShowFreeAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.FreeAgentGroupBox);
            this.Controls.Add(this.BackFromFreeAgents);
            this.Name = "ShowFreeAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreeAgents";
            this.FreeAgentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackFromFreeAgents;
        private System.Windows.Forms.GroupBox FreeAgentGroupBox;
        private System.Windows.Forms.Button CentersPosButton;
        private System.Windows.Forms.Button ForwardPosButton;
        private System.Windows.Forms.Button GuardPosButton;
        private System.Windows.Forms.Button AllPosButton;
        private System.Windows.Forms.CheckedListBox FreeAgentsList;
        private System.Windows.Forms.Button AddDropButton;
        private System.Windows.Forms.CheckedListBox PlayersTeamList;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ListBox AddDropBox;
    }
}