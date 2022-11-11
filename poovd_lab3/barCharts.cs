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
        //parent - переменная, хранящая в себе объект класса основной формы
        Form1 parent;

        //brightsAmounts - массив, хранящий количество пикселей с яркостями, соответствующими индексу в массиве
        ushort[] brightsAmounts = new ushort[256];
        
        //флаги для проверки движения движков
        bool moveLeft = false, moveRight = false;

        //ChangeRange - событие изменения диапазона, выделенного на гистаграмме
        public event Action<ushort, ushort, ushort, ushort, bool> ChangeRange;

        //CloseCharts - событие закрытия дополнительного окна
        public event Action CloseCharts;

        //переменные, в которых хранятся новые значения яркостей за пределами выделенного диапазона
        ushort newLeft; ushort newRight;

        //normalize - флаг, будет ли проводиться нормирование яркостей
        bool normalize = false;
        
        //переменные, в которых хранятся текущие границы диапазона
        ushort leftX = 0; ushort rightX = 255;

        //расстояние между границами диапазона в количестве яркостей, изначально не задано
        int range = -1;

        //keepR - флаг, фиксируются ли движки
        bool keepR = false;

        //конструктор формы с инициализацией и подключением объектов и обработчиков событий
        public BarCharts()
        {
            InitializeComponent();
            brightChart.MouseDown += BrightChart_MouseDown;
            brightChart.MouseUp += BrightChart_MouseUp;
            brightChart.MouseMove += BrightChart_MouseMove;
            leftOptions.SelectedIndex = 1;
            rightOptions.SelectedIndex = 1;
            brightChart.Series[0].Points.Clear();
        }

        //конструктор формы, принимающий объект основного окна
        public BarCharts(Form1 parent): this()
        {
            this.parent = parent;
            //к событию класса Form1 подписывается метод этого класса
            parent.RedrawImage += RedrawImage;
            //яркости изображения получаются из поля image класса ByteImage
            this.brightsAmounts = parent.image.brightAmounts;
            brightChart.Series[0].Points.DataBindY(brightsAmounts);
        }

        //обработчик нажатия на гистограмму
        //проверяет, находится ли точка нажатия рядом с одним из движков и присваивает
        //соответствующему флагу true, если движок выбран
        //параметр sender - объект, вызвавший событие (гистограмма brightChart)
        //параметр e - объект, содержащий данные о событии 
        private void BrightChart_MouseDown(object sender, MouseEventArgs e)
        {
            int X = (int)brightChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            //если координата клика в допустимых пределах яркости для изображения (внутри гистограммы)
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

        //метод для перемещения обоих движков, когда они зафиксированы относительно друг друга
        //принимает переменную X - координата X точки нажатия на гистограмме
        private void MoveBothStripLines(int X)
        {
            if (moveLeft)
            {
                //переменная с предполагаемым положением правого движка
                int temp = X + range;
                //если temp превосходит предельное значение яркости, то правому движку присваивается 255
                rightX = (ushort)((temp < 256) ? temp : 255);
                brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = rightX;
                rightBright.Text = rightX.ToString();
                //левый движок остается на расстоянии range от правого
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

        //обработчик движения курсора по гистограмме
        //управляет перемещением движков, выделенных ранее в обработчике события MouseDown
        //параметр sender - объект, вызвавший событие (гистограмма brightChart)
        //параметр e - объект, содержащий данные о событии
        private void BrightChart_MouseMove(object sender, MouseEventArgs e)
        {
            int X = -1;
            //проверка корректности координаты X - в пределах гистограммы
            try
            {
                X = (int)brightChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            }
            //в случае выхода за пределы гистограммы
            catch (Exception)
            {
                if (moveLeft)
                {
                    //присваивается значение, соответствующее выходу за границы гистограммы
                    X = -1;
                    //движок останавливается в крайнем положении
                    brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = 0;
                    leftBright.Text = "0";
                    //остановка перемещения левого движка
                    moveLeft = false;
                }
                if (moveRight)
                {
                    //присваивается значение, соответствующее выходу за границы гистограммы
                    X = 256;
                    brightChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = 255;
                    rightBright.Text = "255";
                    moveRight = false;
                }
            }
            if (X >= 0 && X < 256)
            {
                if (moveLeft)
                {
                    //если выбрана фиксация движков, изменятся положения обоих движков
                    if (keepR) MoveBothStripLines(X);
                    else
                    {
                        //проверка на возможность наложения движков друг на друга
                        if (rightX < X + 5)
                        {
                            //перемещение движка прекращается
                            moveLeft = false;
                            return;
                        }
                        brightChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = X;
                        leftX = (ushort)X;
                        leftBright.Text = X.ToString();
                    }
                }
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
            }
            //если ранее был выход за границы гистограммы, движки останавливаются
            else
            {
                if (moveLeft) moveLeft = false;
                if (moveRight) moveRight = false;
            }
        }

        //обработчик поднятия кнопки мыши над гистограммой
        //проверяет, находится ли курсор в этот момент в допустимом диапазоне и
        //вызывает событие изменения диапазона
        //параметр sender - объект, вызвавший событие (гистограмма brightChart)
        //параметр e - объект, содержащий данные о событии
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
                //движки останавливаются
                if (moveRight) moveRight = false;
                if (moveLeft) moveLeft = false;
                //вызывается событие изменения диапазона и яркостей
                ChangeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
            }
        }

        //метод для перерисовки изображения, вызываемый из Form1
        //передает текущие границы диапазона, новые яркости и флаг в метод класса Form1
        private void RedrawImage()
        {
            ChangeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
        }

        //обработчик изменения выбранного элемента в комбобоксе для левого движка
        //изменяет величину newLeft и переменную normalize, если необходимо
        //при выборе 4 варианта также изменяет значение в комбобоксе для правого движка
        //параметр sender - объект, вызвавший событие (комбобокс leftOptions)
        //параметр e - объект, содержащий данные о событии
        private void LeftOptions_SelectedIndexChanged(object sender, EventArgs e)
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
            //вызывает событие изменения диапазона и яркостей
            ChangeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
        }

        //обработчик изменения выбранного элемента в комбобоксе для правого движка
        //изменяет величину newRight и переменную normalize, если необходимо
        //при выборе 4 варианта также изменяет значение в комбобоксе для левого движка
        //параметр sender - объект, вызвавший событие (комбобокс rightOptions)
        //параметр e - объект, содержащий данные о событии
        private void RightOptions_SelectedIndexChanged(object sender, EventArgs e)
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
            //вызывает событие изменения диапазона и яркостей
            ChangeRange?.Invoke(leftX, rightX, newLeft, newRight, normalize);
        }

        //обработчик нажатия на чекбокс фиксации движков
        //рассчитывает текущее расстояние между движками и меняет флаг
        //параметр sender - объект, вызвавший событие (чекбокс keepRange)
        //параметр e - объект, содержащий данные о событии 
        private void KeepRange_CheckedChanged(object sender, EventArgs e)
        {
            range = rightX - leftX;
            keepR = !keepR;
        }

        //обработчик, вызывающий событие из класса Form1 при закрытии этого окна
        //параметр sender - объект, вызвавший событие (форма barCharts)
        //параметр e - объект, содержащий данные о событии 
        private void BarCharts_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCharts?.Invoke();
        }
    }
}
