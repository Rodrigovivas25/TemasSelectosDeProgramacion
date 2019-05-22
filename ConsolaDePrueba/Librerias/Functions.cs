using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDePrueba.Librerias.Function
{
    public class Functions
    {

        #region Funciones Matlab
        /// <summary>
        /// Método que genera N puntos equidistantes entre dos valores.
        /// </summary>
        /// <param name="x1">Límite inferior. Es el valor donde comenzará la generación de puntos.</param>
        /// <param name="x2">Límite superior. Es el valor donde terminará la generación de puntos.</param>
        /// <param name="Ndatos">Cantidad de puntos a obtener entre los límites inferior y superior (incluyéndolos).</param>
        /// <returns>Devuelve un arreglo con los valores obtenidos.</returns>
        public static double[] linspace(double x1, double x2, int Ndatos)
        {
            try
            {
                double paso = (x2 - x1) / (Ndatos - 1);
                double[] arreglo = new double[Ndatos];
                for (int i = 0; i < Ndatos; i++)
                {
                    arreglo[i] = Math.Round(paso * i + x1,4);
                }
                return arreglo;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("El arreglo debe contener más de un valor");
                double[] array = { 0 };
                return array;
            }
        }

        /// <summary>
        /// Método para visualizar los elementos de un arreglo.
        /// </summary>
        /// <param name="arreglo">Es el arreglo del cual se desea visualizar sus valores.</param>
        public static void Visualizador(double[] arreglo)
        {
            Console.WriteLine("El arreglo de valores es: ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("{0}: "+arreglo[i],i);
            }
        }

        public static void Visualizador(double[,] arreglo)
        {
            Console.WriteLine("El arreglo de valores es: ");
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    Console.Write(arreglo[i, j]+"\t", i, j);
                }
                Console.WriteLine();
            }
        }

        public static double Integral(double[] y, TypeIntegral tipo)
        {
            double output = 0;
            switch (tipo)
            {
                case TypeIntegral.Simpson:
                    //output = integralTrapezio(y); Este es el método privado que debe ir en su respectiva región
                    break;
                case TypeIntegral.Trapezoidal:
                    break;
                default:
                    break;
            }
            return 0;
        }

        public static double Max(double[] x)
        {
            double mayor = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] > mayor)
                {
                    mayor = x[i];
                }
            }
            return mayor;
        }

        public static double Min(double[] x)
        {
            double menor = x[0];
            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] < menor)
                {
                    menor = x[i];
                }
            }
            return menor;
        }

        public static double[] MaxMin(double[] x)
        {
            double[] array = new double[2];
            array[0] = x[0];
            array[1] = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] > array[1])
                {
                    array[1] = x[i];
                }
                if(x[i] < array[0])
                {
                    array[0] = x[i];
                }
            }
            return array;
        }

        private void plot(double[] x, double[] y)
        {
            
        }

        public static double Evaluate(double x, double mu, double sigma)
        {
            double y = Math.Round((1 / (sigma * Math.Sqrt(2 * Math.PI))) * Math.Exp(-(Math.Pow(x - mu, 2)) / (2 * Math.Pow(sigma, 2))),4);
            return y;
        }

        public static double[] diff(double[] x)
        {
            double[] y = new double[x.Length-1];
            for(int i = 0; i < x.Length-1; i++)
            {
                y[i] = x[i + 1] - x[i];
            }
            return y;
        }

        #endregion

        #region funciones matlab privadas

        /*8public static double trapz(double[] x, double a, double b)
        {
            double suma = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if(i == 0 || i == x.Length - 1)
                {
                    suma += x[i];
                }
                else
                {
                    suma += 2 * x[i];
                }
            }
            //b-a
            double integral = ((b - a) / (2*x.Length)) * suma;
            return integral;
        }*/

        /// <summary>
        /// Calcula la integral numérica
        /// </summary>
        /// <param name="x">El vector de puntos equidistantes</param>
        /// <param name="y">El vector de valores normalizados</param>
        /// <returns>Retorna el valor de la integral</returns>
        public static double trapz(double[] x, double[] y)
        {
            double h = x[1] - x[0];
            double output = y.Sum();
            output = Math.Round(h * output,4);
            return output;
        }

        #endregion

        #region enumeradores
        public enum TypeIntegral
        {
            Trapezoidal, Simpson
        }
        #endregion
        /*
        public void ImportarExcel(DataGridView dgv, string hoja)
        {
            //Para pasar los datos del excel a Forms
            OleDbConnection Conexion; //Hace la conexión con el archivo de excel
            OleDbDataAdapter Adaptador; //Almacena la info y la envía al data table
            DataTable dt; //Se llena con el Adaptador
            string ruta = "";
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();//Para buscar el archivo en la compu
                openfile.Filter = "Excel Files |*.xlsx"; //Solo se ven los archivos .xlsx
                openfile.Title = "Seleccione el archivo de Excel";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    if (openfile.FileName.Equals("") == false) //Si el nombre no está vacío
                    {
                        ruta = openfile.FileName;
                    }
                }
                Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                Adaptador = new OleDbDataAdapter("Select * from [" + hoja + "$]", Conexion);
                dt = new DataTable();
                Adaptador.Fill(dt);
                dgv.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }*/

        public static void calcularPi()
        {
            double pi_real = Math.PI;
            double pi = 0;
            double cambio = 1;
            double error = 5;
            double i = 0;
            while(error > 0.1)
            {
                if (i % 2 == 0)
                {
                    pi += 4 / cambio;
                }
                else
                {
                    pi -= 4 / cambio;
                }
                cambio += 2;
                i++;
                error = ((Math.Abs(pi_real - pi)) / pi)*100;
                
            }
            Console.WriteLine("Iteraciones: "+i);
            Console.WriteLine("El error es de: " + error);
            Console.WriteLine(pi);
        }

        public static int hardlim(double input)
        {
            return input >= 0 ? 1 : 0;
            
        }

        
    }
}
