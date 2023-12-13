namespace PVZ_Language_settings
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonFr = new System.Windows.Forms.Button();
            this.buttonEn = new System.Windows.Forms.Button();
            this.buttonDe = new System.Windows.Forms.Button();
            this.buttonIt = new System.Windows.Forms.Button();
            this.buttonEs = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.timerLogo = new System.Windows.Forms.Timer(this.components);
            this.linkLabelThanks = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(424, 24);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(400, 240);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonFr
            // 
            this.buttonFr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(50)))));
            this.buttonFr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.buttonFr.FlatAppearance.BorderSize = 3;
            this.buttonFr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFr.ForeColor = System.Drawing.Color.White;
            this.buttonFr.Image = ((System.Drawing.Image)(resources.GetObject("buttonFr.Image")));
            this.buttonFr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFr.Location = new System.Drawing.Point(463, 384);
            this.buttonFr.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.buttonFr.Name = "buttonFr";
            this.buttonFr.Padding = new System.Windows.Forms.Padding(6);
            this.buttonFr.Size = new System.Drawing.Size(155, 60);
            this.buttonFr.TabIndex = 1;
            this.buttonFr.Text = "Français";
            this.buttonFr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFr.UseVisualStyleBackColor = false;
            this.buttonFr.Click += new System.EventHandler(this.buttonFr_Click);
            // 
            // buttonEn
            // 
            this.buttonEn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(50)))));
            this.buttonEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.buttonEn.FlatAppearance.BorderSize = 3;
            this.buttonEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEn.ForeColor = System.Drawing.Color.White;
            this.buttonEn.Image = ((System.Drawing.Image)(resources.GetObject("buttonEn.Image")));
            this.buttonEn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEn.Location = new System.Drawing.Point(463, 312);
            this.buttonEn.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.buttonEn.Name = "buttonEn";
            this.buttonEn.Padding = new System.Windows.Forms.Padding(6);
            this.buttonEn.Size = new System.Drawing.Size(155, 60);
            this.buttonEn.TabIndex = 2;
            this.buttonEn.Text = "English";
            this.buttonEn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEn.UseVisualStyleBackColor = false;
            this.buttonEn.Click += new System.EventHandler(this.buttonEn_Click);
            // 
            // buttonDe
            // 
            this.buttonDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(50)))));
            this.buttonDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.buttonDe.FlatAppearance.BorderSize = 3;
            this.buttonDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDe.ForeColor = System.Drawing.Color.White;
            this.buttonDe.Image = ((System.Drawing.Image)(resources.GetObject("buttonDe.Image")));
            this.buttonDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDe.Location = new System.Drawing.Point(630, 312);
            this.buttonDe.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDe.Name = "buttonDe";
            this.buttonDe.Padding = new System.Windows.Forms.Padding(6);
            this.buttonDe.Size = new System.Drawing.Size(155, 60);
            this.buttonDe.TabIndex = 4;
            this.buttonDe.Text = "Deutsch";
            this.buttonDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDe.UseVisualStyleBackColor = false;
            this.buttonDe.Click += new System.EventHandler(this.buttonDe_Click);
            // 
            // buttonIt
            // 
            this.buttonIt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonIt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(50)))));
            this.buttonIt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.buttonIt.FlatAppearance.BorderSize = 3;
            this.buttonIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIt.ForeColor = System.Drawing.Color.White;
            this.buttonIt.Image = ((System.Drawing.Image)(resources.GetObject("buttonIt.Image")));
            this.buttonIt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIt.Location = new System.Drawing.Point(547, 456);
            this.buttonIt.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.buttonIt.Name = "buttonIt";
            this.buttonIt.Padding = new System.Windows.Forms.Padding(6);
            this.buttonIt.Size = new System.Drawing.Size(155, 60);
            this.buttonIt.TabIndex = 3;
            this.buttonIt.Text = "Italiano";
            this.buttonIt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIt.UseVisualStyleBackColor = false;
            this.buttonIt.Click += new System.EventHandler(this.buttonIt_Click);
            // 
            // buttonEs
            // 
            this.buttonEs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(50)))));
            this.buttonEs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.buttonEs.FlatAppearance.BorderSize = 3;
            this.buttonEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEs.ForeColor = System.Drawing.Color.White;
            this.buttonEs.Image = ((System.Drawing.Image)(resources.GetObject("buttonEs.Image")));
            this.buttonEs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEs.Location = new System.Drawing.Point(630, 384);
            this.buttonEs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEs.Name = "buttonEs";
            this.buttonEs.Padding = new System.Windows.Forms.Padding(6);
            this.buttonEs.Size = new System.Drawing.Size(155, 60);
            this.buttonEs.TabIndex = 5;
            this.buttonEs.Text = "Español";
            this.buttonEs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEs.UseVisualStyleBackColor = false;
            this.buttonEs.Click += new System.EventHandler(this.buttonEs_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(24, 730);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(120, 24);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "Version 1.0.0.0";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelGithub.LinkColor = System.Drawing.Color.White;
            this.linkLabelGithub.Location = new System.Drawing.Point(1136, 730);
            this.linkLabelGithub.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(88, 24);
            this.linkLabelGithub.TabIndex = 7;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "My GitHub";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // timerLogo
            // 
            this.timerLogo.Interval = 1;
            this.timerLogo.Tick += new System.EventHandler(this.timerLogo_Tick);
            // 
            // linkLabelThanks
            // 
            this.linkLabelThanks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelThanks.AutoSize = true;
            this.linkLabelThanks.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelThanks.LinkColor = System.Drawing.Color.White;
            this.linkLabelThanks.Location = new System.Drawing.Point(496, 730);
            this.linkLabelThanks.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabelThanks.Name = "linkLabelThanks";
            this.linkLabelThanks.Size = new System.Drawing.Size(257, 24);
            this.linkLabelThanks.TabIndex = 9;
            this.linkLabelThanks.TabStop = true;
            this.linkLabelThanks.Text = "Thanks to Shaklin for translation";
            this.linkLabelThanks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelThanks_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 778);
            this.Controls.Add(this.linkLabelThanks);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonEs);
            this.Controls.Add(this.buttonDe);
            this.Controls.Add(this.buttonIt);
            this.Controls.Add(this.buttonEn);
            this.Controls.Add(this.buttonFr);
            this.Controls.Add(this.pictureBoxLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Burbank Big Cd Bd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PVZ Language settings for GOTY edition";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Button buttonFr;
        private Button buttonEn;
        private Button buttonDe;
        private Button buttonIt;
        private Button buttonEs;
        private Label labelVersion;
        private LinkLabel linkLabelGithub;
        private System.Windows.Forms.Timer timerLogo;
        private LinkLabel linkLabelThanks;
    }
}