using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorPicker
{
    //拾色器主窗体
    public partial class MainForm : Form
    {
        //APP名称
        public string AppName = "拾色器";
        //APP描述
        public string AppSummary = "ColorPicker拾色器\r\n获取光标处的坐标和颜色\r\n开始：点击开始按钮，或按空格键/回车键\r\n停止：单击鼠标左/中/右键都可";
        //作者
        public string Author = "ordinary-student";
        //链接
        public string Href = "https://github.com/ordinary-student";
        //版本
        public string Version = "v1.0.0";
        //最后更新时间
        public string LastUpdateTime = "2022-03-11";

        //屏幕大小
        public int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        public int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        //
        public Form MaskForm;

        //构造方法
        public MainForm()
        {
            //加载组件
            InitializeComponent();
        }

        //主窗口按键释放事件
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            //空格-自动按下开始按钮
            if (e.KeyCode == Keys.Space)
            {
                StartButton.PerformClick();
            }
        }

        //窗口置顶勾选框状态改变事件
        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            TopMost = CheckBox.Checked;
        }

        //开始按钮单击事件
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (MaskForm == null)
            {
                StartButton.Text = "停止";
                //创建透明窗体
                Form maskForm = new Form
                {
                    //窗体大小
                    Size = new Size(ScreenWidth, ScreenHeight),
                    //窗体无标题边框
                    FormBorderStyle = FormBorderStyle.None,
                    //透明度
                    //maskForm.Opacity = 0.01;
                    //R不等于B，因为R=B会导致鼠标穿透
                    BackColor = Color.FromArgb(255, 254, 253),
                    TransparencyKey = Color.FromArgb(255, 254, 253)
                };

                //匿名委托-鼠标点击时关闭窗口
                maskForm.MouseClick += (sd, ea) => maskForm.Dispose();
                //匿名委托-鼠标移动事件
                maskForm.MouseMove += (sd, ea) => MaskFormMouseMove(sd, ea);
                //显示窗体
                maskForm.Show(this);
                MaskForm = maskForm;
            }
            else
            {
                MaskFormDispose();
                StartButton.Text = "开始";
            }
        }

        //关闭透明窗体
        private void MaskFormDispose()
        {
            if (MaskForm != null)
            {
                MaskForm.Dispose();
                MaskForm = null;
            }
        }


        //透明窗口鼠标移动事件
        public void MaskFormMouseMove(object sender, MouseEventArgs e)
        {
            //获取鼠标坐标
            int x = e.X;
            int y = e.Y;
            //以光标为中心截取图片
            Bitmap bmp = CaptureScreen(new Point(x - 10, y - 10), new Size(20, 20));
            //获取中心点颜色
            Color pixelColor = bmp.GetPixel(10, 10);
            //像素点颜色
            //byte a = pixelColor.A;          
            byte r = pixelColor.R;
            byte g = pixelColor.G;
            byte b = pixelColor.B;
            //标签设置背景色
            ColorLabel.BackColor = pixelColor;
            //设置文字
            XTextBox.Text = x.ToString();
            YTextBox.Text = y.ToString();
            RGBTextBox.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
            HtmlTextBox.Text = ColorTranslator.ToHtml(pixelColor).ToString();
            // 放大图片并设置
            PictureBox.Image = ZoomImage(bmp, new Size(200, 200));
        }

        //截取屏幕指定位置和大小的图像
        private Bitmap CaptureScreen(Point point, Size size)
        {
            //新建空白图像
            Bitmap img = new Bitmap(size.Width, size.Height);
            //新建画布
            Graphics g = Graphics.FromImage(img);
            // 把屏幕图片拷贝到空白图片中
            //参数说明：屏幕位置-粘贴到空白图像上的位置-屏幕图像大小
            g.CopyFromScreen(point, new Point(0, 0), size);
            //返回图像
            return img;
        }

        /// <summary>
        /// 缩放图片
        /// </summary>
        /// <param name="bmp">图片源</param>
        /// <param name="size">新图片大小</param>
        /// <returns></returns>
        private Bitmap ZoomImage(Bitmap bmp, Size size)
        {
            //新建空白图像
            Bitmap img = new Bitmap(size.Width, size.Height);
            //新建画布
            Graphics g = Graphics.FromImage(img);

            // 设置合成质量         
            g.CompositingQuality = CompositingQuality.HighQuality;

            //设置插值模式-高质量/近邻算法
            //g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            //设置平滑模式(抗锯齿)-高质量/无
            //g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.None;

            //绘制图像
            g.DrawImage(bmp, new Rectangle(0, 0, size.Width, size.Height), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);

            //设置画笔颜色和粗细
            Pen pen = new Pen(Color.Red, 1);
            //画直线
            g.DrawLine(pen, 0, size.Height / 2, size.Width, size.Height / 2);
            g.DrawLine(pen, size.Width / 2, 0, size.Width / 2, size.Height);

            //返回新图像
            return img;
        }

        //定时器触发事件
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (MaskForm != null)
            {
                if (MaskForm.IsDisposed)
                {
                    MaskForm = null;
                    StartButton.Text = "开始";
                }
            }
        }

        //主窗体加载事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            //定时器时间间隔-100毫秒
            Timer.Interval = 100;
            //启动定时器
            Timer.Start();
            StartButton.Focus();
        }

      

        //关于按钮单击事件
        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppSummary + "\r\nAuthor：" + Author + "\r\n" + Href + "\r\nVersion：" + Version + "\r\nLastUpdate：" + LastUpdateTime, AppName);
        }
    }
}
