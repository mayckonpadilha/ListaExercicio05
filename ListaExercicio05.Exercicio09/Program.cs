using System;

namespace ListaExercicio05.Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica mediaHarmonica = new MediaHarmonica();

            mediaHarmonica.nota1 = 10;
            mediaHarmonica.nota2 = 7;
            mediaHarmonica.nota3 = 8;

            Console.WriteLine("A media entre as notas harmonicas é de: " + mediaHarmonica.CalculandoMediaHarmonica());
        }
    }
}
