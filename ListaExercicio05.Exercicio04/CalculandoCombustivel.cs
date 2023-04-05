using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio05.Exercicio04
{
    class CalculandoCombustivel
    {

        public double kmInicial, kmFinal, distancia, combustivelUsado;



        public double valorCombustivelPorKm()
        {
            distancia = kmFinal - kmInicial;

            return distancia / combustivelUsado;

        }

    }
}
