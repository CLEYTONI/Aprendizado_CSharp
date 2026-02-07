using System;
using System.Globalization;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {


            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Estrutura de repetição while, ela faz que tudo que está em seu escopo se repete
            // enquanto uma condição não foi atendinda é tipo o cara que rola a pedra até o topo
            // da motanha e volta pro inicio, só que nessa dá pra chegar ao topo
            while (x > 0) {

                Console.WriteLine(Math.Sqrt(x).ToString("", CultureInfo.InvariantCulture));

                Console.Write("Digite outro número: ");

                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }


            Console.WriteLine("Número Negativo");


        }
    }
}