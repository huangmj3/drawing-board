using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 画图板
{
    public partial class Form1 : Form
    {
        string filePath = "$";   //默认文件目录为空
        Color color = Color.Black;   //默认为黑色 
        int size = 1;    //标记工具大小，默认为1
        bool isDrawing = false;     //判断是否正在画图
        Point oldPoint;      //用于记录鼠标画图时的老坐标
        Point startPoint;     //用于记录鼠标画图时的开始坐标
        //Point oldPoint;        //画图时用于记录老坐标
        //Image image1 = new Bitmap(400, 400);
        bool isSave = true;    //该画图文件是否已经被保存
        enum toolBox
        {
            mouse,pen,eraser,line,ellipese, rectangle,triangle
        };
        toolBox drawTool = toolBox.pen;    //默认初始为画笔工具
        public Form1()
        {
            InitializeComponent();
            this.Text = "狐仙魔法书";
            one.Checked = true;    //默认工具大小为1
        }

        private void DrawingForm_MouseDown(object sender,MouseEventArgs e)     //鼠标按下事件
        {
            //MessageBox.Show("Yes!");
            if(e.Button == MouseButtons.Left)
            {
                if (drawTool != toolBox.mouse)
                    isSave = false;                  
                //MessageBox.Show("Yes again!");
                isDrawing = true;     //正在画图
                oldPoint = new Point(e.X, e.Y);
                startPoint = oldPoint;
            }
        }

        private void Form1_MouseMove(object sender,MouseEventArgs e)    //鼠标移动事件
        {
            //MessageBox.Show("Yes");
            if(isDrawing == true)
            {
                //MessageBox.Show("Yes again!");
                Graphics graphics = DrawingForm.CreateGraphics();
                switch(drawTool)
                {
                    case toolBox.pen:
                        graphics.DrawLine(new Pen(color, size), oldPoint, new Point(e.X, e.Y));    //使用画笔画直线
                        oldPoint.X = e.X;    //更新画图直线的初始坐标
                        oldPoint.Y = e.Y;
                        break;
                    case toolBox.eraser:
                        graphics.DrawLine(new Pen(Color.White, size), oldPoint, new Point(e.X, e.Y));    //使用白笔画图，覆盖原来画的图
                        oldPoint.X = e.X;
                        oldPoint.Y = e.Y;
                        break;
                    default:
                        oldPoint.X = e.X;
                        oldPoint.Y = e.Y;
                        break;
                }
            }
        }

        private void DrawingForm_MounseUP(object sender,MouseEventArgs e)      //鼠标抬起事件
        {
            Graphics graphics = DrawingForm.CreateGraphics();
            if (isDrawing)
            {
                switch (drawTool)
                {
                    case toolBox.line:    //画直线
                        graphics.DrawLine(new Pen(color, size), startPoint, oldPoint);
                        break;
                    case toolBox.rectangle:    //画矩形
                        graphics.DrawRectangle(new Pen(color, size), startPoint.X, startPoint.Y, oldPoint.X-startPoint.X, oldPoint.Y-startPoint.Y);
                        break;
                    case toolBox.ellipese:    //画圆
                        graphics.DrawEllipse(new Pen(color, size), startPoint.X, startPoint.Y, oldPoint.X - startPoint.X, oldPoint.Y - startPoint.Y);
                        break;
                    case toolBox.triangle:
                        graphics.DrawLine(new Pen(color, size), startPoint, oldPoint);
                        graphics.DrawLine(new Pen(color, size), startPoint.X,startPoint.Y, (startPoint.X + startPoint.X - oldPoint.X),oldPoint.Y);
                        graphics.DrawLine(new Pen(color, size), (startPoint.X + startPoint.X - oldPoint.X), oldPoint.Y, oldPoint.X,oldPoint.Y);
                        graphics.DrawLine(new Pen(color, size), startPoint, startPoint);
                        graphics.DrawLine(new Pen(color, size), oldPoint, oldPoint);
                        graphics.DrawLine(new Pen(color, size), (startPoint.X + startPoint.X - oldPoint.X), oldPoint.Y, (startPoint.X + startPoint.X - oldPoint.X),oldPoint.Y);
                        break;
                }
            }
            isDrawing = false;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.ShowDialog();
        }

        private void 关于画图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本软件由黄茂杰开发，如有疑问可通过邮箱1263371193@qq.com联系");
        }

        private void 铅笔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTool = toolBox.pen;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = DrawingForm.CreateGraphics();
            if (isSave == true)
            {
                graphics.Clear(Color.White);     //重置画图板
            }
            else
            {
                string name = this.Text;
                DialogResult result = MessageBox.Show("                  是否将更改保存到" + name, "狐仙魔法书", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:         //执行保存操作
                        保存ToolStripMenuItem_Click(sender, e);
                        break;
                    case DialogResult.No:                  //重置画板
                        graphics.Clear(Color.White);
                        isSave = true;
                        break;
                    case DialogResult.Cancel:               //取消什么都不做
                        break;
                }
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG(*.png)|*.png | GIF(*.gif)|*.gif | JPEG(*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg";
            saveFileDialog.FilterIndex = 3;
            DrawingForm.Image
            Bitmap bitmat = new Bitmap(DrawingForm.Image);
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pictureName = saveFileDialog.FileName;
                try
                {
                    using (MemoryStream mem = new MemoryStream())
                    {
                        //这句很重要，不然不能正确保存图片或出错（关键就这一句）
                        Bitmap bmp = new Bitmap(DrawingForm.Image);
                        //保存到磁盘文件
                        bmp.Save(@pictureName, DrawingForm.Image.RawFormat);
                        bmp.Dispose();
                        MessageBox.Show("附件另存成功！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //将image作为流数据进行保存
                    MemoryStream mstream = new MemoryStream();
                    if (saveFileDialog.FilterIndex == 1)
                       // bitmat.Save(filePath, ImageFormat.Png);
                    //ImageFormat image;
                        DrawingForm.Image.Save(filePath,ImageFormat.Png);
                    else if (saveFileDialog.FilterIndex == 2)
                        //bitmat.Save(filePath, ImageFormat.Gif);
                        DrawingForm.Image.Save(filePath,ImageFormat.Gif);
                    else if (saveFileDialog.FilterIndex == 3)
                        //bitmat.Save(filePath, ImageFormat.Jpeg);
                        DrawingForm.Image.Save(filePath,ImageFormat.Jpeg);
                    //MessageBox.Show("Yes again!");
                }
                catch
                {
                    MessageBox.Show("保存失败！");
                }
            }
        }

        private void 橡皮擦ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTool = toolBox.eraser;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(isSave.ToString());
            if(isSave == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  //默认桌面作为打开文件路径
                openFileDialog.Filter = "PNG(*.png)|*.png | GIF(*.gif)|*.gif | ICO(*.ico)|*.ico | JPEG(*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg;*jpeg;*jpe;*jfif | 所有图片文件|*.png;*.gif;*.bmp;*.wmf;*.ico;*.cur;*.jpg;*.jpeg;*.jpe*,jfif  | 所有文件(.)|*.*";
                openFileDialog.FilterIndex = 5;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Graphics graphic = DrawingForm.CreateGraphics();
                    Image image = Bitmap.FromFile(openFileDialog.FileName);
                    graphic.DrawImage(image, this.ClientRectangle);
                    this.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.IndexOf("//") + 1);
                    filePath = openFileDialog.FileName;
                }
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            one.Checked = true;
            two.Checked = false;
            four.Checked = false;
            eight.Checked = false;
            size = 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            one.Checked = false;
            two.Checked = true;
            four.Checked = false;
            eight.Checked = false;
            size = 2;
        }

        private void four_Click(object sender, EventArgs e)
        {
            one.Checked = false;
            two.Checked = false;
            four.Checked = true;
            eight.Checked = false;
            size = 4;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            one.Checked = false;
            two.Checked = false;
            four.Checked = false;
            eight.Checked = true;
            size = 8;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(filePath != "$")
            {
                isSave = true;
                DrawingForm.Image.Save(filePath);
            }
            else
                另存为ToolStripMenuItem_Click(sender, e);
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 直线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTool = toolBox.line;
        }

        private void 圆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTool = toolBox.ellipese;
        }

        private void 矩形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTool = toolBox.rectangle;
        }

        private void 三角形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTool = toolBox.triangle;
        }

        private void 向右旋转90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawingForm.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
        }

        private void 向左旋转90度ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
