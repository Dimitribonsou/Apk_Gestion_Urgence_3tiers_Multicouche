namespace GUI
{
    partial class Publication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnPublier = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateInfo = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEnvoie = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.dgvInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMessage.BorderRadius = 10;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(626, 109);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMessage.PlaceholderText = "";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(329, 59);
            this.txtMessage.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Message";
            // 
            // txtTitre
            // 
            this.txtTitre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitre.BorderRadius = 10;
            this.txtTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitre.DefaultText = "";
            this.txtTitre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.ForeColor = System.Drawing.Color.Black;
            this.txtTitre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitre.Location = new System.Drawing.Point(180, 109);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.PasswordChar = '\0';
            this.txtTitre.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTitre.PlaceholderText = "";
            this.txtTitre.SelectedText = "";
            this.txtTitre.Size = new System.Drawing.Size(329, 59);
            this.txtTitre.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Titre";
            // 
            // btnDeleteInfo
            // 
            this.btnDeleteInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteInfo.BorderRadius = 10;
            this.btnDeleteInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteInfo.FillColor = System.Drawing.Color.Blue;
            this.btnDeleteInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInfo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInfo.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDeleteInfo.Location = new System.Drawing.Point(961, 298);
            this.btnDeleteInfo.Name = "btnDeleteInfo";
            this.btnDeleteInfo.Size = new System.Drawing.Size(223, 58);
            this.btnDeleteInfo.TabIndex = 24;
            this.btnDeleteInfo.Text = "Supprimer";
            this.btnDeleteInfo.Click += new System.EventHandler(this.btnDeleteInfo_Click);
            // 
            // btnPublier
            // 
            this.btnPublier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPublier.BorderRadius = 10;
            this.btnPublier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPublier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPublier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPublier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPublier.FillColor = System.Drawing.Color.Blue;
            this.btnPublier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublier.ForeColor = System.Drawing.Color.White;
            this.btnPublier.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnPublier.Location = new System.Drawing.Point(688, 298);
            this.btnPublier.Name = "btnPublier";
            this.btnPublier.Size = new System.Drawing.Size(223, 58);
            this.btnPublier.TabIndex = 25;
            this.btnPublier.Text = "Publier";
            this.btnPublier.Click += new System.EventHandler(this.btnPublier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnnuler.BorderRadius = 10;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.Blue;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnAnnuler.Location = new System.Drawing.Point(372, 298);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(223, 58);
            this.btnAnnuler.TabIndex = 26;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateInfo.BorderRadius = 10;
            this.btnUpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateInfo.FillColor = System.Drawing.Color.Blue;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfo.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateInfo.Location = new System.Drawing.Point(90, 298);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(223, 58);
            this.btnUpdateInfo.TabIndex = 27;
            this.btnUpdateInfo.Text = "Modifier";
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 38);
            this.label9.TabIndex = 28;
            this.label9.Text = "Liste  Publications";
            // 
            // dtpEnvoie
            // 
            this.dtpEnvoie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEnvoie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnvoie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnvoie.Location = new System.Drawing.Point(202, 221);
            this.dtpEnvoie.Name = "dtpEnvoie";
            this.dtpEnvoie.Size = new System.Drawing.Size(307, 34);
            this.dtpEnvoie.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date Debut";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(621, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date Fin";
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiration.Location = new System.Drawing.Point(626, 221);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(307, 34);
            this.dtpExpiration.TabIndex = 30;
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfo.ColumnHeadersHeight = 50;
            this.dgvInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInfo.Location = new System.Drawing.Point(24, 508);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowHeadersVisible = false;
            this.dgvInfo.RowTemplate.Height = 50;
            this.dgvInfo.Size = new System.Drawing.Size(1199, 360);
            this.dgvInfo.TabIndex = 31;
            this.dgvInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInfo.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvInfo.ThemeStyle.ReadOnly = true;
            this.dgvInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInfo.ThemeStyle.RowsStyle.Height = 50;
            this.dgvInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            this.dgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            this.dgvInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            // 
            // Publication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1252, 908);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.dtpExpiration);
            this.Controls.Add(this.dtpEnvoie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeleteInfo);
            this.Controls.Add(this.btnPublier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Publication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publication";
            this.Load += new System.EventHandler(this.Publication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTitre;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnDeleteInfo;
        private Guna.UI2.WinForms.Guna2Button btnPublier;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private Guna.UI2.WinForms.Guna2Button btnUpdateInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEnvoie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInfo;
    }
}