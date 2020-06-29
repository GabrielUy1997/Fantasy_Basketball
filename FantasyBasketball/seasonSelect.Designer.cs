namespace FantasyBasketball
{
    partial class SeasonSelect
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
            this.SeasonEntry = new System.Windows.Forms.TextBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.QuitGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeasonEntry
            // 
            this.SeasonEntry.Location = new System.Drawing.Point(325, 225);
            this.SeasonEntry.Name = "SeasonEntry";
            this.SeasonEntry.Size = new System.Drawing.Size(296, 20);
            this.SeasonEntry.TabIndex = 0;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(322, 209);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(276, 13);
            this.SeasonLabel.TabIndex = 1;
            this.SeasonLabel.Text = "What season would you like to simulate? (ex. 2018-2019)";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(325, 251);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Simulate";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // QuitGameButton
            // 
            this.QuitGameButton.Location = new System.Drawing.Point(13, 13);
            this.QuitGameButton.Name = "QuitGameButton";
            this.QuitGameButton.Size = new System.Drawing.Size(75, 23);
            this.QuitGameButton.TabIndex = 3;
            this.QuitGameButton.Text = "Quit";
            this.QuitGameButton.UseVisualStyleBackColor = true;
            this.QuitGameButton.Click += new System.EventHandler(this.QuitGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "The data used in this program is from: https://www.basketball-reference.com/";
            // 
            // SeasonSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitGameButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.SeasonEntry);
            this.Name = "SeasonSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecting Season";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeasonEntry;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button QuitGameButton;
        private System.Windows.Forms.Label label1;
    }
}

