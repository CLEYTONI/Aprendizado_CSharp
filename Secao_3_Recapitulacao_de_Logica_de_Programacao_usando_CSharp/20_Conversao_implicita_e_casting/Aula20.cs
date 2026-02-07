using System;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Conversão explicita e casting

            // Conversão explicita

            float x = 4.5f;
            double y = x; // Pelo fato de double suporta mais bytes que float, a é completamente possível

            Console.WriteLine(y);

            // CaSting
            double a = 200000000.7;
            // Console.WriteLine(double.MaxValue);
            float b = (float)a; // Possui um erro pois float suporta menos bytes que double, logo terá que realizar um casting
            Console.WriteLine(b);

            double k = 5.1;
            int l = (int)k; // Perda de dados ao converte um inteiro em um número de ponto flutuante
            Console.WriteLine($"O valor antes da conversão é {k} e o valor apóa a conversão é {l}");


            int p = 5;
            int q = 2;

            double resultado = p / q; // perda de dados pois pelo menos um dos números precisa se deponto flutuante
            double formaCorreta = (double)p / q;
            Console.WriteLine(formaCorreta);


        }
    }
}