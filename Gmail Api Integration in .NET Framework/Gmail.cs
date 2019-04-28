using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmail_Api_Integration_in.NET_Framework
{
    public partial class Gmail : Form
    {
        private BackgroundWorker worker;
        public Gmail()
        {
            InitializeComponent();
            LoadMessages(EmailCategory.INBOX);
            //worker = new BackgroundWorker();
            //worker.DoWork += worker_DoWork;
            //worker.ProgressChanged += worker_ProgressChanged;
            //worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            //worker.WorkerReportsProgress = true;
            //worker.WorkerSupportsCancellation = true;
        }

        private void lnkMailComposer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Compose_Email ce = new Compose_Email();
            ce.ShowDialog();
        }

        private void LoadMessages(string category)
        {
            EmailServices es = new EmailServices();
            dgvInbox.DataSource = es.GetRangedEmails(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1), category);
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //ModifyJSPFiles(files);
            //ModifyJavaFiles(files);
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //e.ProgressPercentage
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Cancled");
            else
            {
                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
