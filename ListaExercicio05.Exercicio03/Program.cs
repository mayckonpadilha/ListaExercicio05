using System;

namespace ListaExercicio05.Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            cilindro.altura = 10;
            cilindro.raio = 20;



            Console.WriteLine("O volume do cilindro é: " + cilindro.Volume());



        }
    }
}
