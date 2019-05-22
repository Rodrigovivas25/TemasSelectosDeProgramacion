using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDePrueba
{
    public class And
    {
        double input1, input2;
        
        public And(double input1, double input2)
        {
            this.input1 = input1;
            this.input2 = input2;
        }

        public double GResult
        {
            get
            {
                if(input1!=0 && input2 != 0)
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
