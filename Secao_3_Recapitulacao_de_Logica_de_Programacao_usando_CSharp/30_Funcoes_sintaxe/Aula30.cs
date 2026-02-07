using System;
using System;

namespace Laboratorio {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine(resultado);

        }

        // Iniciando uma função, o significado de static ainda vai ser explicado
        // mais tome que usamos static por causa que a função principal inicia com static
        // int é o tipo de retorno que a função terá. 

        // estrutura basica de uma função
        static int Maior(int a, int b, int c) {
            // Funções tem seu própi escopo uma variavel no escopo de uma função não pode ser usada
            // em outra função.
            int m;
            
            if (a > b || a > c) {
                m = a;
            }

            else if (b > c) {
                m = b;
            }
            // Observação importante apesar de dentro do escopo de if uma variavel definida não valer
            // se essa variavel estiver definida no if e no else ela é valida
            else {
                m = c;
            }

                return m;

        }
    }
}