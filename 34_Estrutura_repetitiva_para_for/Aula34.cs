using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Estrura for em C#
            // Essa estrutura é indicada para ser usada quando você sabe quantas vezes você tem que repetir

            Console.Write("Quantos números inteiros você vai digitar? ");

            int N = int.Parse(Console.ReadLine());


            int soma = 0;


            // A estrutura for age da sequinte forma
            // O primeiro elemento é por onde ele vai começar no caso 1
            // O segundo seria uma condição de parada como no While
            // E o ultimo elemnto é o incremento, ou seja soma mais quanto a cada volta


            for (int i = 1; i <= N; i++) {

                Console.Write("Valor #{0}: ", i);

                int valor = int.Parse(Console.ReadLine());
                soma += valor;


            }

            Console.WriteLine("Soma " + soma);



            
        }
    }
}