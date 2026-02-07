using System.Globalization;

namespace Laboratorio {
    internal class Produto {

        public string Nome;

        public double Preco;

        public int Quantidade;



        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;


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
