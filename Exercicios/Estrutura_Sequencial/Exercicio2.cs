using System;
using System.Drawing;
using System.Globalization;

namespace Laboratorio{
    class Program {
        static void Main(string[] args) {

            // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            // casas decimais conforme exemplos.
            // Fórmula da área: area = π.raio2
            // Considere o valor de π = 3.14159

            Console.Write("Digite o raio do círculo: ");
            double raioCirc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double areaCirc = pi * Math.Pow(raioCirc, 2);

            Console.WriteLine("O valor da área do circulo é: " + areaCirc.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}