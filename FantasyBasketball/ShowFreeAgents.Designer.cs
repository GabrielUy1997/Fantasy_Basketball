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
            // ShowFreeAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BackFromFreeAgents);
            this.Name = "ShowFreeAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreeAgents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackFromFreeAgents;
    }
}