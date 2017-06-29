using System;
using System.IO;

namespace SanityArchiver
{
    class FileSystemHandler
    {
        private MainForm mainForm;
        private FileList fileList;

        public FileSystemHandler(MainForm mainForm, FileList fileList)
        {
            this.mainForm = mainForm;
            this.fileList = fileList;
        }

        public void CopyMoveFile(String FileToCopy)
        {
            if (!FileToCopy.Equals(""))
            {
                try
                {

                    string[] FileParts = FileToCopy.Split('\\');
                    String FileName = FileParts[FileParts.Length - 1];
                    string destFile = Path.Combine(mainForm.PathBox.Text, FileName);
                    if (mainForm.Cut)
                    {
                        mainForm.Cut = false;
                        File.Move(FileToCopy, destFile);
                    }
                    else
                    {
                        File.Copy(FileToCopy, destFile, true);
                    }
                }
                catch
                {

                }
                finally
                {
                    mainForm.Paste = false;
                    FileToCopy = "";
                    fileList.RefressFileListView();
                }
            }
        }
    }
}
