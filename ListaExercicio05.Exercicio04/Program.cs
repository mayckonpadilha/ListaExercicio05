using System;

namespace ListaExercicio05.Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculandoCombustivel calculandoCombustivel = new CalculandoCombustivel();


            calculandoCombustivel.kmInicial = 10;
            calculandoCombustivel.kmFinal = 60;
            calculandoCombustivel.combustivelUsado = 80;

            Console.WriteLine("O valor de combustivel gastos por quilometros rodados é de:" + calculandoCombustivel.valorCombustivelPorKm());
        }
    }
}
