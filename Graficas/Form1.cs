using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using f = ConsolaDePrueba.Librerias.Function.Functions;
using s = ConsolaDePrueba.Librerias.Statistic.Statistics;

namespace Graficas
{
    public partial class Form1 : Form
    {
        private int num = 1;


        public static double[] platR = { 255, 251, 253, 248, 252, 251, 233 };
        public static double[] tamR = { 176, 225, 192, 164, 230, 229, 232 };
        public static double[] platV = { 215, 198, 207, 188, 208, 205, 176 };
        public static double[] tamV = { 121, 183, 144, 11, 183, 180, 197 };
        public static double[] platA = { 93, 6, 49, 12, 77, 31, 0 };
        public static double[] tamA = { 80, 135, 108, 69, 139, 124, 155 };

        double meanPlatR = s.Mean(platR);
        double meanTamR = s.Mean(tamR);
        double meanPlatV = s.Mean(platV);
        double meanTamV = s.Mean(tamV);
        double meanPlatA = s.Mean(platA);
        double meanTamA = s.Mean(tamA);

        double stdPlatR = s.Std(platR);
        double stdTamR = s.Std(tamR);
        double stdPlatV = s.Std(platV);
        double stdTamV = s.Std(tamV);
        double stdPlatA = s.Std(platA);
        double stdTamA = s.Std(tamA);
        public Form1()
        {
            InitializeComponent();
        }


        private void hold_on()
        {
            num++;
        }
        private void plot(double[] x, double[] y)
        {
            Grafica.Series.Add("");

            for(int i = 0; i < x.Length; i++)
            {
                Grafica.Series["Series" + num].Points.AddXY(x[i],y[i]);
                Grafica.Series["Series" + num].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
        }
        private void plot(double[] x, double[] y, System.Windows.Forms.DataVisualization.Charting.Chart grafica)
        {
            grafica.Series.Add("");
            for(int i = 0; i < x.Length; i++)
            {
                grafica.Series["Series" + num].Points.AddXY(x[i], y[i]);
                grafica.Series["Series" + num].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
        }
        

        private void btn_graficar_Click(object sender, EventArgs e)
        {
            Grafica.Series.Clear();
            Grafica2.Series.Clear();
            Grafica3.Series.Clear();

            double meanPlatR = s.Mean(platR);
            double meanTamR = s.Mean(tamR);
            double meanPlatV = s.Mean(platV);
            double meanTamV = s.Mean(tamV);
            double meanPlatA = s.Mean(platA);
            double meanTamA = s.Mean(tamA);

            double stdPlatR = s.Std(platR);
            double stdTamR = s.Std(tamR);
            double stdPlatV = s.Std(platV);
            double stdTamV = s.Std(tamV);
            double stdPlatA = s.Std(platA);
            double stdTamA = s.Std(tamA);

            double minR = 0;
            double minV = 0;
            double minA = 0;
            double minPlatR = meanPlatR - 4 * stdPlatR;
            double minTamR = meanTamR - 4 * stdTamR;
            double minPlatV = meanPlatV - 4 * stdPlatV;
            double minTamV = meanTamV - 4 * stdTamV;
            double minPlatA = meanPlatA - 4 * stdPlatA;
            double minTamA = meanTamA - 4 * stdTamA;

            double maxR = 0;
            double maxV = 0;
            double maxA = 0;
            double maxPlatR = meanPlatR + 4 * stdPlatR;
            double maxTamR = meanTamR + 4 * stdTamR;
            double maxPlatV = meanPlatV + 4 * stdPlatV;
            double maxTamV = meanTamV + 4 * stdTamV;
            double maxPlatA = meanPlatA + 4 * stdPlatA;
            double maxTamA = meanTamA + 4 * stdTamA;
            
            if(minPlatR <= minTamR)
            {
                minR = minPlatR;
            }
            else
            {
                minR = minTamR;
            }
            if(maxPlatR >= maxTamR)
            {
                maxR = maxPlatR;
            }
            else
            {
                maxR = maxTamR;
            }


            if (minPlatV <= minTamV)
            {
                minV = minPlatV;
            }
            else
            {
                minV = minTamV;
            }
            if (maxPlatV >= maxTamV)
            {
                maxV = maxPlatV;
            }
            else
            {
                maxV = maxTamV;
            }

            if (minPlatA <= minTamA)
            {
                minA = minPlatA;
            }
            else
            {
                minA = minTamA;
            }
            if (maxPlatA >= maxTamA)
            {
                maxA = maxPlatA;
            }
            else
            {
                maxA = maxTamA;
            }


            double[] x = f.linspace(minR, maxR, 500);
            double[] x2 = f.linspace(minV, maxV, 500);
            double[] x3 = f.linspace(minA, maxA, 500);
            double[] normPlatR = s.Normpdf(x, meanPlatR, stdPlatR);
            double[] normTamR = s.Normpdf(x, meanTamR, stdTamR);
            double[] normPlatV = s.Normpdf(x2, meanPlatV, stdPlatV);
            double[] normTamV = s.Normpdf(x2, meanTamV, stdTamV);
            double[] normPlatA = s.Normpdf(x3, meanPlatA, stdPlatA);
            double[] normTamA = s.Normpdf(x3, meanTamA, stdTamA);

            plot(x, normPlatR, Grafica);
            plot(x2, normPlatV, Grafica2);
            plot(x3, normPlatA, Grafica3);
            hold_on();
            plot(x, normTamR, Grafica);
            plot(x2, normTamV, Grafica2);
            plot(x3, normTamA, Grafica3);

            for(int i = 0; i < platR.Length; i++)
            {
                dgv_Platano.Rows.Add();
                dgv_Tamarindo.Rows.Add();
                dgv_Platano.Rows[i].Cells[0].Value = platR[i];
                dgv_Platano.Rows[i].Cells[1].Value = platV[i];
                dgv_Platano.Rows[i].Cells[2].Value = platA[i];
                dgv_Tamarindo.Rows[i].Cells[0].Value = tamR[i];
                dgv_Tamarindo.Rows[i].Cells[1].Value = tamR[i];
                dgv_Tamarindo.Rows[i].Cells[2].Value = tamR[i];
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dato = double.Parse(txt_Dato.Text);

            double probPlatR = f.Evaluate(dato, meanPlatR, stdPlatR);
            double probTamR = f.Evaluate(dato, meanTamR, stdTamR);

            lbl_probPlatR.Text = probPlatR.ToString();
            lbl_probTamR.Text = probTamR.ToString();
            
            if(probPlatR > probTamR)
            {
                lbl_resR.Text = "Plátano";
            }
            else
            {
                lbl_resR.Text = "Tamarindo";
            }
            
            
            
        }

        private void btn_CalcularA_Click(object sender, EventArgs e)
        {
            double dato = double.Parse(txt_Dato.Text);
            double probPlatA = f.Evaluate(dato, meanPlatA, stdPlatA);
            double probTamA = f.Evaluate(dato, meanPlatA, stdTamA);
            lbl_probPlatA.Text = probPlatA.ToString();
            lbl_probTamA.Text = probTamA.ToString();

            if (probPlatA > probTamA)
            {
                lbl_resA.Text = "Plátano";
            }
            else
            {
                lbl_resA.Text = "Tamarindo";
            }
        }

        private void btn_calcularV_Click(object sender, EventArgs e)
        {
            double dato = double.Parse(txt_Dato.Text);
            double probPlatV = f.Evaluate(dato, meanPlatV, stdPlatV);
            double probTamV = f.Evaluate(dato, meanTamV, stdTamV);

            lbl_probPlatV.Text = probPlatV.ToString();
            lbl_probTamV.Text = probTamV.ToString();

            if (probPlatV > probTamV)
            {
                lbl_resV.Text = "Plátano";
            }
            else
            {
                lbl_resV.Text = "Tamarindo";
            }
        }
    }
}
