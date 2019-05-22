using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDePrueba.Librerias.Statistic
{
    public class Statistics
    {

        /// <summary>
        /// Método que calcula el promedio de un conjunto de valores.
        /// </summary>
        /// <param name="A">Arreglo que contiene los valores a promediar.</param>
        /// <returns>Devuelve el promedio de los valores del arreglo.</returns>
        public static double Mean(double[] A)
        {
            try
            {
                double suma = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    suma += A[i];
                }
                double promedio = suma / A.Length;
                return promedio;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("El arreglo no tiene ningún elemento.");
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error con el cálculo de la media.");
                return 0;
            }
        }

        /// <summary>
        /// Método que calcula la varianza de un conjunto de valores.
        /// </summary>
        /// <param name="A">Arreglo que contiene los valores con los cuales operar.</param>
        /// <returns>Devuelve la varianza de los valores del arreglo.</returns>
        public static double Var(double[] A)
        {
            try
            {
                double media = Mean(A);
                double suma = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    suma += Math.Pow((A[i] - media), 2);
                }
                double varianza = suma / (A.Length - 1);
                return varianza;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Debe haber más de un valor para calcular la varianza");
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error con el cálculo de la varianza");
                return 0;
            }
        }

        /// <summary>
        /// Método que calcula la varianza de un conjunto de valores, indicando el peso.
        /// </summary>
        /// <param name="A">Arreglo que contiene los valores con los cuales operar.</param>
        /// <param name="w">Peso con el cual calcular la varianza. Si w = 0, la varianza es normalizada por N-1. Si w=1, la varianza es normalizada por el número de observaciones, N.</param>
        /// <returns>Devuelve la varianza de los valores del arreglo.</returns>
        public static double Var(double[] A, int w)
        {
            double media = Mean(A);
            double suma = 0;
            for (int i = 0; i < A.Length; i++)
            {
                suma += Math.Pow((A[i] - media), 2);
            }
            if (w == 0)
            {
                double varianza = suma / (A.Length - 1);
                return varianza;
            }
            else if (w == 1)
            {
                double varianza = suma / A.Length;
                return varianza;
            }
            else
            {
                throw new Exception("No se ingresó un valor correcto para el peso");
            }

        }


        public static double Cov(double[] x, double[] y)
        {
            double mediaX = Mean(x);
            double mediaY = Mean(y);
            double suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                suma += (x[i] - mediaX) * (y[i] - mediaY);
            }
            double covarianza = suma / x.Length;
            return covarianza;
        }

        public static double Pearson(double[] x, double[] y)
        {
            double suma1 = 0;
            double suma2 = 0;
            double suma3 = 0;
            double meanX = Mean(x);
            double meanY = Mean(y);
            for (int i = 0; i < x.Length; i++)
            {
                suma1 += (x[i] - meanX) * (y[i] - meanY);
                suma2 += Math.Pow(x[i] - meanX, 2);
                suma3 += Math.Pow(y[i] - meanY, 2);
            }
            double r2 = suma1 / Math.Sqrt(suma2 * suma3);
            return r2;
        }

        /// <summary>
        /// Método que calcula la desviación estándar de un conjunto de valores.
        /// </summary>
        /// <param name="A">Arreglo que contiene los valores con los cuales operar.</param>
        /// <returns>Devuelve la desviación estándar de los valores del arreglo.</returns>
        public static double Std(double[] A)
        {
            try
            {
                double desviacion = Math.Sqrt(Var(A));
                return desviacion;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error con el cálculo de la desviación estándar.");
                return 0;
            }
        }

        public static double[] CoefLinReg(double[] x, double[] y)
        {
            double[] coeficientes = new double[2];
            double sX = 0;
            double sY = 0;
            double sXY = 0;
            double sX2 = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sX += x[i];
                sY += y[i];
                sXY += (x[i] * y[i]);
                sX2 += Math.Pow(x[i], 2);
            }

            double m = ((x.Length * sXY) - (sX * sY)) / ((x.Length * sX2) - (sX * sX));
            double a = (sY - (m * sX)) / x.Length;
            coeficientes[0] = a;
            coeficientes[1] = m;
            return coeficientes;
        }

        /// <summary>
        /// Método que calcula la desviación estándar de un conjunto de valores, indicando el peso.
        /// </summary>
        /// <param name="A">Arreglo que contiene los valores con los cuales operar.</param>
        /// <param name="w">Peso con el cual calcular la desviación estándar. Si w = 0, el resultado es normalizada por N-1. Si w=1, el resultado es normalizada por el número de observaciones, N.</param>
        /// <returns>Devuelve la desviación estándar de los valores del arreglo.</returns>
        public static double Std(double[] A, int w)
        {
            try
            {
                double desviacion = Math.Sqrt(Var(A, w));
                return desviacion;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrión un error con el cálculo de la desviación estándar.");
                return 0;
            }
        }


        /// <summary>
        /// Método que te calcula la distribución normal de un conjunto de datos.
        /// </summary>
        /// <param name="x">Vector en x</param>
        /// <param name="mu">Media de la muestra</param>
        /// <param name="sigma">Desviación estándar</param>
        /// <returns>Un vector con la distribución normal acotada en x</returns>
        public static double[] Normpdf(double[] x, double mu, double sigma)
        {
            double[] normal = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                normal[i] = Math.Round((1 / (sigma * Math.Sqrt(2 * Math.PI))) * Math.Exp(-(Math.Pow(x[i] - mu, 2)) / (2 * Math.Pow(sigma, 2))), 4);
            }
            return normal;
        }

        public static double EMP(double[] y, double[] yp)
        {
            double suma = 0;
            for (int i = 0; i < y.Length; i++)
            {
                suma += (y[i] - yp[i]);
            }
            return suma / y.Length;
        }

        public static double EMC(double[] y, double[] yp)
        {
            double suma = 0;
            for (int i = 0; i < y.Length; i++)
            {
                suma += Math.Pow(y[i] - yp[i], 2);
            }
            return suma / y.Length;
        }

        public static double DEE(double[] y, double[] yp, double EMP)
        {
            double suma = 0;
            for (int i = 0; i < y.Length; i++)
            {
                suma += Math.Pow(y[i] - yp[i] - EMP, 2);
            }
            return Math.Sqrt(suma / (y.Length - 1));
        }

        public static double DAM(double[] y, double[] yp)
        {
            double suma = 0;
            for (int i = 0; i < y.Length; i++)
            {
                suma += Math.Abs(y[i] - yp[i]);
            }
            return suma / y.Length;
        }

        public static double PEMA(double[] y, double[] yp)
        {
            double suma = 0;
            for (int i = 0; i < y.Length; i++)
            {
                suma += (y[i] - yp[i]) / y[i];
            }
            return suma / y.Length * 100;


        }

    }
}
