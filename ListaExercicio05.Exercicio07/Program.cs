using System;

namespace ListaExercicio05.Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculandoValorSalarioFinal valorSalarioFinal = new CalculandoValorSalarioFinal();

            valorSalarioFinal.valorSalario = 1000;
            valorSalarioFinal.valorVendido = 1000;
            valorSalarioFinal.porcetagem = 20;

          
            Console.WriteLine("Seu Salario junto com a comissão será de:" + valorSalarioFinal.ValorCalculadoSalarioFinal());
        }
    }
}
