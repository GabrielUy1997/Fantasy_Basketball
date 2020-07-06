namespace FantasyBasketball
{
    partial class ShowGame
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
            this.ShowPlayerTeam = new System.Windows.Forms.Button();
            this.ScheduleBox = new System.Windows.Forms.ListBox();
            this.AdvanceWeekButton = new System.Windows.Forms.Button();
            this.ThisWeeksStats = new System.Windows.Forms.ListBox();
            this.MatchUpBox = new System.Windows.Forms.ListBox();
            this.Winners = new System.Windows.Forms.ListBox();
            this.FreeAgentButton = new System.Windows.Forms.Button();
            this.TradingButton = new System.Windows.Forms.Button();
            this.MainMenuGroup = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Schedule = new System.Windows.Forms.GroupBox();
            this.Standings = new System.Windows.Forms.GroupBox();
            this.StandingsBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.MainMenuGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.Standings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPlayerTeam
            // 
            this.ShowPlayerTeam.Location = new System.Drawing.Point(19, 20);
            this.ShowPlayerTeam.Name = "ShowPlayerTeam";
            this.ShowPlayerTeam.Size = new System.Drawing.Size(115, 40);
            this.ShowPlayerTeam.TabIndex = 0;
            this.ShowPlayerTeam.Text = "Show Team";
            this.ShowPlayerTeam.UseVisualStyleBackColor = true;
            this.ShowPlayerTeam.Click += new System.EventHandler(this.ShowPlayerTeam_Click);
            // 
            // ScheduleBox
            // 
            this.ScheduleBox.FormattingEnabled = true;
            this.ScheduleBox.Location = new System.Drawing.Point(21, 26);
            this.ScheduleBox.Name = "ScheduleBox";
            this.ScheduleBox.Size = new System.Drawing.Size(241, 251);
            this.ScheduleBox.TabIndex = 1;
            // 
            // AdvanceWeekButton
            // 
            this.AdvanceWeekButton.Location = new System.Drawing.Point(19, 160);
            this.AdvanceWeekButton.Name = "AdvanceWeekButton";
            this.AdvanceWeekButton.Size = new System.Drawing.Size(115, 71);
            this.AdvanceWeekButton.TabIndex = 2;
            this.AdvanceWeekButton.Text = "Advance to next week";
            this.AdvanceWeekButton.UseVisualStyleBackColor = true;
            this.AdvanceWeekButton.Click += new System.EventHandler(this.AdvanceWeekButton_Click);
            // 
            // ThisWeeksStats
            // 
            this.ThisWeeksStats.FormattingEnabled = true;
            this.ThisWeeksStats.Location = new System.Drawing.Point(6, 19);
            this.ThisWeeksStats.Name = "ThisWeeksStats";
            this.ThisWeeksStats.Size = new System.Drawing.Size(340, 69);
            this.ThisWeeksStats.TabIndex = 3;
            // 
            // MatchUpBox
            // 
            this.MatchUpBox.FormattingEnabled = true;
            this.MatchUpBox.Location = new System.Drawing.Point(36, 21);
            this.MatchUpBox.Name = "MatchUpBox";
            this.MatchUpBox.Size = new System.Drawing.Size(340, 173);
            this.MatchUpBox.TabIndex = 5;
            // 
            // Winners
            // 
            this.Winners.FormattingEnabled = true;
            this.Winners.Location = new System.Drawing.Point(6, 19);
            this.Winners.Name = "Winners";
            this.Winners.Size = new System.Drawing.Size(340, 368);
            this.Winners.TabIndex = 7;
            // 
            // FreeAgentButton
            // 
            this.FreeAgentButton.Location = new System.Drawing.Point(19, 68);
            this.FreeAgentButton.Name = "FreeAgentButton";
            this.FreeAgentButton.Size = new System.Drawing.Size(115, 40);
            this.FreeAgentButton.TabIndex = 8;
            this.FreeAgentButton.Text = "Free Agents";
            this.FreeAgentButton.UseVisualStyleBackColor = true;
            this.FreeAgentButton.Click += new System.EventHandler(this.FreeAgentButton_Click);
            // 
            // TradingButton
            // 
            this.TradingButton.Location = new System.Drawing.Point(19, 114);
            this.TradingButton.Name = "TradingButton";
            this.TradingButton.Size = new System.Drawing.Size(115, 40);
            this.TradingButton.TabIndex = 9;
            this.TradingButton.Text = "Trade";
            this.TradingButton.UseVisualStyleBackColor = true;
            this.TradingButton.Click += new System.EventHandler(this.TradingButton_Click);
            // 
            // MainMenuGroup
            // 
            this.MainMenuGroup.Controls.Add(this.SeasonLabel);
            this.MainMenuGroup.Controls.Add(this.pictureBox1);
            this.MainMenuGroup.Controls.Add(this.groupBox3);
            this.MainMenuGroup.Controls.Add(this.groupBox2);
            this.MainMenuGroup.Controls.Add(this.groupBox1);
            this.MainMenuGroup.Controls.Add(this.Schedule);
            this.MainMenuGroup.Controls.Add(this.Standings);
            this.MainMenuGroup.Controls.Add(this.TradingButton);
            this.MainMenuGroup.Controls.Add(this.ShowPlayerTeam);
            this.MainMenuGroup.Controls.Add(this.FreeAgentButton);
            this.MainMenuGroup.Controls.Add(this.AdvanceWeekButton);
            this.MainMenuGroup.Location = new System.Drawing.Point(12, 12);
            this.MainMenuGroup.Name = "MainMenuGroup";
            this.MainMenuGroup.Size = new System.Drawing.Size(960, 537);
            this.MainMenuGroup.TabIndex = 10;
            this.MainMenuGroup.TabStop = false;
            this.MainMenuGroup.Text = "Home";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ThisWeeksStats);
            this.groupBox3.Location = new System.Drawing.Point(575, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 101);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "This week\'s stats";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Winners);
            this.groupBox2.Location = new System.Drawing.Point(575, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 395);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Winners";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MatchUpBox);
            this.groupBox1.Location = new System.Drawing.Point(144, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 211);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "This week\'s matchup";
            // 
            // Schedule
            // 
            this.Schedule.Controls.Add(this.ScheduleBox);
            this.Schedule.Location = new System.Drawing.Point(289, 237);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(268, 285);
            this.Schedule.TabIndex = 13;
            this.Schedule.TabStop = false;
            this.Schedule.Text = "Schedule";
            // 
            // Standings
            // 
            this.Standings.Controls.Add(this.StandingsBox);
            this.Standings.Location = new System.Drawing.Point(144, 237);
            this.Standings.Name = "Standings";
            this.Standings.Size = new System.Drawing.Size(139, 116);
            this.Standings.TabIndex = 12;
            this.Standings.TabStop = false;
            this.Standings.Text = "Standings";
            // 
            // StandingsBox
            // 
            this.StandingsBox.FormattingEnabled = true;
            this.StandingsBox.Location = new System.Drawing.Point(6, 16);
            this.StandingsBox.Name = "StandingsBox";
            this.StandingsBox.Size = new System.Drawing.Size(120, 95);
            this.StandingsBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(33, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonLabel.Location = new System.Drawing.Point(14, 438);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(257, 25);
            this.SeasonLabel.TabIndex = 18;
            this.SeasonLabel.Text = "The 2018-2019 Season";
            // 
            // ShowGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MainMenuGroup);
            this.Name = "ShowGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.MainMenuGroup.ResumeLayout(false);
            this.MainMenuGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Schedule.ResumeLayout(false);
            this.Standings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowPlayerTeam;
        private System.Windows.Forms.ListBox ScheduleBox;
        private System.Windows.Forms.Button AdvanceWeekButton;
        private System.Windows.Forms.ListBox ThisWeeksStats;
        private System.Windows.Forms.ListBox MatchUpBox;
        private System.Windows.Forms.ListBox Winners;
        private System.Windows.Forms.Button FreeAgentButton;
        private System.Windows.Forms.Button TradingButton;
        private System.Windows.Forms.GroupBox MainMenuGroup;
        private System.Windows.Forms.ListBox StandingsBox;
        private System.Windows.Forms.GroupBox Schedule;
        private System.Windows.Forms.GroupBox Standings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SeasonLabel;
    }
}