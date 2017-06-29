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
    public partial class FileMenu : Form
    {
        public String FullFileName;
        private FileInfo file;
        bool isReadOnly;
        bool isHidden;
        bool isArchive;
        bool isSystem;

        public FileMenu()
        {
            InitializeComponent();
        }

        private void FileMenu_Load(object sender, EventArgs e)
        {
            PathTextBox.Text = FullFileName;
            file = new FileInfo(FullFileName);
            isReadOnly = ((File.GetAttributes(FullFileName) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly);
            isHidden = ((File.GetAttributes(FullFileName) & FileAttributes.Hidden) == FileAttributes.Hidden);
            isArchive = ((File.GetAttributes(FullFileName) & FileAttributes.Archive) == FileAttributes.Archive);
            isSystem = ((File.GetAttributes(FullFileName) & FileAttributes.System) == FileAttributes.System);
            SetCheckBoxes();

        }

        private void SetCheckBoxes()
        {
            if (isReadOnly)
            {
                ReadOnly.Checked = true;
            }
            if (isHidden)
            {
                Hidden.Checked = true;
            }
            if (isArchive)
            {
                Archive.Checked = true;
            }
            if (isSystem)
            {
                System.Checked = true;
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReadOnly.Checked)
                {
                    file.IsReadOnly = true;
                }
                else
                {
                    file.IsReadOnly = false;
                }
                if (Hidden.Checked)
                {
                    File.SetAttributes(FullFileName, File.GetAttributes(FullFileName) | FileAttributes.Hidden);
                }
                else
                {
                    File.SetAttributes(FullFileName, File.GetAttributes(FullFileName) & ~FileAttributes.Hidden);
                }
                if (Archive.Checked)
                {
                    File.SetAttributes(FullFileName, File.GetAttributes(FullFileName) | FileAttributes.Archive);
                }
                else
                {
                    File.SetAttributes(FullFileName, File.GetAttributes(FullFileName) & ~FileAttributes.Archive);
                }
                if (System.Checked)
                {
                    File.SetAttributes(FullFileName, File.GetAttributes(FullFileName) | FileAttributes.System);
                }
                else
                {
                    File.SetAttributes(FullFileName, File.GetAttributes(FullFileName) & ~FileAttributes.System);
                }
            } catch
            {
                MessageBox.Show("Can't change the file's attributes.", "Acces denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Close();
        }

    }
}
