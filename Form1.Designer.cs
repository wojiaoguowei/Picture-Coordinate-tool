
namespace WindowsFormsApp12
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxY2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxWidth2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxHeight2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(140, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(512, 28);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(249, 28);
            this.textBoxX1.TabIndex = 2;
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(512, 95);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(249, 28);
            this.textBoxX2.TabIndex = 3;
            // 
            // textBoxY2
            // 
            // 
            // 
            // 
            this.textBoxY2.Border.Class = "TextBoxBorder";
            this.textBoxY2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxY2.Location = new System.Drawing.Point(512, 144);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.PreventEnterBeep = true;
            this.textBoxY2.Size = new System.Drawing.Size(249, 28);
            this.textBoxY2.TabIndex = 4;
            // 
            // textBoxWidth2
            // 
            // 
            // 
            // 
            this.textBoxWidth2.Border.Class = "TextBoxBorder";
            this.textBoxWidth2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxWidth2.Location = new System.Drawing.Point(512, 192);
            this.textBoxWidth2.Name = "textBoxWidth2";
            this.textBoxWidth2.PreventEnterBeep = true;
            this.textBoxWidth2.Size = new System.Drawing.Size(249, 28);
            this.textBoxWidth2.TabIndex = 5;
            // 
            // textBoxHeight2
            // 
            // 
            // 
            // 
            this.textBoxHeight2.Border.Class = "TextBoxBorder";
            this.textBoxHeight2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxHeight2.Location = new System.Drawing.Point(512, 241);
            this.textBoxHeight2.Name = "textBoxHeight2";
            this.textBoxHeight2.PreventEnterBeep = true;
            this.textBoxHeight2.Size = new System.Drawing.Size(249, 28);
            this.textBoxHeight2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxHeight2);
            this.Controls.Add(this.textBoxWidth2);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxY2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxWidth2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxHeight2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

