using System;
using System.Globalization;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            Console.Write("Digite um número: ");
            int usuario = int.Parse(Console.ReadLine());

            if (usuario < 0) {
                Console.WriteLine("O número digitado é negativo");
            }
            else {
                Console.WriteLine("O número digitado é positivo");
            }
        }
    }
}