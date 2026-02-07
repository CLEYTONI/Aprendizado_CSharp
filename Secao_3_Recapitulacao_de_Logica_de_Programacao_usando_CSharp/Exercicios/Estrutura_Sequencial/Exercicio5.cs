using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Laboratorio{
    class Program {
        static void Main(string[] args) {
            // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            // código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago

            Console.WriteLine("Produto 1: código da peça, quantidade, valor por unidade:");
            string[] dadosProduto1 = Console.ReadLine().Split();

            Console.WriteLine("Produto 2: código da peça, quantidade, valor por unidade:");
            string[] dadosProduto2 = Console.ReadLine().Split();


            int codProduto1 = int.Parse(dadosProduto1[0]);
            int qtdProduto1 = int.Parse(dadosProduto1[1]);
            double valorProduto1 = double.Parse(dadosProduto1[2], CultureInfo.InvariantCulture);

            int codProduto2 = int.Parse(dadosProduto2[0]);
            int qtdProduto2 = int.Parse(dadosProduto2[1]);
            double valorProduto2 = double.Parse(dadosProduto2[2], CultureInfo.InvariantCulture);
            

            double valorTotal = (qtdProduto1 * valorProduto1) + (qtdProduto2 * valorProduto2);

            Console.WriteLine("Valor a pagar: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}