using System;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {


            // Quando um número com o sinal na frente seguido do operador de atribuição
            // siginifica que é o novo valor da variável é o valor atual mais o valor do lado direito do operador.
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            int b = 10;
            b *= 2;
            Console.WriteLine(b);

            int c = 10;
            c -= 2;
            Console.WriteLine(c);

            int d = 10;
            d /= 2;
            Console.WriteLine(d);

            int e = 10;
            e %= 2;
            Console.WriteLine(e);


            // A operação de atribuição funciona também em strings fazendo uma concatenação
            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            // O a atribuição mais adição
            int x = 10; // Fazendo a soma de mais
            Console.WriteLine(x);

            int y = 10;
            y--;
            Console.WriteLine(y);

    
        }
    }
}