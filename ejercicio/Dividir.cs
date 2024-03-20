using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Dividir
    {
        float C;
        float D;

        public Dividir(float C, float D)
        {
            this.C = C;
            this.D = D;
        }

        public float Solucion()
        {
            return C / D;
        }
    }
}
