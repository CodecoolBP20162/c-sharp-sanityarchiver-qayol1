using System;
using System.Windows.Forms;

namespace SanityArchiver
{
    class ContextMenuHandler
    {
        private MainForm mainForm;

        public ContextMenuHandler(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void HandleMenu(ListViewItem SelectedItem, MouseEventArgs e)
        {
            if (mainForm.Paste)
            {
                mainForm.ContextMenuStrip.Items[2].Enabled = true;
            }
            else
            {
                mainForm.ContextMenuStrip.Items[2].Enabled = false;
            }
            // set txt file right click menu
            if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("text/plain"))
            {
                int[] flags = { 0, 1, 2, 3, 5, 6, 9 };
                SetVisibility(flags);
            }
            // set zipped file right click menu
            else if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("gz"))
            {
                int[] flags = { 0, 1, 2, 4, 6, 9 };
                SetVisibility(flags);
            }
            // set directory right click menu
            else if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("File folder"))
            {
                int[] flags = { 2, 8 };
                SetVisibility(flags);
            }
            // set crypt file right click menu
            else if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[2].Text.Equals("crypt"))
            {
                int[] flags = { 0, 1, 2, 3, 5, 7, 9 };
                SetVisibility(flags);
            }
            else if (SelectedItem.Bounds.Contains(e.Location) == true && SelectedItem.SubItems[1].Equals(""))
            {
                //empty line has no menu
            }
            // set remained files right click menu
            else
            {
                int[] flags = { 0, 1, 2, 3, 6, 9 };
                SetVisibility(flags);
            }
        }

        private void SetVisibility(int[] flags)
        {
            mainForm.ContextMenuStrip.Show(Cursor.Position);
            for (int i = 0; i < mainForm.ContextMenuStrip.Items.Count; i++)
            {
                if (Array.IndexOf(flags, i) > -1)
                {
                    mainForm.ContextMenuStrip.Items[i].Visible = true;
                }
                else
                {
                    mainForm.ContextMenuStrip.Items[i].Visible = false;
                }
            }
        }
    }
}
