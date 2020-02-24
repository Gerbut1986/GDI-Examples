using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifty_Squares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Clear_PictureBox()
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
        }

        void ColorSquares()
        {
            Clear_PictureBox(); // Сначала очищаем рictureBox
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            pictureBox.Image = bitmap;
            Pen pen = new Pen(Color.Black);

            float x1 = pictureBox.Width / 10;
            float y1 = pictureBox.Height / 10;
            float width = pictureBox.Width - (2 * x1);
            float height = pictureBox.Height - (2 * y1);
            float x2 = x1 + width;
            float y2 = y1;
            float x3 = x2;
            float y3 = y2 + height;
            float x4 = x1;
            float y4 = y3;
            float p = 0.08f;
            graphics.DrawRectangle(pen, x1, y1, width, height);
            for (int i = 0; i < 50; i++) // В цикле, когда рисуем все 50 квадратов
            {
                if (i % 2 == 0)   // ..делаем проверку, если переменная цикла "і" парная(тоесть делиться по модулю на 2, и нету остачи)
                    pen = new Pen(Color.DarkGoldenrod); // ..то устанавливаем перо в какой то цвет, и отрисовываем ним квадрат
                else pen = new Pen(Color.Blue);         // Иначе(если не парная переменная цикла) , устанавливаем перо в другой цвет
                x1 = x1 + (x2 - x1) * p;
                x2 = x2 + (x3 - x2) * p;
                x3 = x3 + (x4 - x3) * p;
                x4 = x4 + (x1 - x4) * p;
                y1 = y1 + (y2 - y1) * p;
                y2 = y2 + (y3 - y2) * p;
                y3 = y3 + (y4 - y3) * p;
                y4 = y4 + (y1 - y4) * p;

                // Отрисовываем каждую сторону квадрата, по указаным координатам:
                graphics.DrawLine(pen, x1, y1, x2, y2);
                graphics.DrawLine(pen, x2, y2, x3, y3);
                graphics.DrawLine(pen, x1, y1, x4, y4);
                graphics.DrawLine(pen, x4, y4, x3, y3);
            }
        }
        private void drawBtn_Click(object sender, EventArgs e)
        {

        }

        private void colorBtn_Click(object sender, EventArgs e)
        {

        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
