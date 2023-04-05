using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio05.Exercicio05
{
    class Esfera
    {
        public double raio;

       public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
        }

    }

}
