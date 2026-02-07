using System.Globalization;

namespace Laboratorio {
    internal class Produto {

        public string Nome;

        public double Preco;

        public int Quantidade;



        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;


        }

        // void vem de vazio ou seja usamos void quando nosso método não retorna
        // nenhum valor apenas executa uma ação
        public void AdicionarProdutos(int quantidade) { // Prametro de função iniciace com letra minuscula

            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {

            Quantidade -= quantidade;

        }

        // Sobreposição sobre um método já exixtente
        // Redefinindo o retorno de ToString
        public override string ToString() {
            return Nome
                   + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }





    }
}
