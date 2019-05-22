using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using f =  ConsolaDePrueba.Librerias.Function.Functions;
using s = ConsolaDePrueba.Librerias.Statistic.Statistics;


namespace ConsolaDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("|****************************************|");
            Console.WriteLine("|  Temas selectos de programación        |");
            Console.WriteLine("|  Rodrigo Vivas Maldonado               |");
            Console.WriteLine("|****************************************|");

            /*double[] x = f.linspace(0, 15, 151);
            double[] y = s.Normpdf(x, 7, 2);
            //double area = f.trapz(y, 0, y.Length);
            double area = f.trapz(x, y);
            //f.Visualizador(y);
            double[] arreglo = f.MaxMin(y);
            f.Visualizador(arreglo);
            double aber = f.Evaluate(5, 7, 2);
            Console.WriteLine(aber);
            
            Console.WriteLine("El valor de la integral es "+area);*/
            //f.calcularPi();

            //double[] x = {2,6,9,5,3,6,7};
            //double[] y = f.diff(x);
            //f.Visualizador(y);
            //double[] x = { 18, 17, 15, 16, 14, 12, 9, 15, 16, 14, 16, 18 };
            //double[] y = { 13, 15, 14, 13, 9, 10, 8, 13, 12, 13, 10, 8 };

            /*
            double[] x = { 100, 90, 80, 45, 50, 50, 60, 40, 25, 20 };
            double[] y = { 3, 5, 9, 10, 20, 21, 24, 24, 27, 35 };
            double r2 = s.Pearson(x, y);
            double[] coef = s.CoefLinReg(x, y);
            f.Visualizador(coef);
            Console.WriteLine(r2);
            Console.ReadKey();
            */


            //Entradas
            /*
            double[][] entrada =
            {
                new double[] { 1, 1 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 0, 0 },
            };*/
            /*double[][] entrada =
            {
                new double[] { 1,1,1,1,1,1,0},
                new double[] { 0,1,1,0,0,0,0},
                new double[] { 1,1,0,1,1,0,1},
                new double[] { 1,1,1,1,0,0,1},
                new double[] { 0,1,1,0,0,1,1},
                new double[] { 1,0,1,1,0,1,1},
                new double[] { 1,0,1,1,1,1,1},
                new double[] { 1,1,1,0,0,0,0},
                new double[] { 1,1,1,1,1,1,1},
                new double[] { 1,1,1,1,0,1,1},
            };*/
            double[][] entrada =
            {
                new double[] { 0.7, 3},
                new double[] { 1.5, 5},
                new double[] { 2.0, 9},
                new double[] { 0.9, 11},
                new double[] { 4.2, 0},
                new double[] { 2.2, 1},
                new double[] { 3.6, 7},
                new double[] { 4.5, 6},
            };


            //Salidas
            /*double[] salida =
            {
                1,
                0,
                0,
                0
            };*/
            /* double[] salida =
             {
                 1,
                 0,
                 1,
                 0,
                 1,
                 0,
                 1,
                 0,
                 1,
                 0
             };
             */
            double[][] salida =
           {
                new double[] { 0,0 },
                new double[] { 0,0 },
                new double[] { 0,1 },
                new double[] { 0,1 },
                new double[] { 1,0 },
                new double[] { 1,0 },
                new double[] { 1,1 },
                new double[] { 1,1 },

            };

            //Algoritmo de aprendizaje
            //Neurona N1 = new Neurona(7, TypeFuncionActivacion.hardlim);
            //Neurona N1 = new Neurona(entrada[0].Length, TypeFuncionActivacion.hardlim);
            //Neurona N2 = new Neurona(entrada[0].Length, TypeFuncionActivacion.hardlim);
            //N1.GSw = new double[]{ .5, .2 };
            //N1.GSb = 0.24;
            //N1.GSn = 0.25;
            //N1.GSInput = new double[] { 1, 1 };
            //N1.Run();

            CapaNeurona capa = new CapaNeurona(2,entrada, salida);
            capa.Run();
            /*bool estatus = false;
            int cont = 0; 
            do
            {
                estatus = false;
                cont++;
                Console.WriteLine(cont);
                for(int i = 0; i < entrada.Length; i++)
                {
                    N1.GSInput = entrada[i];
                    N2.GSInput = entrada[i];
                    N1.Run();
                    N2.Run();


                    double[] error = new double[2];
                    error[0] = salida[i][0] - N1.GOutput;
                    error[1] = salida[i][1] - N2.GOutput;


                    //double[] delta = new double[N1.GSInput.Length];

                    //if(error != 0)
                    //{
                    //    estatus = true;
                    //}

                    if (error[0] != 0 && error[1] != 0)
                    {
                        estatus = true;
                    }
                    double[] deltaN1 = new double[N1.GSInput.Length];
                    double[] deltaN2 = new double[N2.GSInput.Length];*/

                    /*for (int j = 0; j < delta.Length; j++)
                    {
                        delta[j] = N1.GSn * error * N1.GSInput[j];
                    }*/
                   // for(int j = 0; j < deltaN1.Length; j++)
                    //{
                      //  deltaN1[j] = N1.GSn * error[0] * N1.GSInput[j];
                        //deltaN2[j] = N2.GSn * error[1] * N2.GSInput[j];
                    //}

                    /*
                    for (int k = 0; k < N1.GSw.Length; k++)
                    {
                        N1.GSw[k] = N1.GSw[k] + delta[k];
                    }*/
                    /*for (int k = 0; k < N1.GSw.Length; k++)
                    {
                        N1.GSw[k] = N1.GSw[k] + deltaN1[k];
                        N2.GSw[k] = N2.GSw[k] + deltaN2[k];
                    }

                    //N1.GSb = N1.GSb - N1.GSn * error;
                    N1.GSb = N1.GSb - N1.GSn * error[0];
                    N2.GSb = N2.GSb - N2.GSn * error[1];
                }
            } while (estatus);*/


            
            Console.ReadKey();
        }
    }
}
