﻿namespace GUI
{
    partial class Aide
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
            this.richTextBoxAide = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxAide
            // 
            this.richTextBoxAide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxAide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAide.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxAide.Name = "richTextBoxAide";
            this.richTextBoxAide.ReadOnly = true;
            this.richTextBoxAide.Size = new System.Drawing.Size(1099, 739);
            this.richTextBoxAide.TabIndex = 0;
            this.richTextBoxAide.Text = "";
            // 
            // Aide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 739);
            this.Controls.Add(this.richTextBoxAide);
            this.Name = "Aide";
            this.Text = "Aide";
            this.Load += new System.EventHandler(this.Aide_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAide;
    }
}