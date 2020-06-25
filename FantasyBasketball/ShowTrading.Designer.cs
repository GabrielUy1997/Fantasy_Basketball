namespace FantasyBasketball
{
    partial class ShowTrading
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
            this.BackFromTrading = new System.Windows.Forms.Button();
            this.Team1Button = new System.Windows.Forms.Button();
            this.Team2Button = new System.Windows.Forms.Button();
            this.Team3Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PlayersPlayerBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CPUPlayerBox = new System.Windows.Forms.CheckedListBox();
            this.CPUteamLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TradeResultBox = new System.Windows.Forms.ListBox();
            this.resetTradeBox = new System.Windows.Forms.Button();
            this.TradeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackFromTrading
            // 
            this.BackFromTrading.Location = new System.Drawing.Point(12, 12);
            this.BackFromTrading.Name = "BackFromTrading";
            this.BackFromTrading.Size = new System.Drawing.Size(75, 23);
            this.BackFromTrading.TabIndex = 2;
            this.BackFromTrading.Text = "Back";
            this.BackFromTrading.UseVisualStyleBackColor = true;
            this.BackFromTrading.Click += new System.EventHandler(this.BackFromTrading_Click);
            // 
            // Team1Button
            // 
            this.Team1Button.Location = new System.Drawing.Point(21, 19);
            this.Team1Button.Name = "Team1Button";
            this.Team1Button.Size = new System.Drawing.Size(122, 53);
            this.Team1Button.TabIndex = 3;
            this.Team1Button.UseVisualStyleBackColor = true;
            this.Team1Button.Click += new System.EventHandler(this.Team1Button_Click);
            // 
            // Team2Button
            // 
            this.Team2Button.Location = new System.Drawing.Point(21, 100);
            this.Team2Button.Name = "Team2Button";
            this.Team2Button.Size = new System.Drawing.Size(122, 53);
            this.Team2Button.TabIndex = 4;
            this.Team2Button.UseVisualStyleBackColor = true;
            this.Team2Button.Click += new System.EventHandler(this.Team2Button_Click);
            // 
            // Team3Button
            // 
            this.Team3Button.Location = new System.Drawing.Point(21, 181);
            this.Team3Button.Name = "Team3Button";
            this.Team3Button.Size = new System.Drawing.Size(122, 52);
            this.Team3Button.TabIndex = 5;
            this.Team3Button.UseVisualStyleBackColor = true;
            this.Team3Button.Click += new System.EventHandler(this.Team3Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Team1Button);
            this.groupBox1.Controls.Add(this.Team3Button);
            this.groupBox1.Controls.Add(this.Team2Button);
            this.groupBox1.Location = new System.Drawing.Point(31, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 243);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select team to trade with";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(204, 19);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PlayersPlayerBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CPUPlayerBox);
            this.splitContainer1.Panel2.Controls.Add(this.CPUteamLabel);
            this.splitContainer1.Size = new System.Drawing.Size(420, 387);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 7;
            // 
            // PlayersPlayerBox
            // 
            this.PlayersPlayerBox.CheckOnClick = true;
            this.PlayersPlayerBox.FormattingEnabled = true;
            this.PlayersPlayerBox.Location = new System.Drawing.Point(8, 28);
            this.PlayersPlayerBox.Name = "PlayersPlayerBox";
            this.PlayersPlayerBox.Size = new System.Drawing.Size(193, 349);
            this.PlayersPlayerBox.TabIndex = 1;
            this.PlayersPlayerBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PlayersPlayerBox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your team:";
            // 
            // CPUPlayerBox
            // 
            this.CPUPlayerBox.CheckOnClick = true;
            this.CPUPlayerBox.FormattingEnabled = true;
            this.CPUPlayerBox.Location = new System.Drawing.Point(7, 28);
            this.CPUPlayerBox.Name = "CPUPlayerBox";
            this.CPUPlayerBox.Size = new System.Drawing.Size(191, 349);
            this.CPUPlayerBox.TabIndex = 2;
            this.CPUPlayerBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CPUPlayerBox_ItemCheck);
            // 
            // CPUteamLabel
            // 
            this.CPUteamLabel.AutoSize = true;
            this.CPUteamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUteamLabel.Location = new System.Drawing.Point(3, 4);
            this.CPUteamLabel.Name = "CPUteamLabel";
            this.CPUteamLabel.Size = new System.Drawing.Size(112, 20);
            this.CPUteamLabel.TabIndex = 1;
            this.CPUteamLabel.Text = "CPU\'s Team:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TradeResultBox);
            this.groupBox2.Controls.Add(this.resetTradeBox);
            this.groupBox2.Controls.Add(this.TradeButton);
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(32, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 440);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trading Menu";
            // 
            // TradeResultBox
            // 
            this.TradeResultBox.FormattingEnabled = true;
            this.TradeResultBox.Location = new System.Drawing.Point(630, 219);
            this.TradeResultBox.Name = "TradeResultBox";
            this.TradeResultBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.TradeResultBox.Size = new System.Drawing.Size(244, 95);
            this.TradeResultBox.TabIndex = 10;
            // 
            // resetTradeBox
            // 
            this.resetTradeBox.Location = new System.Drawing.Point(703, 149);
            this.resetTradeBox.Name = "resetTradeBox";
            this.resetTradeBox.Size = new System.Drawing.Size(85, 44);
            this.resetTradeBox.TabIndex = 9;
            this.resetTradeBox.Text = "Reset";
            this.resetTradeBox.UseVisualStyleBackColor = true;
            this.resetTradeBox.Click += new System.EventHandler(this.resetTradeBox_Click);
            // 
            // TradeButton
            // 
            this.TradeButton.Enabled = false;
            this.TradeButton.Location = new System.Drawing.Point(685, 90);
            this.TradeButton.Name = "TradeButton";
            this.TradeButton.Size = new System.Drawing.Size(122, 53);
            this.TradeButton.TabIndex = 8;
            this.TradeButton.Text = "Propose Trade";
            this.TradeButton.UseVisualStyleBackColor = true;
            this.TradeButton.Click += new System.EventHandler(this.TradeButton_Click);
            // 
            // ShowTrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BackFromTrading);
            this.Name = "ShowTrading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowTrading";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackFromTrading;
        private System.Windows.Forms.Button Team1Button;
        private System.Windows.Forms.Button Team2Button;
        private System.Windows.Forms.Button Team3Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CPUteamLabel;
        private System.Windows.Forms.CheckedListBox PlayersPlayerBox;
        private System.Windows.Forms.CheckedListBox CPUPlayerBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TradeButton;
        private System.Windows.Forms.Button resetTradeBox;
        private System.Windows.Forms.ListBox TradeResultBox;
    }
}