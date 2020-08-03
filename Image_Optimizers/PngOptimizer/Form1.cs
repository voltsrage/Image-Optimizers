using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PngOptimizer;
using PNGCompression;
using System.IO;

namespace PngOptimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG Files (*.PNG)|*.PNG";
            openFile.Title = "Select PNG Files";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                foreach(string filename in openFile.FileNames)
                {
                    listBox1.Items.Add(filename);
                }                
            }
        }

        private string CompressPNG(string SourcePath, string TargetPath, bool isLossy, int LossyValue, string LossylessValue)
        {
            try
            {
                PNGCompressor pNGCompressor = new PNGCompressor();

                if(isLossy == true)
                {
                    LossyInputSettings lossyInput = new LossyInputSettings();
                    lossyInput.Speed = LossyValue;
                    pNGCompressor.CompressImageLossy(SourcePath, TargetPath,lossyInput);
                }
                else
                {
                    LosslessInputSettings losslessInput = new LosslessInputSettings();
                    losslessInput.OptimizationLevel = "Level" + LossylessValue;
                    pNGCompressor.CompressImageLossLess(SourcePath, TargetPath,losslessInput);
                }

                

                return "OK";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           

            foreach(string pngPath in listBox1.Items)
            {
                string Fname = Path.GetFileNameWithoutExtension(pngPath) + ".png";
                CompressPNG(pngPath, txtOutput.Text + Fname, rdB_Lossy.Checked, trackBarLossy.Value, trackBarLossyLess.Value.ToString());
            }
        }
    }
}
