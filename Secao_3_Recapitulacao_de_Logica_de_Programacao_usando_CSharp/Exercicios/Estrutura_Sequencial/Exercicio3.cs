using System;
using System.Drawing;
using System.Globalization;

namespace Laboratorio{
    class Program {
        static void Main(string[] args) {


            // Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            // de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            Console.WriteLine($"DIFERENÇA: {diferenca}");


        }
    }
}