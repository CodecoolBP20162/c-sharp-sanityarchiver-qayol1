using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace SanityArchiver
{
    public class Zip
    {
        public static void CompressFile(FileInfo fileToArchive)
        {
            try
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
            catch
            {
                MessageBox.Show("You have no acces to this file.", "Acces denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void DecompressFile(FileInfo fileToDecompress)
        {
            FileStream originalFileStream = fileToDecompress.OpenRead();
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

    }
}
