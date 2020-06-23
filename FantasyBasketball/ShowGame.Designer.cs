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
            this.cWeek = new System.Windows.Forms.Label();
            this.MatchUpBox = new System.Windows.Forms.ListBox();
            this.MatchUpLabel = new System.Windows.Forms.Label();
            this.Winners = new System.Windows.Forms.ListBox();
            this.FreeAgentButton = new System.Windows.Forms.Button();
            this.TradingButton = new System.Windows.Forms.Button();
            this.MainMenuGroup = new System.Windows.Forms.GroupBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.MainMenuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowPlayerTeam
            // 
            this.ShowPlayerTeam.Location = new System.Drawing.Point(19, 29);
            this.ShowPlayerTeam.Name = "ShowPlayerTeam";
            this.ShowPlayerTeam.Size = new System.Drawing.Size(115, 23);
            this.ShowPlayerTeam.TabIndex = 0;
            this.ShowPlayerTeam.Text = "Show Team";
            this.ShowPlayerTeam.UseVisualStyleBackColor = true;
            this.ShowPlayerTeam.Click += new System.EventHandler(this.ShowPlayerTeam_Click);
            // 
            // ScheduleBox
            // 
            this.ScheduleBox.FormattingEnabled = true;
            this.ScheduleBox.Location = new System.Drawing.Point(166, 241);
            this.ScheduleBox.Name = "ScheduleBox";
            this.ScheduleBox.Size = new System.Drawing.Size(241, 251);
            this.ScheduleBox.TabIndex = 1;
            // 
            // AdvanceWeekButton
            // 
            this.AdvanceWeekButton.Location = new System.Drawing.Point(19, 116);
            this.AdvanceWeekButton.Name = "AdvanceWeekButton";
            this.AdvanceWeekButton.Size = new System.Drawing.Size(115, 23);
            this.AdvanceWeekButton.TabIndex = 2;
            this.AdvanceWeekButton.Text = "Go to next week";
            this.AdvanceWeekButton.UseVisualStyleBackColor = true;
            this.AdvanceWeekButton.Click += new System.EventHandler(this.AdvanceWeekButton_Click);
            // 
            // ThisWeeksStats
            // 
            this.ThisWeeksStats.FormattingEnabled = true;
            this.ThisWeeksStats.Location = new System.Drawing.Point(560, 48);
            this.ThisWeeksStats.Name = "ThisWeeksStats";
            this.ThisWeeksStats.Size = new System.Drawing.Size(340, 69);
            this.ThisWeeksStats.TabIndex = 3;
            // 
            // cWeek
            // 
            this.cWeek.AutoSize = true;
            this.cWeek.Location = new System.Drawing.Point(557, 32);
            this.cWeek.Name = "cWeek";
            this.cWeek.Size = new System.Drawing.Size(35, 13);
            this.cWeek.TabIndex = 4;
            this.cWeek.Text = "label1";
            // 
            // MatchUpBox
            // 
            this.MatchUpBox.FormattingEnabled = true;
            this.MatchUpBox.Location = new System.Drawing.Point(166, 48);
            this.MatchUpBox.Name = "MatchUpBox";
            this.MatchUpBox.Size = new System.Drawing.Size(340, 173);
            this.MatchUpBox.TabIndex = 5;
            // 
            // MatchUpLabel
            // 
            this.MatchUpLabel.AutoSize = true;
            this.MatchUpLabel.Location = new System.Drawing.Point(163, 29);
            this.MatchUpLabel.Name = "MatchUpLabel";
            this.MatchUpLabel.Size = new System.Drawing.Size(113, 13);
            this.MatchUpLabel.TabIndex = 6;
            this.MatchUpLabel.Text = "This week\'s match up:";
            // 
            // Winners
            // 
            this.Winners.FormattingEnabled = true;
            this.Winners.Location = new System.Drawing.Point(560, 136);
            this.Winners.Name = "Winners";
            this.Winners.Size = new System.Drawing.Size(340, 368);
            this.Winners.TabIndex = 7;
            // 
            // FreeAgentButton
            // 
            this.FreeAgentButton.Location = new System.Drawing.Point(19, 58);
            this.FreeAgentButton.Name = "FreeAgentButton";
            this.FreeAgentButton.Size = new System.Drawing.Size(115, 23);
            this.FreeAgentButton.TabIndex = 8;
            this.FreeAgentButton.Text = "Free Agents";
            this.FreeAgentButton.UseVisualStyleBackColor = true;
            this.FreeAgentButton.Click += new System.EventHandler(this.FreeAgentButton_Click);
            // 
            // TradingButton
            // 
            this.TradingButton.Location = new System.Drawing.Point(19, 87);
            this.TradingButton.Name = "TradingButton";
            this.TradingButton.Size = new System.Drawing.Size(115, 23);
            this.TradingButton.TabIndex = 9;
            this.TradingButton.Text = "Trade";
            this.TradingButton.UseVisualStyleBackColor = true;
            this.TradingButton.Click += new System.EventHandler(this.TradingButton_Click);
            // 
            // MainMenuGroup
            // 
            this.MainMenuGroup.Controls.Add(this.SeasonLabel);
            this.MainMenuGroup.Controls.Add(this.MatchUpBox);
            this.MainMenuGroup.Controls.Add(this.TradingButton);
            this.MainMenuGroup.Controls.Add(this.ShowPlayerTeam);
            this.MainMenuGroup.Controls.Add(this.FreeAgentButton);
            this.MainMenuGroup.Controls.Add(this.ScheduleBox);
            this.MainMenuGroup.Controls.Add(this.Winners);
            this.MainMenuGroup.Controls.Add(this.AdvanceWeekButton);
            this.MainMenuGroup.Controls.Add(this.MatchUpLabel);
            this.MainMenuGroup.Controls.Add(this.ThisWeeksStats);
            this.MainMenuGroup.Controls.Add(this.cWeek);
            this.MainMenuGroup.Location = new System.Drawing.Point(12, 12);
            this.MainMenuGroup.Name = "MainMenuGroup";
            this.MainMenuGroup.Size = new System.Drawing.Size(960, 523);
            this.MainMenuGroup.TabIndex = 10;
            this.MainMenuGroup.TabStop = false;
            this.MainMenuGroup.Text = "Home";
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(166, 228);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(91, 13);
            this.SeasonLabel.TabIndex = 10;
            this.SeasonLabel.Text = "Season Schedule";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowPlayerTeam;
        private System.Windows.Forms.ListBox ScheduleBox;
        private System.Windows.Forms.Button AdvanceWeekButton;
        private System.Windows.Forms.ListBox ThisWeeksStats;
        private System.Windows.Forms.Label cWeek;
        private System.Windows.Forms.ListBox MatchUpBox;
        private System.Windows.Forms.Label MatchUpLabel;
        private System.Windows.Forms.ListBox Winners;
        private System.Windows.Forms.Button FreeAgentButton;
        private System.Windows.Forms.Button TradingButton;
        private System.Windows.Forms.GroupBox MainMenuGroup;
        private System.Windows.Forms.Label SeasonLabel;
    }
}