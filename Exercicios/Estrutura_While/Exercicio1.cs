using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;


namespace Laboratorio {
    class Program { 
    
        static void Main(string[] args) {

           // Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
           // incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
           // impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.


            int password = 2002;
            Console.Write("Para entrar no sistema insira sua senha: " );
            

            int user = int.Parse(Console.ReadLine());

            while (user != password) {

                Console.Write("Senha incorreta digite novamente: ");
                user = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Acesso permitido");




        }
    }
}