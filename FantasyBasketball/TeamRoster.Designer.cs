namespace FantasyBasketball
{
    partial class TeamRoster
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
            this.SuspendLayout();
            // 
            // TeamList
            // 
            this.TeamList.FormattingEnabled = true;
            this.TeamList.Location = new System.Drawing.Point(12, 58);
            this.TeamList.Name = "TeamList";
            this.TeamList.Size = new System.Drawing.Size(180, 69);
            this.TeamList.TabIndex = 0;
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
            // TeamRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BackFromTeamRoster);
            this.Controls.Add(this.TeamList);
            this.Name = "TeamRoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamRoster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TeamList;
        private System.Windows.Forms.Button BackFromTeamRoster;
    }
}