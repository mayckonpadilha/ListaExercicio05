using System;

namespace ListaExercicio05.Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvetendoParaFahrenheit converte = new ConvetendoParaFahrenheit();

            converte.temperaturaCalsius = 32;

            Console.WriteLine("O valor convertido para Fahrenheit é:" + converte.ConvertendoEmFahrenheit());
        }
    }
}
