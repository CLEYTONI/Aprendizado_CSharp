using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            // um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            // 4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            // que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            // mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            // exemplo.

            int user = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (user != 4) {


                if (user == 1) {

                    alcool += 1;
                }

                else if (user == 2) {
                    gasolina += 1;
                }

                else if (user == 3) {
                    diesel += 1;
                }

                user = int.Parse(Console.ReadLine());

                }



            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");



            
        }
    }
}