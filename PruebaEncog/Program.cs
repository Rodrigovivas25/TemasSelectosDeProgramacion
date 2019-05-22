using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class Program
    {
        static void Main(string[] args)
        {
            XOR red = new XOR();
            //TestLibreria red = new TestLibreria();
            red.Run();
            Console.ReadKey();

        }
    }
}
