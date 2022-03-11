using System;
using System.Globalization;

/* Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor
da área, perímetro e diagonal deste retângulo, com quatro casas decimais. */

namespace Teste {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double b, h, area, perimetro, diagonal;

            Console.WriteLine("Digite a Altura do Retângulo:");
            h = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Digite a Base do Retângulo");
            b = double.Parse(Console.ReadLine(), CI);


            area = b * h;
            perimetro = (b * 2) + (h * 2);
            diagonal = Math.Sqrt(Math.Pow(b,2) + Math.Pow(h,2));

            Console.WriteLine("O Valor da Area desse retangulo é:" + area.ToString("F2",CI));
            Console.WriteLine("O Valor do perimetro desse retangulo é:" + perimetro.ToString("F2", CI));
            Console.WriteLine("O Valor da Diagonal desse retangulo é:" + diagonal.ToString("F2",CI));


            




            }
    }
}
