using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio05.Exercicio07
{
    class CalculandoValorSalarioFinal
    {
        public double valorSalario, valorVendido, valorComissionado, porcetagem;



           public double ValorCalculadoSalarioFinal()
        {
            valorComissionado = porcetagem / 100 * valorVendido;

            return valorComissionado + valorSalario;
            
        }
    }
}
