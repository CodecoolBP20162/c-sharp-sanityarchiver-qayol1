﻿namespace SanityArchiver
{
    partial class ShowText
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
            this.FileText = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FileText
            // 
            this.FileText.FormattingEnabled = true;
            this.FileText.Location = new System.Drawing.Point(13, 13);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(543, 472);
            this.FileText.TabIndex = 0;
            // 
            // ShowText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 503);
            this.Controls.Add(this.FileText);
            this.Name = "ShowText";
            this.Text = "ShowText";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FileText;
    }
}