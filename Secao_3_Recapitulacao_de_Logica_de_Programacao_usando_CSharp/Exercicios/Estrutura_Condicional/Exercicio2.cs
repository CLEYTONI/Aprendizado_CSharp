using System;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
            Console.Write("Digite um número: ");
            int usuario = int.Parse(Console.ReadLine());

            if (usuario % 2 == 0) {
                Console.WriteLine("PAR");
            }

            else {
                Console.WriteLine("ÍMPAR");
            }

        }
    }
}