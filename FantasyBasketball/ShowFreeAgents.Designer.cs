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
            this.AddDropBox = new System.Windows.Forms.ListBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddDropButton = new System.Windows.Forms.Button();
            this.PlayersTeamList = new System.Windows.Forms.CheckedListBox();
            this.FreeAgentsList = new System.Windows.Forms.CheckedListBox();
            this.CentersPosButton = new System.Windows.Forms.Button();
            this.ForwardPosButton = new System.Windows.Forms.Button();
            this.GuardPosButton = new System.Windows.Forms.Button();
            this.AllPosButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FABox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FreeAgentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.FreeAgentGroupBox.Controls.Add(this.label1);
            this.FreeAgentGroupBox.Controls.Add(this.FABox);
            this.FreeAgentGroupBox.Controls.Add(this.pictureBox1);
            this.FreeAgentGroupBox.Controls.Add(this.label2);
            this.FreeAgentGroupBox.Controls.Add(this.PlayerBox);
            this.FreeAgentGroupBox.Controls.Add(this.pictureBox2);
            this.FreeAgentGroupBox.Controls.Add(this.AddDropBox);
            this.FreeAgentGroupBox.Controls.Add(this.ResetButton);
            this.FreeAgentGroupBox.Controls.Add(this.AddDropButton);
            this.FreeAgentGroupBox.Controls.Add(this.PlayersTeamList);
            this.FreeAgentGroupBox.Controls.Add(this.FreeAgentsList);
            this.FreeAgentGroupBox.Controls.Add(this.CentersPosButton);
            this.FreeAgentGroupBox.Controls.Add(this.ForwardPosButton);
            this.FreeAgentGroupBox.Controls.Add(this.GuardPosButton);
            this.FreeAgentGroupBox.Controls.Add(this.AllPosButton);
            this.FreeAgentGroupBox.Location = new System.Drawing.Point(29, 41);
            this.FreeAgentGroupBox.Name = "FreeAgentGroupBox";
            this.FreeAgentGroupBox.Size = new System.Drawing.Size(900, 508);
            this.FreeAgentGroupBox.TabIndex = 3;
            this.FreeAgentGroupBox.TabStop = false;
            this.FreeAgentGroupBox.Text = "Free Agent Add/Drop";
            // 
            // AddDropBox
            // 
            this.AddDropBox.FormattingEnabled = true;
            this.AddDropBox.Location = new System.Drawing.Point(573, 283);
            this.AddDropBox.Name = "AddDropBox";
            this.AddDropBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.AddDropBox.Size = new System.Drawing.Size(268, 56);
            this.AddDropBox.TabIndex = 9;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(660, 241);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 36);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddDropButton
            // 
            this.AddDropButton.Location = new System.Drawing.Point(631, 180);
            this.AddDropButton.Name = "AddDropButton";
            this.AddDropButton.Size = new System.Drawing.Size(155, 55);
            this.AddDropButton.TabIndex = 7;
            this.AddDropButton.Text = "Add/Drop Selected";
            this.AddDropButton.UseVisualStyleBackColor = true;
            this.AddDropButton.Click += new System.EventHandler(this.AddDropButton_Click);
            // 
            // PlayersTeamList
            // 
            this.PlayersTeamList.CheckOnClick = true;
            this.PlayersTeamList.FormattingEnabled = true;
            this.PlayersTeamList.Location = new System.Drawing.Point(553, 50);
            this.PlayersTeamList.Name = "PlayersTeamList";
            this.PlayersTeamList.Size = new System.Drawing.Size(318, 124);
            this.PlayersTeamList.TabIndex = 6;
            this.PlayersTeamList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PlayersTeamList_ItemCheck);
            // 
            // FreeAgentsList
            // 
            this.FreeAgentsList.CheckOnClick = true;
            this.FreeAgentsList.FormattingEnabled = true;
            this.FreeAgentsList.Location = new System.Drawing.Point(23, 50);
            this.FreeAgentsList.Name = "FreeAgentsList";
            this.FreeAgentsList.Size = new System.Drawing.Size(492, 229);
            this.FreeAgentsList.TabIndex = 5;
            this.FreeAgentsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FreeAgentsList_ItemCheck);
            // 
            // CentersPosButton
            // 
            this.CentersPosButton.Location = new System.Drawing.Point(329, 21);
            this.CentersPosButton.Name = "CentersPosButton";
            this.CentersPosButton.Size = new System.Drawing.Size(75, 23);
            this.CentersPosButton.TabIndex = 4;
            this.CentersPosButton.Text = "Centers";
            this.CentersPosButton.UseVisualStyleBackColor = true;
            this.CentersPosButton.Click += new System.EventHandler(this.CentersPosButton_Click);
            // 
            // ForwardPosButton
            // 
            this.ForwardPosButton.Location = new System.Drawing.Point(247, 21);
            this.ForwardPosButton.Name = "ForwardPosButton";
            this.ForwardPosButton.Size = new System.Drawing.Size(75, 23);
            this.ForwardPosButton.TabIndex = 3;
            this.ForwardPosButton.Text = "Forwards";
            this.ForwardPosButton.UseVisualStyleBackColor = true;
            this.ForwardPosButton.Click += new System.EventHandler(this.ForwardPosButton_Click);
            // 
            // GuardPosButton
            // 
            this.GuardPosButton.Location = new System.Drawing.Point(165, 21);
            this.GuardPosButton.Name = "GuardPosButton";
            this.GuardPosButton.Size = new System.Drawing.Size(75, 23);
            this.GuardPosButton.TabIndex = 2;
            this.GuardPosButton.Text = "Guards";
            this.GuardPosButton.UseVisualStyleBackColor = true;
            this.GuardPosButton.Click += new System.EventHandler(this.GuardPosButton_Click);
            // 
            // AllPosButton
            // 
            this.AllPosButton.Location = new System.Drawing.Point(83, 21);
            this.AllPosButton.Name = "AllPosButton";
            this.AllPosButton.Size = new System.Drawing.Size(75, 23);
            this.AllPosButton.TabIndex = 1;
            this.AllPosButton.Text = "All";
            this.AllPosButton.UseVisualStyleBackColor = true;
            this.AllPosButton.Click += new System.EventHandler(this.AllPosButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(398, 285);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 177);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // PlayerBox
            // 
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.Location = new System.Drawing.Point(398, 471);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(120, 30);
            this.PlayerBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dropping:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adding:";
            // 
            // FABox
            // 
            this.FABox.FormattingEnabled = true;
            this.FABox.Location = new System.Drawing.Point(128, 469);
            this.FABox.Name = "FABox";
            this.FABox.Size = new System.Drawing.Size(120, 30);
            this.FABox.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(128, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 177);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
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
            this.FreeAgentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox PlayerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FABox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}