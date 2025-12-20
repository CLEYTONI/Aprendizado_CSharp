using System;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            bool completo = false; // Valores booleanos só aceitam false ou verdadeiro
            char genero = 'F'; // Primeira forma de escrever caracteres
            char letra = '\u0041'; // É possivel ecrever as letras pelo seu code unicode
            // É uma forma univesal de escrever caracteres
            float n4 = 4.5f; // Números do tipo float é necesario mencionar o f em seu final
            double n5 = 4.5; // números do tipo double caso ultrapasse o limete permitido pelo float
            string nome = "Cleytoni Ferreira"; // Para palvras frases e conjunto de caracteres usasse strings
            object obj1 = "Anne Caroline"; // O tipio object pode receber qualquer tipo de valor
            object obj2 = 3.14f;
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            // Para verificar qual o valor maximo ou minimo permitido por cada tipo
            // é possivel usar as funções abixo

            int valor = int.MaxValue; // Valor maximo suportado pelo tipo int
            int valor2 = int.MinValue; // Valor minimo suportado pelo tipo int
            decimal valor3 = decimal.MaxValue; // Valor Maximo permitido pelo decimal
            Console.WriteLine(valor);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);

         


        }
    }

}

