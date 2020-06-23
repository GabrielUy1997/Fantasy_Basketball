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
            // SeasonSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
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
    }
}

