using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio05.Exercicio10
{
    class MediaPonderada
    {
        public decimal notaDaProva1, notaDaProva2, peso1, peso2;

        public decimal CalcularMediaPonderada()
        {
            return (notaDaProva1 * peso1 + notaDaProva2 * peso2) / (peso1 + peso2);
        }
    }
}
