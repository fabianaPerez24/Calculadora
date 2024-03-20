using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Modulo
    {
        float E;
        float F;

        public Modulo(float E, float F)
        {
            this.E = E;
            this.F = F;
        }

        public float Solucion()
        {
            return E % F;
        }
    }
}
