using System;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {


            // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            // seguintes intervalos([0, 25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            // nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.



            // Minha solução

            //Console.WriteLine("Digite um valor: ");

            //double user = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string intervalo = "";

            //if (user >= 0 && user <= 25) {
            //    intervalo = "[0, 25]";
            //}

            //else if (user >= 25 && user <= 50) {
            //    intervalo = "(25, 50]";
            //}

            //else if (user > 25 && user <= 50) {
            //    intervalo = "(25, 50]";
            //}

            //else if (user > 50 && user <= 75) {
            //    intervalo = "(50, 75]";
            //}

            //else if (user > 75 && user <= 100) {
            //    intervalo = "(75, 100]";
            //}

            //else {
            //    intervalo = "Fora de intervalo";
            //}

            //Console.WriteLine($"Intervalo: {intervalo}");


            // Solução do professor

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0) {
                Console.WriteLine("Fora de intervalo"); // Elimina a possibilida de estar fora do intervalo
            }
            else if (numero <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            }
            else {
                Console.WriteLine("Intervalo (75,100]");
            }

        }
    }
}