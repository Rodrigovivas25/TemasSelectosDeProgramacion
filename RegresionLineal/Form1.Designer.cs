namespace RegresionLineal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficaRegresion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Graficar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graficaRegresion)).BeginInit();
            this.SuspendLayout();
            // 
            // graficaRegresion
            // 
            chartArea3.Name = "ChartArea1";
            this.graficaRegresion.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graficaRegresion.Legends.Add(legend3);
            this.graficaRegresion.Location = new System.Drawing.Point(297, 60);
            this.graficaRegresion.Name = "graficaRegresion";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graficaRegresion.Series.Add(series3);
            this.graficaRegresion.Size = new System.Drawing.Size(300, 300);
            this.graficaRegresion.TabIndex = 0;
            this.graficaRegresion.Text = "chart1";
            // 
            // btn_Graficar
            // 
            this.btn_Graficar.Location = new System.Drawing.Point(65, 175);
            this.btn_Graficar.Name = "btn_Graficar";
            this.btn_Graficar.Size = new System.Drawing.Size(75, 23);
            this.btn_Graficar.TabIndex = 1;
            this.btn_Graficar.Text = "Graficar";
            this.btn_Graficar.UseVisualStyleBackColor = true;
            this.btn_Graficar.Click += new System.EventHandler(this.btn_Graficar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 407);
            this.Controls.Add(this.btn_Graficar);
            this.Controls.Add(this.graficaRegresion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graficaRegresion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficaRegresion;
        private System.Windows.Forms.Button btn_Graficar;
    }
}

