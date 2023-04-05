using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio05.Exercicio08
{
    class LatadeOleo
    {
        public double altura, raio;

        public double Volume() { 
        
        return Math.PI * Math.Pow(raio, 2) * altura;

        }
    }
}
