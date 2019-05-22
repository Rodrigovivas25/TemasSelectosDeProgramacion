using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDePrueba
{
    public class Not
    {
        double input1;

        public Not(double input1)
        {
            this.input1 = input1;
        }

        public double GResult
        {
            get
            {
                if (input1 == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
