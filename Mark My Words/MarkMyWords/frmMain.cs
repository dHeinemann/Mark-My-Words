using System;
using System.IO;
using System.Windows.Forms;

namespace MarkMyWords
{
    public partial class frmMain : Form
    {
        String fileName;
        DateTime latestWrite;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();

            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTarget.Text = browser.FileName;
                fileName = browser.FileName;
                startTimer();
            }
            btnBrowse.Enabled = false;
        }

        private void startTimer()
        {
            System.Timers.Timer renderTimer = new System.Timers.Timer(500);
            renderTimer.Elapsed += new System.Timers.ElapsedEventHandler(renderPage);
            renderTimer.Enabled = true;
        }

        private void renderPage(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime lastWrite = File.GetLastWriteTime(fileName);
            if (lastWrite != latestWrite)
            {
                latestWrite = lastWrite;

                var md = new MarkdownDeep.Markdown();
                md.SafeMode = false;

                TextReader infile = new StreamReader(fileName);
                String output = md.Transform(infile.ReadToEnd());
                infile.Close();
                webTargetPage.DocumentText = output;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
