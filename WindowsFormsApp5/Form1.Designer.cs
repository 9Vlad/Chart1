namespace WindowsFormsApp5
{
    partial class frmGraphics
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtZnach = new System.Windows.Forms.TextBox();
            this.cbGraphics = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFunc2 = new System.Windows.Forms.CheckBox();
            this.chkFunc1 = new System.Windows.Forms.CheckBox();
            this.chkCos2 = new System.Windows.Forms.CheckBox();
            this.chkCos = new System.Windows.Forms.CheckBox();
            this.chkSin = new System.Windows.Forms.CheckBox();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCount = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStep);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(564, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальные данные:";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(159, 106);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(119, 30);
            this.txtStep.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(159, 70);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(119, 30);
            this.txtMax.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(159, 35);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(119, 30);
            this.txtMin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите шаг:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите Xmax:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите Xmin:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtZnach);
            this.groupBox2.Controls.Add(this.cbGraphics);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(854, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 694);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значения графика:";
            // 
            // txtZnach
            // 
            this.txtZnach.Location = new System.Drawing.Point(11, 179);
            this.txtZnach.Multiline = true;
            this.txtZnach.Name = "txtZnach";
            this.txtZnach.Size = new System.Drawing.Size(304, 481);
            this.txtZnach.TabIndex = 3;
            // 
            // cbGraphics
            // 
            this.cbGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphics.FormattingEnabled = true;
            this.cbGraphics.Items.AddRange(new object[] {
            "Sin(x)",
            "Cos(x)",
            "Cos(x)+2*x",
            "кв.корень(x)",
            "4+x+x^2"});
            this.cbGraphics.Location = new System.Drawing.Point(11, 125);
            this.cbGraphics.Name = "cbGraphics";
            this.cbGraphics.Size = new System.Drawing.Size(304, 33);
            this.cbGraphics.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 87);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выберите функцию, значения которой нужно показать:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFunc2);
            this.groupBox3.Controls.Add(this.chkFunc1);
            this.groupBox3.Controls.Add(this.chkCos2);
            this.groupBox3.Controls.Add(this.chkCos);
            this.groupBox3.Controls.Add(this.chkSin);
            this.groupBox3.Location = new System.Drawing.Point(575, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 300);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Построение графиков:";
            // 
            // chkFunc2
            // 
            this.chkFunc2.Location = new System.Drawing.Point(5, 232);
            this.chkFunc2.Name = "chkFunc2";
            this.chkFunc2.Size = new System.Drawing.Size(256, 62);
            this.chkFunc2.TabIndex = 4;
            this.chkFunc2.Text = "Построить график 4+x+x^2";
            this.chkFunc2.UseVisualStyleBackColor = true;
            // 
            // chkFunc1
            // 
            this.chkFunc1.Location = new System.Drawing.Point(5, 174);
            this.chkFunc1.Name = "chkFunc1";
            this.chkFunc1.Size = new System.Drawing.Size(256, 61);
            this.chkFunc1.TabIndex = 3;
            this.chkFunc1.Text = "Построить график кв.корень (x) ";
            this.chkFunc1.UseVisualStyleBackColor = true;
            // 
            // chkCos2
            // 
            this.chkCos2.Location = new System.Drawing.Point(5, 109);
            this.chkCos2.Name = "chkCos2";
            this.chkCos2.Size = new System.Drawing.Size(256, 59);
            this.chkCos2.TabIndex = 2;
            this.chkCos2.Text = "Построить график cos (x)+ 2*x";
            this.chkCos2.UseVisualStyleBackColor = true;
            // 
            // chkCos
            // 
            this.chkCos.AutoSize = true;
            this.chkCos.Location = new System.Drawing.Point(5, 74);
            this.chkCos.Name = "chkCos";
            this.chkCos.Size = new System.Drawing.Size(275, 29);
            this.chkCos.TabIndex = 1;
            this.chkCos.Text = "Построить график cos (x)";
            this.chkCos.UseVisualStyleBackColor = true;
            // 
            // chkSin
            // 
            this.chkSin.AutoSize = true;
            this.chkSin.Location = new System.Drawing.Point(5, 39);
            this.chkSin.Name = "chkSin";
            this.chkSin.Size = new System.Drawing.Size(269, 29);
            this.chkSin.TabIndex = 0;
            this.chkSin.Text = "Построить график sin (x)";
            this.chkSin.UseVisualStyleBackColor = true;
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(12, 12);
            this.chartGraph.Name = "chartGraph";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.Legend = "Legend1";
            series1.Name = "Sin (x)";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Cos (x)";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Cos (x) + 2*x";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.Name = "кв.корень(x)";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Fuchsia;
            series5.Legend = "Legend1";
            series5.Name = "(x+4)/(x^2)";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Series.Add(series2);
            this.chartGraph.Series.Add(series3);
            this.chartGraph.Series.Add(series4);
            this.chartGraph.Series.Add(series5);
            this.chartGraph.Size = new System.Drawing.Size(546, 732);
            this.chartGraph.TabIndex = 3;
            this.chartGraph.Text = "chart1";
            // 
            // btCount
            // 
            this.btCount.Location = new System.Drawing.Point(629, 503);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(123, 49);
            this.btCount.TabIndex = 4;
            this.btCount.Text = "Расчёт";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(629, 558);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(123, 67);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Очистить графики";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(629, 631);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(123, 41);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 756);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCount);
            this.Controls.Add(this.chartGraph);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGraphics";
            this.Text = "Графики";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGraphics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZnach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFunc2;
        private System.Windows.Forms.CheckBox chkFunc1;
        private System.Windows.Forms.CheckBox chkCos2;
        private System.Windows.Forms.CheckBox chkCos;
        private System.Windows.Forms.CheckBox chkSin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
    }
}

