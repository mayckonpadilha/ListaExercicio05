using System;

namespace ListaExercicio05.Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvetendoParaCelsius cPCelsius = new ConvetendoParaCelsius();

            cPCelsius.valorFahrenheit = 72;


            Console.WriteLine("O volume da caixa é de: " + cPCelsius.Convertendo());
        }
    }
}
