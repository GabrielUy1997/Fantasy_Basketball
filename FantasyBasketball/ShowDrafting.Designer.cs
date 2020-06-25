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
            this.PlayerSelectionsBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.DraftCheckList.Location = new System.Drawing.Point(17, 19);
            this.DraftCheckList.Name = "DraftCheckList";
            this.DraftCheckList.Size = new System.Drawing.Size(503, 403);
            this.DraftCheckList.TabIndex = 1;
            this.DraftCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DraftCheckList_ItemCheck);
            // 
            // DraftButton
            // 
            this.DraftButton.Enabled = false;
            this.DraftButton.Location = new System.Drawing.Point(17, 482);
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
            this.DraftingOrder.Location = new System.Drawing.Point(172, 499);
            this.DraftingOrder.Name = "DraftingOrder";
            this.DraftingOrder.Size = new System.Drawing.Size(57, 20);
            this.DraftingOrder.TabIndex = 3;
            this.DraftingOrder.Text = "label1";
            // 
            // DraftedList
            // 
            this.DraftedList.FormattingEnabled = true;
            this.DraftedList.Location = new System.Drawing.Point(18, 19);
            this.DraftedList.Name = "DraftedList";
            this.DraftedList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DraftedList.Size = new System.Drawing.Size(336, 264);
            this.DraftedList.TabIndex = 4;
            // 
            // EndDraftButton
            // 
            this.EndDraftButton.Enabled = false;
            this.EndDraftButton.Location = new System.Drawing.Point(647, 481);
            this.EndDraftButton.Name = "EndDraftButton";
            this.EndDraftButton.Size = new System.Drawing.Size(237, 57);
            this.EndDraftButton.TabIndex = 5;
            this.EndDraftButton.Text = "End Draft";
            this.EndDraftButton.UseVisualStyleBackColor = false;
            this.EndDraftButton.Click += new System.EventHandler(this.EndDraftButton_Click);
            // 
            // PlayerSelectionsBox
            // 
            this.PlayerSelectionsBox.FormattingEnabled = true;
            this.PlayerSelectionsBox.Location = new System.Drawing.Point(18, 24);
            this.PlayerSelectionsBox.Name = "PlayerSelectionsBox";
            this.PlayerSelectionsBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.PlayerSelectionsBox.Size = new System.Drawing.Size(336, 95);
            this.PlayerSelectionsBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlayerSelectionsBox);
            this.groupBox1.Location = new System.Drawing.Point(585, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your draft selections";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DraftedList);
            this.groupBox2.Location = new System.Drawing.Point(585, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 297);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All draft selections";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DraftCheckList);
            this.groupBox3.Location = new System.Drawing.Point(17, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 439);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available players";
            // 
            // ShowDrafting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EndDraftButton);
            this.Controls.Add(this.DraftingOrder);
            this.Controls.Add(this.DraftButton);
            this.Controls.Add(this.test);
            this.Name = "ShowDrafting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drafting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox PlayerSelectionsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}