namespace ColorPicker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.RGBLabel = new System.Windows.Forms.Label();
            this.HtmlLabel = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.RGBTextBox = new System.Windows.Forms.TextBox();
            this.HtmlTextBox = new System.Windows.Forms.TextBox();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.AboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(5, 5);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(200, 200);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // ColorLabel
            // 
            this.ColorLabel.BackColor = System.Drawing.Color.White;
            this.ColorLabel.Location = new System.Drawing.Point(220, 5);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(70, 70);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XLabel
            // 
            this.XLabel.Location = new System.Drawing.Point(220, 87);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(70, 25);
            this.XLabel.TabIndex = 7;
            this.XLabel.Text = "X坐标：";
            this.XLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YLabel
            // 
            this.YLabel.Location = new System.Drawing.Point(220, 117);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(70, 25);
            this.YLabel.TabIndex = 8;
            this.YLabel.Text = "Y坐标：";
            this.YLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RGBLabel
            // 
            this.RGBLabel.Location = new System.Drawing.Point(220, 147);
            this.RGBLabel.Name = "RGBLabel";
            this.RGBLabel.Size = new System.Drawing.Size(70, 25);
            this.RGBLabel.TabIndex = 9;
            this.RGBLabel.Text = "RGB：";
            this.RGBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HtmlLabel
            // 
            this.HtmlLabel.Location = new System.Drawing.Point(220, 177);
            this.HtmlLabel.Name = "HtmlLabel";
            this.HtmlLabel.Size = new System.Drawing.Size(70, 25);
            this.HtmlLabel.TabIndex = 10;
            this.HtmlLabel.Text = "HTML：";
            this.HtmlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // XTextBox
            // 
            this.XTextBox.Font = new System.Drawing.Font("楷体", 12F);
            this.XTextBox.Location = new System.Drawing.Point(300, 87);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.ReadOnly = true;
            this.XTextBox.Size = new System.Drawing.Size(175, 26);
            this.XTextBox.TabIndex = 3;
            // 
            // YTextBox
            // 
            this.YTextBox.Font = new System.Drawing.Font("楷体", 12F);
            this.YTextBox.Location = new System.Drawing.Point(300, 117);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.ReadOnly = true;
            this.YTextBox.Size = new System.Drawing.Size(175, 26);
            this.YTextBox.TabIndex = 4;
            // 
            // RGBTextBox
            // 
            this.RGBTextBox.Font = new System.Drawing.Font("楷体", 12F);
            this.RGBTextBox.Location = new System.Drawing.Point(300, 147);
            this.RGBTextBox.Name = "RGBTextBox";
            this.RGBTextBox.ReadOnly = true;
            this.RGBTextBox.Size = new System.Drawing.Size(175, 26);
            this.RGBTextBox.TabIndex = 5;
            // 
            // HtmlTextBox
            // 
            this.HtmlTextBox.Font = new System.Drawing.Font("楷体", 12F);
            this.HtmlTextBox.Location = new System.Drawing.Point(300, 177);
            this.HtmlTextBox.Name = "HtmlTextBox";
            this.HtmlTextBox.ReadOnly = true;
            this.HtmlTextBox.Size = new System.Drawing.Size(175, 26);
            this.HtmlTextBox.TabIndex = 6;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Checked = true;
            this.CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox.Location = new System.Drawing.Point(300, 13);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(90, 20);
            this.CheckBox.TabIndex = 1;
            this.CheckBox.Text = "窗口置顶";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("楷体", 14F);
            this.StartButton.Location = new System.Drawing.Point(397, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 62);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "开始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(300, 45);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(90, 25);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "关于";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.HtmlTextBox);
            this.Controls.Add(this.RGBTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.HtmlLabel);
            this.Controls.Add(this.RGBLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.PictureBox);
            this.Font = new System.Drawing.Font("楷体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 250);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "拾色器";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label RGBLabel;
        private System.Windows.Forms.Label HtmlLabel;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox RGBTextBox;
        private System.Windows.Forms.TextBox HtmlTextBox;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button AboutButton;
    }
}

