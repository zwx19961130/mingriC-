using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cachet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Font Var_Font = new Font("Arial", 12, FontStyle.Bold);

        Rectangle rect = new Rectangle(10, 10, 160, 160);

        private void button1_Click(object sender, EventArgs e)
        {
            int tem_Line = 0;
            int circularity_W = 4;

            if (panel1.Width >= panel1.Height)
            {
                tem_Line = panel1.Height;
            }
            else
            {
                tem_Line = panel1.Width;
            }

           

            rect = new Rectangle(circularity_W, circularity_W, tem_Line - circularity_W * 2, tem_Line - circularity_W * 2);

            Font star_Font = new Font("Arial", 30, FontStyle.Regular);

            string star_Str = "❤";

            Graphics g = this.panel1.CreateGraphics();

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.Clear(Color.Yellow);

            Pen myPen = new Pen(Color.Red, circularity_W);

            g.DrawEllipse(myPen, rect);

            SizeF Var_Size = new SizeF(rect.Width, rect.Width);

            Var_Size = g.MeasureString(star_Str, star_Font);

            g.DrawString(star_Str, star_Font, myPen.Brush, new PointF((rect.Width / 2F) + circularity_W - Var_Size.Width / 2F, rect.Height / 2F - Var_Size.Width / 2F));

            Var_Size = g.MeasureString("专用章", Var_Font);

            g.DrawString("专用章", Var_Font, myPen.Brush, new PointF((rect.Width / 2F) + circularity_W - Var_Size.Width / 2F, rect.Height / 2F + Var_Size.Height * 2));

            string tempStr = "吉林减肥急哦发生的适当方式呢";

            int len = tempStr.Length;

            float angle = 180 + (180 - len * 20) / 2;

            for (int i = 0; i < len; i++) {
                
                g.TranslateTransform((tem_Line + circularity_W / 2) / 2, (tem_Line + circularity_W / 2) / 2);

                g.RotateTransform(angle);

                Brush myBrush = Brushes.Red;

                g.DrawString(tempStr.Substring(i, 1), Var_Font, myBrush, 60, 0);

                angle += 20;
            }
        }
    }
}
