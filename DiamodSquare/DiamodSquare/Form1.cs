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

namespace DiamodSquare
{
    public partial class Landscape : Form
    {
        private Random rnd = new Random();

        private float[,] PointArray = new float[1025, 1025];

        private float first = 0;
        private float second = 0;
        private float third = 0;
        private float fourth = 0;

        private float roughness = 1f;

        private int Rand()
        {
            return rnd.Next(-1, 1) == 0 ? 1 : -1;
        }

        public Landscape()
        {
            InitializeComponent();
            for (int i = 0; i < 1025; i++)
            {
                PointArray[i, i] = 0;
            }
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

            DrawTerrain(gr, bm);

            // Display the result.
            LandscapePictureBox.Image = bm;

            // Save the bitmap into a file.
            bm.Save("Landscape " + roughness + ".bmp");
        }

        private void DrawTerrain(Graphics gr, Bitmap bm)
        {
            int randomness = 2048;
            int tileWidth = 1024;

            while (tileWidth > 1)
            {
                int halfSide = tileWidth / 2;

                for (int x = 0; x < 1024; x += tileWidth)
                {
                    for (int y = 0; y < 1024; y += tileWidth)
                    {
                        float cornerSum = PointArray[x, y] +
                            PointArray[x + tileWidth, y] +
                            PointArray[x, y + tileWidth] +
                            PointArray[x + tileWidth, y + tileWidth];

                        float avg = cornerSum / 4;
                        avg += rnd.Next(-randomness, randomness) * roughness;

                        PointArray[x + halfSide, y + halfSide] = avg;
                    }
                }

                for (int x = 0; x < 1024; x += halfSide)
                {
                    for (int y = (x + halfSide) % tileWidth; y < 1024; y += tileWidth)
                    {
                        float avg = 
                            PointArray[(x - halfSide + 1024) % 1024, y] +
                            PointArray[(x + halfSide) % 1024, y] +
                            PointArray[x, (y + halfSide) % 1024] +
                            PointArray[x, (y - halfSide + 1024) % 1024];

                        avg /= 4;
                        avg += rnd.Next(-randomness, randomness) * roughness;

                        PointArray[x, y] = avg;

                        if (x == 0)
                            PointArray[1024, y] = avg;
                        if (y == 0)
                            PointArray[x, 1024] = avg;
                    }
                }

                randomness = Math.Max(randomness / 2, 1);
                tileWidth /= 2;
            }

            int minH = Convert.ToInt32(Math.Ceiling(MinMaxH(0)));
            int maxH = Convert.ToInt32(Math.Ceiling(MinMaxH(1))) - minH;
            for (int i = 0; i < 1025; i++)
            {
                for (int k = 0; k < 1025; k++)
                {
                    bool waterLine = false;
                    float H = 0;

                    if (PointArray[i, k] <= 0)
                        waterLine = true;
                    else
                        waterLine = false;

                    H = PointArray[i, k];

                    PointArray[i, k] -= minH;
                    PointArray[i, k] /= maxH;
                    PointArray[i, k] *= 255;
                    int colorus = Convert.ToInt32(Math.Ceiling(PointArray[i, k]));

                    Color bbb;
                    if (waterLine)
                    {
                        colorus = Math.Abs(colorus);
                        bbb = Color.FromArgb(255 - (colorus/2), 0, 0, colorus);
                    }
                    else
                        bbb = Color.FromArgb(colorus / 2, 255 - colorus, 0);

                    bm.SetPixel(i, k, bbb);
                }
            }

            for (int i = 0; i < 1025; i++)
            {
                for (int k = 0; k < 1025; k++)
                {
                    PointArray[i, k] = 0;
                }
            }
        }

        private float MinMaxH(int mode)
        {
            float returnNumer = PointArray[0,0];
            for (int i = 0; i < 1025; i++)
            {
                for (int k = 0; k < 1025; k++)
                {
                    // 0 - min
                    if (returnNumer > PointArray[i, k] && mode == 0)
                    {
                        returnNumer = PointArray[i, k];
                        continue;
                    }
                    // 1 - max
                    if (returnNumer < PointArray[i, k] && mode == 1)
                    {
                        returnNumer = PointArray[i, k];
                        continue;
                    }
                }
            }
            return returnNumer;
        }

        private void ScanData()
        {
            CheckAndScanRoughness();
            first = Convert.ToSingle(height1_textbox.Text);
            second = Convert.ToSingle(height2_textbox.Text);
            third = Convert.ToSingle(height3_textbox.Text);
            fourth = Convert.ToSingle(height4_textbox.Text);
            PointArray[0, 0] = first;
            PointArray[0, 1024] = second;
            PointArray[1024, 0] = third;
            PointArray[1024, 1024] = fourth;
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