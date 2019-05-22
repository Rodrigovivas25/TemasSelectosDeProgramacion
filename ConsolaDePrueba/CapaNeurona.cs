using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDePrueba
{
    public class CapaNeurona
    {
        int numNeuronas;
        double[][] entradas;
        double[][] salidas;
        Neurona[] neuronas;
        bool estatus;
        int cont = 0;

        public CapaNeurona(int numNeuronas, double[][] entradas, double[][] salidas)
        {
            this.numNeuronas = numNeuronas;
            neuronas = new Neurona[this.numNeuronas];
            this.entradas = entradas;
            this.salidas = salidas;
            for(int i = 0; i < numNeuronas; i++)
            {
                neuronas[i] = new Neurona(this.entradas[0].Length,TypeFuncionActivacion.hardlim);
            }
        }

        public void Run()
        {
            double[] error = new double[numNeuronas];
            double[][] deltas = new double[numNeuronas][];
            do
            {
                estatus = false;
                cont++;
                Console.WriteLine(cont);
                for (int i = 0; i < entradas.Length; i++)
                {
                    for(int j = 0; j < numNeuronas; j++)
                    {
                        neuronas[j].GSInput = entradas[i];
                        neuronas[j].Run();

                        error[j] = salidas[i][j] - neuronas[j].GOutput;

                        deltas[j] = new double[neuronas[j].GSInput.Length];

                        for(int k = 0; k < deltas[j].Length; k++)
                        {
                            deltas[j][k] = neuronas[j].GSn * error[j] * neuronas[k].GSInput[k];
                        }

                        for(int k = 0; k < neuronas[j].GSw.Length; k++)
                        {
                            neuronas[j].GSw[k] = neuronas[j].GSw[k] + deltas[j][k];
                        }

                        neuronas[j].GSb = neuronas[j].GSb - neuronas[j].GSn * error[j];

                        if (error[j] != 0)
                        {
                            estatus = true;
                        }

                    }
                }
            } while (estatus);
        }

        
    }
}
