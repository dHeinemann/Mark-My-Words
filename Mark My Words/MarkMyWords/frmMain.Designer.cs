namespace MarkMyWords
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.webTargetPage = new System.Windows.Forms.WebBrowser();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.chkJekyllMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Open";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // webTargetPage
            // 
            this.webTargetPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webTargetPage.Location = new System.Drawing.Point(12, 39);
            this.webTargetPage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTargetPage.Name = "webTargetPage";
            this.webTargetPage.Size = new System.Drawing.Size(600, 391);
            this.webTargetPage.TabIndex = 4;
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.Location = new System.Drawing.Point(93, 12);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(402, 20);
            this.txtTarget.TabIndex = 0;
            this.txtTarget.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Image = global::MarkMyWords.Properties.Resources.about;
            this.btnAbout.Location = new System.Drawing.Point(589, 10);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 23);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.TabStop = false;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // chkJekyllMode
            // 
            this.chkJekyllMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJekyllMode.AutoSize = true;
            this.chkJekyllMode.Checked = true;
            this.chkJekyllMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJekyllMode.Location = new System.Drawing.Point(501, 14);
            this.chkJekyllMode.Name = "chkJekyllMode";
            this.chkJekyllMode.Size = new System.Drawing.Size(82, 17);
            this.chkJekyllMode.TabIndex = 5;
            this.chkJekyllMode.TabStop = false;
            this.chkJekyllMode.Text = "Jekyll Mode";
            this.chkJekyllMode.UseVisualStyleBackColor = true;
            this.chkJekyllMode.CheckedChanged += new System.EventHandler(this.chkJekyllMode_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.chkJekyllMode);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.webTargetPage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtTarget);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmMain";
            this.Text = "Mark My Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.WebBrowser webTargetPage;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox chkJekyllMode;
    }
}

