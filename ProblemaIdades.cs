using System;
using System.Globalization;

/* Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os
nomes e a idade média entre essas pessoas, com uma casa decimal. */

namespace Teste {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade1, idade2;
            double media;
            string nome1, nome2;

            Console.WriteLine("Digite o Nome da Primeira Pessoa:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite a Idade da Primeira Pessoa:");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome da Segunda Pessoa:");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite a Idade da Segunda Pessoa:");
            idade2 = int.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2;

            Console.WriteLine("Dados da Primeira Pessoa: Nome - " + nome1 + ", Idade - " + idade1 + " anos.");
            Console.WriteLine("Dados da Segunda Pessoa: Nome - " + nome2 + ", Idade - " + idade2 + " anos.");
            Console.WriteLine("A Idade média entre " + nome1 + " e " + nome2 + " é igual a: " + media.ToString("F1", CI) + " anos.");

        }
    }
}
