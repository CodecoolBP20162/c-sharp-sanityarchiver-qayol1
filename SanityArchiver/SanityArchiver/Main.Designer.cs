namespace SanityArchiver
{
    partial class MainForm
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
            this.FileListView = new System.Windows.Forms.ListView();
            this.Column0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TxtFileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DirContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtFileContextMenuStrip.SuspendLayout();
            this.FileContextMenuStrip.SuspendLayout();
            this.DirContextMenuStrip.SuspendLayout();
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
            this.FileListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileListView_MouseClick);
            this.FileListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileListView_MouseDoubleClick);
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
            // Column3
            // 
            this.Column3.Text = "Size";
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
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 30);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<--";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFileContextMenuStrip
            // 
            this.TxtFileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.readToolStripMenuItem,
            this.cryptToolStripMenuItem});
            this.TxtFileContextMenuStrip.Name = "TxtFileContextMenuStrip";
            this.TxtFileContextMenuStrip.Size = new System.Drawing.Size(104, 92);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.archiveToolStripMenuItem.Text = "Zip";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // cryptToolStripMenuItem
            // 
            this.cryptToolStripMenuItem.Name = "cryptToolStripMenuItem";
            this.cryptToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cryptToolStripMenuItem.Text = "Crypt";
            // 
            // FileContextMenuStrip
            // 
            this.FileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.zipToolStripMenuItem,
            this.cryptToolStripMenuItem1});
            this.FileContextMenuStrip.Name = "FileContextMenuStrip";
            this.FileContextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            // 
            // zipToolStripMenuItem
            // 
            this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
            this.zipToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zipToolStripMenuItem.Text = "Zip";
            // 
            // cryptToolStripMenuItem1
            // 
            this.cryptToolStripMenuItem1.Name = "cryptToolStripMenuItem1";
            this.cryptToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cryptToolStripMenuItem1.Text = "Crypt";
            // 
            // DirContextMenuStrip
            // 
            this.DirContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem});
            this.DirContextMenuStrip.Name = "DirContextMenuStrip";
            this.DirContextMenuStrip.Size = new System.Drawing.Size(95, 26);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 479);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.FileListView);
            this.Name = "MainForm";
            this.Text = "SanityExplorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TxtFileContextMenuStrip.ResumeLayout(false);
            this.FileContextMenuStrip.ResumeLayout(false);
            this.DirContextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ContextMenuStrip TxtFileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cryptToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip FileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cryptToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip DirContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
    }
}

