namespace Gmail_Api_Integration_in.NET_Framework
{
    partial class Gmail
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
            this.gmailUI = new System.Windows.Forms.TabControl();
            this.inboxPage = new System.Windows.Forms.TabPage();
            this.draftPage = new System.Windows.Forms.TabPage();
            this.trashPage = new System.Windows.Forms.TabPage();
            this.btnMailComposer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gmailUI.SuspendLayout();
            this.inboxPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmailUI
            // 
            this.gmailUI.Controls.Add(this.inboxPage);
            this.gmailUI.Controls.Add(this.draftPage);
            this.gmailUI.Controls.Add(this.trashPage);
            this.gmailUI.Location = new System.Drawing.Point(12, 24);
            this.gmailUI.Name = "gmailUI";
            this.gmailUI.SelectedIndex = 0;
            this.gmailUI.Size = new System.Drawing.Size(536, 385);
            this.gmailUI.TabIndex = 0;
            // 
            // inboxPage
            // 
            this.inboxPage.Controls.Add(this.comboBox2);
            this.inboxPage.Controls.Add(this.comboBox1);
            this.inboxPage.Location = new System.Drawing.Point(4, 22);
            this.inboxPage.Name = "inboxPage";
            this.inboxPage.Padding = new System.Windows.Forms.Padding(3);
            this.inboxPage.Size = new System.Drawing.Size(528, 359);
            this.inboxPage.TabIndex = 0;
            this.inboxPage.Text = "Inbox";
            this.inboxPage.UseVisualStyleBackColor = true;
            // 
            // draftPage
            // 
            this.draftPage.Location = new System.Drawing.Point(4, 22);
            this.draftPage.Name = "draftPage";
            this.draftPage.Padding = new System.Windows.Forms.Padding(3);
            this.draftPage.Size = new System.Drawing.Size(528, 359);
            this.draftPage.TabIndex = 1;
            this.draftPage.Text = "Drafts";
            this.draftPage.UseVisualStyleBackColor = true;
            // 
            // trashPage
            // 
            this.trashPage.Location = new System.Drawing.Point(4, 22);
            this.trashPage.Name = "trashPage";
            this.trashPage.Padding = new System.Windows.Forms.Padding(3);
            this.trashPage.Size = new System.Drawing.Size(528, 371);
            this.trashPage.TabIndex = 2;
            this.trashPage.Text = "Trash";
            this.trashPage.UseVisualStyleBackColor = true;
            // 
            // btnMailComposer
            // 
            this.btnMailComposer.Location = new System.Drawing.Point(462, 12);
            this.btnMailComposer.Name = "btnMailComposer";
            this.btnMailComposer.Size = new System.Drawing.Size(86, 28);
            this.btnMailComposer.TabIndex = 1;
            this.btnMailComposer.Text = "Compose";
            this.btnMailComposer.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "One Week",
            "Month",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(319, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "One Week",
            "Month",
            "Year"});
            this.comboBox2.Location = new System.Drawing.Point(433, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 421);
            this.Controls.Add(this.btnMailComposer);
            this.Controls.Add(this.gmailUI);
            this.Name = "Gmail";
            this.Text = "Gmail";
            this.gmailUI.ResumeLayout(false);
            this.inboxPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl gmailUI;
        private System.Windows.Forms.TabPage inboxPage;
        private System.Windows.Forms.TabPage draftPage;
        private System.Windows.Forms.TabPage trashPage;
        private System.Windows.Forms.Button btnMailComposer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}