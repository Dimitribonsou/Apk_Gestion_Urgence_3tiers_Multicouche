namespace GUI
{
    partial class FormPersonnel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonnel));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDeconnecter = new FontAwesome.Sharp.IconButton();
            this.btnAide = new FontAwesome.Sharp.IconButton();
            this.btnApropos = new FontAwesome.Sharp.IconButton();
            this.btnInformation = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelheader = new System.Windows.Forms.Panel();
            this.lbHeure = new System.Windows.Forms.Label();
            this.lbPage = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Navy;
            this.panelMenu.Controls.Add(this.btnDeconnecter);
            this.panelMenu.Controls.Add(this.btnAide);
            this.panelMenu.Controls.Add(this.btnApropos);
            this.panelMenu.Controls.Add(this.btnInformation);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.panellogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.BackColor = System.Drawing.Color.Transparent;
            this.btnDeconnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDeconnecter, "btnDeconnecter");
            this.btnDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnDeconnecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeconnecter.ForeColor = System.Drawing.Color.White;
            this.btnDeconnecter.Icon = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnDeconnecter.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeconnecter.IconSize = 40;
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.UseVisualStyleBackColor = false;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // btnAide
            // 
            resources.ApplyResources(this.btnAide, "btnAide");
            this.btnAide.BackColor = System.Drawing.Color.Transparent;
            this.btnAide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAide.FlatAppearance.BorderSize = 0;
            this.btnAide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAide.ForeColor = System.Drawing.Color.White;
            this.btnAide.Icon = FontAwesome.Sharp.IconChar.Inbox;
            this.btnAide.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAide.IconSize = 40;
            this.btnAide.Name = "btnAide";
            this.btnAide.UseVisualStyleBackColor = false;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnApropos
            // 
            resources.ApplyResources(this.btnApropos, "btnApropos");
            this.btnApropos.BackColor = System.Drawing.Color.Transparent;
            this.btnApropos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApropos.FlatAppearance.BorderSize = 0;
            this.btnApropos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnApropos.ForeColor = System.Drawing.Color.White;
            this.btnApropos.Icon = FontAwesome.Sharp.IconChar.ThList;
            this.btnApropos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnApropos.IconSize = 40;
            this.btnApropos.Name = "btnApropos";
            this.btnApropos.UseVisualStyleBackColor = false;
            this.btnApropos.Click += new System.EventHandler(this.btnApropos_Click);
            // 
            // btnInformation
            // 
            resources.ApplyResources(this.btnInformation, "btnInformation");
            this.btnInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Icon = FontAwesome.Sharp.IconChar.EnvelopeO;
            this.btnInformation.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInformation.IconSize = 40;
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // iconButton1
            // 
            resources.ApplyResources(this.iconButton1, "iconButton1");
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.Icon = FontAwesome.Sharp.IconChar.TextWidth;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.label2);
            this.panellogo.Controls.Add(this.pictureBoxLogo);
            resources.ApplyResources(this.panellogo, "panellogo");
            this.panellogo.Name = "panellogo";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderRadius = 5;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::GUI.Properties.Resources.urgence;
            this.pictureBoxLogo.ImageRotate = 0F;
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Crimson;
            this.panelheader.Controls.Add(this.lbHeure);
            this.panelheader.Controls.Add(this.lbPage);
            this.panelheader.Controls.Add(this.lbDate);
            this.panelheader.Controls.Add(this.label1);
            resources.ApplyResources(this.panelheader, "panelheader");
            this.panelheader.Name = "panelheader";
            // 
            // lbHeure
            // 
            resources.ApplyResources(this.lbHeure, "lbHeure");
            this.lbHeure.ForeColor = System.Drawing.Color.White;
            this.lbHeure.Name = "lbHeure";
            // 
            // lbPage
            // 
            resources.ApplyResources(this.lbPage, "lbPage");
            this.lbPage.ForeColor = System.Drawing.Color.Lime;
            this.lbPage.Name = "lbPage";
            // 
            // lbDate
            // 
            resources.ApplyResources(this.lbDate, "lbDate");
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Name = "lbDate";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panelContainer
            // 
            resources.ApplyResources(this.panelContainer, "panelContainer");
            this.panelContainer.Name = "panelContainer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPersonnel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPersonnel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPersonnel_Load);
            this.panelMenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panellogo;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconButton btnDeconnecter;
        public FontAwesome.Sharp.IconButton btnAide;
        public FontAwesome.Sharp.IconButton btnApropos;
        public FontAwesome.Sharp.IconButton btnInformation;
        public FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbHeure;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}