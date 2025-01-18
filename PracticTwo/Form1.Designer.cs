namespace PracticTwo
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.v);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bString);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.y);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.eY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.x);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "β,ед\\год:";
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(16, 308);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(100, 22);
            this.v.TabIndex = 15;
            this.v.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "δ:";
            // 
            // bString
            // 
            this.bString.Location = new System.Drawing.Point(16, 258);
            this.bString.Name = "bString";
            this.bString.Size = new System.Drawing.Size(100, 22);
            this.bString.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "y0:";
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(16, 208);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(100, 22);
            this.y.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "α:";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(16, 157);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ε,ед\\год:";
            // 
            // eY
            // 
            this.eY.Location = new System.Drawing.Point(16, 107);
            this.eY.Name = "eY";
            this.eY.Size = new System.Drawing.Size(100, 22);
            this.eY.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "X0:";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(16, 57);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 22);
            this.x.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(232, 23);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Поколение 1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Поколение 2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Поколение 3";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(545, 404);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(13, 372);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 55);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Start;
    }
}

