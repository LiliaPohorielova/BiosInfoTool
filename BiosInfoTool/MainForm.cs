using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiosInfoTool
{
    public partial class MainForm : MaterialForm
    {
        private StringBuilder results;
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            InsertInfo("Win32_BIOS", ref listBIOS, true);
            InsertInfo("Win32_Processor", ref listCPU, true);
            InsertInfo("Win32_VideoController", ref listGPU, true);
            results = new StringBuilder("BIOS INFO TOOL\n");
            //Win32_BIOS
            //Win32_Processor
            //Win32_OperatingSystem
            //Win32_Battery
            //Win32_VideoController
        }

        private void InsertInfo(string Key, ref ListView lst, bool DontInsertNull)
        {
            lst.Items.Clear();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);

            try
            {
                foreach (ManagementObject share in searcher.Get())
                {

                    ListViewGroup grp;
                    try
                    {
                        grp = lst.Groups.Add(share["Name"].ToString(), share["Name"].ToString());
                    }
                    catch
                    {
                        grp = lst.Groups.Add(share.ToString(), share.ToString());
                    }

                    if (share.Properties.Count <= 0)
                    {
                        MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (PropertyData PC in share.Properties)
                    {

                        ListViewItem item = new ListViewItem(grp);
                        if (lst.Items.Count % 2 != 0)
                            item.BackColor = Color.White;
                        else
                            item.BackColor = Color.WhiteSmoke;

                        item.Text = PC.Name;

                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;

                                    string str2 = "";
                                    foreach (string st in str)
                                        str2 += st + " ";

                                    item.SubItems.Add(str2);

                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;


                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                        tstr2 += st.ToString() + " ";

                                    item.SubItems.Add(tstr2);

                                    break;

                                default:
                                    item.SubItems.Add(PC.Value.ToString());
                                    break;
                            }
                        }
                        else
                        {
                            if (!DontInsertNull)
                                item.SubItems.Add("No Information available");
                            else
                                continue;
                        }
                        lst.Items.Add(item);
                    }
                }
            }


            catch (Exception exp)
            {
                MessageBox.Show("can't get data because of the followeing error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void materialButton1_Click(object sender, EventArgs e)
        { 
            SaveFileDialog file = new SaveFileDialog();
            file.FileName = "BiosInfoTool(Bios).txt";
            file.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (file.FileName.ToString() != "")
                {
                    using (StreamWriter sw = new StreamWriter(file.FileName))
                    {
                        sw.WriteLine("====================== BIOS INFORMATION ==============================================================================================================");
                        foreach (ListViewItem item in listBIOS.Items)
                        {
                            StringBuilder itemString = new StringBuilder(item.SubItems[0].Text);
                            for (int i = itemString.Length; i < 30; i++)
                            {
                                itemString.Append(" ");
                            }
                            sw.WriteLine("{0}{1}{2}", itemString.ToString(), "\t\t", item.SubItems[1].Text.ToString());
                        }
                    }
                }
            }
        }

        private void learnMoreBiosLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/BIOS");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MaterialDialog materialDialog = new MaterialDialog(this, "Information about BIOS", "This information about the BIOS of your computer was obtained using the WMI class Win32_BIOS. To show SQL query press OK", "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("SELECT * FROM Win32_BIOS", 750);
                SnackBarMessage.Show(this);
            }
        }

        private int colorSchemeIndex;
        private void MaterialButton4_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2)
                colorSchemeIndex = 0;
            updateColor();
        }
        private void updateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            Invalidate();
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            updateColor();
        }

        private void materialSwitch8_CheckedChanged(object sender, EventArgs e)
        {
            DrawerShowIconsWhenHidden = materialSwitch8.Checked;
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Central_processing_unit");
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            MaterialDialog materialDialog = new MaterialDialog(this, "Information about CPU", "This information about the CPU of your computer was obtained using the WMI class Win32_Processor. To show SQL query press OK", "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("SELECT * FROM Win32_Processor", 750);
                SnackBarMessage.Show(this);
            }
        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Graphics_processing_unit");
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            MaterialDialog materialDialog = new MaterialDialog(this, "Information about GPU", "This information about the GPU of your computer was obtained using the WMI class Win32_VideoController. To show SQL query press OK", "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("SELECT * FROM Win32_VideoController", 750);
                SnackBarMessage.Show(this);
            }
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.FileName = "BiosInfoTool(CPU).txt";
            file.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (file.FileName.ToString() != "")
                {
                    using (StreamWriter sw = new StreamWriter(file.FileName))
                    {
                        sw.WriteLine("============================== CPU INFORMATION ===============================================================");
                        foreach (ListViewItem item in listCPU.Items)
                        {
                            StringBuilder itemString = new StringBuilder(item.SubItems[0].Text);
                            for (int i = itemString.Length; i < 40; i++)
                            {
                                itemString.Append(" ");
                            }
                            sw.WriteLine("{0}{1}{2}", itemString.ToString(), "\t\t", item.SubItems[1].Text.ToString());
                        }
                    }
                }
            }
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.FileName = "BiosInfoTool(GPU).txt";
            file.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (file.FileName.ToString() != "")
                {
                    using (StreamWriter sw = new StreamWriter(file.FileName))
                    {
                        sw.WriteLine("======================= GPU INFORMATION ===============================================================");
                        foreach (ListViewItem item in listGPU.Items)
                        {
                            StringBuilder itemString = new StringBuilder(item.SubItems[0].Text);
                            for (int i = itemString.Length; i < 30; i++)
                            {
                                itemString.Append(" ");
                            }
                            sw.WriteLine("{0}{1}{2}", itemString.ToString(), "\t\t", item.SubItems[1].Text.ToString());
                        }
                    }
                }
            }
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/c1NPUDcK3YM");
        }

        private void materialSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            DrawerUseColors = materialSwitch4.Checked;
        }

        private void materialSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            DrawerHighlightWithAccent = materialSwitch5.Checked;
        }

        private void materialSwitch6_CheckedChanged(object sender, EventArgs e)
        {
            DrawerBackgroundWithAccent = materialSwitch6.Checked;
        }

        private void materialSwitch9_CheckedChanged(object sender, EventArgs e)
        {
            DrawerAutoShow = materialSwitch9.Checked;
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LiliaPohorielova/BiosInfoTool");
        }
    }
}
