using System;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    
    public partial class MainForm : Form
    {
        public String path;
        ListViewItem SelectedItem;
        String FileToCopy = "";
        public Boolean Paste = false;
        public Boolean Cut = false;

        MainForm mainForm;
        Drives drives;
        FileList fileList;
        FileSystemHandler fileSystemHandler;
        Dir dir;
        ContextMenuHandler contextMenuHandler;

        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileList = new FileList(mainForm);
            contextMenuHandler = new ContextMenuHandler(mainForm);
            dir = new Dir(mainForm, fileList);
            fileSystemHandler = new FileSystemHandler(mainForm, fileList);
            drives = new Drives(mainForm, fileList);
            drives.ShowDrives();
            mainForm.FileListView.SmallImageList = this.imageList1;
        }

        private void DriversComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            drives.SelectDrive();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            dir.GoBack();
        }

        private void FileListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FileListView.FocusedItem.SubItems[2].Text.Equals("File folder"))
            {
                path = FileListView.FocusedItem.SubItems[1].Text;
                dir.GoToNewDir();
            }
            else
            {
                var form = new FileMenu();
                form.FullFileName = FileListView.FocusedItem.SubItems[1].Text;
                form.Text = FileListView.FocusedItem.SubItems[0].Text;
                form.ShowDialog(this);
            }
        }


        private void FileListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedItem = FileListView.FocusedItem;
                contextMenuHandler.HandleMenu(SelectedItem, e);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileToCopy = FileListView.FocusedItem.SubItems[1].Text;
            Paste = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileToCopy = FileListView.FocusedItem.SubItems[1].Text;
            Paste = true;
            Cut = true;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileSystemHandler.CopyMoveFile(FileToCopy);
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            Zip.CompressFile(file);
            fileList.RefressFileListView();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ShowText();
            form.action = 1;
            form.FileName = FileListView.FocusedItem.SubItems[1].Text;
            form.Text = FileListView.FocusedItem.SubItems[0].Text;
            form.ShowDialog(this);
        }

        private void zipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            Zip.CompressFile(file);
            fileList.RefressFileListView();
        }

        private void decompressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            Zip.DecompressFile(file);
            fileList.RefressFileListView();
        }

        private void sizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectedItem.SubItems.Add(ByteConverter.ConvertBytes(dir.GetSize(new DirectoryInfo(SelectedItem.SubItems[1].Text))));
        }

        private void cryptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Length > 0)
            {
                var form = new ShowText();
                form.action = 2;
                form.Text = "File: " + searchBox.Text + " search result:";
                form.FileName = searchBox.Text;
                form.ShowDialog(this);
            }
        }

    }
}
