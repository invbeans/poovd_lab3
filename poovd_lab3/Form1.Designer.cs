namespace poovd_lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageChoiceBox = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.imageNameBox = new System.Windows.Forms.GroupBox();
            this.lineFileName = new System.Windows.Forms.Label();
            this.codeShiftBox = new System.Windows.Forms.GroupBox();
            this.radioShift3 = new System.Windows.Forms.RadioButton();
            this.radioShift2 = new System.Windows.Forms.RadioButton();
            this.radioShift1 = new System.Windows.Forms.RadioButton();
            this.highestRowBox = new System.Windows.Forms.GroupBox();
            this.highestRowButton = new System.Windows.Forms.Button();
            this.highestRowInput = new System.Windows.Forms.TextBox();
            this.coordinatesBox = new System.Windows.Forms.GroupBox();
            this.brightLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.brightValue = new System.Windows.Forms.TextBox();
            this.xValue = new System.Windows.Forms.TextBox();
            this.yValue = new System.Windows.Forms.TextBox();
            this.scrollStepBox = new System.Windows.Forms.GroupBox();
            this.scrollStepInput = new System.Windows.Forms.TextBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.imageContainer = new System.Windows.Forms.PictureBox();
            this.zoomContainer = new System.Windows.Forms.PictureBox();
            this.zoomBox = new System.Windows.Forms.GroupBox();
            this.zoom3Button = new System.Windows.Forms.RadioButton();
            this.zoom2Button = new System.Windows.Forms.RadioButton();
            this.zoom1Button = new System.Windows.Forms.RadioButton();
            this.zoomMethod = new System.Windows.Forms.CheckBox();
            this.normalizeBox = new System.Windows.Forms.CheckBox();
            this.overviewContainer = new System.Windows.Forms.PictureBox();
            this.altText = new System.Windows.Forms.Label();
            this.openCharts = new System.Windows.Forms.Button();
            this.imageChoiceBox.SuspendLayout();
            this.imageNameBox.SuspendLayout();
            this.codeShiftBox.SuspendLayout();
            this.highestRowBox.SuspendLayout();
            this.coordinatesBox.SuspendLayout();
            this.scrollStepBox.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomContainer)).BeginInit();
            this.zoomBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // imageChoiceBox
            // 
            this.imageChoiceBox.Controls.Add(this.loadButton);
            this.imageChoiceBox.Controls.Add(this.imageNameBox);
            this.imageChoiceBox.Location = new System.Drawing.Point(0, -2);
            this.imageChoiceBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageChoiceBox.Name = "imageChoiceBox";
            this.imageChoiceBox.Padding = new System.Windows.Forms.Padding(2);
            this.imageChoiceBox.Size = new System.Drawing.Size(436, 75);
            this.imageChoiceBox.TabIndex = 0;
            this.imageChoiceBox.TabStop = false;
            this.imageChoiceBox.Text = "Загрузка .mbv файла:";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(11, 25);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(117, 37);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // imageNameBox
            // 
            this.imageNameBox.Controls.Add(this.lineFileName);
            this.imageNameBox.Location = new System.Drawing.Point(193, 9);
            this.imageNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageNameBox.Name = "imageNameBox";
            this.imageNameBox.Padding = new System.Windows.Forms.Padding(2);
            this.imageNameBox.Size = new System.Drawing.Size(243, 66);
            this.imageNameBox.TabIndex = 0;
            this.imageNameBox.TabStop = false;
            this.imageNameBox.Text = "Загружено изображение:";
            // 
            // lineFileName
            // 
            this.lineFileName.AutoSize = true;
            this.lineFileName.Location = new System.Drawing.Point(13, 37);
            this.lineFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lineFileName.Name = "lineFileName";
            this.lineFileName.Size = new System.Drawing.Size(123, 16);
            this.lineFileName.TabIndex = 7;
            this.lineFileName.Text = "Нет изображения";
            // 
            // codeShiftBox
            // 
            this.codeShiftBox.Controls.Add(this.radioShift3);
            this.codeShiftBox.Controls.Add(this.radioShift2);
            this.codeShiftBox.Controls.Add(this.radioShift1);
            this.codeShiftBox.Location = new System.Drawing.Point(441, -2);
            this.codeShiftBox.Margin = new System.Windows.Forms.Padding(2);
            this.codeShiftBox.Name = "codeShiftBox";
            this.codeShiftBox.Padding = new System.Windows.Forms.Padding(2);
            this.codeShiftBox.Size = new System.Drawing.Size(154, 75);
            this.codeShiftBox.TabIndex = 1;
            this.codeShiftBox.TabStop = false;
            this.codeShiftBox.Text = "Сдвигать коды на:";
            // 
            // radioShift3
            // 
            this.radioShift3.AutoSize = true;
            this.radioShift3.Location = new System.Drawing.Point(102, 50);
            this.radioShift3.Margin = new System.Windows.Forms.Padding(2);
            this.radioShift3.Name = "radioShift3";
            this.radioShift3.Size = new System.Drawing.Size(35, 20);
            this.radioShift3.TabIndex = 6;
            this.radioShift3.TabStop = true;
            this.radioShift3.Text = "2";
            this.radioShift3.UseVisualStyleBackColor = true;
            this.radioShift3.CheckedChanged += new System.EventHandler(this.RadioShift3_CheckedChanged);
            // 
            // radioShift2
            // 
            this.radioShift2.AutoSize = true;
            this.radioShift2.Location = new System.Drawing.Point(63, 50);
            this.radioShift2.Margin = new System.Windows.Forms.Padding(2);
            this.radioShift2.Name = "radioShift2";
            this.radioShift2.Size = new System.Drawing.Size(35, 20);
            this.radioShift2.TabIndex = 6;
            this.radioShift2.TabStop = true;
            this.radioShift2.Text = "1";
            this.radioShift2.UseVisualStyleBackColor = true;
            this.radioShift2.CheckedChanged += new System.EventHandler(this.RadioShift2_CheckedChanged);
            // 
            // radioShift1
            // 
            this.radioShift1.AutoSize = true;
            this.radioShift1.Location = new System.Drawing.Point(24, 50);
            this.radioShift1.Margin = new System.Windows.Forms.Padding(2);
            this.radioShift1.Name = "radioShift1";
            this.radioShift1.Size = new System.Drawing.Size(35, 20);
            this.radioShift1.TabIndex = 6;
            this.radioShift1.TabStop = true;
            this.radioShift1.Text = "0";
            this.radioShift1.UseVisualStyleBackColor = true;
            this.radioShift1.CheckedChanged += new System.EventHandler(this.RadioShift1_CheckedChanged);
            // 
            // highestRowBox
            // 
            this.highestRowBox.Controls.Add(this.highestRowButton);
            this.highestRowBox.Controls.Add(this.highestRowInput);
            this.highestRowBox.Location = new System.Drawing.Point(600, -2);
            this.highestRowBox.Margin = new System.Windows.Forms.Padding(2);
            this.highestRowBox.Name = "highestRowBox";
            this.highestRowBox.Padding = new System.Windows.Forms.Padding(2);
            this.highestRowBox.Size = new System.Drawing.Size(238, 75);
            this.highestRowBox.TabIndex = 2;
            this.highestRowBox.TabStop = false;
            this.highestRowBox.Text = "Верхние строки изображений:";
            // 
            // highestRowButton
            // 
            this.highestRowButton.Location = new System.Drawing.Point(122, 38);
            this.highestRowButton.Margin = new System.Windows.Forms.Padding(2);
            this.highestRowButton.Name = "highestRowButton";
            this.highestRowButton.Size = new System.Drawing.Size(99, 33);
            this.highestRowButton.TabIndex = 8;
            this.highestRowButton.Text = "<- задать";
            this.highestRowButton.UseVisualStyleBackColor = true;
            this.highestRowButton.Click += new System.EventHandler(this.HighestRowButton_Click);
            // 
            // highestRowInput
            // 
            this.highestRowInput.Location = new System.Drawing.Point(42, 49);
            this.highestRowInput.Margin = new System.Windows.Forms.Padding(2);
            this.highestRowInput.Name = "highestRowInput";
            this.highestRowInput.Size = new System.Drawing.Size(75, 22);
            this.highestRowInput.TabIndex = 7;
            // 
            // coordinatesBox
            // 
            this.coordinatesBox.Controls.Add(this.brightLabel);
            this.coordinatesBox.Controls.Add(this.yLabel);
            this.coordinatesBox.Controls.Add(this.xLabel);
            this.coordinatesBox.Controls.Add(this.brightValue);
            this.coordinatesBox.Controls.Add(this.xValue);
            this.coordinatesBox.Controls.Add(this.yValue);
            this.coordinatesBox.Location = new System.Drawing.Point(0, 647);
            this.coordinatesBox.Margin = new System.Windows.Forms.Padding(2);
            this.coordinatesBox.Name = "coordinatesBox";
            this.coordinatesBox.Padding = new System.Windows.Forms.Padding(2);
            this.coordinatesBox.Size = new System.Drawing.Size(266, 130);
            this.coordinatesBox.TabIndex = 3;
            this.coordinatesBox.TabStop = false;
            this.coordinatesBox.Text = "Координаты курсора:";
            // 
            // brightLabel
            // 
            this.brightLabel.AutoSize = true;
            this.brightLabel.Location = new System.Drawing.Point(14, 101);
            this.brightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brightLabel.Name = "brightLabel";
            this.brightLabel.Size = new System.Drawing.Size(64, 16);
            this.brightLabel.TabIndex = 6;
            this.brightLabel.Text = "Яркость:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(22, 69);
            this.yLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(26, 16);
            this.yLabel.TabIndex = 6;
            this.yLabel.Text = "Y =";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(22, 37);
            this.xLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(25, 16);
            this.xLabel.TabIndex = 6;
            this.xLabel.Text = "X =";
            // 
            // brightValue
            // 
            this.brightValue.Location = new System.Drawing.Point(120, 97);
            this.brightValue.Margin = new System.Windows.Forms.Padding(2);
            this.brightValue.Name = "brightValue";
            this.brightValue.ReadOnly = true;
            this.brightValue.Size = new System.Drawing.Size(62, 22);
            this.brightValue.TabIndex = 6;
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(120, 37);
            this.xValue.Margin = new System.Windows.Forms.Padding(2);
            this.xValue.Name = "xValue";
            this.xValue.ReadOnly = true;
            this.xValue.Size = new System.Drawing.Size(62, 22);
            this.xValue.TabIndex = 6;
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(120, 66);
            this.yValue.Margin = new System.Windows.Forms.Padding(2);
            this.yValue.Name = "yValue";
            this.yValue.ReadOnly = true;
            this.yValue.Size = new System.Drawing.Size(62, 22);
            this.yValue.TabIndex = 6;
            // 
            // scrollStepBox
            // 
            this.scrollStepBox.Controls.Add(this.scrollStepInput);
            this.scrollStepBox.Location = new System.Drawing.Point(842, -2);
            this.scrollStepBox.Margin = new System.Windows.Forms.Padding(2);
            this.scrollStepBox.Name = "scrollStepBox";
            this.scrollStepBox.Padding = new System.Windows.Forms.Padding(2);
            this.scrollStepBox.Size = new System.Drawing.Size(127, 75);
            this.scrollStepBox.TabIndex = 5;
            this.scrollStepBox.TabStop = false;
            this.scrollStepBox.Text = "Шаг прокр";
            // 
            // scrollStepInput
            // 
            this.scrollStepInput.Location = new System.Drawing.Point(22, 49);
            this.scrollStepInput.Margin = new System.Windows.Forms.Padding(2);
            this.scrollStepInput.Name = "scrollStepInput";
            this.scrollStepInput.Size = new System.Drawing.Size(69, 22);
            this.scrollStepInput.TabIndex = 6;
            this.scrollStepInput.TextChanged += new System.EventHandler(this.ScrollStepInput_TextChanged);
            // 
            // imagePanel
            // 
            this.imagePanel.AutoScroll = true;
            this.imagePanel.Controls.Add(this.imageContainer);
            this.imagePanel.Location = new System.Drawing.Point(0, 77);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(521, 566);
            this.imagePanel.TabIndex = 6;
            // 
            // imageContainer
            // 
            this.imageContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageContainer.Location = new System.Drawing.Point(0, 0);
            this.imageContainer.Margin = new System.Windows.Forms.Padding(2);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(500, 700);
            this.imageContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageContainer.TabIndex = 0;
            this.imageContainer.TabStop = false;
            // 
            // zoomContainer
            // 
            this.zoomContainer.Location = new System.Drawing.Point(722, 77);
            this.zoomContainer.Margin = new System.Windows.Forms.Padding(2);
            this.zoomContainer.Name = "zoomContainer";
            this.zoomContainer.Size = new System.Drawing.Size(420, 420);
            this.zoomContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.zoomContainer.TabIndex = 7;
            this.zoomContainer.TabStop = false;
            // 
            // zoomBox
            // 
            this.zoomBox.Controls.Add(this.zoom3Button);
            this.zoomBox.Controls.Add(this.zoom2Button);
            this.zoomBox.Controls.Add(this.zoom1Button);
            this.zoomBox.Location = new System.Drawing.Point(722, 602);
            this.zoomBox.Margin = new System.Windows.Forms.Padding(2);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Padding = new System.Windows.Forms.Padding(2);
            this.zoomBox.Size = new System.Drawing.Size(174, 74);
            this.zoomBox.TabIndex = 8;
            this.zoomBox.TabStop = false;
            this.zoomBox.Text = "Увеличение в:";
            // 
            // zoom3Button
            // 
            this.zoom3Button.AutoSize = true;
            this.zoom3Button.Location = new System.Drawing.Point(103, 34);
            this.zoom3Button.Margin = new System.Windows.Forms.Padding(2);
            this.zoom3Button.Name = "zoom3Button";
            this.zoom3Button.Size = new System.Drawing.Size(41, 20);
            this.zoom3Button.TabIndex = 2;
            this.zoom3Button.TabStop = true;
            this.zoom3Button.Text = "х7";
            this.zoom3Button.UseVisualStyleBackColor = true;
            this.zoom3Button.CheckedChanged += new System.EventHandler(this.Zoom3Button_CheckedChanged);
            // 
            // zoom2Button
            // 
            this.zoom2Button.AutoSize = true;
            this.zoom2Button.Location = new System.Drawing.Point(58, 33);
            this.zoom2Button.Margin = new System.Windows.Forms.Padding(2);
            this.zoom2Button.Name = "zoom2Button";
            this.zoom2Button.Size = new System.Drawing.Size(41, 20);
            this.zoom2Button.TabIndex = 1;
            this.zoom2Button.TabStop = true;
            this.zoom2Button.Text = "х5";
            this.zoom2Button.UseVisualStyleBackColor = true;
            this.zoom2Button.CheckedChanged += new System.EventHandler(this.Zoom2Button_CheckedChanged);
            // 
            // zoom1Button
            // 
            this.zoom1Button.AutoSize = true;
            this.zoom1Button.Location = new System.Drawing.Point(12, 33);
            this.zoom1Button.Margin = new System.Windows.Forms.Padding(2);
            this.zoom1Button.Name = "zoom1Button";
            this.zoom1Button.Size = new System.Drawing.Size(41, 20);
            this.zoom1Button.TabIndex = 0;
            this.zoom1Button.TabStop = true;
            this.zoom1Button.Text = "х3";
            this.zoom1Button.UseVisualStyleBackColor = true;
            this.zoom1Button.CheckedChanged += new System.EventHandler(this.Zoom1Button_CheckedChanged);
            // 
            // zoomMethod
            // 
            this.zoomMethod.AutoSize = true;
            this.zoomMethod.Location = new System.Drawing.Point(725, 680);
            this.zoomMethod.Margin = new System.Windows.Forms.Padding(2);
            this.zoomMethod.Name = "zoomMethod";
            this.zoomMethod.Size = new System.Drawing.Size(148, 20);
            this.zoomMethod.TabIndex = 9;
            this.zoomMethod.Text = "Интерполировать";
            this.zoomMethod.UseVisualStyleBackColor = true;
            this.zoomMethod.CheckedChanged += new System.EventHandler(this.ZoomMethod_CheckedChanged);
            // 
            // normalizeBox
            // 
            this.normalizeBox.AutoSize = true;
            this.normalizeBox.Location = new System.Drawing.Point(725, 704);
            this.normalizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.normalizeBox.Name = "normalizeBox";
            this.normalizeBox.Size = new System.Drawing.Size(118, 20);
            this.normalizeBox.TabIndex = 10;
            this.normalizeBox.Text = "Нормировать";
            this.normalizeBox.UseVisualStyleBackColor = true;
            this.normalizeBox.CheckedChanged += new System.EventHandler(this.NormalizeBox_CheckedChanged);
            // 
            // overviewContainer
            // 
            this.overviewContainer.Location = new System.Drawing.Point(543, 77);
            this.overviewContainer.Margin = new System.Windows.Forms.Padding(2);
            this.overviewContainer.Name = "overviewContainer";
            this.overviewContainer.Size = new System.Drawing.Size(156, 618);
            this.overviewContainer.TabIndex = 11;
            this.overviewContainer.TabStop = false;
            // 
            // altText
            // 
            this.altText.AutoSize = true;
            this.altText.Location = new System.Drawing.Point(743, 124);
            this.altText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.altText.Name = "altText";
            this.altText.Size = new System.Drawing.Size(284, 16);
            this.altText.TabIndex = 12;
            this.altText.Text = "Для увеличения нажмите на изображение";
            // 
            // openCharts
            // 
            this.openCharts.Location = new System.Drawing.Point(732, 738);
            this.openCharts.Name = "openCharts";
            this.openCharts.Size = new System.Drawing.Size(208, 34);
            this.openCharts.TabIndex = 13;
            this.openCharts.Text = "Окно гистограмм";
            this.openCharts.UseVisualStyleBackColor = true;
            this.openCharts.Click += new System.EventHandler(this.OpenCharts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 786);
            this.Controls.Add(this.openCharts);
            this.Controls.Add(this.altText);
            this.Controls.Add(this.overviewContainer);
            this.Controls.Add(this.normalizeBox);
            this.Controls.Add(this.zoomMethod);
            this.Controls.Add(this.zoomBox);
            this.Controls.Add(this.zoomContainer);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.scrollStepBox);
            this.Controls.Add(this.coordinatesBox);
            this.Controls.Add(this.highestRowBox);
            this.Controls.Add(this.codeShiftBox);
            this.Controls.Add(this.imageChoiceBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Визуализация изображений высокого разрешения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.imageChoiceBox.ResumeLayout(false);
            this.imageNameBox.ResumeLayout(false);
            this.imageNameBox.PerformLayout();
            this.codeShiftBox.ResumeLayout(false);
            this.codeShiftBox.PerformLayout();
            this.highestRowBox.ResumeLayout(false);
            this.highestRowBox.PerformLayout();
            this.coordinatesBox.ResumeLayout(false);
            this.coordinatesBox.PerformLayout();
            this.scrollStepBox.ResumeLayout(false);
            this.scrollStepBox.PerformLayout();
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomContainer)).EndInit();
            this.zoomBox.ResumeLayout(false);
            this.zoomBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox imageChoiceBox;
        private System.Windows.Forms.GroupBox codeShiftBox;
        private System.Windows.Forms.GroupBox highestRowBox;
        private System.Windows.Forms.GroupBox coordinatesBox;
        private System.Windows.Forms.GroupBox scrollStepBox;
        private System.Windows.Forms.GroupBox imageNameBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label lineFileName;
        private System.Windows.Forms.RadioButton radioShift1;
        private System.Windows.Forms.RadioButton radioShift2;
        private System.Windows.Forms.RadioButton radioShift3;
        private System.Windows.Forms.Button highestRowButton;
        private System.Windows.Forms.TextBox highestRowInput;
        private System.Windows.Forms.TextBox scrollStepInput;
        private System.Windows.Forms.Label brightLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox brightValue;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox imageContainer;
        private System.Windows.Forms.PictureBox zoomContainer;
        private System.Windows.Forms.GroupBox zoomBox;
        private System.Windows.Forms.RadioButton zoom1Button;
        private System.Windows.Forms.RadioButton zoom2Button;
        private System.Windows.Forms.RadioButton zoom3Button;
        private System.Windows.Forms.CheckBox zoomMethod;
        private System.Windows.Forms.CheckBox normalizeBox;
        private System.Windows.Forms.PictureBox overviewContainer;
        private System.Windows.Forms.Label altText;
        private System.Windows.Forms.Button openCharts;
    }
}



