using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            // Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode
            // começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.


            // Minha Solução
            //int tempoTotal = 0;

            //Console.Write("Informe a hora inicial e final do jogo: ");
            //string[] tempo = Console.ReadLine().Split(' ');

            //int hrInicial = int.Parse(tempo[0]);
            //int hrFinal = int.Parse(tempo[1]);

            //tempoTotal = hrInicial + hrFinal;

            //if (hrInicial > hrFinal) {

            //    tempoTotal = (24 - hrInicial) + hrFinal;
            //}

            //else if (hrFinal > hrInicial) {
            //    tempoTotal = hrFinal - hrInicial;
            //}

            //else {
            //    tempoTotal = 24;
            //}

            //Console.WriteLine($"Tempo Total é {tempoTotal} H");




            // Solução do professor

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}