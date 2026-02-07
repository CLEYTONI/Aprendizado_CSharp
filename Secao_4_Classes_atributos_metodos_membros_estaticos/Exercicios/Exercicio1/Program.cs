using System;
using System.Globalization;
using System.Reflection;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();


            Console.WriteLine("Digite os dados (nome, idade) da primeira pessoa: ");

            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados (nome, idade) da segunda pessoa: ");

            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine($"Nome: {p1.Nome}");
            Console.WriteLine($"Idade: {p1.Idade}");

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine($"Nome: {p2.Nome}");
            Console.WriteLine($"Idade: {p2.Idade}");


            if (p1.Idade > p2.Idade) {
                Console.WriteLine($"Pessoa mais velha {p1.Nome}");
            }

            else if (p1.Idade == p2.Idade) {
                Console.WriteLine("Ambas tem a mesma idade");
            }

            else {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");

            }

        }
    }
}