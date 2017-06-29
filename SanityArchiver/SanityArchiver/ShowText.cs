using System;
using System.IO;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class ShowText : Form
    {

        public String FileName;
        public int action;

        public ShowText()
        {
            InitializeComponent();
        }

        private void ShowText_Load(object sender, EventArgs e)
        {
            if (action == 1)
            {
                FileText.Items.Clear();
                string[] lines = File.ReadAllLines(FileName);
                foreach (string line in lines)
                {
                    FileText.Items.Add(line);
                }
                action = 0;
            }
            if (action == 2)
            {
                FileText.Items.Clear();
                DirSearch("c:/");
                action = 0;
            }
       }

        void DirSearch(string sDir)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(sDir))
                {
                    foreach (string file in Directory.GetFiles(dir, FileName))
                    {
                        FileText.Items.Add(file);
                    }
                    DirSearch(dir);
                }
            }
            catch
            {
               
            }
        }
    }
}
