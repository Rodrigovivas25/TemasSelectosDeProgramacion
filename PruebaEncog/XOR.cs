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
    class XOR
    {
        public static double[][] entradas = {
            new[] {0.0, 0.0},
            new[] {1.0, 0.0},
            new[] {0.0, 1.0},
            new[] {1.0, 1.0}
        };

       
        public static double[][] salidas = {
            new[] {0.0},
            new[] {1.0},
            new[] {1.0},
            new[] {0.0}
        };

       

        

        public void Run()
        {
            //Se crea la red neuronal con sus respectivas capas
            var network = new BasicNetwork();
            network.AddLayer(new BasicLayer(null, true, 2));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 3));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), false, 1));
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
            } while (train.Error > 0.01);

            // test the neural network
            Console.WriteLine("Resultados:");
            foreach (IMLDataPair pair in conjuntoEntrenamiento)
            {
                IMLData output = network.Compute(pair.Input);
                Console.WriteLine(pair.Input[0] + @"," + pair.Input[1]
                                  + @", actual=" + output[0] + @",ideal=" + pair.Ideal[0]);
            }
        }

    }
}
