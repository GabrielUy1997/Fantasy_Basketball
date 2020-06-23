namespace FantasyBasketball
{
    partial class ShowDrafting
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
            this.test = new System.Windows.Forms.Label();
            this.DraftCheckList = new System.Windows.Forms.CheckedListBox();
            this.DraftButton = new System.Windows.Forms.Button();
            this.DraftingOrder = new System.Windows.Forms.Label();
            this.DraftedList = new System.Windows.Forms.ListBox();
            this.EndDraftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.Location = new System.Drawing.Point(12, 9);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(303, 25);
            this.test.TabIndex = 0;
            this.test.Text = "TESTINGTESTINGETSTING";
            this.test.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DraftCheckList
            // 
            this.DraftCheckList.CheckOnClick = true;
            this.DraftCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DraftCheckList.FormattingEnabled = true;
            this.DraftCheckList.Location = new System.Drawing.Point(17, 38);
            this.DraftCheckList.Name = "DraftCheckList";
            this.DraftCheckList.Size = new System.Drawing.Size(581, 382);
            this.DraftCheckList.TabIndex = 1;
            this.DraftCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DraftCheckList_ItemCheck);
            // 
            // DraftButton
            // 
            this.DraftButton.Enabled = false;
            this.DraftButton.Location = new System.Drawing.Point(17, 452);
            this.DraftButton.Name = "DraftButton";
            this.DraftButton.Size = new System.Drawing.Size(108, 57);
            this.DraftButton.TabIndex = 2;
            this.DraftButton.Text = "Draft";
            this.DraftButton.UseVisualStyleBackColor = true;
            this.DraftButton.Click += new System.EventHandler(this.DraftButton_Click);
            // 
            // DraftingOrder
            // 
            this.DraftingOrder.AutoSize = true;
            this.DraftingOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DraftingOrder.Location = new System.Drawing.Point(205, 452);
            this.DraftingOrder.Name = "DraftingOrder";
            this.DraftingOrder.Size = new System.Drawing.Size(57, 20);
            this.DraftingOrder.TabIndex = 3;
            this.DraftingOrder.Text = "label1";
            // 
            // DraftedList
            // 
            this.DraftedList.FormattingEnabled = true;
            this.DraftedList.Location = new System.Drawing.Point(658, 38);
            this.DraftedList.Name = "DraftedList";
            this.DraftedList.Size = new System.Drawing.Size(237, 381);
            this.DraftedList.TabIndex = 4;
            // 
            // EndDraftButton
            // 
            this.EndDraftButton.Enabled = false;
            this.EndDraftButton.Location = new System.Drawing.Point(658, 452);
            this.EndDraftButton.Name = "EndDraftButton";
            this.EndDraftButton.Size = new System.Drawing.Size(237, 57);
            this.EndDraftButton.TabIndex = 5;
            this.EndDraftButton.Text = "End Draft";
            this.EndDraftButton.UseVisualStyleBackColor = false;
            this.EndDraftButton.Click += new System.EventHandler(this.EndDraftButton_Click);
            // 
            // ShowDrafting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.EndDraftButton);
            this.Controls.Add(this.DraftedList);
            this.Controls.Add(this.DraftingOrder);
            this.Controls.Add(this.DraftButton);
            this.Controls.Add(this.DraftCheckList);
            this.Controls.Add(this.test);
            this.Name = "ShowDrafting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drafting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Button DraftButton;
        private System.Windows.Forms.Label DraftingOrder;
        public System.Windows.Forms.CheckedListBox DraftCheckList;
        private System.Windows.Forms.ListBox DraftedList;
        private System.Windows.Forms.Button EndDraftButton;
    }
}