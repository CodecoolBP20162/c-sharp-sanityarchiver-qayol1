using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{


    public partial class MainForm : Form
    {
        static String path;
        static ListViewItem SelectedItem;
        static Dictionary<string, string> MimeTypes = Extensions.MimeTypes;
        static String FileToCopy = "";
        static Boolean Paste = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                DriversComboBox.Items.Add(d.Name);
            } 
        }

        private void DriversComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.DriversComboBox.GetItemText(this.DriversComboBox.SelectedItem);
            path = selected;
            FileSystemData.FillData(path);
            FileListView.SmallImageList = this.imageList1;
            ShowData();
        }

        private void ShowData()
        {
            FileListView.Items.Clear();
            foreach (DirectoryInfo dir in FileSystemData.DirList)
            {
                ListViewItem item = FileListView.Items.Add(dir.Name);
                item.ImageIndex = 0;
                item.SubItems.Add(dir.FullName);
                item.SubItems.Add("File folder");
            }
            foreach (FileInfo file in FileSystemData.FileList)
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
                    item.ImageIndex = 3;
                } else
                {
                    item.ImageIndex = 2;
                }
                item.SubItems.Add(ByteConverter.ConvertBytes(file.Length));
            }
            if (FileListView.Items.Count < 1)
            {
                addEmptyItem();
            }
            PathBox.Text = FileSystemData.currentDirectory.FullName;
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

        private void addEmptyItem()
        {
            ListViewItem emptyItem = FileListView.Items.Add("");
            emptyItem.SubItems.Add("");
            emptyItem.SubItems.Add("");
        }
       
        private void GoToNewDir()
        {
            PathBox.Text = path;
            RefressFileListView();
        }

        private void RefressFileListView()
        {
            FileSystemData.FillData(path);
            ShowData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileSystemData.currentDirectory = Directory.GetParent(path);
                path = FileSystemData.currentDirectory.FullName;
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
                if (Paste)
                {
                    ContextMenuStrip.Items[2].Enabled = true;
                } else
                {
                    ContextMenuStrip.Items[2].Enabled = false;
                }
                // set txt file right click menu
                if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("text/plain"))
                {
                    ContextMenuStrip.Show(Cursor.Position);
                    for (int i = 0; i < ContextMenuStrip.Items.Count; i++)
                    {
                        if (i == 0 || i == 1 || i == 2 || i == 3 || i == 5 || i == 6 || i == 7)
                        {
                            ContextMenuStrip.Items[i].Visible = true;
                        }
                        else
                        {
                            ContextMenuStrip.Items[i].Visible = false;
                        }
                    }

                }
                // set zipped file right click menu
                if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("gz"))
                {
                    ContextMenuStrip.Show(Cursor.Position);
                    for (int i = 0; i < ContextMenuStrip.Items.Count; i++)
                    {
                        if (i == 0 || i == 1 || i == 2 || i == 4 || i == 6 || i == 7)
                        {
                            ContextMenuStrip.Items[i].Visible = true;
                        }
                        else
                        {
                            ContextMenuStrip.Items[i].Visible = false;
                        }
                    }

                }
                // set directory right click menu
                if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("File folder"))
                {
                    ContextMenuStrip.Show(Cursor.Position);
                    for (int i = 0; i < ContextMenuStrip.Items.Count; i++)
                    {
                        if (i == 8 || i == 2)
                        {
                            ContextMenuStrip.Items[i].Visible = true;
                        }  else
                        {
                            ContextMenuStrip.Items[i].Visible = false;
                        }
                    }
                }
                // set remained files right click menu
                if (SelectedItem.Bounds.Contains(e.Location) == true && 
                    !SelectedItem.SubItems[2].Text.Equals("File folder") && 
                    !SelectedItem.SubItems[2].Text.Equals("text/plain") && 
                    !SelectedItem.SubItems[2].Text.Equals("gz") && 
                    !SelectedItem.SubItems[1].Equals(""))
                {
                    ContextMenuStrip.Show(Cursor.Position);
                    for (int i = 0; i < ContextMenuStrip.Items.Count; i++)
                    {
                        if (i == 0 || i == 1 || i == 2 || i == 3 || i == 6 || i == 7 )
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
            FileToCopy = FileListView.FocusedItem.SubItems[1].Text;
            Paste = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileToCopy = FileListView.FocusedItem.SubItems[1].Text;
            Paste = true;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FileToCopy.Equals(""))
            {
                try
                {
                    
                    string[] FileParts = FileToCopy.Split('\\');
                    String FileName = FileParts[FileParts.Length-1];
                    string destFile = Path.Combine(PathBox.Text, FileName);
                    File.Copy(FileToCopy, destFile, true);
                } catch
                {

                } finally
                {
                    Paste = false;
                    FileToCopy = "";
                }
            }
            
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            Zip.CompressFile(file);
            RefressFileListView();
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
            RefressFileListView();
        }

        private void decompressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(SelectedItem.SubItems[1].Text);
            Zip.DecompressFile(file);
            RefressFileListView();
        }

        private void sizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           SelectedItem.SubItems.Add(ByteConverter.ConvertBytes(DirSize.GetSize(new DirectoryInfo(SelectedItem.SubItems[1].Text))));
        }

        private void cryptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Length>0)
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
