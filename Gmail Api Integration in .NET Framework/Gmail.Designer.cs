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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gmail));
            this.gmailUI = new System.Windows.Forms.TabControl();
            this.inboxPage = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.draftPage = new System.Windows.Forms.TabPage();
            this.trashPage = new System.Windows.Forms.TabPage();
            this.dgvInbox = new System.Windows.Forms.DataGridView();
            this.lnkMailComposer = new System.Windows.Forms.LinkLabel();
            this.mailLoader = new System.Windows.Forms.ProgressBar();
            this.gmailUI.SuspendLayout();
            this.inboxPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbox)).BeginInit();
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
            this.gmailUI.Size = new System.Drawing.Size(536, 372);
            this.gmailUI.TabIndex = 0;
            // 
            // inboxPage
            // 
            this.inboxPage.Controls.Add(this.dgvInbox);
            this.inboxPage.Controls.Add(this.comboBox2);
            this.inboxPage.Controls.Add(this.comboBox1);
            this.inboxPage.Location = new System.Drawing.Point(4, 22);
            this.inboxPage.Name = "inboxPage";
            this.inboxPage.Padding = new System.Windows.Forms.Padding(3);
            this.inboxPage.Size = new System.Drawing.Size(528, 346);
            this.inboxPage.TabIndex = 0;
            this.inboxPage.Text = "Inbox";
            this.inboxPage.UseVisualStyleBackColor = true;
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
            this.trashPage.Size = new System.Drawing.Size(528, 359);
            this.trashPage.TabIndex = 2;
            this.trashPage.Text = "Trash";
            this.trashPage.UseVisualStyleBackColor = true;
            // 
            // dgvInbox
            // 
            this.dgvInbox.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInbox.Location = new System.Drawing.Point(3, 3);
            this.dgvInbox.Name = "dgvInbox";
            this.dgvInbox.Size = new System.Drawing.Size(522, 340);
            this.dgvInbox.TabIndex = 2;
            // 
            // lnkMailComposer
            // 
            this.lnkMailComposer.AutoSize = true;
            this.lnkMailComposer.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMailComposer.Location = new System.Drawing.Point(487, 25);
            this.lnkMailComposer.Name = "lnkMailComposer";
            this.lnkMailComposer.Size = new System.Drawing.Size(56, 17);
            this.lnkMailComposer.TabIndex = 1;
            this.lnkMailComposer.TabStop = true;
            this.lnkMailComposer.Text = "Compose";
            this.lnkMailComposer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMailComposer_LinkClicked);
            // 
            // mailLoader
            // 
            this.mailLoader.Location = new System.Drawing.Point(446, 400);
            this.mailLoader.Name = "mailLoader";
            this.mailLoader.Size = new System.Drawing.Size(100, 16);
            this.mailLoader.TabIndex = 2;
            // 
            // Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(560, 421);
            this.Controls.Add(this.mailLoader);
            this.Controls.Add(this.lnkMailComposer);
            this.Controls.Add(this.gmailUI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(576, 459);
            this.MinimumSize = new System.Drawing.Size(576, 459);
            this.Name = "Gmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gmail";
            this.gmailUI.ResumeLayout(false);
            this.inboxPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl gmailUI;
        private System.Windows.Forms.TabPage inboxPage;
        private System.Windows.Forms.TabPage draftPage;
        private System.Windows.Forms.TabPage trashPage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvInbox;
        private System.Windows.Forms.LinkLabel lnkMailComposer;
        private System.Windows.Forms.ProgressBar mailLoader;
    }
}