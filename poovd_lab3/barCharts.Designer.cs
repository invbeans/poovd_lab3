namespace poovd_lab3
{
    partial class BarCharts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine7 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine8 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.brightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.гистограммыСечениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаВертикальногоСеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLeft = new System.Windows.Forms.GroupBox();
            this.leftBright = new System.Windows.Forms.Label();
            this.leftOptions = new System.Windows.Forms.ComboBox();
            this.changeRight = new System.Windows.Forms.GroupBox();
            this.rightBright = new System.Windows.Forms.Label();
            this.rightOptions = new System.Windows.Forms.ComboBox();
            this.horizChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vertChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.keepRange = new System.Windows.Forms.CheckBox();
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
            chartArea10.AxisX.Interval = 10D;
            chartArea10.AxisX.IsLabelAutoFit = false;
            stripLine7.BackColor = System.Drawing.Color.Maroon;
            stripLine7.IntervalOffset = 245D;
            stripLine7.StripWidth = 1D;
            stripLine8.BackColor = System.Drawing.Color.Green;
            stripLine8.IntervalOffset = 10D;
            stripLine8.StripWidth = 1D;
            chartArea10.AxisX.StripLines.Add(stripLine7);
            chartArea10.AxisX.StripLines.Add(stripLine8);
            chartArea10.Name = "ChartArea1";
            this.brightChart.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.brightChart.Legends.Add(legend10);
            this.brightChart.Location = new System.Drawing.Point(25, 63);
            this.brightChart.Name = "brightChart";
            this.brightChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.brightChart.Series.Add(series10);
            this.brightChart.Size = new System.Drawing.Size(1059, 536);
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
            this.menuStrip1.Size = new System.Drawing.Size(1155, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // гистограммыСечениToolStripMenuItem
            // 
            this.гистограммыСечениToolStripMenuItem.Name = "гистограммыСечениToolStripMenuItem";
            this.гистограммыСечениToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.гистограммыСечениToolStripMenuItem.Text = "Гистограмма яркостей изображения";
            this.гистограммыСечениToolStripMenuItem.Click += new System.EventHandler(this.гистограммыСечениToolStripMenuItem_Click);
            // 
            // гистограммаВертикальногоСеченияToolStripMenuItem
            // 
            this.гистограммаВертикальногоСеченияToolStripMenuItem.Name = "гистограммаВертикальногоСеченияToolStripMenuItem";
            this.гистограммаВертикальногоСеченияToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.гистограммаВертикальногоСеченияToolStripMenuItem.Text = "Гист. вертик. сечения";
            this.гистограммаВертикальногоСеченияToolStripMenuItem.Click += new System.EventHandler(this.гистограммаВертикальногоСеченияToolStripMenuItem_Click);
            // 
            // гистограммаГоризонтальногоСеченияToolStripMenuItem
            // 
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem.Name = "гистограммаГоризонтальногоСеченияToolStripMenuItem";
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem.Text = "Гист. гориз. сечения";
            this.гистограммаГоризонтальногоСеченияToolStripMenuItem.Click += new System.EventHandler(this.гистограммаГоризонтальногоСеченияToolStripMenuItem_Click);
            // 
            // changeLeft
            // 
            this.changeLeft.Controls.Add(this.leftBright);
            this.changeLeft.Controls.Add(this.leftOptions);
            this.changeLeft.Location = new System.Drawing.Point(0, 654);
            this.changeLeft.Name = "changeLeft";
            this.changeLeft.Size = new System.Drawing.Size(447, 77);
            this.changeLeft.TabIndex = 2;
            this.changeLeft.TabStop = false;
            this.changeLeft.Text = "Замена левее движка L";
            // 
            // leftBright
            // 
            this.leftBright.AutoSize = true;
            this.leftBright.Location = new System.Drawing.Point(6, 38);
            this.leftBright.Name = "leftBright";
            this.leftBright.Size = new System.Drawing.Size(61, 16);
            this.leftBright.TabIndex = 6;
            this.leftBright.Text = "Яркость";
            // 
            // leftOptions
            // 
            this.leftOptions.FormattingEnabled = true;
            this.leftOptions.Items.AddRange(new object[] {
            "Считать равными L",
            "Считать равными минимальному значению 0",
            "Считать равными 0",
            "Отображать в диапазон [0, 255]"});
            this.leftOptions.Location = new System.Drawing.Point(96, 35);
            this.leftOptions.Name = "leftOptions";
            this.leftOptions.Size = new System.Drawing.Size(345, 24);
            this.leftOptions.TabIndex = 2;
            this.leftOptions.SelectedIndexChanged += new System.EventHandler(this.leftOptions_SelectedIndexChanged);
            // 
            // changeRight
            // 
            this.changeRight.Controls.Add(this.rightBright);
            this.changeRight.Controls.Add(this.rightOptions);
            this.changeRight.Location = new System.Drawing.Point(450, 654);
            this.changeRight.Name = "changeRight";
            this.changeRight.Size = new System.Drawing.Size(445, 77);
            this.changeRight.TabIndex = 3;
            this.changeRight.TabStop = false;
            this.changeRight.Text = "Замена правее движка R";
            // 
            // rightBright
            // 
            this.rightBright.AutoSize = true;
            this.rightBright.Location = new System.Drawing.Point(6, 38);
            this.rightBright.Name = "rightBright";
            this.rightBright.Size = new System.Drawing.Size(61, 16);
            this.rightBright.TabIndex = 1;
            this.rightBright.Text = "Яркость";
            // 
            // rightOptions
            // 
            this.rightOptions.FormattingEnabled = true;
            this.rightOptions.Items.AddRange(new object[] {
            "Считать равными R",
            "Считать равными максимальному значению 255",
            "Считать равными 0",
            "Отображать в диапазон [0, 255]"});
            this.rightOptions.Location = new System.Drawing.Point(95, 35);
            this.rightOptions.Name = "rightOptions";
            this.rightOptions.Size = new System.Drawing.Size(344, 24);
            this.rightOptions.TabIndex = 0;
            this.rightOptions.SelectedIndexChanged += new System.EventHandler(this.rightOptions_SelectedIndexChanged);
            // 
            // horizChart
            // 
            chartArea11.Name = "ChartArea1";
            this.horizChart.ChartAreas.Add(chartArea11);
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.horizChart.Legends.Add(legend11);
            this.horizChart.Location = new System.Drawing.Point(77, 80);
            this.horizChart.Name = "horizChart";
            this.horizChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.horizChart.Series.Add(series11);
            this.horizChart.Size = new System.Drawing.Size(743, 519);
            this.horizChart.TabIndex = 4;
            this.horizChart.Text = "chart1";
            // 
            // vertChart
            // 
            chartArea12.Name = "ChartArea1";
            this.vertChart.ChartAreas.Add(chartArea12);
            legend12.Enabled = false;
            legend12.Name = "Legend1";
            this.vertChart.Legends.Add(legend12);
            this.vertChart.Location = new System.Drawing.Point(77, 80);
            this.vertChart.Name = "vertChart";
            this.vertChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.vertChart.Series.Add(series12);
            this.vertChart.Size = new System.Drawing.Size(743, 519);
            this.vertChart.TabIndex = 5;
            this.vertChart.Text = "chart1";
            // 
            // keepRange
            // 
            this.keepRange.AutoSize = true;
            this.keepRange.Location = new System.Drawing.Point(904, 688);
            this.keepRange.Name = "keepRange";
            this.keepRange.Size = new System.Drawing.Size(165, 20);
            this.keepRange.TabIndex = 6;
            this.keepRange.Text = "Сохранить диапазон";
            this.keepRange.UseVisualStyleBackColor = true;
            this.keepRange.CheckedChanged += new System.EventHandler(this.keepRange_CheckedChanged);
            // 
            // BarCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 763);
            this.Controls.Add(this.keepRange);
            this.Controls.Add(this.vertChart);
            this.Controls.Add(this.horizChart);
            this.Controls.Add(this.changeRight);
            this.Controls.Add(this.changeLeft);
            this.Controls.Add(this.brightChart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BarCharts";
            this.Text = "Гистаграммы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BarCharts_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.brightChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.changeLeft.ResumeLayout(false);
            this.changeLeft.PerformLayout();
            this.changeRight.ResumeLayout(false);
            this.changeRight.PerformLayout();
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
        private System.Windows.Forms.Label leftBright;
        private System.Windows.Forms.Label rightBright;
        private System.Windows.Forms.CheckBox keepRange;
    }
}