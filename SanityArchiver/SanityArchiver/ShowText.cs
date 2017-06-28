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
    public partial class ShowText : Form
    {

        public String FullFileName;

        public ShowText()
        {
            InitializeComponent();
        }

        private void ShowText_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(FullFileName);
            foreach (string line in lines)
            {
                FileText.Items.Add(line);
            }

        }
    }
}
