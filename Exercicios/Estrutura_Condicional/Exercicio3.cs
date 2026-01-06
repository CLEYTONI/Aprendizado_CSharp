using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            // Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            // ordem crescente ou decrescente.

            // string[] user = Console.ReadLine().Split(' ') -> Lendo os dois valores de uma única vez
            Console.Write("Digite um número: ");
            int userN1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int userN2 = int.Parse(Console.ReadLine());

            if (userN1 % userN2 == 0 || userN2 % userN1 == 0) {
                Console.WriteLine("Os núemros informados são multiplo");
            }

            // Daria para usar um segundo if else ou um ou como usado acima
            //else if (userN2 / userN1 == 0) {
                //Console.WriteLine("Os números informados são multiplos");
            //}

            else {
                Console.WriteLine("Os número informados não são multiplos");
            }





            }

        }
    }
