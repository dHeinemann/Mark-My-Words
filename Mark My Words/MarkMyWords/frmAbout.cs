using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarkMyWords
{
    public partial class frmAbout : Form
    {

        public frmAbout()
        {
            InitializeComponent();
        }

        private void llblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dheinemann.com/projects/mark-my-words");
            Close();
        }

        private void llblSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/dHeinemann/mark-my-words");
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "v1.01";
        }
        
    }
}
