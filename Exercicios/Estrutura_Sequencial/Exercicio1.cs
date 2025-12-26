using System;

namespace Laboratorio{
    class Program {
        static void Main(string[] args) {
            // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            // mensagem explicativa, conforme exemplos.

            Console.Write("Digite um número: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int number2 = int.Parse(Console.ReadLine());

            int soma = number1 + number2;

            Console.WriteLine("SOMA = " + (number1 + number2));


        }
    }
}