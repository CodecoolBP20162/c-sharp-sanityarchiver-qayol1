using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public class FileList
    {
        private MainForm mainForm;
        Dictionary<string, string> MimeTypes = Extensions.MimeTypes;

        public FileList(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void ShowData()
        {
            mainForm.FileListView.Items.Clear();
            foreach (DirectoryInfo dir in FileSystemData.DirList)
            {
                ListViewItem item = mainForm.FileListView.Items.Add(dir.Name);
                item.ImageIndex = 0;
                item.SubItems.Add(dir.FullName);
                item.SubItems.Add("File folder");
            }
            foreach (FileInfo file in FileSystemData.FileList)
            {
                ListViewItem item = mainForm.FileListView.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                item.SubItems.Add(file.FullName);
                String fileExtension;
                if (file.Extension.Length > 0)
                {
                    fileExtension = file.Extension.Substring(1);
                }
                else
                {
                    fileExtension = file.Extension;
                }
                if (MimeTypes.ContainsKey(fileExtension))
                {
                    item.SubItems.Add(MimeTypes[fileExtension]);
                }
                else
                {
                    item.SubItems.Add(fileExtension);
                }

                if (file.Extension.Equals(".txt"))
                {
                    item.ImageIndex = 3;
                }
                else
                {
                    item.ImageIndex = 2;
                }
                item.SubItems.Add(ByteConverter.ConvertBytes(file.Length));
            }
            if (mainForm.FileListView.Items.Count < 1)
            {
                addEmptyItem();
            }
            mainForm.PathBox.Text = FileSystemData.currentDirectory.FullName;
            mainForm.FileListView.Columns[1].Width = 0;
            for (int i = 0; i < mainForm.FileListView.Columns.Count; i++)
            {
                if (!mainForm.FileListView.Columns[i].Text.Equals("Path"))
                {
                    mainForm.FileListView.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    mainForm.FileListView.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void addEmptyItem()
        {
            ListViewItem emptyItem = mainForm.FileListView.Items.Add("");
            emptyItem.SubItems.Add("");
            emptyItem.SubItems.Add("");
        }

        public void RefressFileListView()
        {
            FileSystemData.FillData(mainForm.path);
            ShowData();
        }
    }
}
