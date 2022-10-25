namespace poovd_lab3
{
    partial class barCharts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.brightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.гистограммыСечениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаВертикальногоСеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLeft = new System.Windows.Forms.GroupBox();
            this.changeRight = new System.Windows.Forms.GroupBox();
            this.rightOptions = new System.Windows.Forms.ComboBox();
            this.leftOptions = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.brightChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.changeLeft.SuspendLayout();
            this.changeRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightChart
            // 
            chartArea1.Name = "ChartArea1";
            this.brightChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.brightChart.Legends.Add(legend1);
            this.brightChart.Location = new System.Drawing.Point(77, 80);
            this.brightChart.Name = "brightChart";
            this.brightChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.brightChart.Series.Add(series1);
            this.brightChart.Size = new System.Drawing.Size(743, 519);
            this.brightChart.TabIndex = 0;
            this.brightChart.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гистограммыСечениToolStripMenuItem,
            this.гистограммаВертикальногоСеченияToolStripMenuItem,
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // гистограммыСечениToolStripMenuItem
            // 
            this.гистограммыСечениToolStripMenuItem.Name = "гистограммыСечениToolStripMenuItem";
            this.гистограммыСечениToolStripMenuItem.Size = new System.Drawing.Size(281, 24);
            this.гистограммыСечениToolStripMenuItem.Text = "Гистограмма яркостей изображения";
            this.гистограммыСечениToolStripMenuItem.Click += new System.EventHandler(this.гистограммыСечениToolStripMenuItem_Click);
            // 
            // гистограммаВертикальногоСеченияToolStripMenuItem
            // 
            this.гистограммаВертикальногоСеченияToolStripMenuItem.Name = "гистограммаВертикальногоСеченияToolStripMenuItem";
            this.гистограммаВертикальногоСеченияToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.гистограммаВертикальногоСеченияToolStripMenuItem.Text = "Гист. вертик. сечения";
            this.гистограммаВертикальногоСеченияToolStripMenuItem.Click += new System.EventHandler(this.гистограммаВертикальногоСеченияToolStripMenuItem_Click);
            // 
            // гистограммаГоризонтальногоСеченияToolStripMenuItem
            // 
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem.Name = "гистограммаГоризонтальногоСеченияToolStripMenuItem";
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem.Text = "Гист. гориз. сечения";
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem.Click += new System.EventHandler(this.гистограммаГоризонтальногоСеченияToolStripMenuItem_Click);
            // 
            // changeLeft
            // 
            this.changeLeft.Controls.Add(this.leftOptions);
            this.changeLeft.Location = new System.Drawing.Point(77, 654);
            this.changeLeft.Name = "changeLeft";
            this.changeLeft.Size = new System.Drawing.Size(370, 77);
            this.changeLeft.TabIndex = 2;
            this.changeLeft.TabStop = false;
            this.changeLeft.Text = "Замена левее движка L";
            // 
            // changeRight
            // 
            this.changeRight.Controls.Add(this.rightOptions);
            this.changeRight.Location = new System.Drawing.Point(450, 654);
            this.changeRight.Name = "changeRight";
            this.changeRight.Size = new System.Drawing.Size(370, 77);
            this.changeRight.TabIndex = 3;
            this.changeRight.TabStop = false;
            this.changeRight.Text = "Замена правее движка R";
            // 
            // rightOptions
            // 
            this.rightOptions.FormattingEnabled = true;
            this.rightOptions.Items.AddRange(new object[] {
            "Считать равными L",
            "Считать равными минимальному значению 0",
            "Считать равными 0",
            "Отображать в диапазон [0, 255]"});
            this.rightOptions.Location = new System.Drawing.Point(17, 35);
            this.rightOptions.Name = "rightOptions";
            this.rightOptions.Size = new System.Drawing.Size(121, 24);
            this.rightOptions.TabIndex = 0;
            // 
            // leftOptions
            // 
            this.leftOptions.FormattingEnabled = true;
            this.leftOptions.Items.AddRange(new object[] {
            "Считать равными R",
            "Считать равными максимальному значению 255",
            "Считать равными 0",
            "Отображать в диапазон [0, 255]"});
            this.leftOptions.Location = new System.Drawing.Point(16, 35);
            this.leftOptions.Name = "leftOptions";
            this.leftOptions.Size = new System.Drawing.Size(121, 24);
            this.leftOptions.TabIndex = 2;
            // 
            // barCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 731);
            this.Controls.Add(this.changeRight);
            this.Controls.Add(this.changeLeft);
            this.Controls.Add(this.brightChart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "barCharts";
            this.Text = "barCharts";
            ((System.ComponentModel.ISupportInitialize)(this.brightChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.changeLeft.ResumeLayout(false);
            this.changeRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart brightChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem гистограммыСечениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаВертикальногоСеченияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаГоризонтальногоСеченияToolStripMenuItem;
        private System.Windows.Forms.GroupBox changeLeft;
        private System.Windows.Forms.GroupBox changeRight;
        private System.Windows.Forms.ComboBox leftOptions;
        private System.Windows.Forms.ComboBox rightOptions;
    }
}