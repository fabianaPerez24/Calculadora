using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Resta
    {
        float B;
        float A;

        public Resta(float A, float B)
        {
            this.B = A;
            this.A = B;
        }

        public float Solucion()
        {
            return B - A;
        }
    }
}
