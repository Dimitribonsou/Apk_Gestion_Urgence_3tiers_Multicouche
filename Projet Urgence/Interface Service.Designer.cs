namespace GUI
{
    partial class Interface_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface_Service));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.lbHeure = new System.Windows.Forms.Label();
            this.lbPage = new System.Windows.Forms.Label();
            this.lbNomService = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInformation = new FontAwesome.Sharp.IconButton();
            this.btnApropos = new FontAwesome.Sharp.IconButton();
            this.btnDeconnect = new FontAwesome.Sharp.IconButton();
            this.btnAide = new FontAwesome.Sharp.IconButton();
            this.btnPlanification = new FontAwesome.Sharp.IconButton();
            this.btnPublication = new FontAwesome.Sharp.IconButton();
            this.btnPersonnel = new FontAwesome.Sharp.IconButton();
            this.btnPleinte = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelheader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(292, 100);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1328, 765);
            this.panelContainer.TabIndex = 5;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Crimson;
            this.panelheader.Controls.Add(this.lbHeure);
            this.panelheader.Controls.Add(this.lbPage);
            this.panelheader.Controls.Add(this.lbNomService);
            this.panelheader.Controls.Add(this.lbDate);
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(292, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1328, 100);
            this.panelheader.TabIndex = 4;
            // 
            // lbHeure
            // 
            this.lbHeure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHeure.AutoSize = true;
            this.lbHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeure.ForeColor = System.Drawing.Color.White;
            this.lbHeure.Location = new System.Drawing.Point(1080, 48);
            this.lbHeure.Name = "lbHeure";
            this.lbHeure.Size = new System.Drawing.Size(70, 25);
            this.lbHeure.TabIndex = 1;
            this.lbHeure.Text = "Heure";
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPage.ForeColor = System.Drawing.Color.Lime;
            this.lbPage.Location = new System.Drawing.Point(46, 42);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(94, 32);
            this.lbPage.TabIndex = 1;
            this.lbPage.Text = "Home";
            // 
            // lbNomService
            // 
            this.lbNomService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNomService.AutoSize = true;
            this.lbNomService.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbNomService.ForeColor = System.Drawing.Color.White;
            this.lbNomService.Location = new System.Drawing.Point(725, 29);
            this.lbNomService.Name = "lbNomService";
            this.lbNomService.Size = new System.Drawing.Size(80, 36);
            this.lbNomService.TabIndex = 1;
            this.lbNomService.Text = "Nom";
            this.lbNomService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            this.lbDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(332, 40);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(57, 25);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(546, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = " SERVICE";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Navy;
            this.panelMenu.Controls.Add(this.btnInformation);
            this.panelMenu.Controls.Add(this.btnApropos);
            this.panelMenu.Controls.Add(this.btnDeconnect);
            this.panelMenu.Controls.Add(this.btnAide);
            this.panelMenu.Controls.Add(this.btnPlanification);
            this.panelMenu.Controls.Add(this.btnPublication);
            this.panelMenu.Controls.Add(this.btnPersonnel);
            this.panelMenu.Controls.Add(this.btnPleinte);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(292, 865);
            this.panelMenu.TabIndex = 3;
            // 
            // btnInformation
            // 
            this.btnInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Icon = FontAwesome.Sharp.IconChar.EnvelopeO;
            this.btnInformation.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInformation.IconSize = 40;
            this.btnInformation.Image = ((System.Drawing.Image)(resources.GetObject("btnInformation.Image")));
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInformation.Location = new System.Drawing.Point(3, 526);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(289, 66);
            this.btnInformation.TabIndex = 3;
            this.btnInformation.Text = "Informations";
            this.btnInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnApropos
            // 
            this.btnApropos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApropos.BackColor = System.Drawing.Color.Transparent;
            this.btnApropos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApropos.FlatAppearance.BorderSize = 0;
            this.btnApropos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnApropos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApropos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnApropos.ForeColor = System.Drawing.Color.White;
            this.btnApropos.Icon = FontAwesome.Sharp.IconChar.ThList;
            this.btnApropos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnApropos.IconSize = 40;
            this.btnApropos.Image = ((System.Drawing.Image)(resources.GetObject("btnApropos.Image")));
            this.btnApropos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApropos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApropos.Location = new System.Drawing.Point(0, 694);
            this.btnApropos.Name = "btnApropos";
            this.btnApropos.Size = new System.Drawing.Size(289, 70);
            this.btnApropos.TabIndex = 2;
            this.btnApropos.Text = "A Propos";
            this.btnApropos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApropos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApropos.UseVisualStyleBackColor = false;
            this.btnApropos.Click += new System.EventHandler(this.btnApropos_Click);
            // 
            // btnDeconnect
            // 
            this.btnDeconnect.BackColor = System.Drawing.Color.Transparent;
            this.btnDeconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeconnect.FlatAppearance.BorderSize = 0;
            this.btnDeconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnDeconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnect.ForeColor = System.Drawing.Color.White;
            this.btnDeconnect.Icon = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnDeconnect.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeconnect.IconSize = 40;
            this.btnDeconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDeconnect.Image")));
            this.btnDeconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnect.Location = new System.Drawing.Point(0, 800);
            this.btnDeconnect.Name = "btnDeconnect";
            this.btnDeconnect.Size = new System.Drawing.Size(292, 65);
            this.btnDeconnect.TabIndex = 1;
            this.btnDeconnect.Text = "Se Deconnecter";
            this.btnDeconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeconnect.UseVisualStyleBackColor = false;
            this.btnDeconnect.Click += new System.EventHandler(this.btnDeconnect_Click);
            // 
            // btnAide
            // 
            this.btnAide.BackColor = System.Drawing.Color.Transparent;
            this.btnAide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAide.FlatAppearance.BorderSize = 0;
            this.btnAide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAide.ForeColor = System.Drawing.Color.White;
            this.btnAide.Icon = FontAwesome.Sharp.IconChar.Inbox;
            this.btnAide.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAide.IconSize = 40;
            this.btnAide.Image = ((System.Drawing.Image)(resources.GetObject("btnAide.Image")));
            this.btnAide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAide.Location = new System.Drawing.Point(3, 611);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(289, 64);
            this.btnAide.TabIndex = 1;
            this.btnAide.Text = "Aide";
            this.btnAide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAide.UseVisualStyleBackColor = false;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnPlanification
            // 
            this.btnPlanification.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanification.FlatAppearance.BorderSize = 0;
            this.btnPlanification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnPlanification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanification.ForeColor = System.Drawing.Color.White;
            this.btnPlanification.Icon = FontAwesome.Sharp.IconChar.ThList;
            this.btnPlanification.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPlanification.IconSize = 40;
            this.btnPlanification.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanification.Image")));
            this.btnPlanification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanification.Location = new System.Drawing.Point(0, 443);
            this.btnPlanification.Name = "btnPlanification";
            this.btnPlanification.Size = new System.Drawing.Size(283, 64);
            this.btnPlanification.TabIndex = 1;
            this.btnPlanification.Text = "Planifications";
            this.btnPlanification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanification.UseVisualStyleBackColor = false;
            this.btnPlanification.Click += new System.EventHandler(this.btnPlanification_Click);
            // 
            // btnPublication
            // 
            this.btnPublication.BackColor = System.Drawing.Color.Transparent;
            this.btnPublication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublication.FlatAppearance.BorderSize = 0;
            this.btnPublication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnPublication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublication.ForeColor = System.Drawing.Color.White;
            this.btnPublication.Icon = FontAwesome.Sharp.IconChar.Refresh;
            this.btnPublication.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPublication.IconSize = 40;
            this.btnPublication.Image = ((System.Drawing.Image)(resources.GetObject("btnPublication.Image")));
            this.btnPublication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublication.Location = new System.Drawing.Point(3, 356);
            this.btnPublication.Name = "btnPublication";
            this.btnPublication.Size = new System.Drawing.Size(289, 64);
            this.btnPublication.TabIndex = 1;
            this.btnPublication.Text = "Publications";
            this.btnPublication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublication.UseVisualStyleBackColor = false;
            this.btnPublication.Click += new System.EventHandler(this.btnPublication_Click);
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonnel.FlatAppearance.BorderSize = 0;
            this.btnPersonnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnel.ForeColor = System.Drawing.Color.White;
            this.btnPersonnel.Icon = FontAwesome.Sharp.IconChar.TextWidth;
            this.btnPersonnel.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPersonnel.IconSize = 40;
            this.btnPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.Image")));
            this.btnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.Location = new System.Drawing.Point(3, 196);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(289, 71);
            this.btnPersonnel.TabIndex = 1;
            this.btnPersonnel.Text = "Personnels";
            this.btnPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnPleinte
            // 
            this.btnPleinte.BackColor = System.Drawing.Color.Transparent;
            this.btnPleinte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPleinte.FlatAppearance.BorderSize = 0;
            this.btnPleinte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnPleinte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPleinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPleinte.ForeColor = System.Drawing.Color.White;
            this.btnPleinte.Icon = FontAwesome.Sharp.IconChar.TextWidth;
            this.btnPleinte.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPleinte.IconSize = 40;
            this.btnPleinte.Image = ((System.Drawing.Image)(resources.GetObject("btnPleinte.Image")));
            this.btnPleinte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPleinte.Location = new System.Drawing.Point(3, 273);
            this.btnPleinte.Name = "btnPleinte";
            this.btnPleinte.Size = new System.Drawing.Size(289, 64);
            this.btnPleinte.TabIndex = 1;
            this.btnPleinte.Text = "Pleinte";
            this.btnPleinte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPleinte.UseVisualStyleBackColor = false;
            this.btnPleinte.Click += new System.EventHandler(this.btnPleinte_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.pictureBoxLogo);
            this.panellogo.Controls.Add(this.label2);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(292, 156);
            this.panellogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderRadius = 5;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::GUI.Properties.Resources.urgence;
            this.pictureBoxLogo.ImageRotate = 0F;
            this.pictureBoxLogo.Location = new System.Drawing.Point(28, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(172, 103);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acceuil";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Interface_Service
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1620, 865);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panelMenu);
            this.Name = "Interface_Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface_Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Interface_Service_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label lbHeure;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        public FontAwesome.Sharp.IconButton btnDeconnect;
        public FontAwesome.Sharp.IconButton btnAide;
        public FontAwesome.Sharp.IconButton btnPlanification;
        public FontAwesome.Sharp.IconButton btnPublication;
        public FontAwesome.Sharp.IconButton btnPleinte;
        private System.Windows.Forms.Panel panellogo;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        public FontAwesome.Sharp.IconButton btnPersonnel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNomService;
        public FontAwesome.Sharp.IconButton btnApropos;
        public FontAwesome.Sharp.IconButton btnInformation;
    }
}