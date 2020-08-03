using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gif_Optimizers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "GIF Files|*.gif";
            openFileDialog1.Title = "Select a GIF File";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutPutFile.Text = openFileDialog1.FileName;
                using (var fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    var ms = new MemoryStream();
                    fs.CopyTo(ms);
                    ms.Position = 0;
                    if (pB_Source.Image != null)
                        pB_Source.Image.Dispose();
                    pB_Source.Image = Image.FromStream(ms);
                    pB_Source.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }            
        }

        private void cmb_Compress_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Level = cmb_Compress.Text;

            Properties.Settings.Default.Lossy = Convert.ToInt32(nUp_Lossy.Value);

            Properties.Settings.Default.Colors = Convert.ToInt32(nUp_Color.Value);

            Properties.Settings.Default.Height = int.Parse(txt_Height.Text);

            Properties.Settings.Default.Width = int.Parse(txt_Width.Text);

            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Compress.Text = Properties.Settings.Default.Level;
            nUp_Color.Value = Properties.Settings.Default.Colors;
            nUp_Lossy.Value = Properties.Settings.Default.Lossy;
            txt_Width.Text = Properties.Settings.Default.Width.ToString();
            txt_Height.Text = Properties.Settings.Default.Height.ToString();
        }

        private void Optimize()
        {
            string ExeToUse = string.Empty;

            if (Environment.Is64BitOperatingSystem == true)
            {
                ExeToUse = "gifopt64.exe";
            }
            else
            {
                ExeToUse = "gifopt32.exe";
            }
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.FileName = ExeToUse;

            string CompressValue = cmb_Compress.Text;

            StringBuilder ArgString = new StringBuilder();

            ArgString.Append(" -" + CompressValue + " ");

            if(nUp_Lossy.Value > 0)
            {
                ArgString.Append(" --lossy=" + nUp_Lossy.Value.ToString());
            }

            if (nUp_Color.Value > 0)
            {
                ArgString.Append(" --colors=" + nUp_Color.Value.ToString());
            }

            if (txt_Height.Text != "0" && txt_Width.Text != "0")
            {
                ArgString.Append(" --resize-fit=" + txt_Width.Text + "X" + txt_Height.Text + " ");
            }

            ArgString.Append("\"" + txtOutPutFile.Text + "\"");
            ArgString.Append(" -o" + "\"" + "temp.gif" + "\"");

            psi.Arguments = ArgString.ToString();

            Process.Start(psi).WaitForExit();

            //Show Image
            using (var fs = new FileStream("temp.gif", FileMode.Open, FileAccess.Read))
            {
                var ms = new MemoryStream();
                fs.CopyTo(ms);
                ms.Position = 0;
                if (pB_Optimize.Image != null)
                    pB_Optimize.Image.Dispose();
                pB_Optimize.Image = Image.FromStream(ms);
                pB_Optimize.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Optimize_Click(object sender, EventArgs e)
        {
            Optimize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();

            if(result == DialogResult.OK)
            {
                File.Copy("temp.gif", folder.SelectedPath + "\\Optimized.gif");
            }
        }
    }
}
