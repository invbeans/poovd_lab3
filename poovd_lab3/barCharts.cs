using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace poovd_lab3
{
    public partial class BarCharts : Form
    {
        Form1 parent;
        ushort[] vertical;
        ushort[] horizontal;
        ushort[] allImage = new ushort[256];
        Bitmap img;
        int vertX;
        int horizY;
        bool moveLeft = false;
        bool moveRight = false;
        public event Action<ushort, ushort, ushort, ushort, bool> changeRange;
        public event Action closeCharts;
        ushort newLeft; ushort newRight;
        bool normalize = false;
        ushort leftX = 0; ushort rightX = 255;
        int range = -1;
        bool keepR = false;

        public BarCharts()
        {
            InitializeComponent();
            brightChart.MouseDown += brightChart_MouseDown;
            brightChart.MouseUp += brightChart_MouseUp;
            brightChart.MouseMove += brightChart_MouseMove;
            leftOptions.SelectedIndex = 1;
            rightOptions.SelectedIndex = 1;
            brightChart.Series[0].Points.Clear();
        }

        public BarCharts(Form1 parent): this()
        {
            this.parent = parent;
            this.img = parent.img;
            this.vertX = parent.vertX;
            this.horizY = parent.horizY;   
            this.allImage = parent.image.brightAmounts;
            brightChart.Series[0].Points.DataBindY(allImage);
            vertChart.Visible = false;
            horizChart.Visible = false;
        }

        // иксы и какие в них графики
        public BarCharts(Form1 parent, ushort[] brightAmounts, Bitmap img, int vertX, int horixY): this()
        {
            this.parent = parent;
            this.img = img;
            this.vertX = vertX;
            this.horizY = horixY;
            this.allImage = brightAmounts;
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
            keepRange.Visible = false;
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
            keepRange.Visible = false;
            horizChart.Visible = false;
            changeLeft.Visible = false;
            changeRight.Visible = false;
        }

        private void гистограммыСечениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // правый 0-ая стриплин, левый 1-ый стриплин зазазазахпхп
            brightChart.Series[0].Points.DataBindY(allImage);
            brightChart.Visible = true;
            keepRange.Visible = true;
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
                if (X >= leftX - 3 && X <= leftX + 3 && !moveRight) //может начать падать об одновременное движение
                {
                    moveLeft = true;
                }
            }
        }

        private void moveBothStripLines(bool moveLeft, bool moveRight, int X)
        {
            if (moveLeft)
            {
                int temp = X + range;
                brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = (temp < 256) ? temp : 255;
            }
            if (moveRight)
            {
                int temp = X - range;
                brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = (temp > -1) ? temp : 0;
            }
        }

        private void brightChart_MouseMove(object sender, MouseEventArgs e)
        {
            int X = -1;
            try
            {
                X = (int)brightChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            }
            catch (Exception)
            {
                if (moveLeft)
                {
                    X = -1; // ведет к подъёбке
                    brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = 0;
                    leftBright.Text = "0";
                    moveLeft = false;
                }
                if (moveRight)
                {
                    X = 256; // тоже ведет к подъёбке
                    brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = 255;
                    rightBright.Text = "255";
                    moveRight = false;
                }
            }
            if (X >= 0 && X < 256)
            {
                if (moveRight)
                {
                    if (leftX > X - 5) moveRight = false;
                    if (keepR) moveBothStripLines(moveLeft, moveRight, X);
                    brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = X;
                    rightX = (ushort)X;
                    rightBright.Text = X.ToString();
                }
                if (moveLeft)
                {
                    if(rightX < X + 5) moveLeft = false;
                    if (keepR) moveBothStripLines(moveLeft, moveRight, X);
                    brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = X;
                    leftX = (ushort)X;
                    leftBright.Text = X.ToString();
                }
            }
            else // подъёбка
            {
                if (moveLeft) moveLeft = false;
                if (moveRight) moveRight = false;
            }
            
        }

        private void brightChart_MouseUp(object sender, MouseEventArgs e)
        {
            int X = -1;
            try
            {
                X = (int)brightChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            }
            catch (Exception)
            {
                return; //????
            }
            
            if (X >= 0 && X < 256)
            {
                if (moveRight)
                {
                    brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = X;
                    rightX = (ushort)X;
                    rightBright.Text = X.ToString();
                    moveRight = false;
                }
                if (moveLeft)
                {
                    brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = X;
                    leftX = (ushort)X;
                    leftBright.Text = X.ToString();
                    moveLeft = false;
                }
                changeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
            }
        }

        private void leftOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Считать равными L
Считать равными минимальному значению 0
Считать равными 0
Отображать в диапазон [0, 255]*/
            normalize = false;
            switch (leftOptions.SelectedIndex)
            {
                case 0:
                    {
                        newLeft = leftX;
                    }
                    break;
                case 1:
                    {
                        newLeft = 0;
                    }
                    break;
                case 2:
                    {
                        newLeft = 0;
                    }
                    break;
                case 3:
                    {
                        newLeft = 0;
                        rightOptions.SelectedIndex = 3;
                        normalize = true;
                    }
                    break;
            }
            changeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
        }

        private void rightOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Считать равными R
Считать равными максимальному значению 255
Считать равными 0
Отображать в диапазон [0, 255]*/
            normalize = false;
            switch (rightOptions.SelectedIndex)
            {
                case 0:
                    {
                        newRight = rightX;
                    }
                    break;
                case 1:
                    {
                        newRight = 255;
                    }
                    break;
                case 2:
                    {
                        newRight = 0;
                    }
                    break;
                case 3:
                    {
                        newRight = 255;
                        leftOptions.SelectedIndex = 3; 
                        normalize = true;
                    }
                    break;
            }
            changeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
        }

        private void keepRange_CheckedChanged(object sender, EventArgs e)
        {
            range = rightX - leftX;
            keepR = !keepR;
        }

        private void BarCharts_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeCharts?.Invoke();
        }
    }
}
