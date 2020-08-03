namespace PngOptimizer
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdB_Lossy = new System.Windows.Forms.RadioButton();
            this.rdB_LossyLess = new System.Windows.Forms.RadioButton();
            this.trackBarLossy = new System.Windows.Forms.TrackBar();
            this.trackBarLossyLess = new System.Windows.Forms.TrackBar();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLossy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLossyLess)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(21, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(546, 280);
            this.listBox1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(447, 45);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 31);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 368);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 31);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.trackBarLossyLess);
            this.groupBox1.Controls.Add(this.trackBarLossy);
            this.groupBox1.Controls.Add(this.rdB_LossyLess);
            this.groupBox1.Controls.Add(this.rdB_Lossy);
            this.groupBox1.Location = new System.Drawing.Point(160, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // rdB_Lossy
            // 
            this.rdB_Lossy.AutoSize = true;
            this.rdB_Lossy.Checked = true;
            this.rdB_Lossy.Location = new System.Drawing.Point(16, 21);
            this.rdB_Lossy.Name = "rdB_Lossy";
            this.rdB_Lossy.Size = new System.Drawing.Size(50, 16);
            this.rdB_Lossy.TabIndex = 0;
            this.rdB_Lossy.TabStop = true;
            this.rdB_Lossy.Text = "Lossy";
            this.rdB_Lossy.UseVisualStyleBackColor = true;
            // 
            // rdB_LossyLess
            // 
            this.rdB_LossyLess.AutoSize = true;
            this.rdB_LossyLess.Location = new System.Drawing.Point(16, 68);
            this.rdB_LossyLess.Name = "rdB_LossyLess";
            this.rdB_LossyLess.Size = new System.Drawing.Size(70, 16);
            this.rdB_LossyLess.TabIndex = 0;
            this.rdB_LossyLess.Text = "LossyLess";
            this.rdB_LossyLess.UseVisualStyleBackColor = true;
            // 
            // trackBarLossy
            // 
            this.trackBarLossy.Location = new System.Drawing.Point(104, 21);
            this.trackBarLossy.Minimum = 1;
            this.trackBarLossy.Name = "trackBarLossy";
            this.trackBarLossy.Size = new System.Drawing.Size(285, 45);
            this.trackBarLossy.TabIndex = 1;
            this.trackBarLossy.Value = 1;
            // 
            // trackBarLossyLess
            // 
            this.trackBarLossyLess.Location = new System.Drawing.Point(104, 68);
            this.trackBarLossyLess.Maximum = 8;
            this.trackBarLossyLess.Minimum = 1;
            this.trackBarLossyLess.Name = "trackBarLossyLess";
            this.trackBarLossyLess.Size = new System.Drawing.Size(285, 45);
            this.trackBarLossyLess.TabIndex = 1;
            this.trackBarLossyLess.Value = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(104, 125);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(285, 22);
            this.txtOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Directory:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNG Optimizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLossy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLossyLess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdB_LossyLess;
        private System.Windows.Forms.RadioButton rdB_Lossy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TrackBar trackBarLossyLess;
        private System.Windows.Forms.TrackBar trackBarLossy;
    }
}

