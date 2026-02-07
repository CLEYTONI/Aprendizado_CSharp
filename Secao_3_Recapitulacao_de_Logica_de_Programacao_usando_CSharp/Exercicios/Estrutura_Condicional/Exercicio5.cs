using System;
using System.Globalization;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.A
            // seguir, calcule e mostre o valor da conta a pagar.

            Console.Write("Digite o código do item e sua quantidade: ");

            string[] dados = Console.ReadLine().Split();

            int item = int.Parse(dados[0]);
            int qtd = int.Parse(dados[1]);

            double total = 0;

            if (item == 1) {
                total = qtd * 4.00;
            }

            else if (item == 2) {
                total = qtd * 4.50;
            }
            else if (item == 3) {
                total = qtd * 5.00;
            }
            else if (item == 4) {
                total = qtd * 2.00;
            }
            else if (item == 5) {
                total = qtd * 1.50;
            }
            else {
                Console.WriteLine("Produto não encontrado");
            }

            if (total > 0) {
                Console.WriteLine($"Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
            }



        }
    }
}