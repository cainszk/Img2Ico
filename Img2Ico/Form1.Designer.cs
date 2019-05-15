namespace Img2Ico
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn4convert = new System.Windows.Forms.Button();
            this.btn4selimg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt4imgpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt4icopath = new System.Windows.Forms.TextBox();
            this.btn4selicopath = new System.Windows.Forms.Button();
            this.lb4status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb4icosize = new System.Windows.Forms.ComboBox();
            this.btn4findico = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn4convert
            // 
            this.btn4convert.BackColor = System.Drawing.Color.White;
            this.btn4convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4convert.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4convert.ForeColor = System.Drawing.Color.Green;
            this.btn4convert.Location = new System.Drawing.Point(450, 216);
            this.btn4convert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn4convert.Name = "btn4convert";
            this.btn4convert.Size = new System.Drawing.Size(192, 61);
            this.btn4convert.TabIndex = 0;
            this.btn4convert.Text = "转换为.ico文件";
            this.btn4convert.UseVisualStyleBackColor = false;
            this.btn4convert.Click += new System.EventHandler(this.btn4convert_Click);
            // 
            // btn4selimg
            // 
            this.btn4selimg.BackColor = System.Drawing.Color.White;
            this.btn4selimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4selimg.ForeColor = System.Drawing.Color.Green;
            this.btn4selimg.Location = new System.Drawing.Point(568, 100);
            this.btn4selimg.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn4selimg.Name = "btn4selimg";
            this.btn4selimg.Size = new System.Drawing.Size(74, 39);
            this.btn4selimg.TabIndex = 1;
            this.btn4selimg.Text = "浏览...";
            this.btn4selimg.UseVisualStyleBackColor = false;
            this.btn4selimg.Click += new System.EventHandler(this.btn4selimg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt4imgpath
            // 
            this.txt4imgpath.BackColor = System.Drawing.Color.White;
            this.txt4imgpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt4imgpath.Location = new System.Drawing.Point(16, 106);
            this.txt4imgpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt4imgpath.Name = "txt4imgpath";
            this.txt4imgpath.ReadOnly = true;
            this.txt4imgpath.Size = new System.Drawing.Size(542, 29);
            this.txt4imgpath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Step2. 选择需要转换的图片文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Step3. 选择.ico文件保存路径（默认为程序目录下ico文件夹）";
            // 
            // txt4icopath
            // 
            this.txt4icopath.BackColor = System.Drawing.Color.White;
            this.txt4icopath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt4icopath.Location = new System.Drawing.Point(16, 173);
            this.txt4icopath.Margin = new System.Windows.Forms.Padding(5);
            this.txt4icopath.Name = "txt4icopath";
            this.txt4icopath.ReadOnly = true;
            this.txt4icopath.Size = new System.Drawing.Size(542, 29);
            this.txt4icopath.TabIndex = 5;
            // 
            // btn4selicopath
            // 
            this.btn4selicopath.BackColor = System.Drawing.Color.White;
            this.btn4selicopath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4selicopath.ForeColor = System.Drawing.Color.Green;
            this.btn4selicopath.Location = new System.Drawing.Point(568, 167);
            this.btn4selicopath.Margin = new System.Windows.Forms.Padding(5);
            this.btn4selicopath.Name = "btn4selicopath";
            this.btn4selicopath.Size = new System.Drawing.Size(74, 39);
            this.btn4selicopath.TabIndex = 4;
            this.btn4selicopath.Text = "浏览...";
            this.btn4selicopath.UseVisualStyleBackColor = false;
            this.btn4selicopath.Click += new System.EventHandler(this.btn4selicopath_Click);
            // 
            // lb4status
            // 
            this.lb4status.ForeColor = System.Drawing.Color.Goldenrod;
            this.lb4status.Location = new System.Drawing.Point(12, 216);
            this.lb4status.Name = "lb4status";
            this.lb4status.Size = new System.Drawing.Size(228, 61);
            this.lb4status.TabIndex = 7;
            this.lb4status.Text = "运行状态：等待转换...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Step1. 选择需要转换的目标尺寸";
            // 
            // cmb4icosize
            // 
            this.cmb4icosize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb4icosize.FormattingEnabled = true;
            this.cmb4icosize.Items.AddRange(new object[] {
            "128x128",
            "64x64",
            "48x48",
            "32x32",
            "16x16"});
            this.cmb4icosize.Location = new System.Drawing.Point(16, 41);
            this.cmb4icosize.Name = "cmb4icosize";
            this.cmb4icosize.Size = new System.Drawing.Size(121, 29);
            this.cmb4icosize.TabIndex = 9;
            this.cmb4icosize.SelectedIndexChanged += new System.EventHandler(this.cmb4icosize_SelectedIndexChanged);
            // 
            // btn4findico
            // 
            this.btn4findico.BackColor = System.Drawing.Color.White;
            this.btn4findico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4findico.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4findico.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn4findico.Location = new System.Drawing.Point(248, 216);
            this.btn4findico.Margin = new System.Windows.Forms.Padding(5);
            this.btn4findico.Name = "btn4findico";
            this.btn4findico.Size = new System.Drawing.Size(192, 61);
            this.btn4findico.TabIndex = 10;
            this.btn4findico.Text = "打开.ico保存路径";
            this.btn4findico.UseVisualStyleBackColor = false;
            this.btn4findico.Click += new System.EventHandler(this.btn4findico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(465, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Img2Ico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(466, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "图片转图标工具 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 289);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn4findico);
            this.Controls.Add(this.cmb4icosize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb4status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt4icopath);
            this.Controls.Add(this.btn4selicopath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt4imgpath);
            this.Controls.Add(this.btn4selimg);
            this.Controls.Add(this.btn4convert);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片转图标工具 - Img2Ico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn4convert;
        private System.Windows.Forms.Button btn4selimg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt4imgpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt4icopath;
        private System.Windows.Forms.Button btn4selicopath;
        private System.Windows.Forms.Label lb4status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb4icosize;
        private System.Windows.Forms.Button btn4findico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

