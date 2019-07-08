namespace 画图板
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
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于画图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.铅笔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.橡皮擦ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.形状ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.矩形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三角形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.one = new System.Windows.Forms.ToolStripMenuItem();
            this.two = new System.Windows.Forms.ToolStripMenuItem();
            this.four = new System.Windows.Forms.ToolStripMenuItem();
            this.eight = new System.Windows.Forms.ToolStripMenuItem();
            this.旋转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向右旋转90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向左旋转90度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.旋转180度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直翻转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平翻转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawingForm = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingForm)).BeginInit();
            this.SuspendLayout();
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.关于画图ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.新建ToolStripMenuItem.Text = "新建(N)";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打开ToolStripMenuItem.Text = "打开(O)...";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.保存ToolStripMenuItem.Text = "保存(S)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.另存为ToolStripMenuItem.Text = "另存为(A)...";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打印ToolStripMenuItem.Text = "打印(P)";
            this.打印ToolStripMenuItem.Click += new System.EventHandler(this.打印ToolStripMenuItem_Click);
            // 
            // 关于画图ToolStripMenuItem
            // 
            this.关于画图ToolStripMenuItem.Name = "关于画图ToolStripMenuItem";
            this.关于画图ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.关于画图ToolStripMenuItem.Text = "关于画图(T)";
            this.关于画图ToolStripMenuItem.Click += new System.EventHandler(this.关于画图ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.退出ToolStripMenuItem.Text = "退出(X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.铅笔ToolStripMenuItem,
            this.橡皮擦ToolStripMenuItem});
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.主页ToolStripMenuItem.Text = "工具";
            // 
            // 铅笔ToolStripMenuItem
            // 
            this.铅笔ToolStripMenuItem.Name = "铅笔ToolStripMenuItem";
            this.铅笔ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.铅笔ToolStripMenuItem.Text = "铅笔";
            this.铅笔ToolStripMenuItem.Click += new System.EventHandler(this.铅笔ToolStripMenuItem_Click);
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            this.橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            this.橡皮擦ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            this.橡皮擦ToolStripMenuItem.Click += new System.EventHandler(this.橡皮擦ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.主页ToolStripMenuItem,
            this.形状ToolStripMenuItem,
            this.粗细ToolStripMenuItem,
            this.旋转ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1329, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 形状ToolStripMenuItem
            // 
            this.形状ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.直线ToolStripMenuItem,
            this.圆ToolStripMenuItem,
            this.矩形ToolStripMenuItem,
            this.三角形ToolStripMenuItem});
            this.形状ToolStripMenuItem.Name = "形状ToolStripMenuItem";
            this.形状ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.形状ToolStripMenuItem.Text = "形状";
            // 
            // 直线ToolStripMenuItem
            // 
            this.直线ToolStripMenuItem.Name = "直线ToolStripMenuItem";
            this.直线ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.直线ToolStripMenuItem.Text = "直线";
            this.直线ToolStripMenuItem.Click += new System.EventHandler(this.直线ToolStripMenuItem_Click);
            // 
            // 圆ToolStripMenuItem
            // 
            this.圆ToolStripMenuItem.Name = "圆ToolStripMenuItem";
            this.圆ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.圆ToolStripMenuItem.Text = "圆";
            this.圆ToolStripMenuItem.Click += new System.EventHandler(this.圆ToolStripMenuItem_Click);
            // 
            // 矩形ToolStripMenuItem
            // 
            this.矩形ToolStripMenuItem.Name = "矩形ToolStripMenuItem";
            this.矩形ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.矩形ToolStripMenuItem.Text = "矩形";
            this.矩形ToolStripMenuItem.Click += new System.EventHandler(this.矩形ToolStripMenuItem_Click);
            // 
            // 三角形ToolStripMenuItem
            // 
            this.三角形ToolStripMenuItem.Name = "三角形ToolStripMenuItem";
            this.三角形ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.三角形ToolStripMenuItem.Text = "三角形";
            this.三角形ToolStripMenuItem.Click += new System.EventHandler(this.三角形ToolStripMenuItem_Click);
            // 
            // 粗细ToolStripMenuItem
            // 
            this.粗细ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.one,
            this.two,
            this.four,
            this.eight});
            this.粗细ToolStripMenuItem.Name = "粗细ToolStripMenuItem";
            this.粗细ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.粗细ToolStripMenuItem.Text = "粗细";
            // 
            // one
            // 
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(93, 26);
            this.one.Text = "1";
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(93, 26);
            this.two.Text = "2";
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // four
            // 
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(93, 26);
            this.four.Text = "4";
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // eight
            // 
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(93, 26);
            this.eight.Text = "8";
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // 旋转ToolStripMenuItem
            // 
            this.旋转ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.向右旋转90ToolStripMenuItem,
            this.向左旋转90度ToolStripMenuItem,
            this.旋转180度ToolStripMenuItem,
            this.垂直翻转ToolStripMenuItem,
            this.水平翻转ToolStripMenuItem});
            this.旋转ToolStripMenuItem.Name = "旋转ToolStripMenuItem";
            this.旋转ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.旋转ToolStripMenuItem.Text = "旋转";
            // 
            // 向右旋转90ToolStripMenuItem
            // 
            this.向右旋转90ToolStripMenuItem.Name = "向右旋转90ToolStripMenuItem";
            this.向右旋转90ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.向右旋转90ToolStripMenuItem.Text = "向右旋转90度";
            this.向右旋转90ToolStripMenuItem.Click += new System.EventHandler(this.向右旋转90ToolStripMenuItem_Click);
            // 
            // 向左旋转90度ToolStripMenuItem
            // 
            this.向左旋转90度ToolStripMenuItem.Name = "向左旋转90度ToolStripMenuItem";
            this.向左旋转90度ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.向左旋转90度ToolStripMenuItem.Text = "向左旋转90度";
            this.向左旋转90度ToolStripMenuItem.Click += new System.EventHandler(this.向左旋转90度ToolStripMenuItem_Click);
            // 
            // 旋转180度ToolStripMenuItem
            // 
            this.旋转180度ToolStripMenuItem.Name = "旋转180度ToolStripMenuItem";
            this.旋转180度ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.旋转180度ToolStripMenuItem.Text = "旋转180度";
            // 
            // 垂直翻转ToolStripMenuItem
            // 
            this.垂直翻转ToolStripMenuItem.Name = "垂直翻转ToolStripMenuItem";
            this.垂直翻转ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.垂直翻转ToolStripMenuItem.Text = "垂直翻转";
            // 
            // 水平翻转ToolStripMenuItem
            // 
            this.水平翻转ToolStripMenuItem.Name = "水平翻转ToolStripMenuItem";
            this.水平翻转ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.水平翻转ToolStripMenuItem.Text = "水平翻转";
            // 
            // DrawingForm
            // 
            this.DrawingForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingForm.BackColor = System.Drawing.Color.White;
            this.DrawingForm.Location = new System.Drawing.Point(0, 31);
            this.DrawingForm.Name = "DrawingForm";
            this.DrawingForm.Size = new System.Drawing.Size(1329, 561);
            this.DrawingForm.TabIndex = 2;
            this.DrawingForm.TabStop = false;
            this.DrawingForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MouseDown);
            this.DrawingForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.DrawingForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MounseUP);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 592);
            this.Controls.Add(this.DrawingForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox DrawingForm;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于画图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 铅笔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 橡皮擦ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 形状ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem one;
        private System.Windows.Forms.ToolStripMenuItem two;
        private System.Windows.Forms.ToolStripMenuItem four;
        private System.Windows.Forms.ToolStripMenuItem eight;
        private System.Windows.Forms.ToolStripMenuItem 直线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 矩形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三角形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 旋转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向右旋转90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向左旋转90度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 旋转180度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直翻转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平翻转ToolStripMenuItem;
    }
}

