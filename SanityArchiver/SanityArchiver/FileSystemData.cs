using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public class FileSystemData
    {
        public static List<FileInfo> FileList = new List<FileInfo>();
        public static List<DirectoryInfo> DirList = new List<DirectoryInfo>();
        public static DirectoryInfo currentDirectory;

        public static void FillData(String path)
        {
            currentDirectory = new DirectoryInfo(path);
            AddFiles();
            AddDirectories();
        }

        private static void AddFiles()
        {
            FileList.Clear();
            try
            {
                foreach (FileInfo fil in currentDirectory.GetFiles())
                {
                    FileList.Add(fil);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You have no acces to the files of this directory.", "Acces denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (IOException)
            {

            }
        }


        private static void AddDirectories()
        {
            DirList.Clear();
            try
            {
                foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
                {
                    DirList.Add(dir);
                }
            }
            catch (UnauthorizedAccessException)
            {

            }
            catch (IOException)
            {

            }
        }


    }
}
