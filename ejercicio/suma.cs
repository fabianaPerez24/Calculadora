using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class suma
    {
        float variable1;
        float variable2;

        public suma(float variable1, float variable2)
        {
            this.variable1 = variable1;
            this.variable2 = variable2;
        }

        public float Solucion()
        {
            return variable1 + variable2;
        }
    }
}
