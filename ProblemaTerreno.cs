using System;
using System.Globalization;

/* Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma
casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida,
o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com
duas casas decimais. */

namespace Teste {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double L, C, MQ;
            double area, preco;

            Console.WriteLine("Digite a Largura do Terreno:");
            L = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Digite o Comprimento do Terreno:");
            C = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Digite o Valor do Metro Quadrado do Terreno:");
            MQ = double.Parse(Console.ReadLine(), CI);

            area = L * C;
            preco = area * MQ;

            Console.WriteLine("O Terreno possui:" + area.ToString("F2", CI) + " Metros Quadrados!");
            Console.WriteLine("E custa:" + preco.ToString("F2", CI) + "R$!");
           
        }
    }
}
