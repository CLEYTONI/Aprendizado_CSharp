using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Ler um número inteiro N e calcular todos os seus divisores.

            Console.Write("Digite um número: ");

            int N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++) {


                if (N % i == 0) {

                    Console.WriteLine(i);

                }

            }


        }
    }

}