using System;
using System.Globalization;

namespace Laboratorio{
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';


            double preco1 = 2100.0;
            double preco2 = 650.0;
            double medida = 53.234567;

            Console.WriteLine("Produto:");
            Console.WriteLine($"{produto1}, cujo o preço é R${preco1:f2}");
            Console.WriteLine("{0} , cujo o preço é R${1:f2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e genero: " + genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));

            Console.WriteLine($"Aredondado (três casas decimais): {medida:f3}");

            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}