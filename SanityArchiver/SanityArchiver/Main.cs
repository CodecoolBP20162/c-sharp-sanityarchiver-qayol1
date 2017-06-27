using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class MainForm : Form
    {

        static DirectoryInfo currentDirectory;
        static List<FileInfo> FileList;
        static List<DirectoryInfo> DirList;
        static String path;
        static ListViewItem SelectedItem;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileList = new List<FileInfo>();
            DirList = new List<DirectoryInfo>();
            path = "C:/";
            FillData();
            ShowData();    
        }

        private void FillData()
        {
            currentDirectory = new DirectoryInfo(path);
            AddFiles();
            AddDirectories();
        }

        private void AddDirectories()
        {
            DirList.Clear();
            try
            {
                foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
                {
                    DirList.Add(dir);
                }
            } catch (UnauthorizedAccessException)
            {

            }       
        }

        private void AddFiles()
        {
            FileList.Clear();
            try
            {
                foreach (FileInfo fil in currentDirectory.GetFiles())
                {
                    FileList.Add(fil);
                }
            } catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You have no acces to this directory.", "Acces denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }      
        }

        private void ShowData()
        {
            FileListView.Items.Clear();
            foreach (DirectoryInfo dir in DirList)
            {
                ListViewItem item = FileListView.Items.Add(dir.Name);
                item.SubItems.Add(dir.FullName);
                item.SubItems.Add("File folder");
            }
            foreach (FileInfo file in FileList)
            {
                ListViewItem item = FileListView.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                item.SubItems.Add(file.FullName);
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(ConvertBytes(file.Length));
            }
            PathBox.Text = currentDirectory.FullName;
            FileListView.Columns[1].Width = 0;
            for (int i=0; i<FileListView.Columns.Count; i++)
            {
                if (!FileListView.Columns[i].Text.Equals("Path"))
                {
                    FileListView.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    FileListView.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
       
        private string ConvertBytes(double FileLength)
        {
            if (FileLength < 1024)
            {
                return FileLength.ToString() + " byte";
            }
            if (FileLength >= 1024 && FileLength < 1024 * 1024)
            {
                return (FileLength / 1024).ToString("n2") + " kB";
            }
            if (FileLength >= 1024 * 1024 && FileLength < 1024 * 1024 * 1024)
            {
                return (FileLength / (1024 * 1024)).ToString("n2") + " MB";
            }
            if (FileLength >= 1024 * 1024 * 1024)
            {
                return (FileLength / (1024 * 1024 * 1024)).ToString("n2") + " GB";
            }
            return "";
        }

        
        private void GoToNewDir()
        {
            PathBox.Text = path;
            FillData();
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                currentDirectory = Directory.GetParent(path);
                path = currentDirectory.FullName;
                GoToNewDir();
            } catch (NullReferenceException)
            {

            }
        }

       private void FileListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FileListView.FocusedItem.SubItems[2].Text.Equals("File folder"))
            {
                path = FileListView.FocusedItem.SubItems[1].Text;
                GoToNewDir();
            }
            else
            {
                var form = new FileMenu();
                form.FullFileName = FileListView.FocusedItem.SubItems[1].Text;
                form.Text = FileListView.FocusedItem.SubItems[0].Text;
                form.ShowDialog(this);
            }
        }

        private void ArchiveFile(FileInfo fileToArchive)
        {
            FileStream input = fileToArchive.OpenRead();
            FileStream output = File.Create(fileToArchive.Directory + @"\" + Path.GetFileNameWithoutExtension(fileToArchive.Name) + ".gz");
            GZipStream Compressor = new GZipStream(output, CompressionMode.Compress);
            int b = input.ReadByte();
            while (b != -1)
            {
                Compressor.WriteByte((byte)b);

                b = input.ReadByte();
            }
            Compressor.Close();
            input.Close();
            output.Close();
        }

        private void FileListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedItem = FileListView.FocusedItem;
                if (SelectedItem.Bounds.Contains(e.Location) == true && !SelectedItem.SubItems[2].Text.Equals("File folder") && SelectedItem.SubItems[2].Text.Equals(".txt"))
                {
                    TxtFileContextMenuStrip.Show(Cursor.Position);
                    
                }
                if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("File folder"))
                {
                    DirContextMenuStrip.Show(Cursor.Position);
                }
                if (SelectedItem.Bounds.Contains(e.Location) == true && !SelectedItem.SubItems[2].Text.Equals("File folder") && !SelectedItem.SubItems[2].Text.Equals(".txt"))
                {
                    FileContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            ArchiveFile(file);
            FillData();
            ShowData();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cryptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void zipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            ArchiveFile(file);
            FillData();
            ShowData();
        }

        private void cryptToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
