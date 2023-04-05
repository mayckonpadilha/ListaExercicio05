using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio05.Exercicio01.ConsoleApp
{
    public class CaixaRetangular
    {
        public int largura;
        public int complimento;
        public int altura;


        public  decimal CalcularVolume()
        {
            return altura * complimento * largura;

        }

    }
}
