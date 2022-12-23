
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace BiosInfoTool
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Bios = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.learnMoreBiosLabel = new MaterialSkin.Controls.MaterialLabel();
            this.biosLabel = new MaterialSkin.Controls.MaterialLabel();
            this.listBIOS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPU = new System.Windows.Forms.TabPage();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.listCPU = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.GPU = new System.Windows.Forms.TabPage();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.listGPU = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.Save = new System.Windows.Forms.TabPage();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Help = new System.Windows.Forms.TabPage();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialLabel51 = new MaterialSkin.Controls.MaterialLabel();
            this.materialExpansionPanel2 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialExpansionPanel3 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialExpansionPanel4 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialExpansionPanel5 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.Settings = new System.Windows.Forms.TabPage();
            this.materialSwitch6 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch5 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch9 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch4 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitch8 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.MaterialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.GitHub = new System.Windows.Forms.TabPage();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.Bios.SuspendLayout();
            this.CPU.SuspendLayout();
            this.GPU.SuspendLayout();
            this.Save.SuspendLayout();
            this.Help.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.materialExpansionPanel1.SuspendLayout();
            this.materialExpansionPanel2.SuspendLayout();
            this.materialExpansionPanel3.SuspendLayout();
            this.materialExpansionPanel4.SuspendLayout();
            this.materialExpansionPanel5.SuspendLayout();
            this.Settings.SuspendLayout();
            this.GitHub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-downloads-folder-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-electronics-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-github-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-home-page-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-question-mark-48.png");
            this.imageList1.Images.SetKeyName(5, "icons8-settings-48.png");
            this.imageList1.Images.SetKeyName(6, "icons8-bios-48.png");
            this.imageList1.Images.SetKeyName(7, "icons8-gpu-48.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Bios);
            this.materialTabControl1.Controls.Add(this.CPU);
            this.materialTabControl1.Controls.Add(this.GPU);
            this.materialTabControl1.Controls.Add(this.Save);
            this.materialTabControl1.Controls.Add(this.Help);
            this.materialTabControl1.Controls.Add(this.Settings);
            this.materialTabControl1.Controls.Add(this.GitHub);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 52);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(797, 578);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.ImageKey = "icons8-home-page-48.png";
            this.Home.Location = new System.Drawing.Point(4, 31);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(789, 543);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Bios
            // 
            this.Bios.Controls.Add(this.materialButton2);
            this.Bios.Controls.Add(this.learnMoreBiosLabel);
            this.Bios.Controls.Add(this.biosLabel);
            this.Bios.Controls.Add(this.listBIOS);
            this.Bios.ImageKey = "icons8-bios-48.png";
            this.Bios.Location = new System.Drawing.Point(4, 31);
            this.Bios.Margin = new System.Windows.Forms.Padding(2);
            this.Bios.Name = "Bios";
            this.Bios.Size = new System.Drawing.Size(789, 543);
            this.Bios.TabIndex = 1;
            this.Bios.Text = "BIOS";
            this.Bios.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(588, 521);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(146, 36);
            this.materialButton2.TabIndex = 82;
            this.materialButton2.Text = "Show WMI class";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // learnMoreBiosLabel
            // 
            this.learnMoreBiosLabel.AutoSize = true;
            this.learnMoreBiosLabel.Depth = 0;
            this.learnMoreBiosLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.learnMoreBiosLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.learnMoreBiosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.learnMoreBiosLabel.HighEmphasis = true;
            this.learnMoreBiosLabel.Location = new System.Drawing.Point(10, 530);
            this.learnMoreBiosLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.learnMoreBiosLabel.Name = "learnMoreBiosLabel";
            this.learnMoreBiosLabel.Size = new System.Drawing.Size(148, 17);
            this.learnMoreBiosLabel.TabIndex = 81;
            this.learnMoreBiosLabel.Text = "Learn more about BIOS";
            this.learnMoreBiosLabel.UseAccent = true;
            this.learnMoreBiosLabel.Click += new System.EventHandler(this.learnMoreBiosLabel_Click);
            // 
            // biosLabel
            // 
            this.biosLabel.AutoSize = true;
            this.biosLabel.Depth = 0;
            this.biosLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.biosLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.biosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.biosLabel.Location = new System.Drawing.Point(12, 6);
            this.biosLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.biosLabel.Name = "biosLabel";
            this.biosLabel.Size = new System.Drawing.Size(252, 29);
            this.biosLabel.TabIndex = 69;
            this.biosLabel.Text = "Information about BIOS";
            // 
            // listBIOS
            // 
            this.listBIOS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listBIOS.HideSelection = false;
            this.listBIOS.Location = new System.Drawing.Point(12, 41);
            this.listBIOS.Margin = new System.Windows.Forms.Padding(2);
            this.listBIOS.Name = "listBIOS";
            this.listBIOS.Size = new System.Drawing.Size(722, 473);
            this.listBIOS.TabIndex = 0;
            this.listBIOS.UseCompatibleStateImageBehavior = false;
            this.listBIOS.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Characteristic";
            this.columnHeader1.Width = 288;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 929;
            // 
            // CPU
            // 
            this.CPU.Controls.Add(this.materialButton3);
            this.CPU.Controls.Add(this.materialLabel5);
            this.CPU.Controls.Add(this.listCPU);
            this.CPU.Controls.Add(this.materialLabel4);
            this.CPU.ImageKey = "icons8-electronics-48.png";
            this.CPU.Location = new System.Drawing.Point(4, 31);
            this.CPU.Margin = new System.Windows.Forms.Padding(2);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(789, 543);
            this.CPU.TabIndex = 6;
            this.CPU.Text = "CPU";
            this.CPU.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(588, 521);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(146, 36);
            this.materialButton3.TabIndex = 84;
            this.materialButton3.Text = "Show WMI class";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.Location = new System.Drawing.Point(10, 530);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(144, 17);
            this.materialLabel5.TabIndex = 83;
            this.materialLabel5.Text = "Learn more about CPU";
            this.materialLabel5.UseAccent = true;
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // listCPU
            // 
            this.listCPU.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listCPU.HideSelection = false;
            this.listCPU.Location = new System.Drawing.Point(12, 41);
            this.listCPU.Margin = new System.Windows.Forms.Padding(2);
            this.listCPU.Name = "listCPU";
            this.listCPU.Size = new System.Drawing.Size(722, 473);
            this.listCPU.TabIndex = 71;
            this.listCPU.UseCompatibleStateImageBehavior = false;
            this.listCPU.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Characteristic";
            this.columnHeader3.Width = 288;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 929;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 6);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(246, 29);
            this.materialLabel4.TabIndex = 70;
            this.materialLabel4.Text = "Information about CPU";
            // 
            // GPU
            // 
            this.GPU.Controls.Add(this.materialButton5);
            this.GPU.Controls.Add(this.materialLabel6);
            this.GPU.Controls.Add(this.listGPU);
            this.GPU.Controls.Add(this.materialLabel7);
            this.GPU.ImageKey = "icons8-gpu-48.png";
            this.GPU.Location = new System.Drawing.Point(4, 31);
            this.GPU.Margin = new System.Windows.Forms.Padding(2);
            this.GPU.Name = "GPU";
            this.GPU.Size = new System.Drawing.Size(789, 543);
            this.GPU.TabIndex = 7;
            this.GPU.Text = "GPU";
            this.GPU.UseVisualStyleBackColor = true;
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(586, 520);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(146, 36);
            this.materialButton5.TabIndex = 88;
            this.materialButton5.Text = "Show WMI class";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(8, 529);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(145, 17);
            this.materialLabel6.TabIndex = 87;
            this.materialLabel6.Text = "Learn more about GPU";
            this.materialLabel6.UseAccent = true;
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // listGPU
            // 
            this.listGPU.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listGPU.HideSelection = false;
            this.listGPU.Location = new System.Drawing.Point(10, 41);
            this.listGPU.Margin = new System.Windows.Forms.Padding(2);
            this.listGPU.Name = "listGPU";
            this.listGPU.Size = new System.Drawing.Size(722, 473);
            this.listGPU.TabIndex = 86;
            this.listGPU.UseCompatibleStateImageBehavior = false;
            this.listGPU.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Characteristic";
            this.columnHeader5.Width = 288;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 929;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(10, 6);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(246, 29);
            this.materialLabel7.TabIndex = 85;
            this.materialLabel7.Text = "Information about GPU";
            // 
            // Save
            // 
            this.Save.Controls.Add(this.pictureBox2);
            this.Save.Controls.Add(this.materialLabel14);
            this.Save.Controls.Add(this.materialButton8);
            this.Save.Controls.Add(this.materialButton6);
            this.Save.Controls.Add(this.materialLabel8);
            this.Save.Controls.Add(this.materialButton1);
            this.Save.ImageKey = "icons8-downloads-folder-48.png";
            this.Save.Location = new System.Drawing.Point(4, 31);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(789, 543);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save to file";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // materialLabel14
            // 
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(17, 67);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(711, 64);
            this.materialLabel14.TabIndex = 90;
            this.materialLabel14.Text = resources.GetString("materialLabel14.Text");
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton8.Depth = 0;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = null;
            this.materialButton8.Location = new System.Drawing.Point(20, 345);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton8.Size = new System.Drawing.Size(182, 36);
            this.materialButton8.TabIndex = 88;
            this.materialButton8.Text = "Save gpu info to file";
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = false;
            this.materialButton8.UseVisualStyleBackColor = true;
            this.materialButton8.Click += new System.EventHandler(this.materialButton8_Click);
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(20, 275);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(182, 36);
            this.materialButton6.TabIndex = 87;
            this.materialButton6.Text = "Save CPU info to file";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(15, 11);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(150, 29);
            this.materialLabel8.TabIndex = 86;
            this.materialLabel8.Text = "Saving results";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(20, 201);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(186, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Save bios info to file";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Help
            // 
            this.Help.Controls.Add(this.materialButton9);
            this.Help.Controls.Add(this.materialLabel11);
            this.Help.Controls.Add(this.materialLabel10);
            this.Help.Controls.Add(this.flowLayoutPanel1);
            this.Help.ImageKey = "icons8-question-mark-48.png";
            this.Help.Location = new System.Drawing.Point(4, 31);
            this.Help.Margin = new System.Windows.Forms.Padding(2);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(789, 543);
            this.Help.TabIndex = 3;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(581, 502);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(150, 36);
            this.materialButton9.TabIndex = 88;
            this.materialButton9.Text = "WATCH THE VIDEO";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // materialLabel11
            // 
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(20, 55);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(711, 64);
            this.materialLabel11.TabIndex = 0;
            this.materialLabel11.Text = resources.GetString("materialLabel11.Text");
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(18, 14);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(50, 29);
            this.materialLabel10.TabIndex = 87;
            this.materialLabel10.Text = "Help";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.materialExpansionPanel1);
            this.flowLayoutPanel1.Controls.Add(this.materialExpansionPanel2);
            this.flowLayoutPanel1.Controls.Add(this.materialExpansionPanel3);
            this.flowLayoutPanel1.Controls.Add(this.materialExpansionPanel4);
            this.flowLayoutPanel1.Controls.Add(this.materialExpansionPanel5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 340);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.CancelButtonText = "";
            this.materialExpansionPanel1.CausesValidation = false;
            this.materialExpansionPanel1.Collapse = true;
            this.materialExpansionPanel1.Controls.Add(this.materialLabel51);
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Description = "Get started";
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(12, 1);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(12, 1, 12, 0);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(18, 52, 18, 13);
            this.materialExpansionPanel1.Size = new System.Drawing.Size(716, 48);
            this.materialExpansionPanel1.TabIndex = 0;
            this.materialExpansionPanel1.Title = "User instructions";
            this.materialExpansionPanel1.ValidationButtonEnable = true;
            this.materialExpansionPanel1.ValidationButtonText = "OK";
            // 
            // materialLabel51
            // 
            this.materialLabel51.Depth = 0;
            this.materialLabel51.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel51.Location = new System.Drawing.Point(28, 68);
            this.materialLabel51.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel51.Name = "materialLabel51";
            this.materialLabel51.Size = new System.Drawing.Size(675, 64);
            this.materialLabel51.TabIndex = 2;
            this.materialLabel51.Text = resources.GetString("materialLabel51.Text");
            // 
            // materialExpansionPanel2
            // 
            this.materialExpansionPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel2.CancelButtonText = "";
            this.materialExpansionPanel2.CausesValidation = false;
            this.materialExpansionPanel2.Collapse = true;
            this.materialExpansionPanel2.Controls.Add(this.materialLabel1);
            this.materialExpansionPanel2.Depth = 0;
            this.materialExpansionPanel2.Description = "Basic Input/Output System";
            this.materialExpansionPanel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel2.Location = new System.Drawing.Point(12, 50);
            this.materialExpansionPanel2.Margin = new System.Windows.Forms.Padding(12, 1, 12, 0);
            this.materialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel2.Name = "materialExpansionPanel2";
            this.materialExpansionPanel2.Padding = new System.Windows.Forms.Padding(18, 52, 18, 13);
            this.materialExpansionPanel2.Size = new System.Drawing.Size(716, 48);
            this.materialExpansionPanel2.TabIndex = 1;
            this.materialExpansionPanel2.Title = "BIOS";
            this.materialExpansionPanel2.ValidationButtonEnable = true;
            this.materialExpansionPanel2.ValidationButtonText = "OK";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 68);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(675, 81);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = resources.GetString("materialLabel1.Text");
            // 
            // materialExpansionPanel3
            // 
            this.materialExpansionPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel3.CancelButtonText = "";
            this.materialExpansionPanel3.CausesValidation = false;
            this.materialExpansionPanel3.Collapse = true;
            this.materialExpansionPanel3.Controls.Add(this.materialLabel2);
            this.materialExpansionPanel3.Depth = 0;
            this.materialExpansionPanel3.Description = "Central Processing Unit";
            this.materialExpansionPanel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel3.Location = new System.Drawing.Point(12, 99);
            this.materialExpansionPanel3.Margin = new System.Windows.Forms.Padding(12, 1, 12, 0);
            this.materialExpansionPanel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel3.Name = "materialExpansionPanel3";
            this.materialExpansionPanel3.Padding = new System.Windows.Forms.Padding(18, 52, 18, 13);
            this.materialExpansionPanel3.Size = new System.Drawing.Size(716, 48);
            this.materialExpansionPanel3.TabIndex = 2;
            this.materialExpansionPanel3.Title = "CPU";
            this.materialExpansionPanel3.ValidationButtonEnable = true;
            this.materialExpansionPanel3.ValidationButtonText = "OK";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 68);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(668, 81);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = resources.GetString("materialLabel2.Text");
            // 
            // materialExpansionPanel4
            // 
            this.materialExpansionPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel4.CancelButtonText = "";
            this.materialExpansionPanel4.CausesValidation = false;
            this.materialExpansionPanel4.Collapse = true;
            this.materialExpansionPanel4.Controls.Add(this.materialLabel3);
            this.materialExpansionPanel4.Depth = 0;
            this.materialExpansionPanel4.Description = "Graphics Processing Unit";
            this.materialExpansionPanel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel4.Location = new System.Drawing.Point(12, 148);
            this.materialExpansionPanel4.Margin = new System.Windows.Forms.Padding(12, 1, 12, 1);
            this.materialExpansionPanel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel4.Name = "materialExpansionPanel4";
            this.materialExpansionPanel4.Padding = new System.Windows.Forms.Padding(18, 52, 18, 13);
            this.materialExpansionPanel4.Size = new System.Drawing.Size(716, 48);
            this.materialExpansionPanel4.TabIndex = 3;
            this.materialExpansionPanel4.Title = "GPU";
            this.materialExpansionPanel4.ValidationButtonEnable = true;
            this.materialExpansionPanel4.ValidationButtonText = "OK";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(28, 68);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(675, 81);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = resources.GetString("materialLabel3.Text");
            // 
            // materialExpansionPanel5
            // 
            this.materialExpansionPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel5.CancelButtonText = "";
            this.materialExpansionPanel5.CausesValidation = false;
            this.materialExpansionPanel5.Collapse = true;
            this.materialExpansionPanel5.Controls.Add(this.materialLabel9);
            this.materialExpansionPanel5.Depth = 0;
            this.materialExpansionPanel5.Description = "Information about program";
            this.materialExpansionPanel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel5.Location = new System.Drawing.Point(12, 197);
            this.materialExpansionPanel5.Margin = new System.Windows.Forms.Padding(12, 0, 12, 13);
            this.materialExpansionPanel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel5.Name = "materialExpansionPanel5";
            this.materialExpansionPanel5.Padding = new System.Windows.Forms.Padding(18, 52, 18, 13);
            this.materialExpansionPanel5.Size = new System.Drawing.Size(716, 48);
            this.materialExpansionPanel5.TabIndex = 4;
            this.materialExpansionPanel5.Title = "About";
            this.materialExpansionPanel5.ValidationButtonEnable = true;
            this.materialExpansionPanel5.ValidationButtonText = "OK";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(28, 68);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(675, 81);
            this.materialLabel9.TabIndex = 2;
            this.materialLabel9.Text = resources.GetString("materialLabel9.Text");
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.materialSwitch6);
            this.Settings.Controls.Add(this.materialSwitch5);
            this.Settings.Controls.Add(this.materialSwitch9);
            this.Settings.Controls.Add(this.materialSwitch4);
            this.Settings.Controls.Add(this.materialLabel12);
            this.Settings.Controls.Add(this.materialLabel13);
            this.Settings.Controls.Add(this.materialSwitch8);
            this.Settings.Controls.Add(this.materialButton7);
            this.Settings.Controls.Add(this.MaterialButton4);
            this.Settings.ImageKey = "icons8-settings-48.png";
            this.Settings.Location = new System.Drawing.Point(4, 31);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(789, 543);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // materialSwitch6
            // 
            this.materialSwitch6.AutoSize = true;
            this.materialSwitch6.Depth = 0;
            this.materialSwitch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch6.Location = new System.Drawing.Point(33, 242);
            this.materialSwitch6.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch6.Name = "materialSwitch6";
            this.materialSwitch6.Ripple = true;
            this.materialSwitch6.Size = new System.Drawing.Size(291, 37);
            this.materialSwitch6.TabIndex = 93;
            this.materialSwitch6.Text = "Drawer - Background with Accent";
            this.materialSwitch6.UseVisualStyleBackColor = true;
            this.materialSwitch6.CheckedChanged += new System.EventHandler(this.materialSwitch6_CheckedChanged);
            // 
            // materialSwitch5
            // 
            this.materialSwitch5.AutoSize = true;
            this.materialSwitch5.Checked = true;
            this.materialSwitch5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch5.Depth = 0;
            this.materialSwitch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch5.Location = new System.Drawing.Point(33, 198);
            this.materialSwitch5.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch5.Name = "materialSwitch5";
            this.materialSwitch5.Ripple = true;
            this.materialSwitch5.Size = new System.Drawing.Size(270, 37);
            this.materialSwitch5.TabIndex = 92;
            this.materialSwitch5.Text = "Drawer - Highlight with Accent";
            this.materialSwitch5.UseVisualStyleBackColor = true;
            this.materialSwitch5.CheckedChanged += new System.EventHandler(this.materialSwitch5_CheckedChanged);
            // 
            // materialSwitch9
            // 
            this.materialSwitch9.AutoSize = true;
            this.materialSwitch9.Depth = 0;
            this.materialSwitch9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch9.Location = new System.Drawing.Point(33, 333);
            this.materialSwitch9.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch9.Name = "materialSwitch9";
            this.materialSwitch9.Ripple = true;
            this.materialSwitch9.Size = new System.Drawing.Size(195, 37);
            this.materialSwitch9.TabIndex = 90;
            this.materialSwitch9.Text = "Drawer - Auto show";
            this.materialSwitch9.UseVisualStyleBackColor = true;
            this.materialSwitch9.CheckedChanged += new System.EventHandler(this.materialSwitch9_CheckedChanged);
            // 
            // materialSwitch4
            // 
            this.materialSwitch4.AutoSize = true;
            this.materialSwitch4.Depth = 0;
            this.materialSwitch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch4.Location = new System.Drawing.Point(33, 152);
            this.materialSwitch4.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch4.Name = "materialSwitch4";
            this.materialSwitch4.Ripple = true;
            this.materialSwitch4.Size = new System.Drawing.Size(193, 37);
            this.materialSwitch4.TabIndex = 91;
            this.materialSwitch4.Text = "Drawer - Use colors";
            this.materialSwitch4.UseVisualStyleBackColor = true;
            this.materialSwitch4.CheckedChanged += new System.EventHandler(this.materialSwitch4_CheckedChanged);
            // 
            // materialLabel12
            // 
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(30, 64);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(711, 64);
            this.materialLabel12.TabIndex = 88;
            this.materialLabel12.Text = resources.GetString("materialLabel12.Text");
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(28, 23);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(173, 29);
            this.materialLabel13.TabIndex = 89;
            this.materialLabel13.Text = "Change settings";
            // 
            // materialSwitch8
            // 
            this.materialSwitch8.AutoSize = true;
            this.materialSwitch8.Depth = 0;
            this.materialSwitch8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch8.Location = new System.Drawing.Point(33, 287);
            this.materialSwitch8.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch8.Name = "materialSwitch8";
            this.materialSwitch8.Ripple = true;
            this.materialSwitch8.Size = new System.Drawing.Size(309, 37);
            this.materialSwitch8.TabIndex = 29;
            this.materialSwitch8.Text = "Drawer - Display Icons when hidden";
            this.materialSwitch8.UseVisualStyleBackColor = true;
            this.materialSwitch8.CheckedChanged += new System.EventHandler(this.materialSwitch8_CheckedChanged);
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(200, 469);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Size = new System.Drawing.Size(133, 36);
            this.materialButton7.TabIndex = 24;
            this.materialButton7.Text = "Change Theme";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // MaterialButton4
            // 
            this.MaterialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MaterialButton4.Depth = 0;
            this.MaterialButton4.HighEmphasis = true;
            this.MaterialButton4.Icon = null;
            this.MaterialButton4.Location = new System.Drawing.Point(37, 469);
            this.MaterialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialButton4.Name = "MaterialButton4";
            this.MaterialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MaterialButton4.Size = new System.Drawing.Size(140, 36);
            this.MaterialButton4.TabIndex = 23;
            this.MaterialButton4.Text = "Change Colors";
            this.MaterialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MaterialButton4.UseAccentColor = false;
            this.MaterialButton4.UseVisualStyleBackColor = true;
            this.MaterialButton4.Click += new System.EventHandler(this.MaterialButton4_Click);
            // 
            // GitHub
            // 
            this.GitHub.Controls.Add(this.pictureBox3);
            this.GitHub.Controls.Add(this.materialButton10);
            this.GitHub.Controls.Add(this.materialLabel15);
            this.GitHub.Controls.Add(this.materialLabel16);
            this.GitHub.ImageKey = "icons8-github-48.png";
            this.GitHub.Location = new System.Drawing.Point(4, 31);
            this.GitHub.Margin = new System.Windows.Forms.Padding(2);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(789, 543);
            this.GitHub.TabIndex = 4;
            this.GitHub.Text = "GitHub";
            this.GitHub.UseVisualStyleBackColor = true;
            // 
            // materialButton10
            // 
            this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton10.Depth = 0;
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = null;
            this.materialButton10.Location = new System.Drawing.Point(618, 478);
            this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton10.Size = new System.Drawing.Size(120, 36);
            this.materialButton10.TabIndex = 92;
            this.materialButton10.Text = "GO TO GITHUB";
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = false;
            this.materialButton10.UseVisualStyleBackColor = true;
            this.materialButton10.Click += new System.EventHandler(this.materialButton10_Click);
            // 
            // materialLabel15
            // 
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(27, 70);
            this.materialLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(711, 64);
            this.materialLabel15.TabIndex = 90;
            this.materialLabel15.Text = resources.GetString("materialLabel15.Text");
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(25, 29);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(136, 29);
            this.materialLabel16.TabIndex = 91;
            this.materialLabel16.Text = "Source code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BiosInfoTool.Properties.Resources.img_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiosInfoTool.Properties.Resources.bios;
            this.pictureBox2.Location = new System.Drawing.Point(258, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(414, 281);
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 167);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(829, 267);
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 632);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(801, 632);
            this.MinimumSize = new System.Drawing.Size(801, 632);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiosInfoTool";
            this.materialTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.Bios.ResumeLayout(false);
            this.Bios.PerformLayout();
            this.CPU.ResumeLayout(false);
            this.CPU.PerformLayout();
            this.GPU.ResumeLayout(false);
            this.GPU.PerformLayout();
            this.Save.ResumeLayout(false);
            this.Save.PerformLayout();
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            this.materialExpansionPanel2.ResumeLayout(false);
            this.materialExpansionPanel2.PerformLayout();
            this.materialExpansionPanel3.ResumeLayout(false);
            this.materialExpansionPanel3.PerformLayout();
            this.materialExpansionPanel4.ResumeLayout(false);
            this.materialExpansionPanel4.PerformLayout();
            this.materialExpansionPanel5.ResumeLayout(false);
            this.materialExpansionPanel5.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.GitHub.ResumeLayout(false);
            this.GitHub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Bios;
        private System.Windows.Forms.TabPage Save;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.TabPage GitHub;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listBIOS;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel biosLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel51;
        private MaterialSkin.Controls.MaterialLabel learnMoreBiosLabel;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.TabPage CPU;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialExpansionPanel materialExpansionPanel4;
        private MaterialLabel materialLabel3;
        private MaterialExpansionPanel materialExpansionPanel3;
        private MaterialLabel materialLabel2;
        private MaterialExpansionPanel materialExpansionPanel2;
        private MaterialLabel materialLabel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialButton materialButton7;
        private MaterialButton MaterialButton4;
        private MaterialSwitch materialSwitch8;
        private MaterialButton materialButton3;
        private MaterialLabel materialLabel5;
        private ListView listCPU;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private MaterialLabel materialLabel4;
        private TabPage GPU;
        private MaterialButton materialButton5;
        private MaterialLabel materialLabel6;
        private ListView listGPU;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel8;
        private MaterialButton materialButton8;
        private MaterialButton materialButton6;
        private MaterialLabel materialLabel10;
        private MaterialLabel materialLabel11;
        private MaterialExpansionPanel materialExpansionPanel5;
        private MaterialLabel materialLabel9;
        private MaterialButton materialButton9;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel13;
        private MaterialSwitch materialSwitch6;
        private MaterialSwitch materialSwitch5;
        private MaterialSwitch materialSwitch9;
        private MaterialSwitch materialSwitch4;
        private MaterialLabel materialLabel14;
        private PictureBox pictureBox2;
        private MaterialButton materialButton10;
        private MaterialLabel materialLabel15;
        private MaterialLabel materialLabel16;
        private PictureBox pictureBox3;
    }
}

