using System;

namespace ListaExercicio05.Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            LatadeOleo lata = new LatadeOleo();

            lata.altura = 100;
            lata.raio = 50;

            Console.WriteLine("O valume da lata de oléo e de:" + lata.Volume());
        }
    }
}
