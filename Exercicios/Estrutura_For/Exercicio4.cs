using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {


            // Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            // segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            Console.Write("Digite a quantidade de repetição: ");

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {

                Console.Write("Digite os números: ");

                string[] valores = Console.ReadLine().Split(" ");

                int vl1 = int.Parse(valores[0], CultureInfo.InvariantCulture);

                int vl2 = int.Parse(valores[1], CultureInfo.InvariantCulture);

                

                if (vl2 == 0) {
                    Console.WriteLine("Divisão Impossivel");
                }
                else {
                    double divisao = (double)vl1 / vl2; // Conversão Explicita
                    Console.WriteLine((vl1 / vl2).ToString("F1", CultureInfo.InvariantCulture));
                }
            }





        }
    }

}