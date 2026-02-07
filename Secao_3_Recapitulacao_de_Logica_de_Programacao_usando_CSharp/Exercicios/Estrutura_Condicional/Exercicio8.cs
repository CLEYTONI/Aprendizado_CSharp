using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            // que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            // qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.
            // Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            // mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

            // Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de
            // salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é
            // de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com
            // duas casas decimais.

            Console.Write("Bem vindo cidadão de Lisarb ");

            // double wage = double.Parse(Console.ReadLine());
            double wage = 3002.00;
            double wageDown = 3002.00;
            double percentage = 0.0;
            double incomeTax = 0.0;

            if (wage > 2000.00) {
                wageDown -= 2000.00;
            }

            if (wage > 2000.00) {

                if (wageDown > 1000) {

                }

                percentage = (wageDown * 8) / 100;
                incomeTax += percentage;

            }

            if (wage > 3000.00) {

                percentage = (wage * 18) / 100;
                incomeTax += percentage;
            }






            // Solução do professor

            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double imposto;
            //if (salario <= 2000.0) {
            //    imposto = 0.0;
            //}
            //else if (salario <= 3000.0) {
            //    imposto = (salario - 2000.0) * 0.08;
            //}
            //else if (salario <= 4500.0) {
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            //}
            //else {
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            //}

            //if (imposto == 0.0) {
            //    Console.WriteLine("Isento");
            //}
            //else {
            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

            //}
        }
    }
}