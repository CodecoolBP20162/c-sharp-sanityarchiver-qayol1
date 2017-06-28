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
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, FileName))
                    {
                        FileText.Items.Add(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
