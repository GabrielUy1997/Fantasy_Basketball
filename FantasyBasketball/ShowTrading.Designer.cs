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
            this.Team1Button.Location = new System.Drawing.Point(152, 56);
            this.Team1Button.Name = "Team1Button";
            this.Team1Button.Size = new System.Drawing.Size(75, 23);
            this.Team1Button.TabIndex = 3;
            this.Team1Button.UseVisualStyleBackColor = true;
            // 
            // Team2Button
            // 
            this.Team2Button.Location = new System.Drawing.Point(152, 86);
            this.Team2Button.Name = "Team2Button";
            this.Team2Button.Size = new System.Drawing.Size(75, 23);
            this.Team2Button.TabIndex = 4;
            this.Team2Button.UseVisualStyleBackColor = true;
            // 
            // Team3Button
            // 
            this.Team3Button.Location = new System.Drawing.Point(152, 116);
            this.Team3Button.Name = "Team3Button";
            this.Team3Button.Size = new System.Drawing.Size(75, 23);
            this.Team3Button.TabIndex = 5;
            this.Team3Button.UseVisualStyleBackColor = true;
            // 
            // ShowTrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Team3Button);
            this.Controls.Add(this.Team2Button);
            this.Controls.Add(this.Team1Button);
            this.Controls.Add(this.BackFromTrading);
            this.Name = "ShowTrading";
            this.Text = "ShowTrading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackFromTrading;
        private System.Windows.Forms.Button Team1Button;
        private System.Windows.Forms.Button Team2Button;
        private System.Windows.Forms.Button Team3Button;
    }
}