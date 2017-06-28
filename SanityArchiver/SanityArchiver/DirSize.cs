using System.IO;

namespace SanityArchiver
{
    public class DirSize
    {
        public static long GetSize(DirectoryInfo d)
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

    }
}
