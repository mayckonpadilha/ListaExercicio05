using System;

namespace ListaExercicio05.Exercicio01.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {      
            CaixaRetangular caixa = new CaixaRetangular();

            caixa.largura = 10;
            caixa.complimento = 10;
            caixa.altura = 10;

                Console.WriteLine("O volume da caixa é de: " + caixa.CalcularVolume());
        }
    }
}
