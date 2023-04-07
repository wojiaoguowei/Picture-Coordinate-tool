using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Rectangle rect = new Rectangle();
        private bool drawing = false;
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            drawing = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                // 获取矩形坐标
                rect.X = Math.Min(startPoint.X, e.X);
                rect.Y = Math.Min(startPoint.Y, e.Y);
                rect.Width = Math.Abs(startPoint.X - e.X);
                rect.Height = Math.Abs(startPoint.Y - e.Y);
                textBoxX1.Text = String.Format("x:  {0}  y: {1}  width: {2} height: {3}", rect.X, rect.Y, rect.Width, rect.Height);
                // 将画布重置为原始图片
                bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bitmap;

                // 在画布上绘制矩形
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawRectangle(Pens.Red, rect);
                }

                pictureBox1.Invalidate();
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;

            // Get the coordinates of the rectangle
            int x = rect.X;
            int y = rect.Y;
            int width = rect.Width;
            int height = rect.Height;

            // Create a new image with the same dimensions as the rectangle
            Bitmap croppedImage = new Bitmap(new Bitmap(@"D:\work\develop\杨铭交接\MAX-100上位机交接资料\右侧模块图片\right\MAX100-XT-AI2 AO1.png"), width, height);
            // Copy the contents of the rectangle from the original image to the new image
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(pictureBox1.Image, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
            }

            // Set the new image as the image of a PictureBox
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newPictureBox.Location = new Point(x, y);
            newPictureBox.Size = new Size(width, height);
            newPictureBox.Image = croppedImage;

            // Add the new PictureBox to the form
            pictureBox1.Controls.Add(newPictureBox);
        }
    }
}
