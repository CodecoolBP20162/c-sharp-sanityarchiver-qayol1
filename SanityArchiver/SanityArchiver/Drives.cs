using System.IO;

namespace SanityArchiver
{
    public class Drives
    {

        private MainForm mainForm;
        private FileList fileList;

        public Drives(MainForm mainForm, FileList fileList)
        {
            this.mainForm = mainForm;
            this.fileList = fileList;
        }

        public void ShowDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                mainForm.DriversComboBox.Items.Add(d.Name);
            }
        }

        public void SelectDrive()
        {
            string selected = mainForm.DriversComboBox.GetItemText(mainForm.DriversComboBox.SelectedItem);
            mainForm.path = selected;
            FileSystemData.FillData(mainForm.path);
            fileList.ShowData();
        }
    }
}
