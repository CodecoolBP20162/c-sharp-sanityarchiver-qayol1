using System;
using System.IO;

namespace SanityArchiver
{
    public class Dir
    {
        private MainForm mainForm;
        private FileList fileList;

        public Dir(MainForm mainForm, FileList fileList)
        {
            this.mainForm = mainForm;
            this.fileList = fileList;
        }

        public long GetSize(DirectoryInfo d)
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
                    size += GetSize(di);
                }
                return size;
            }
            catch
            {
                return 0;
            }
        }

        public void GoToNewDir()
        {
            mainForm.PathBox.Text = mainForm.path;
            fileList.RefressFileListView();
        }

        public void GoBack()
        {
            try
            {
                FileSystemData.currentDirectory = Directory.GetParent(mainForm.path);
                mainForm.path = FileSystemData.currentDirectory.FullName;
                GoToNewDir();
            }
            catch (NullReferenceException)
            {

            }
        }

    }
}
