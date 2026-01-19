using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
            // Lembrando que, por definição, fatorial de 0 é 1.

            Console.WriteLine("Digite um número");

            int N = int.Parse(Console.ReadLine());

            int fatorial = N;

            for (int i = N - 1; i >= 1; i--) {

                //  N = N * (N-1) * (N-2) * (N-3) * ... * 1.

                fatorial *= (N - i);
                
            }

            Console.WriteLine(fatorial);



            // Solução do professor

            // int n = int.Parse(Console.ReadLine());

            // int fat = 1;
            // for (int i = 1; i <= n; i++) {
            //    fat = fat * i;
            // }

            //Console.WriteLine(fat);


        }
    }

}