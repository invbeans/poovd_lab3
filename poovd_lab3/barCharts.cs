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
        ushort[] allImage = new ushort[256];
        bool moveLeft = false;
        bool moveRight = false;
        public event Action<ushort, ushort, ushort, ushort, bool> ChangeRange;
        public event Action CloseCharts;
        ushort newLeft; ushort newRight;
        bool normalize = false;
        ushort leftX = 0; ushort rightX = 255;
        int range = -1;
        bool keepR = false;

        public BarCharts()
        {
            InitializeComponent();
            brightChart.MouseDown += brightChart_MouseDown;
            brightChart.MouseUp += BrightChart_MouseUp;
            brightChart.MouseMove += BrightChart_MouseMove;
            leftOptions.SelectedIndex = 1;
            rightOptions.SelectedIndex = 1;
            brightChart.Series[0].Points.Clear();
        }

        public BarCharts(Form1 parent): this()
        {
            this.parent = parent;
            parent.RedrawImage += RedrawImage;
            this.allImage = parent.image.brightAmounts;
            brightChart.Series[0].Points.DataBindY(allImage);
        }

        private void brightChart_MouseDown(object sender, MouseEventArgs e)
        {
            int X = (int)brightChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            if(X >= 0 && X < 256)
            {
                int rightX = (int)brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset;
                int leftX = (int)brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset;
                if (X >= rightX - 3 && X <= rightX + 3 && !moveLeft)
                {
                    moveRight = true;
                }
                if (X >= leftX - 3 && X <= leftX + 3 && !moveRight)
                {
                    moveLeft = true;
                }
            }
        }

        private void MoveBothStripLines(int X)
        {
            if (moveLeft)
            {
                int temp = X + range;
                rightX = (ushort)((temp < 256) ? temp : 255);
                brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = rightX;
                rightBright.Text = rightX.ToString();

                leftX = (ushort)((temp < 256) ? X : 255 - range);
                brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = leftX;
                leftBright.Text = leftX.ToString();
            }
            if (moveRight)
            {
                int temp = X - range;
                leftX = (ushort)((temp > -1) ? temp : 0);
                brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = leftX;
                leftBright.Text = leftX.ToString();

                rightX = (ushort)((temp > -1) ? X : range);
                brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = rightX;
                rightBright.Text = rightX.ToString();
            }
        }

        private void BrightChart_MouseMove(object sender, MouseEventArgs e)
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
                    if (keepR) MoveBothStripLines(X);
                    else
                    {
                        if (leftX > X - 5)
                        {
                            moveRight = false;
                            return;
                        }
                        brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = X;
                        rightX = (ushort)X;
                        rightBright.Text = X.ToString();
                    }                    
                }
                if (moveLeft)
                {
                    if (keepR) MoveBothStripLines(X);
                    else
                    {
                        if (rightX < X + 5)
                        {
                            moveLeft = false;
                            return;
                        }
                        brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = X;
                        leftX = (ushort)X;
                        leftBright.Text = X.ToString();
                    }
                }
            }
            else // подъёбка
            {
                if (moveLeft) moveLeft = false;
                if (moveRight) moveRight = false;
            }
        }

        private void BrightChart_MouseUp(object sender, MouseEventArgs e)
        {
            int X = -1;
            try
            {
                X = (int)brightChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            }
            catch (Exception)
            {
                return;
            }

            if (X >= 0 && X < 256)
            {
                if (moveRight) moveRight = false;
                if (moveLeft) moveLeft = false;
                ChangeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
            }
        }

        private void RedrawImage()
        {
            ChangeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
        }

        private void leftOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            ChangeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
        }

        private void rightOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            ChangeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
        }

        private void keepRange_CheckedChanged(object sender, EventArgs e)
        {
            range = rightX - leftX;
            keepR = !keepR;
        }

        private void BarCharts_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCharts?.Invoke();
        }
    }
}
