using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Img2Ico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string FileName;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb4icosize.SelectedIndex = 0;
            txt4icopath.Text = Application.StartupPath + "\\ico\\";
        }

        public static Icon ConvertToIcon(Image image, bool nullTonull = false)
        {
            if (image == null)
            {
                if (nullTonull) { return null; }
                throw new ArgumentNullException("image");
            }

            using (MemoryStream msImg = new MemoryStream()
                              , msIco = new MemoryStream())
            {
                image.Save(msImg, ImageFormat.Png);
            
                using (var bin = new BinaryWriter(msIco))
                {
                    //写图标头部
                    bin.Write((short)0);           //0-1保留
                    bin.Write((short)1);           //2-3文件类型。1=图标, 2=光标
                    bin.Write((short)1);           //4-5图像数量（图标可以包含多个图像）

                    bin.Write((byte)image.Width);  //6图标宽度
                    bin.Write((byte)image.Height); //7图标高度
                    bin.Write((byte)0);            //8颜色数（若像素位深>=8，填0。这是显然的，达到8bpp的颜色数最少是256，byte不够表示）
                    bin.Write((byte)0);            //9保留。必须为0
                    bin.Write((short)0);           //10-11调色板
                    bin.Write((short)32);          //12-13位深
                    bin.Write((int)msImg.Length);  //14-17位图数据大小
                    bin.Write(22);                 //18-21位图数据起始字节

                    //写图像数据
                    bin.Write(msImg.ToArray());

                    bin.Flush();
                    bin.Seek(0, SeekOrigin.Begin);
                    return new Icon(msIco);
                }
            }
        }

        private void btn4convert_Click(object sender, EventArgs e)
        {
            Size size = new Size(128, 128);
            switch (cmb4icosize.SelectedIndex)
            {
                case 0:
                    size = new Size(128, 128);
                    break;
                case 1:
                    size = new Size(64, 648);
                    break;
                case 2:
                    size = new Size(48, 48);
                    break;
                case 3:
                    size = new Size(32, 32);
                    break;
                case 4:
                    size = new Size(16, 16);
                    break;
            }

            try
            {
                Image imgfromfile = Image.FromFile(FileName);
                Bitmap iconBm = new Bitmap(imgfromfile, size);
                Icon icon = ConvertToIcon(iconBm);
                string Name_ = txt4icopath.Text + Path.GetFileNameWithoutExtension(FileName) + ".ico";
                using (Stream stream = new FileStream(Name_, FileMode.Create))
                {
                    icon.Save(stream);
                    lb4status.Text = "运行状态：" + Path.GetFileNameWithoutExtension(FileName) + ".ico 转换成功";
                }
            }
            catch
            {
                lb4status.Text = "运行状态：文件选择错误！ 转换失败！";
            }
        }

        private void btn4selimg_Click(object sender, EventArgs e)
        {
            lb4status.Text = "运行状态：等待转换...";
            openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|GIF|*.gif";
            DialogResult D = openFileDialog1.ShowDialog();
            if (D == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName.Trim();
                txt4imgpath.Text = FileName;
            }
        }

        private void btn4selicopath_Click(object sender, EventArgs e)
        {
            lb4status.Text = "运行状态：等待转换...";
        }

        private void btn4findico_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txt4icopath.Text);
        }

        private void cmb4icosize_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb4status.Text = "运行状态：等待转换...";
        }
    }
}
