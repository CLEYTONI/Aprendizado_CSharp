using System;
using System.Globalization;
using System.Net.Security;
using System.Reflection;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            Funcionario servo1, servo2;
            double media;


            servo1 = new Funcionario();
            servo2 = new Funcionario();

            Console.WriteLine("Insira os dados (nome, salario) do primeiro funcionario: ");
            servo1.Nome = Console.ReadLine();
            servo1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Insira os dados (nome, salario) do primeiro funcionario: ");
            servo2.Nome = Console.ReadLine();
            servo2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (double) (servo1.Salario + servo2.Salario) / 2.0;

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine($"Nome: {servo1.Nome}");
            Console.WriteLine($"Salarioi: " + servo1.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------");
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.WriteLine($"Nome: {servo2.Nome}");
            Console.WriteLine($"Salarioi: " + servo2.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------");
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}