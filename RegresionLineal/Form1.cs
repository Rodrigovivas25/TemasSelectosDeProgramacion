using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using s = ConsolaDePrueba.Librerias.Statistic.Statistics;
using f = ConsolaDePrueba.Librerias.Function.Functions;

namespace RegresionLineal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Graficar_Click(object sender, EventArgs e)
        {
            double[] x = f.linspace(0, 3, 31);
            double[] y = sum(x, 3);

            double[] regresion = regression(x, y);

        }

        private double[] regression(double[] x, double[] y)
        {
            double[] output = new double[2];
            double Ex = sum(x);
            double Ey = sum(y);
            double Ex2 = sum(power(x, 2));
            double Ex_2 = Math.Pow(Ex, 2);
            double Exy = sum(mtimes(x, y));
            double n = x.Length;

            double m = (n * Exy - Ex * Ey) / (n * Ex2 - Ex_2);
            double b = (Ey * Ex2 - Ex * Exy) / (n * Ex2 - Ex_2);
            output[0] = m;
            output[1] = b;
            return output;
        }

        private double[] power(double[] x, double v)
        {
            double[] output = new double[x.Length];
            for(int i = 0; i < x.Length; i++)
            {
                output[i] = Math.Pow(x[i], v);
            }
            return output;
        }

        private double[] mtimes(double[] x, double[] y)
        {
            double[] output = new double[x.Length];
            if(x.Length == y.Length)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    output[i] = x[i] * y[i];
                }
                return output;
            }
            else
            {
                throw new Exception("Los vectores no tienen el mismo tamaño");
            }
        }

        private double sum(double[] x)
        {
            double output = x.Sum();
            return output;
        }

        private double[] sum(double[] x, double v)
        {
            double[] output = new double[x.Length];
            for(int i = 0; i < x.Length; i++)
            {
                output[i] = x[i] + v;
            }
            return output;
        }


    }
}
