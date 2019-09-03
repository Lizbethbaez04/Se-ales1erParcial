using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Señales1erParcial
{
    class Triangular
    {
        public List<Muestra> Muestras { get; set; }

        public Triangular()
        {
            Muestras = new List<Muestra>();
        }

        public double evaluar(double tiempo)
        {
            double resultado = 0;

            if(Math.Abs(tiempo) < 1)
            {
                resultado = 1.0 - Math.Abs(tiempo);
            }
            
            if (Math.Abs(tiempo) >= 1)
            {
                resultado = 0.0;
            }

            return resultado;
        }
    }
}
