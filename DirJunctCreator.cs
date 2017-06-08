using System;
using System.IO;
using System.Windows.Forms;
using Monitor.Core.Utilities;

namespace KSPDirectoryJunctionCreator
{
    public partial class DirectoryJunctionCreator : Form
    {
        public DirectoryJunctionCreator()
        {
            InitializeComponent();

            string tempPath = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\KSP Craft Files";

            if (Properties.Settings.Default.VABPath.Equals(null) || Properties.Settings.Default.VABPath.Length == 0)
                Properties.Settings.Default.VABPath = tempPath + "\\VAB";

            if (Properties.Settings.Default.SPHPath.Equals(null) || Properties.Settings.Default.SPHPath.Length == 0)
                Properties.Settings.Default.SPHPath = tempPath + "\\SPH";

            if (Properties.Settings.Default.SubsPath.Equals(null)|| Properties.Settings.Default.SubsPath.Length == 0)
                Properties.Settings.Default.SubsPath = tempPath + "\\Subassemblies";

            if (Properties.Settings.Default.KSPPath.Equals(null) || Properties.Settings.Default.KSPPath.Length == 0)
            {
                tempPath = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Steam\\steamapps\\common\\Kerbal Space Program";
                if (!Directory.Exists(tempPath))
                {
                    tempPath = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Kerbal Space Program";
                }
                Properties.Settings.Default.KSPPath = tempPath;
            }

            Properties.Settings.Default.Save();
        }

        private void BrowseTargetPath_Click(object sender, EventArgs e)
        {
            TargetPath.Text = GetPath(TargetPath.Text, false, "Select the installation folder for Kerbal Space Program.");
            Properties.Settings.Default.Save();
        }

        private void BrowseVABPath_Click(object sender, EventArgs e)
        {
            VABPath.Text = GetPath(VABPath.Text, true, "Select the path where VAB craft will be stored.");
            Properties.Settings.Default.Save();
        }

        private void BrowseSPHPath_Click(object sender, EventArgs e)
        {
            SPHPath.Text = GetPath(SPHPath.Text, true, "Select the path where SPH craft will be stored.");
            Properties.Settings.Default.Save();
        }

        private void BrowseSubsPath_Click(object sender, EventArgs e)
        {
            SubsPath.Text = GetPath(SubsPath.Text, true, "Select the path where Subassemblies will be stored.");
            Properties.Settings.Default.Save();
        }

        private void CreateVABLinks_Click(object sender, EventArgs e)
        {
            DirectoryInfo target = new DirectoryInfo(VABPath.Text);
            CreateDirectoryJunction(target, "\\Ships\\VAB");
        }

        private void CreateSPHLinks_Click(object sender, EventArgs e)
        {
            DirectoryInfo target = new DirectoryInfo(SPHPath.Text);
            CreateDirectoryJunction(target, "\\Ships\\SPH");
        }

        private void CreateSubsLinks_Click(object sender, EventArgs e)
        {
            DirectoryInfo target = new DirectoryInfo(SubsPath.Text);
            CreateDirectoryJunction(target, "\\Subassemblies");
        }

        string GetPath(string startPath, bool allowCreate, string message)
        {
            folderBrowserDialog.ShowNewFolderButton = allowCreate;
            folderBrowserDialog.SelectedPath = startPath;
            folderBrowserDialog.Description = message;
            folderBrowserDialog.ShowDialog();
            return folderBrowserDialog.SelectedPath;
        }

        private void CreateDirectoryJunction(DirectoryInfo target, string subfolder)
        {
            int tasks = 0;
            DirectoryInfo link = new DirectoryInfo(TargetPath.Text + "\\saves");

            if (!target.Exists)
            {
                target.Create();
                InfoBox.AppendText("Creating Target Folder: {0}\r\n" + target.FullName + Environment.NewLine);
                tasks++;
            }

            foreach (DirectoryInfo SaveGame in link.GetDirectories())
            {
                if (SaveGame.Name == "training" || SaveGame.Name == "scenarios")
                    continue;

                if (!Directory.Exists(SaveGame.FullName + subfolder))
                {
                    InfoBox.AppendText(String.Format("Creating Directory Junction: {0} <<===> {1}\r\n", SaveGame.FullName + subfolder, target.FullName));
                    JunctionPoint.Create(SaveGame.FullName + subfolder, target.FullName, false);
                    tasks++;
                }
            }
            InfoBox.AppendText(String.Format("Completed {0} Tasks\r\n", tasks));
        }

        private void DirectoryJunctionCreator_Load(object sender, EventArgs e)
        {
            InfoBox.AppendText(String.Format("Directory Junction Creator v{0}\r\n", Application.ProductVersion));
        }
    }
}
