using System;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            byte n1 = 255;

            n1++; // Overflow é quando uma variavel ultrapassa
            // o limite da capacidade de bytes do tiopo definido

            Console.WriteLine(n1); // O resultado será 0 pois quando ultrapassodo
            // o limite, ele "volta" para o inicio do intervalo

            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; // Sufixo L indica explicitamente que o numero é do tipo long

            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);


        }
    }

}

