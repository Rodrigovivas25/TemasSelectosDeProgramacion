using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDePrueba.Librerias.GMath
{
    public class GMath
    {
        public static double[] Randn(double[] input)
        {
            Random ran = new Random();
            double[] output = new double[input.Length];
            for(int i = 0; i < output.Length; i++)
            {
                output[i] = ran.NextDouble();
            }
            return output;
        }

        public static double Randn()
        {
            Random r = new Random();
            double a = r.NextDouble();
            return a;
        }

        public static double[] Abs(double[] input)
        {
            double[] output = new double[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                output[i] = Math.Abs(input[i]);
            }
            return output;
        }

        public static double[] Acos(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Acos(input[i]);
            }
            return output;
        }

        public static double[] Asin(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Asin(input[i]);
            }
            return output;
        }

        public static double[] Atan(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Atan(input[i]);
            }
            return output;
            
        }

        public static double[] Ceiling(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Ceiling(input[i]);
            }
            return output;
        }

        public static double[] Cos(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Cos(input[i]);
            }
            return output;
        }

        public static double[] Cosh(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Cosh(input[i]);
            }
            return output;
        }

        public static double[] Exp(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Exp(input[i]);
            }
            return output;
        }

        public static double[] Floor(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Floor(input[i]);
            }
            return output;
        }

        public static double[] Log(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Log(input[i]);
            }
            return output;
        }

        public static double[] Log(double[] input, double b)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Log(input[i],b);
            }
            return output;
        }

        public static double[] Log10(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Log10(input[i]);
            }
            return output;
        }

        public static double[] Pow(double[] input, double exp)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Pow(input[i],exp);
            }
            return output;
        }

        public static double[] Round(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Round(input[i]);
            }
            return output;
        }

        public static double[] Sign(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Sign(input[i]);
            }
            return output;
        }

        public static double[] Sin(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Sin(input[i]);
            }
            return output;
        }

        public static double[] Sinh(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Sinh(input[i]);
            }
            return output;
        }

        public static double[] Sqrt(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Sqrt(input[i]);
            }
            return output;
        }

        public static double[] Tan(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Tan(input[i]);
            }
            return output;
        }

        public static double[] Tanh(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Tanh(input[i]);
            }
            return output;
        }

        public static double[] Truncate(double[] input)
        {
            double[] output = new double[input.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Truncate(input[i]);
            }
            return output;
        }





    }
}
