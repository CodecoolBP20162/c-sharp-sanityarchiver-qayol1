namespace SanityArchiver
{
    partial class FileMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.ReadOnly = new System.Windows.Forms.CheckBox();
            this.Hidden = new System.Windows.Forms.CheckBox();
            this.Archive = new System.Windows.Forms.CheckBox();
            this.System = new System.Windows.Forms.CheckBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(50, 15);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(221, 20);
            this.PathTextBox.TabIndex = 1;
            // 
            // ReadOnly
            // 
            this.ReadOnly.AutoSize = true;
            this.ReadOnly.Location = new System.Drawing.Point(50, 57);
            this.ReadOnly.Name = "ReadOnly";
            this.ReadOnly.Size = new System.Drawing.Size(74, 17);
            this.ReadOnly.TabIndex = 2;
            this.ReadOnly.Text = "Read-only";
            this.ReadOnly.UseVisualStyleBackColor = true;
            // 
            // Hidden
            // 
            this.Hidden.AutoSize = true;
            this.Hidden.Location = new System.Drawing.Point(50, 81);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(60, 17);
            this.Hidden.TabIndex = 3;
            this.Hidden.Text = "Hidden";
            this.Hidden.UseVisualStyleBackColor = true;
            // 
            // Archive
            // 
            this.Archive.AutoSize = true;
            this.Archive.Location = new System.Drawing.Point(50, 105);
            this.Archive.Name = "Archive";
            this.Archive.Size = new System.Drawing.Size(62, 17);
            this.Archive.TabIndex = 4;
            this.Archive.Text = "Archive";
            this.Archive.UseVisualStyleBackColor = true;
            // 
            // System
            // 
            this.System.AutoSize = true;
            this.System.Location = new System.Drawing.Point(50, 129);
            this.System.Name = "System";
            this.System.Size = new System.Drawing.Size(60, 17);
            this.System.TabIndex = 5;
            this.System.Text = "System";
            this.System.UseVisualStyleBackColor = true;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(50, 167);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 6;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // FileMenu
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.System);
            this.Controls.Add(this.Archive);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.ReadOnly);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FileMenu";
            this.Text = "FileMenu";
            this.Load += new System.EventHandler(this.FileMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.CheckBox ReadOnly;
        private System.Windows.Forms.CheckBox Hidden;
        private System.Windows.Forms.CheckBox Archive;
        private System.Windows.Forms.CheckBox System;
        private System.Windows.Forms.Button SetButton;
    }
}