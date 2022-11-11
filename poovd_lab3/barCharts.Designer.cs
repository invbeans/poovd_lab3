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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.brightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeLeft = new System.Windows.Forms.GroupBox();
            this.leftBright = new System.Windows.Forms.Label();
            this.leftOptions = new System.Windows.Forms.ComboBox();
            this.changeRight = new System.Windows.Forms.GroupBox();
            this.rightBright = new System.Windows.Forms.Label();
            this.rightOptions = new System.Windows.Forms.ComboBox();
            this.keepRange = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.brightChart)).BeginInit();
            this.changeLeft.SuspendLayout();
            this.changeRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightChart
            // 
            chartArea1.AxisX.Interval = 10D;
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
            this.brightChart.Location = new System.Drawing.Point(25, 63);
            this.brightChart.Name = "brightChart";
            this.brightChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.brightChart.Series.Add(series1);
            this.brightChart.Size = new System.Drawing.Size(1059, 536);
            this.brightChart.TabIndex = 0;
            this.brightChart.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.Controls.Add(this.changeRight);
            this.Controls.Add(this.changeLeft);
            this.Controls.Add(this.brightChart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BarCharts";
            this.Text = "Гистаграмма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BarCharts_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.brightChart)).EndInit();
            this.changeLeft.ResumeLayout(false);
            this.changeLeft.PerformLayout();
            this.changeRight.ResumeLayout(false);
            this.changeRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart brightChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox changeLeft;
        private System.Windows.Forms.GroupBox changeRight;
        private System.Windows.Forms.ComboBox leftOptions;
        private System.Windows.Forms.ComboBox rightOptions;
        private System.Windows.Forms.Label leftBright;
        private System.Windows.Forms.Label rightBright;
        private System.Windows.Forms.CheckBox keepRange;
    }
}