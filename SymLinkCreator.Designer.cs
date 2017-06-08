namespace KSPDirectoryJunctionCreator
{
    partial class DirectoryJunctionCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryJunctionCreator));
            this.TargetPath = new System.Windows.Forms.TextBox();
            this.VABPath = new System.Windows.Forms.TextBox();
            this.SubsPath = new System.Windows.Forms.TextBox();
            this.SPHPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseTargetPath = new System.Windows.Forms.Button();
            this.BrowseVABPath = new System.Windows.Forms.Button();
            this.CreateVABLinks = new System.Windows.Forms.Button();
            this.CreateSPHLinks = new System.Windows.Forms.Button();
            this.BrowseSPHPath = new System.Windows.Forms.Button();
            this.CreateSubsLinks = new System.Windows.Forms.Button();
            this.BrowseSubsPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TargetPath
            // 
            this.TargetPath.Location = new System.Drawing.Point(15, 25);
            this.TargetPath.Name = "TargetPath";
            this.TargetPath.ReadOnly = true;
            this.TargetPath.Size = new System.Drawing.Size(559, 20);
            this.TargetPath.TabIndex = 0;
            // 
            // VABPath
            // 
            this.VABPath.Location = new System.Drawing.Point(12, 75);
            this.VABPath.Name = "VABPath";
            this.VABPath.ReadOnly = true;
            this.VABPath.Size = new System.Drawing.Size(562, 20);
            this.VABPath.TabIndex = 1;
            // 
            // SubsPath
            // 
            this.SubsPath.Location = new System.Drawing.Point(12, 153);
            this.SubsPath.Name = "SubsPath";
            this.SubsPath.ReadOnly = true;
            this.SubsPath.Size = new System.Drawing.Size(562, 20);
            this.SubsPath.TabIndex = 2;
            // 
            // SPHPath
            // 
            this.SPHPath.Location = new System.Drawing.Point(12, 114);
            this.SPHPath.Name = "SPHPath";
            this.SPHPath.ReadOnly = true;
            this.SPHPath.Size = new System.Drawing.Size(562, 20);
            this.SPHPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kerbal Space Program Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vehicle Assembly Building Craft Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spaceplane Hangar Craft Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subassemblies Path";
            // 
            // BrowseTargetPath
            // 
            this.BrowseTargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseTargetPath.Image = ((System.Drawing.Image)(resources.GetObject("BrowseTargetPath.Image")));
            this.BrowseTargetPath.Location = new System.Drawing.Point(580, 18);
            this.BrowseTargetPath.Name = "BrowseTargetPath";
            this.BrowseTargetPath.Size = new System.Drawing.Size(33, 33);
            this.BrowseTargetPath.TabIndex = 5;
            this.BrowseTargetPath.UseVisualStyleBackColor = true;
            this.BrowseTargetPath.Click += new System.EventHandler(this.BrowseTargetPath_Click);
            // 
            // BrowseVABPath
            // 
            this.BrowseVABPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseVABPath.Image = ((System.Drawing.Image)(resources.GetObject("BrowseVABPath.Image")));
            this.BrowseVABPath.Location = new System.Drawing.Point(580, 68);
            this.BrowseVABPath.Name = "BrowseVABPath";
            this.BrowseVABPath.Size = new System.Drawing.Size(33, 33);
            this.BrowseVABPath.TabIndex = 10;
            this.BrowseVABPath.UseVisualStyleBackColor = true;
            this.BrowseVABPath.Click += new System.EventHandler(this.BrowseVABPath_Click);
            // 
            // CreateVABLinks
            // 
            this.CreateVABLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateVABLinks.Image = ((System.Drawing.Image)(resources.GetObject("CreateVABLinks.Image")));
            this.CreateVABLinks.Location = new System.Drawing.Point(619, 68);
            this.CreateVABLinks.Name = "CreateVABLinks";
            this.CreateVABLinks.Size = new System.Drawing.Size(33, 33);
            this.CreateVABLinks.TabIndex = 11;
            this.CreateVABLinks.UseVisualStyleBackColor = true;
            this.CreateVABLinks.Click += new System.EventHandler(this.CreateVABLinks_Click);
            // 
            // CreateSPHLinks
            // 
            this.CreateSPHLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateSPHLinks.Image = ((System.Drawing.Image)(resources.GetObject("CreateSPHLinks.Image")));
            this.CreateSPHLinks.Location = new System.Drawing.Point(619, 107);
            this.CreateSPHLinks.Name = "CreateSPHLinks";
            this.CreateSPHLinks.Size = new System.Drawing.Size(33, 33);
            this.CreateSPHLinks.TabIndex = 13;
            this.CreateSPHLinks.UseVisualStyleBackColor = true;
            this.CreateSPHLinks.Click += new System.EventHandler(this.CreateSPHLinks_Click);
            // 
            // BrowseSPHPath
            // 
            this.BrowseSPHPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseSPHPath.Image = ((System.Drawing.Image)(resources.GetObject("BrowseSPHPath.Image")));
            this.BrowseSPHPath.Location = new System.Drawing.Point(580, 107);
            this.BrowseSPHPath.Name = "BrowseSPHPath";
            this.BrowseSPHPath.Size = new System.Drawing.Size(33, 33);
            this.BrowseSPHPath.TabIndex = 12;
            this.BrowseSPHPath.UseVisualStyleBackColor = true;
            this.BrowseSPHPath.Click += new System.EventHandler(this.BrowseSPHPath_Click);
            // 
            // CreateSubsLinks
            // 
            this.CreateSubsLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateSubsLinks.Image = ((System.Drawing.Image)(resources.GetObject("CreateSubsLinks.Image")));
            this.CreateSubsLinks.Location = new System.Drawing.Point(619, 146);
            this.CreateSubsLinks.Name = "CreateSubsLinks";
            this.CreateSubsLinks.Size = new System.Drawing.Size(33, 33);
            this.CreateSubsLinks.TabIndex = 15;
            this.CreateSubsLinks.UseVisualStyleBackColor = true;
            this.CreateSubsLinks.Click += new System.EventHandler(this.CreateSubsLinks_Click);
            // 
            // BrowseSubsPath
            // 
            this.BrowseSubsPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseSubsPath.Image = ((System.Drawing.Image)(resources.GetObject("BrowseSubsPath.Image")));
            this.BrowseSubsPath.Location = new System.Drawing.Point(580, 146);
            this.BrowseSubsPath.Name = "BrowseSubsPath";
            this.BrowseSubsPath.Size = new System.Drawing.Size(33, 33);
            this.BrowseSubsPath.TabIndex = 14;
            this.BrowseSubsPath.UseVisualStyleBackColor = true;
            this.BrowseSubsPath.Click += new System.EventHandler(this.BrowseSubsPath_Click);
            // 
            // DirectoryJunctionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 192);
            this.Controls.Add(this.CreateSubsLinks);
            this.Controls.Add(this.BrowseSubsPath);
            this.Controls.Add(this.CreateSPHLinks);
            this.Controls.Add(this.BrowseSPHPath);
            this.Controls.Add(this.CreateVABLinks);
            this.Controls.Add(this.BrowseVABPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrowseTargetPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SPHPath);
            this.Controls.Add(this.SubsPath);
            this.Controls.Add(this.VABPath);
            this.Controls.Add(this.TargetPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectoryJunctionCreator";
            this.Text = "KSP Directory Junction Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TargetPath;
        private System.Windows.Forms.TextBox VABPath;
        private System.Windows.Forms.TextBox SubsPath;
        private System.Windows.Forms.TextBox SPHPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button BrowseTargetPath;
        private System.Windows.Forms.Button BrowseVABPath;
        private System.Windows.Forms.Button CreateVABLinks;
        private System.Windows.Forms.Button CreateSPHLinks;
        private System.Windows.Forms.Button BrowseSPHPath;
        private System.Windows.Forms.Button CreateSubsLinks;
        private System.Windows.Forms.Button BrowseSubsPath;
    }
}

