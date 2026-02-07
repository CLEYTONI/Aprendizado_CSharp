using System;
using System.Globalization;


namespace Laboratorio {
    class Program {
        static void Main(string[] args) {


            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            // Quando é chamado a variavel que instanciou a classe implicitamente
            // Ele chama o método to string
            // Como na classe "redefinimos" o retorno de ToString agora ele retorna
            // a inofrmação desejada
            Console.WriteLine();
            Console.WriteLine("Dados do produto " + p);


            // Poderia usar conforme abaixo também porém é desnecessario já
            // que é reconhecido forma automatica
            // Console.WriteLine("Dados do produto " + p.ToString());

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicinado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}