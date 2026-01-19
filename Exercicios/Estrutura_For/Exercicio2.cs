using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.Intrinsics.X86;


namespace Laboratorio {
    class Progeram {
        static void Main() {

            // Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            // Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            // essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            Console.Write("Digite a quantidade de números: ");

            int N = int.Parse(Console.ReadLine());

            int dentro = 0, fora = 0;


            for (int i = 1; i <= N; i++) {

                Console.Write($"Digite um número {i}°: ");
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20) {

                    dentro += 1;
                }

                else {
                    fora += 1;
                }

            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");

        }
    }
}