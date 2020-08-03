namespace Gif_Optimizers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Compress = new System.Windows.Forms.ComboBox();
            this.nUp_Color = new System.Windows.Forms.NumericUpDown();
            this.nUp_Lossy = new System.Windows.Forms.NumericUpDown();
            this.txtOutPutFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Optimize = new System.Windows.Forms.Button();
            this.pB_Optimize = new System.Windows.Forms.PictureBox();
            this.pB_Source = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUp_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUp_Lossy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Optimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Source)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Gif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Optmized Gif";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Height);
            this.groupBox1.Controls.Add(this.txt_Width);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_Compress);
            this.groupBox1.Controls.Add(this.nUp_Color);
            this.groupBox1.Controls.Add(this.nUp_Lossy);
            this.groupBox1.Location = new System.Drawing.Point(50, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(563, 84);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(100, 22);
            this.txt_Height.TabIndex = 2;
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(563, 30);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(100, 22);
            this.txt_Width.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Color Reduction:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Compression Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lossy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Width:";
            // 
            // cmb_Compress
            // 
            this.cmb_Compress.FormattingEnabled = true;
            this.cmb_Compress.Items.AddRange(new object[] {
            "O1",
            "O2",
            "O3"});
            this.cmb_Compress.Location = new System.Drawing.Point(122, 30);
            this.cmb_Compress.Name = "cmb_Compress";
            this.cmb_Compress.Size = new System.Drawing.Size(121, 20);
            this.cmb_Compress.TabIndex = 1;
            this.cmb_Compress.SelectedIndexChanged += new System.EventHandler(this.cmb_Compress_SelectedIndexChanged);
            // 
            // nUp_Color
            // 
            this.nUp_Color.Location = new System.Drawing.Point(357, 84);
            this.nUp_Color.Name = "nUp_Color";
            this.nUp_Color.Size = new System.Drawing.Size(120, 22);
            this.nUp_Color.TabIndex = 0;
            // 
            // nUp_Lossy
            // 
            this.nUp_Lossy.Location = new System.Drawing.Point(357, 30);
            this.nUp_Lossy.Name = "nUp_Lossy";
            this.nUp_Lossy.Size = new System.Drawing.Size(120, 22);
            this.nUp_Lossy.TabIndex = 0;
            // 
            // txtOutPutFile
            // 
            this.txtOutPutFile.Location = new System.Drawing.Point(50, 340);
            this.txtOutPutFile.Name = "txtOutPutFile";
            this.txtOutPutFile.Size = new System.Drawing.Size(300, 22);
            this.txtOutPutFile.TabIndex = 4;
            this.txtOutPutFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Gif_Optimizers.Properties.Resources.SaveTo_16x16;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(634, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.Image = global::Gif_Optimizers.Properties.Resources.Folder;
            this.btn_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Browse.Location = new System.Drawing.Point(233, 7);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(116, 21);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Optimize
            // 
            this.btn_Optimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Optimize.Image = global::Gif_Optimizers.Properties.Resources.Wizard_16x16;
            this.btn_Optimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Optimize.Location = new System.Drawing.Point(50, 367);
            this.btn_Optimize.Name = "btn_Optimize";
            this.btn_Optimize.Size = new System.Drawing.Size(118, 41);
            this.btn_Optimize.TabIndex = 3;
            this.btn_Optimize.Text = "Optimize";
            this.btn_Optimize.UseVisualStyleBackColor = true;
            this.btn_Optimize.Click += new System.EventHandler(this.btn_Optimize_Click);
            // 
            // pB_Optimize
            // 
            this.pB_Optimize.BackColor = System.Drawing.Color.White;
            this.pB_Optimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_Optimize.Location = new System.Drawing.Point(454, 34);
            this.pB_Optimize.Name = "pB_Optimize";
            this.pB_Optimize.Size = new System.Drawing.Size(300, 300);
            this.pB_Optimize.TabIndex = 0;
            this.pB_Optimize.TabStop = false;
            // 
            // pB_Source
            // 
            this.pB_Source.BackColor = System.Drawing.Color.White;
            this.pB_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_Source.Location = new System.Drawing.Point(50, 34);
            this.pB_Source.Name = "pB_Source";
            this.pB_Source.Size = new System.Drawing.Size(300, 300);
            this.pB_Source.TabIndex = 0;
            this.pB_Source.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOutPutFile);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Optimize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pB_Optimize);
            this.Controls.Add(this.pB_Source);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIF Optimizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUp_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUp_Lossy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Optimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_Source;
        private System.Windows.Forms.PictureBox pB_Optimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Compress;
        private System.Windows.Forms.NumericUpDown nUp_Color;
        private System.Windows.Forms.NumericUpDown nUp_Lossy;
        private System.Windows.Forms.Button btn_Optimize;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txtOutPutFile;
        private System.Windows.Forms.Button btnSave;
    }
}

