using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Laboratorio {
    class Program { 
        static void Main(string[] args) {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);

            Console.Write("Quantos quartos tem a sua casa: ");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine(qtdQuartos);

            Console.Write("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Entre com seu último nome, idade e altura (na mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');

            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);


            Console.WriteLine($"{ultimoNome} {idade} " + altura.ToString("F2", CultureInfo.InvariantCulture));

            
            


        }

    }
}