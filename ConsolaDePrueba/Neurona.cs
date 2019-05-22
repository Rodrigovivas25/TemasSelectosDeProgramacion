using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaDePrueba.Librerias.GMath;
using ConsolaDePrueba.Librerias.Function;

namespace ConsolaDePrueba
{
    public class Neurona
    {
        #region Variables globales
        double[] P,W; //Nunca se define el tamaño aquí; eso es en el constructor.
        double Output, b, n, Epw;
        #endregion

        #region Constructor
        public Neurona(int Input, TypeFuncionActivacion f)
        {
            this.P = new double[Input];
            this.W = new double[Input];
            this.W = GMath.Randn(W);
            this.b = GMath.Randn();
            this.n = 1;


        }
        #endregion

        #region Accesos
        public double[] GSInput
        {
            get { return P; }
            set
            {
                if (value.Length == P.Length)
                {
                    P = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public double GOutput
        {
            get
            {
               // funcion();
                return Output;
            }
        }

        /// <summary>
        /// Coeficiente de aprendizaje
        /// </summary>
        public double GSn
        {
            get { return n; }
            set { n = value; }
        }

        /// <summary>
        /// Pesos
        /// </summary>
        public double[] GSw
        {
            get { return this.W; }
            set { this.W = value; }
        }

        /// <summary>
        /// Devuelve la sumatoria de menos theta
        /// </summary>
        public double GEpw
        {
            get { return Epw; } 
        }

        public double GSb
        {
            get { return b; }
            set { this.b = value; }
        }

        #endregion

        #region Métodos públicos
        public void Run()
        {
            funcion();
        }
        #endregion


        #region Métodos privados
        private void funcion()
        {
            this.Epw = Mtimes(W,P) - b;
            this.Output = Functions.hardlim(Epw);
        }

        public static double Mtimes(double[] input1, double[] input2)
        {
            if(input1.Length == input2.Length)
            {
                double output = 0;
                for (int i = 0; i < input1.Length; i++)
                {
                    output += input1[i] * input2[i];
                }
                return output;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        #endregion
    }

    public enum TypeFuncionActivacion
    {
        hardlim
    }
}
