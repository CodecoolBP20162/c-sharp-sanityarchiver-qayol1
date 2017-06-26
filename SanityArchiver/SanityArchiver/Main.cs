using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                ListViewItem item = FileListView.Items.Add(file.Name);
                item.SubItems.Add(file.FullName);
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(ConvertBytes(file.Length));
            }
            PathBox.Text = currentDirectory.FullName;
            FileListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            FileListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            FileListView.Columns[1].Width = 0;
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
                form.file = FileListView.FocusedItem.SubItems[1].Text;
                form.Text = FileListView.FocusedItem.SubItems[0].Text;
                form.ShowDialog(this);
            }
        }
    }
}
