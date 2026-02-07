using System;
using System.Drawing;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;


namespace Laboratorio {
    class Progeram {
        static void Main() {

            // Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            // de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            // conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            // peso 5.


            Console.Write("Digite a quantidade de teste: ");
            int N = int.Parse(Console.ReadLine());
            double media = 0.0;



            for (int i = 1; i <= N; i++) {

                Console.Write("Digite os três números: ");

                string[] valores = Console.ReadLine().Split();

                double vl1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double vl2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double vl3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = ((vl1 * 2) + (vl2 * 3) + (vl3 * 5)) / ( 2 + 3 + 5);

                Console.WriteLine(media);

            }

            



        }
    }
}