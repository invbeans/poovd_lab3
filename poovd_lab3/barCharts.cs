using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace poovd_lab3
{
    public partial class barCharts : Form
    {
        ByteImage image;
        ushort[] vertical;
        ushort[] horizontal;
        ushort[] allImage = new ushort[256];
        Bitmap img;
        int vertX;
        int horizY;
        bool moveLeft = false;
        bool moveRight = false;
        public barCharts()
        {
            InitializeComponent();
            brightChart.MouseDown += brightChart_MouseDown;
            brightChart.MouseUp += brightChart_MouseUp;
        }

        // иксы и какие в них графики
        public barCharts(ByteImage image, Bitmap img, int vertX, int horixY): this()
        {
            this.image = image;
            this.img = img;
            this.vertX = vertX;
            this.horizY = horixY;
            this.allImage = image.brightAmounts;
            brightChart.Series[0].Points.DataBindY(allImage);
            vertChart.Visible = false;
            horizChart.Visible = false;
        }

        private void гистограммаГоризонтальногоСеченияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            horizontal = new ushort[img.Width];
            for(int i = 0; i < horizontal.Length; i++)
            {
                horizontal[i] = img.GetPixel(i, horizY).B;
            }
            horizChart.Series[0].Points.DataBindY(horizontal);
            horizChart.Visible = true;
            brightChart.Visible = false;
            vertChart.Visible = false;
            changeLeft.Visible = false;
            changeRight.Visible = false;
        }

        private void гистограммаВертикальногоСеченияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vertical = new ushort[img.Height];
            for (int i = 0; i < vertical.Length; i++)
            {
                vertical[i] = img.GetPixel(vertX, i).B;
            }
            vertChart.Series[0].Points.DataBindY(vertical);
            vertChart.Visible = true;
            brightChart.Visible = false;
            horizChart.Visible = false;
            changeLeft.Visible = false;
            changeRight.Visible = false;
        }

        private void гистограммыСечениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // правый 0-ая стриплин, левый 1-ый стриплин зазазазахпхп
            brightChart.Series[0].Points.DataBindY(allImage);
            brightChart.Visible = true;
            horizChart.Visible = false;
            vertChart.Visible = false; 
            changeLeft.Visible = true;
            changeRight.Visible = true;
        }

        private void brightChart_MouseDown(object sender, MouseEventArgs e)
        {
            int X = (int)brightChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            if(X >= 0 && X < 256)
            {
                int rightX = (int)brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset;
                int leftX = (int)brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset;
                if (X >= rightX - 3 && X <= rightX + 3)
                {
                    moveRight = true;
                }
                if (X >= leftX - 3 && X <= leftX + 3)
                {
                    moveLeft = true;
                }
            }
        }

        private void brightChart_MouseUp(object sender, MouseEventArgs e)
        {
            int X = (int)brightChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            if (moveRight)
            {
                brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = X;
                moveRight = false;
            }
            if (moveLeft)
            {
                brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = X;
                moveLeft = false;
            }
        }

    }
}
