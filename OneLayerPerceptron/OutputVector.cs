using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLayerPerceptron
{
    class OutputVector
    {
        int[] Y;

        public OutputVector(int size)
        {
            this.Y = new int[size];
        }
    }

}
