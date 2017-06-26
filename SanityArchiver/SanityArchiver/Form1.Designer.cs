namespace SanityArchiver
{
    partial class Form1
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
            this.FileListView = new System.Windows.Forms.ListView();
            this.Column0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.Column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileListView
            // 
            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3});
            this.FileListView.Location = new System.Drawing.Point(12, 59);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(439, 406);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            this.FileListView.SelectedIndexChanged += new System.EventHandler(this.FileListView_SelectedIndexChanged);
            // 
            // Column0
            // 
            this.Column0.Text = "Name";
            this.Column0.Width = 0;
            // 
            // Column1
            // 
            this.Column1.Text = "Path";
            this.Column1.Width = 109;
            // 
            // Column2
            // 
            this.Column2.Text = "Type";
            this.Column2.Width = 105;
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(129, 33);
            this.PathBox.Name = "PathBox";
            this.PathBox.ReadOnly = true;
            this.PathBox.Size = new System.Drawing.Size(322, 20);
            this.PathBox.TabIndex = 2;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(91, 36);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(32, 13);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Path:";
            // 
            // Column3
            // 
            this.Column3.Text = "Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.FileListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.ColumnHeader Column0;
        private System.Windows.Forms.ColumnHeader Column1;
        private System.Windows.Forms.ColumnHeader Column2;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.ColumnHeader Column3;
        private System.Windows.Forms.Button button1;
    }
}

