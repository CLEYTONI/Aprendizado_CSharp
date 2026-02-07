using System;


namespace Laboratorio {
    internal class Triangulo {

        public double Altura, Largura;

        public double Area() {
            return Altura * Largura;

        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {

            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }



    }
}
