using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class FileMenu : Form
    {

        public String file;

        public FileMenu()
        {
            InitializeComponent();
        }

        private void FileMenu_Load(object sender, EventArgs e)
        {
            label1.Text = file;
        }
    }
}
