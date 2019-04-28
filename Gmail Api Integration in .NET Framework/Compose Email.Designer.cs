namespace Gmail_Api_Integration_in.NET_Framework
{
    partial class Compose_Email
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubjectLine = new System.Windows.Forms.TextBox();
            this.rbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btnSendMail);
            this.groupBox1.Controls.Add(this.rbMessage);
            this.groupBox1.Controls.Add(this.tbSubjectLine);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDestination);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(84, 30);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(390, 20);
            this.tbDestination.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject";
            // 
            // tbSubjectLine
            // 
            this.tbSubjectLine.Location = new System.Drawing.Point(84, 66);
            this.tbSubjectLine.Name = "tbSubjectLine";
            this.tbSubjectLine.Size = new System.Drawing.Size(390, 20);
            this.tbSubjectLine.TabIndex = 3;
            // 
            // rbMessage
            // 
            this.rbMessage.Location = new System.Drawing.Point(21, 106);
            this.rbMessage.Name = "rbMessage";
            this.rbMessage.Size = new System.Drawing.Size(453, 179);
            this.rbMessage.TabIndex = 4;
            this.rbMessage.Text = "";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(399, 296);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 5;
            this.btnSendMail.Text = "Send";
            this.btnSendMail.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(20, 300);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Browse";
            // 
            // Compose_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(515, 356);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(531, 394);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(531, 394);
            this.Name = "Compose_Email";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compose Mail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.RichTextBox rbMessage;
        private System.Windows.Forms.TextBox tbSubjectLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Label label1;
    }
}