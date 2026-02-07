using System;
using System.Drawing;
using System.Globalization;

namespace Laboratorio{
    class Program {
        static void Main(string[] args) {
            // Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            // hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            // decimais.

            Console.Write("Informe seu número: ");
            int CodFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Informe suas horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da sua hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER: {CodFuncionario}");
            Console.WriteLine("SALARY: " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}