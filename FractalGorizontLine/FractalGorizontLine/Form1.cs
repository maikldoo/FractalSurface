using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Collections;

namespace FractalGorizontLine
{
    public partial class Landscape : Form
    {
        Random rnd = new Random();

        private PointF[] PointArray = new PointF[4097];

        private PointF first = new PointF(0, 0);
        private PointF second = new PointF(0, 0);

        private float roughness = 1f;

        private int level = 12;

        int terriaType = 0;
        
        public Landscape()
        {
            InitializeComponent();
        }

        private void Landscape_Load(object sender, EventArgs e)
        {

        }

        private void DrawGasket()
        {
            Bitmap bm = new Bitmap(
                LandscapePictureBox.Width,
                LandscapePictureBox.Height);
            Graphics gr = Graphics.FromImage(bm);

            ModeGraph(gr);

            DrawLandscape(gr, level);

            // Display the result.
            LandscapePictureBox.Image = bm;

            // Save the bitmap into a file.
            bm.Save("Landscape " + roughness + ".bmp");
        }

        private void DrawLandscape(Graphics gr, int level)
        {
            float displace = 0;

            if (terriaType == 0)
            {
                displace = LandscapePictureBox.Height / 5;

                int power = Convert.ToInt32(Math.Pow(2, level));

                displace *= roughness;

                for (int i = 1; i < power; i *= 2)
                {
                    for (int j = (power / i) / 2; j < power; j += power / i)
                    {
                        PointArray[j].X = (PointArray[j - (power / i) / 2].X + PointArray[j + (power / i) / 2].X) / 2;
                        PointArray[j].Y = (PointArray[j - (power / i) / 2].Y + PointArray[j + (power / i) / 2].Y) / 2;
                        PointArray[j].Y += Rand() * displace;
                    }
                    displace *= roughness;
                }

                List<PointF> Points = PointArray.ToList();
                Points.Add(new PointF(LandscapePictureBox.Width, -2 * LandscapePictureBox.Height));
                Points.Add(new PointF(0, -2 * LandscapePictureBox.Height));

                PointArray = Points.ToArray();



                gr.FillPolygon(Brushes.Green, PointArray);
            }
            else
            {
                int power = Convert.ToInt32(Math.Pow(2, level));

                for (int i = 1; i < power; i *= 2)
                {
                    for (int j = (power / i) / 2; j < power; j += power / i)
                    {
                        PointArray[j].X = (PointArray[j - (power / i) / 2].X + PointArray[j + (power / i) / 2].X) / 2;
                        PointArray[j].Y = (PointArray[j - (power / i) / 2].Y + PointArray[j + (power / i) / 2].Y) / 2;
                        PointArray[j].Y += Rand() * (PointArray[j + (power / i) / 2].X - PointArray[j - (power / i) / 2].X) * roughness;
                    }
                }

                List<PointF> Points = PointArray.ToList();
                Points.Add(new PointF(LandscapePictureBox.Width, -2 * LandscapePictureBox.Height));
                Points.Add(new PointF(0, -2 * LandscapePictureBox.Height));

                PointArray = Points.ToArray();



                gr.FillPolygon(Brushes.Green, PointArray);
            }


            
        }

        private float MinMaxY(int mode)
        {
            float returnNumer = PointArray[0].Y;
            for (int i = 0; i < 4097; i++)
            {
                if (returnNumer > PointArray[i].Y && mode == 0)
                {
                    returnNumer = PointArray[i].Y;
                    continue;
                }
                if (returnNumer < PointArray[i].Y && mode == 1)
                {
                    returnNumer = PointArray[i].Y;
                }
            }
            return returnNumer;
        }

        private int Rand()
        {
            return rnd.Next(-1, 1) == 0 ? 1 : -1;
        }

        private void ScanData()
        {
            CheckAndScanRoughness();
            first = new PointF(Convert.ToSingle(point1x_textbox.Text), Convert.ToSingle(point1y_textbox.Text));
            second = new PointF(Convert.ToSingle(point2x_textbox.Text), Convert.ToSingle(point2y_textbox.Text));
            PointArray[0] = first;
            PointArray[4096] = second;
            if (textBox1.Text == "hills" || textBox1.Text == "peaks")
            {
                if (textBox1.Text == "hills")
                    terriaType = 0;
                else
                    terriaType = 1;
            }
            else
            {
                MessageBox.Show("Нужно указать один из возможных типов местности.");
            }
        }

        private void CheckAndScanRoughness()
        {
            if (roughness_textbox.Text == String.Empty)
            {
                MessageBox.Show("Нужно задать параметр шероховатости.");
            }
            else
            {
                roughness = Convert.ToSingle(roughness_textbox.Text);
            }
        }

        private void ModeGraph(Graphics gr)
        {
            gr.Clear(Color.White);
            gr.TranslateTransform(0, LandscapePictureBox.Height - 200);
            gr.ScaleTransform(1, -1);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void Paint_Click(object sender, EventArgs e)
        {
            ScanData();
            DrawGasket();
        }

    }
}
