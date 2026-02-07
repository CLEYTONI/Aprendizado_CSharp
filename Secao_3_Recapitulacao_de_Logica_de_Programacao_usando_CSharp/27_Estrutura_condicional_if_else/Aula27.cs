using System;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            int x = 1;
            for (int i = 1; i < 128; i +=i ) {
                x += x;
            }
            Console.WriteLine( x);

            }

        }
    }