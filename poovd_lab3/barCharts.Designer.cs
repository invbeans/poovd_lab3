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
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.brightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.гистограммыСечениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаВертикальногоСеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLeft = new System.Windows.Forms.GroupBox();
            this.leftOptions = new System.Windows.Forms.ComboBox();
            this.changeRight = new System.Windows.Forms.GroupBox();
            this.rightOptions = new System.Windows.Forms.ComboBox();
            this.horizChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vertChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.brightChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.changeLeft.SuspendLayout();
            this.changeRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertChart)).BeginInit();
            this.SuspendLayout();
            // 
            // brightChart
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            stripLine1.BackColor = System.Drawing.Color.Maroon;
            stripLine1.IntervalOffset = 245D;
            stripLine1.StripWidth = 1D;
            stripLine2.BackColor = System.Drawing.Color.Green;
            stripLine2.IntervalOffset = 10D;
            stripLine2.StripWidth = 1D;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX.StripLines.Add(stripLine2);
            chartArea1.Name = "ChartArea1";
            this.brightChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.brightChart.Legends.Add(legend1);
            this.brightChart.Location = new System.Drawing.Point(77, 80);
            this.brightChart.Name = "brightChart";
            this.brightChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
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
            this.leftOptions.Size = new System.Drawing.Size(348, 24);
            this.leftOptions.TabIndex = 2;
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
            this.rightOptions.Size = new System.Drawing.Size(332, 24);
            this.rightOptions.TabIndex = 0;
            // 
            // horizChart
            // 
            chartArea2.Name = "ChartArea1";
            this.horizChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.horizChart.Legends.Add(legend2);
            this.horizChart.Location = new System.Drawing.Point(77, 80);
            this.horizChart.Name = "horizChart";
            this.horizChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.horizChart.Series.Add(series2);
            this.horizChart.Size = new System.Drawing.Size(743, 519);
            this.horizChart.TabIndex = 4;
            this.horizChart.Text = "chart1";
            // 
            // vertChart
            // 
            chartArea3.Name = "ChartArea1";
            this.vertChart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.vertChart.Legends.Add(legend3);
            this.vertChart.Location = new System.Drawing.Point(77, 80);
            this.vertChart.Name = "vertChart";
            this.vertChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.vertChart.Series.Add(series3);
            this.vertChart.Size = new System.Drawing.Size(743, 519);
            this.vertChart.TabIndex = 5;
            this.vertChart.Text = "chart1";
            // 
            // barCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 731);
            this.Controls.Add(this.vertChart);
            this.Controls.Add(this.horizChart);
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
            ((System.ComponentModel.ISupportInitialize)(this.horizChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertChart)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart horizChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart vertChart;
    }
}