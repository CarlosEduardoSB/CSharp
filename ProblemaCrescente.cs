using System;
using System.Globalization;

//   Problema "crescente" 
Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma
mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente. O
programa deve finalizar quando forem digitados dois valores iguais. //

namespace Teste {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y;

            do {

                Console.WriteLine("Digite 2 Valores:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x < y) {
                    Console.WriteLine("Crescente");
                }
                else if (x > y) {
                    Console.WriteLine("Decrescente");
                }

            } while (x != y);

            Console.WriteLine("Você Digitou numeros iguais!");
        
        }
    }
}
