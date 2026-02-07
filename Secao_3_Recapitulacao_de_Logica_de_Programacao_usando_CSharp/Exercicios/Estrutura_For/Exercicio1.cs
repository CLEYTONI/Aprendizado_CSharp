using System;
using System.Drawing;
using System.Globalization;


namespace Laboratorio {
    class Progeram {
        static void Main() {

            // Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            // X, se for o caso.


            Console.Write("Digite um número de 1 a 1000: ");
            int X = int.Parse(Console.ReadLine());

            while (X < 1 || X > 1000) {
                Console.WriteLine("Número informado é menor que 1 ou mair que 1000! Tente novamente. ");
                Console.Write("Digite um número de 1 a 1000: ");
                X = int.Parse(Console.ReadLine());

            }



            for (int i = 1; i <= X; i++) {

                if (i % 2 != 0) {
                    Console.WriteLine(i);

                }
            }




        }
    }
}