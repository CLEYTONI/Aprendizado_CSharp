using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio {
    class Triangulo {

        public double A;
        public double B;
        public double C;


        // Na class Triangulo passamos a funçaõ de cacula r a area para a prpia classe
        // Limpada o racicinio do código principal e delegando a reposabilidade para a class certa
       
        // Iniciado um método de classe  nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn n ,    nhyy6y6666666666666666 
        public double Area() {

            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;  

        }

    }
}