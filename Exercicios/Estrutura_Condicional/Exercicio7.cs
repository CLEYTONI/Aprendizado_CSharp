using System;
using System.Globalization;
using System.Net;
using System.Runtime.Intrinsics.X86;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            // de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            // ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            // Se o ponto estiver na origem, escreva a mensagem “Origem”.
            // Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            // situação.

            Console.Write("Digite o valor de X e Y: ");

            string[] valores = Console.ReadLine().Split();

            double X = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            Console.WriteLine("O valor de X é " + X.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de Y é " + Y.ToString("F2", CultureInfo.InvariantCulture));

            string quadrante = "Origem";

            if (X > 0 && Y > 0) {
                quadrante = "Q1";
            }
            else if (X < 0 && Y < 0) {
                quadrante = "Q3";
            }

            else if (X > 0 && Y < 0 ) {
                quadrante = "Q4";
            }

            else if (X < 0 && Y > 0) {
                quadrante = "Q2";
            }

            else if (Y == 0.0 && X != 0) {
                quadrante = "Eixo Y";
            }

            else if (X == 0.0 && Y != 0) {
                quadrante = "Eixo X";
            }

            Console.WriteLine(quadrante);
        }
    }
}