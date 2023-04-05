using System;

namespace ListaExercicio05.Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada mediaPonderada = new MediaPonderada();
            mediaPonderada.notaDaProva1 = 10;
            mediaPonderada.notaDaProva2 = 7;
            mediaPonderada.peso1 = 8;
            mediaPonderada.peso2 = 7;

            Console.WriteLine("Há media ponderada entre as provas é de: " + mediaPonderada.CalcularMediaPonderada());
        }
    }
}
