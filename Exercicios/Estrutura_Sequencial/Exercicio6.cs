using System;
using System.Globalization;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {
            // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e
            // mostre:
            // a) a área do triângulo retângulo que tem A por base e C por altura.
            // b) a área do círculo de raio C. (pi = 3.14159)
            // c) a área do trapézio que tem A e B por bases e C por altura.
            // d) a área do quadrado que tem lado B.
            // e) a área do retângulo que tem lados A e B.

            Console.WriteLine("Ler Valores");
            string[] valores = Console.ReadLine().Split(' ');

            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = A * C / 2.0;
            double circulo = 3.14159 * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIÂNGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));





        }
    }
}