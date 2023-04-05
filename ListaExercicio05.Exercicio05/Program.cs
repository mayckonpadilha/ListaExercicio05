using System;

namespace ListaExercicio05.Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            esfera.raio = 10;

            Console.WriteLine("O volume da esfera é: " + esfera.Volume());
        }
    }
}
