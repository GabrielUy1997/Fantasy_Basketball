namespace FantasyBasketball
{
    partial class ShowTeamRoster
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
            this.TeamList = new System.Windows.Forms.ListBox();
            this.BackFromTeamRoster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HistoricalStats = new System.Windows.Forms.GroupBox();
            this.HistoricalStatsBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.HistoricalStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamList
            // 
            this.TeamList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamList.FormattingEnabled = true;
            this.TeamList.ItemHeight = 31;
            this.TeamList.Location = new System.Drawing.Point(33, 34);
            this.TeamList.Name = "TeamList";
            this.TeamList.Size = new System.Drawing.Size(342, 252);
            this.TeamList.TabIndex = 0;
            this.TeamList.Click += new System.EventHandler(this.TeamList_Click);
            // 
            // BackFromTeamRoster
            // 
            this.BackFromTeamRoster.Location = new System.Drawing.Point(13, 13);
            this.BackFromTeamRoster.Name = "BackFromTeamRoster";
            this.BackFromTeamRoster.Size = new System.Drawing.Size(75, 23);
            this.BackFromTeamRoster.TabIndex = 1;
            this.BackFromTeamRoster.Text = "Back";
            this.BackFromTeamRoster.UseVisualStyleBackColor = true;
            this.BackFromTeamRoster.Click += new System.EventHandler(this.BackFromTeamRoster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TeamList);
            this.groupBox1.Location = new System.Drawing.Point(13, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your team roster";
            // 
            // HistoricalStats
            // 
            this.HistoricalStats.Controls.Add(this.HistoricalStatsBox);
            this.HistoricalStats.Location = new System.Drawing.Point(440, 53);
            this.HistoricalStats.Name = "HistoricalStats";
            this.HistoricalStats.Size = new System.Drawing.Size(379, 376);
            this.HistoricalStats.TabIndex = 3;
            this.HistoricalStats.TabStop = false;
            this.HistoricalStats.Text = "Historical Stats";
            // 
            // HistoricalStatsBox
            // 
            this.HistoricalStatsBox.FormattingEnabled = true;
            this.HistoricalStatsBox.Location = new System.Drawing.Point(16, 34);
            this.HistoricalStatsBox.Name = "HistoricalStatsBox";
            this.HistoricalStatsBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.HistoricalStatsBox.Size = new System.Drawing.Size(344, 329);
            this.HistoricalStatsBox.TabIndex = 0;
            // 
            // ShowTeamRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.HistoricalStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackFromTeamRoster);
            this.Name = "ShowTeamRoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamRoster";
            this.groupBox1.ResumeLayout(false);
            this.HistoricalStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TeamList;
        private System.Windows.Forms.Button BackFromTeamRoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox HistoricalStats;
        private System.Windows.Forms.ListBox HistoricalStatsBox;
    }
}