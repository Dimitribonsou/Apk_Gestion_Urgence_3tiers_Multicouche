namespace GUI
{
    partial class Apropos
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
            this.richTextBoxApropos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxApropos
            // 
            this.richTextBoxApropos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxApropos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxApropos.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxApropos.Name = "richTextBoxApropos";
            this.richTextBoxApropos.ReadOnly = true;
            this.richTextBoxApropos.Size = new System.Drawing.Size(1118, 751);
            this.richTextBoxApropos.TabIndex = 0;
            this.richTextBoxApropos.Text = "";
            // 
            // Apropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 751);
            this.Controls.Add(this.richTextBoxApropos);
            this.Name = "Apropos";
            this.Text = "Apropos";
            this.Load += new System.EventHandler(this.Apropos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxApropos;
    }
}