using System;
using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.ML.Train;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Neural.Networks.Training.Propagation.Back;
using Encog.Neural.Networks.Training.Propagation.Resilient;

namespace PruebaEncog
{
    class TestLibreria
    {
        public static double[][] entradas = {
            new double[] { 0.7, 3},
            new double[] { 1.5, 5},
            new double[] { 2.0, 9},
            new double[] { 0.9, 11},
            new double[] { 4.2, 0},
            new double[] { 2.2, 1},
            new double[] { 3.6, 7},
            new double[] { 4.5, 6},
        };


        public static double[][] salidas = {
            new double[] { 0,0 },
            new double[] { 0,0 },
            new double[] { 0,1 },
            new double[] { 0,1 },
            new double[] { 1,0 },
            new double[] { 1,0 },
            new double[] { 1,1 },
            new double[] { 1,1 },
        };





        public void Run()
        {
            //Se crea la red neuronal con sus respectivas capas
            var network = new BasicNetwork();
            network.AddLayer(new BasicLayer(null, true, 2));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 6));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 2));
            network.Structure.FinalizeStructure();
            network.Reset();

            //Crear el conjunto de entrenamiento
            IMLDataSet conjuntoEntrenamiento = new BasicMLDataSet(entradas, salidas);

            //Entrenar
            IMLTrain train = new ResilientPropagation(network, conjuntoEntrenamiento);

            int epoch = 1;

            do
            {
                train.Iteration();
                Console.WriteLine("Epoca #" + epoch + " Error:" + train.Error);
                epoch++;
            } while (train.Error > 0.001);

            //Prueba de la red neuronal
            Console.WriteLine("Resultados:");
            foreach (IMLDataPair pair in conjuntoEntrenamiento)
            {
                IMLData output = network.Compute(pair.Input);
                Console.WriteLine(pair.Input[0] + @"," + pair.Input[1]
                                  + @", actual=" + output[0] +","+output[1] + @",ideal=" + pair.Ideal[0]+","+pair.Ideal[1]);
            }

            IMLData dataprueba = new BasicMLData(new double[] { 2.4, 2.5 });
            var prueba = network.Compute(dataprueba);
            
        }

    }
}
