using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Laboratorio {
    class Program {

        // Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
        // (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
        // ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
        // para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver
        // este problema.



        static void Main(string[] args) {

            Triangulo formaGeo = new Triangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");

            formaGeo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            formaGeo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("AREA = " + formaGeo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + formaGeo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + formaGeo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}