namespace Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_w1 = new System.Windows.Forms.TextBox();
            this.txt_w2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_t = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_AND = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Test = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obtenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_x1
            // 
            this.txt_x1.Location = new System.Drawing.Point(57, 77);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.ReadOnly = true;
            this.txt_x1.Size = new System.Drawing.Size(66, 20);
            this.txt_x1.TabIndex = 0;
            this.txt_x1.Text = "1";
            this.txt_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_x2
            // 
            this.txt_x2.Location = new System.Drawing.Point(57, 240);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.ReadOnly = true;
            this.txt_x2.Size = new System.Drawing.Size(66, 20);
            this.txt_x2.TabIndex = 1;
            this.txt_x2.Text = "1";
            this.txt_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x2";
            // 
            // txt_w1
            // 
            this.txt_w1.Location = new System.Drawing.Point(235, 95);
            this.txt_w1.Name = "txt_w1";
            this.txt_w1.ReadOnly = true;
            this.txt_w1.Size = new System.Drawing.Size(45, 20);
            this.txt_w1.TabIndex = 4;
            this.txt_w1.Text = "0,5";
            this.txt_w1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_w2
            // 
            this.txt_w2.Location = new System.Drawing.Point(235, 231);
            this.txt_w2.Name = "txt_w2";
            this.txt_w2.ReadOnly = true;
            this.txt_w2.Size = new System.Drawing.Size(45, 20);
            this.txt_w2.TabIndex = 5;
            this.txt_w2.Text = "0,2";
            this.txt_w2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "w1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "w2";
            // 
            // txt_t
            // 
            this.txt_t.Location = new System.Drawing.Point(247, 292);
            this.txt_t.Name = "txt_t";
            this.txt_t.ReadOnly = true;
            this.txt_t.Size = new System.Drawing.Size(66, 20);
            this.txt_t.TabIndex = 8;
            this.txt_t.Text = "0,24";
            this.txt_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(371, 292);
            this.txt_n.Name = "txt_n";
            this.txt_n.ReadOnly = true;
            this.txt_n.Size = new System.Drawing.Size(66, 20);
            this.txt_n.TabIndex = 9;
            this.txt_n.Text = "0,25";
            this.txt_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "θ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "η";
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(458, 129);
            this.txt_D.Name = "txt_D";
            this.txt_D.ReadOnly = true;
            this.txt_D.Size = new System.Drawing.Size(66, 20);
            this.txt_D.TabIndex = 12;
            this.txt_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(458, 194);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.ReadOnly = true;
            this.txt_Y.Size = new System.Drawing.Size(66, 20);
            this.txt_Y.TabIndex = 13;
            this.txt_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Y";
            // 
            // dgv_AND
            // 
            this.dgv_AND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.AND});
            this.dgv_AND.Location = new System.Drawing.Point(581, 41);
            this.dgv_AND.Name = "dgv_AND";
            this.dgv_AND.Size = new System.Drawing.Size(215, 129);
            this.dgv_AND.TabIndex = 16;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // AND
            // 
            this.AND.HeaderText = "X AND Y";
            this.AND.Name = "AND";
            // 
            // dgv_Test
            // 
            this.dgv_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Test.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.X2,
            this.Obtenido,
            this.D});
            this.dgv_Test.Location = new System.Drawing.Point(40, 362);
            this.dgv_Test.Name = "dgv_Test";
            this.dgv_Test.Size = new System.Drawing.Size(240, 201);
            this.dgv_Test.TabIndex = 17;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.Width = 50;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.Width = 50;
            // 
            // Obtenido
            // 
            this.Obtenido.HeaderText = "Y";
            this.Obtenido.Name = "Obtenido";
            this.Obtenido.Width = 50;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.Width = 50;
            // 
            // grafica
            // 
            chartArea1.AxisX.Maximum = 2D;
            chartArea1.AxisX.MaximumAutoSize = 0F;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 2D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorY.AutoScroll = false;
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(523, 263);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.grafica.Series.Add(series1);
            this.grafica.Series.Add(series2);
            this.grafica.Size = new System.Drawing.Size(357, 300);
            this.grafica.TabIndex = 18;
            this.grafica.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(337, 27);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 19;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(648, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tabla de verdad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(668, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Grafico";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Valor obtenido y valor deseado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(356, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cálculo de error";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 397);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "δ=D-Y=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Δ1=ηδx1=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(312, 454);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Δ2=ηδx2=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 485);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "w1=w1+Δ1=";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(312, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "w2=w2+Δ2=";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(312, 540);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "θ=θ-ηδ=";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(384, 397);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 13);
            this.lbl1.TabIndex = 30;
            this.lbl1.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(384, 424);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(13, 13);
            this.lbl2.TabIndex = 31;
            this.lbl2.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(384, 454);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(13, 13);
            this.lbl3.TabIndex = 32;
            this.lbl3.Text = "0";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(384, 485);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(13, 13);
            this.lbl4.TabIndex = 33;
            this.lbl4.Text = "0";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(384, 514);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(13, 13);
            this.lbl5.TabIndex = 34;
            this.lbl5.Text = "0";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(384, 540);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(13, 13);
            this.lbl6.TabIndex = 35;
            this.lbl6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 575);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.dgv_Test);
            this.Controls.Add(this.dgv_AND);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.txt_t);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_w2);
            this.Controls.Add(this.txt_w1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_x2);
            this.Controls.Add(this.txt_x1);
            this.Name = "Form1";
            this.Text = " ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_w1;
        private System.Windows.Forms.TextBox txt_w2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_t;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_AND;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn AND;
        private System.Windows.Forms.DataGridView dgv_Test;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obtenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
    }
}

