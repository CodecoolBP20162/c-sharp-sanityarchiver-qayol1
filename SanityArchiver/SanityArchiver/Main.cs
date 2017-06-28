using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
        static Dictionary<string, string> MimeTypes = Extensions.MimeTypes;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileList = new List<FileInfo>();
            DirList = new List<DirectoryInfo>();
            path = "C:/";
            FileListView.SmallImageList = this.imageList1;
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
                item.ImageIndex = 1;
                item.SubItems.Add(dir.FullName);
                item.SubItems.Add("File folder");
            }
            foreach (FileInfo file in FileList)
            {
                ListViewItem item = FileListView.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                item.SubItems.Add(file.FullName);
                String fileExtension;
                if (file.Extension.Length>0)
                {
                    fileExtension = file.Extension.Substring(1);
                } else
                {
                    fileExtension = file.Extension;
                }
                if (MimeTypes.ContainsKey(fileExtension))
                {
                    item.SubItems.Add(MimeTypes[fileExtension]);
                } else
                {
                    item.SubItems.Add(fileExtension);
                }
                    
                if (file.Extension.Equals(".txt"))
                {
                    item.ImageIndex = 2;
                } else
                {
                    item.ImageIndex = 0;
                }
                item.SubItems.Add(ByteConverter.ConvertBytes(file.Length));
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


        private void FileListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedItem = FileListView.FocusedItem;
                if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("text/plain"))
                {
                    ContextMenuStrip.Show(Cursor.Position);
                    for (int i = 0; i < ContextMenuStrip.Items.Count; i++)
                    {
                        if (i == 0 || i == 1 || i == 3 || i == 5 || i == 6 || i == 7)
                        {
                            ContextMenuStrip.Items[i].Visible = true;
                        }
                        else
                        {
                            ContextMenuStrip.Items[i].Visible = false;
                        }
                    }

                }
                if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("gz"))
                {
                    ContextMenuStrip.Show(Cursor.Position);
                    for (int i = 0; i < ContextMenuStrip.Items.Count; i++)
                    {
                        if (i == 0 || i == 1 || i == 4 || i == 6 || i == 7)
                        {
                            ContextMenuStrip.Items[i].Visible = true;
                        }
                        else
                        {
                            ContextMenuStrip.Items[i].Visible = false;
                        }
                    }

                }
                if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("File folder"))
                {
                    ContextMenuStrip.Show(Cursor.Position);
                    for (int i = 0; i < ContextMenuStrip.Items.Count; i++)
                    {
                        if (i == 8)
                        {
                            ContextMenuStrip.Items[i].Visible = true;
                        }  else
                        {
                            ContextMenuStrip.Items[i].Visible = false;
                        }
                    }
                    
                }
                if (SelectedItem.Bounds.Contains(e.Location) == true && !SelectedItem.SubItems[2].Text.Equals("File folder") && !SelectedItem.SubItems[2].Text.Equals("text/plain") && !SelectedItem.SubItems[2].Text.Equals("gz"))
                {
                    ContextMenuStrip.Show(Cursor.Position);
                    for (int i = 0; i < ContextMenuStrip.Items.Count; i++)
                    {
                        if (i == 0 || i == 1 || i == 3 || i == 6 || i == 7 )
                        {
                            ContextMenuStrip.Items[i].Visible = true;
                        }
                        else
                        {
                            ContextMenuStrip.Items[i].Visible = false;
                        }
                    }
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            Zip.ArchiveFile(file);
            FillData();
            ShowData();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ShowText();
            form.FullFileName = FileListView.FocusedItem.SubItems[1].Text;
            form.Text = FileListView.FocusedItem.SubItems[0].Text;
            form.ShowDialog(this);
        }

        private void zipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            Zip.ArchiveFile(file);
            FillData();
            ShowData();
        }

        private void cryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
        }

        private void sizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           SelectedItem.SubItems.Add(ByteConverter.ConvertBytes(DirSize(new DirectoryInfo(SelectedItem.SubItems[1].Text))));
        }

        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            try
            {
                FileInfo[] fis = d.GetFiles();
                foreach (FileInfo fi in fis)
                {
                    size += fi.Length;
                }
                DirectoryInfo[] dis = d.GetDirectories();
                foreach (DirectoryInfo di in dis)
                {
                    size += DirSize(di);
                }
                return size;
            } catch
            {
                return 0;
            }
            
        }

        private void decompressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            Zip.Decompress(file);
            FillData();
            ShowData();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
