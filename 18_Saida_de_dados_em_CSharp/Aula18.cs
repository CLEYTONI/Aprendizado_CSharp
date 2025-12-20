using System;
using System.Globalization;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            char genero = 'F';

            int idade = 32;

            double saldo = 10.35784;

            string nome = "Maria";




            // Impressão de informações na tela
            Console.Write("Bom dia!"); // Imprime sem a quebra de linha
            Console.WriteLine("Boa Tarde!"); // Adiciona a quebra de linha no final de froma automatica
            Console.WriteLine("Boa Noite");

            Console.WriteLine("-----------------------");

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); // ToString controla a quantidade de casas decimais que serão exibidas
            // Ele fará um arredondamento no valor após a virgula
            Console.WriteLine(saldo.ToString("F4")); // 47 casas decimais
            // CultureInfo.InvarianteCulture -> Ignora a formatação por virgula (dependendo do pais)
            // e coloca o padrão que é a vírgula
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            // Placeholders, Concatenação, Interpolação

            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual á {2:f2} reais", nome, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }

}

