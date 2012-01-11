using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MarkMyWords
{
    public partial class frmMain : Form
    {
        String fileName;
        DateTime latestWrite;
        public Boolean jekyllMode = true;
        System.Timers.Timer renderTimer = new System.Timers.Timer(500);

        public frmMain()
        {
            InitializeComponent();
            renderTimer.Elapsed += new System.Timers.ElapsedEventHandler(renderPage);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (renderTimer.Enabled == true)
            {
                stopTimer();
            }

            OpenFileDialog browser = new OpenFileDialog();

            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTarget.Text = browser.FileName;
                fileName = browser.FileName;
                startTimer();
            }
        }

        private void startTimer()
        {
            renderTimer.Enabled = true;
        }

        private void stopTimer()
        {
            renderTimer.Enabled = false;
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
                String input = infile.ReadToEnd();
                infile.Close();

                String output;
                if (jekyllMode)
                {
                    output = md.Transform(Regex.Replace(input, @"---[\p{IsBasicLatin}]+---\r", ""));
                }
                else
                {
                    output = md.Transform(input);
                }
                webTargetPage.DocumentText = output;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void chkJekyllMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJekyllMode.Checked == true)
            {
                jekyllMode = true;
            }
            else
            {
                jekyllMode = false;
            }
        }
    }
}
