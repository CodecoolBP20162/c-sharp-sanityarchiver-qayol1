using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityArchiver
{
    public class ByteConverter
    {
        public static string ConvertBytes(double FileLength)
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
    }
}
