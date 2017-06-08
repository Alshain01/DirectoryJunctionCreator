using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Monitor.Core.Utilities;

namespace KSPDirectoryJunctionCreator
{
    public partial class DirectoryJunctionCreator : Form
    {
        public DirectoryJunctionCreator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\KSP Craft Files";
            VABPath.Text = path + "\\VAB";
            SPHPath.Text = path + "\\SPH";
            SubsPath.Text = path + "\\Subassemblies";

            string installPath = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Steam\\steamapps\\common\\Kerbal Space Program";
            if (!Directory.Exists(installPath))
            {
                installPath = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Kerbal Space Program";
            }
            TargetPath.Text = installPath;
        }

        private void BrowseTargetPath_Click(object sender, EventArgs e)
        {
            TargetPath.Text = GetPath(TargetPath.Text, false, "Select the installation folder for Kerbal Space Program.");
        }

        private void BrowseVABPath_Click(object sender, EventArgs e)
        {
            VABPath.Text = GetPath(VABPath.Text, true, "Select the path where VAB craft will be stored.");
        }

        private void BrowseSPHPath_Click(object sender, EventArgs e)
        {
            SPHPath.Text = GetPath(SPHPath.Text, true, "Select the path where SPH craft will be stored.");
        }

        private void BrowseSubsPath_Click(object sender, EventArgs e)
        {
            SubsPath.Text = GetPath(SubsPath.Text, true, "Select the path where Subassemblies will be stored.");
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
            DirectoryInfo link = new DirectoryInfo(TargetPath.Text + "\\saves");

            if (!target.Exists)
                target.Create();

            foreach (DirectoryInfo SaveGame in link.GetDirectories())
            {
                if (SaveGame.Name == "training" || SaveGame.Name == "scenarios")
                    continue;

                if (!Directory.Exists(SaveGame.FullName + subfolder))
                    JunctionPoint.Create(SaveGame.FullName + subfolder, target.FullName, false);
            }
        }
    }
}
