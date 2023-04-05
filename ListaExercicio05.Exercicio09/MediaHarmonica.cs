using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio05.Exercicio09
{
    class MediaHarmonica
    {
        public double nota1, nota2, nota3;

        public double CalculandoMediaHarmonica()
        {
            return 3 / (1 / (nota1 + 1) / (nota2 + 1) / nota3);
        }
    }
}
