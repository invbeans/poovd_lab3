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
        public barCharts()
        {
            InitializeComponent();
        }

        // иксы и какие в них графики
        public barCharts(ByteImage image, Bitmap img, int vertX, int horixY)
        {
            InitializeComponent();
            this.image = image;
            this.img = img;
            this.vertX = vertX;
            this.horizY = horixY;
            this.allImage = image.brightAmounts;
    
            brightChart.Series[0].Points.DataBindY(allImage);
        }

        private void гистограммаГоризонтальногоСеченияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            horizontal = new ushort[img.Width];
            for(int i = 0; i < horizontal.Length; i++)
            {
                horizontal[i] = img.GetPixel(i, horizY).B;
            }
            brightChart.Series[0].Points.DataBindY(horizontal);
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
            brightChart.Series[0].Points.DataBindY(vertical);
            changeLeft.Visible = false;
            changeRight.Visible = false;
        }

        private void гистограммыСечениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brightChart.Series[0].Points.DataBindY(allImage);
            changeLeft.Visible = true;
            changeRight.Visible = true;
        }


       
    }
}
