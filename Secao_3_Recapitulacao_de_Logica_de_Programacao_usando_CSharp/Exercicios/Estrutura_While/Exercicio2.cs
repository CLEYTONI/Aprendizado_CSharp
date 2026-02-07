using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;


namespace Laboratorio {
    class Program { 
    
        static void Main(string[] args) {

            // Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            // cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            // menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma)..


            Console.Write("Digite as coordenadas(X, Y) para verifcar o quadrante: ");

            string[] position = Console.ReadLine().Split(' ');

            int X = int.Parse(position[0]);
            int Y = int.Parse(position[1]);
            
            while (X != 0 && Y != 0) {

                if (X > 0 && Y > 0) {

                    Console.WriteLine("primeiro");

                }

                else if (X < 0 && Y < 0) {

                    Console.WriteLine("terceiro");
                }

                else if (X > 0 && Y < 0) {

                    Console.WriteLine("quarto");

                }

                else {
                    Console.WriteLine("segundo");
                }

                Console.Write("Digite uma nova coordenada: ");

                position = Console.ReadLine().Split(' ');

                X = int.Parse(position[0]);
                Y = int.Parse(position[1]);


            }

        }
    }
}