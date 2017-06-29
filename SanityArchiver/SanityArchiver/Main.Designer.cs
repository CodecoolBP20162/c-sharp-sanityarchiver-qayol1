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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FileListView = new System.Windows.Forms.ListView();
            this.Column0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DriversComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileListView
            // 
            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3});
            this.FileListView.Location = new System.Drawing.Point(12, 84);
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
            this.PathBox.Location = new System.Drawing.Point(48, 50);
            this.PathBox.Name = "PathBox";
            this.PathBox.ReadOnly = true;
            this.PathBox.Size = new System.Drawing.Size(403, 20);
            this.PathBox.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.ImageKey = "340.png";
            this.BackButton.ImageList = this.imageList1;
            this.BackButton.Location = new System.Drawing.Point(12, 44);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(30, 30);
            this.BackButton.TabIndex = 4;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.jpg");
            this.imageList1.Images.SetKeyName(1, "find.png");
            this.imageList1.Images.SetKeyName(2, "file2.jpg");
            this.imageList1.Images.SetKeyName(3, "txt.png");
            this.imageList1.Images.SetKeyName(4, "340.png");
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.decompressToolStripMenuItem,
            this.readToolStripMenuItem,
            this.cryptToolStripMenuItem,
            this.decryptToolStripMenuItem,
            this.sizeToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.ContextMenuStrip.Name = "TxtFileContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(153, 246);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.archiveToolStripMenuItem.Text = "Zip";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // decompressToolStripMenuItem
            // 
            this.decompressToolStripMenuItem.Name = "decompressToolStripMenuItem";
            this.decompressToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decompressToolStripMenuItem.Text = "Decompress";
            this.decompressToolStripMenuItem.Click += new System.EventHandler(this.decompressToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // cryptToolStripMenuItem
            // 
            this.cryptToolStripMenuItem.Name = "cryptToolStripMenuItem";
            this.cryptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cryptToolStripMenuItem.Text = "Crypt";
            this.cryptToolStripMenuItem.Click += new System.EventHandler(this.cryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem1
            // 
            this.sizeToolStripMenuItem1.Name = "sizeToolStripMenuItem1";
            this.sizeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sizeToolStripMenuItem1.Text = "Size";
            this.sizeToolStripMenuItem1.Click += new System.EventHandler(this.sizeToolStripMenuItem1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(315, 18);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.ImageKey = "find.png";
            this.SearchButton.ImageList = this.imageList1;
            this.SearchButton.Location = new System.Drawing.Point(421, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(30, 30);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DriversComboBox
            // 
            this.DriversComboBox.FormattingEnabled = true;
            this.DriversComboBox.Location = new System.Drawing.Point(62, 16);
            this.DriversComboBox.Name = "DriversComboBox";
            this.DriversComboBox.Size = new System.Drawing.Size(51, 21);
            this.DriversComboBox.TabIndex = 7;
            this.DriversComboBox.SelectedIndexChanged += new System.EventHandler(this.DriversComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Drivers:";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DriversComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.FileListView);
            this.Name = "MainForm";
            this.Text = "SanityExplorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.ColumnHeader Column0;
        private System.Windows.Forms.ColumnHeader Column1;
        private System.Windows.Forms.ColumnHeader Column2;
        public System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.ColumnHeader Column3;
        private System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cryptToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decompressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.ComboBox DriversComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

