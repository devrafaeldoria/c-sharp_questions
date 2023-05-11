using System;

namespace ex_3 {
    class Program {
        static void Main(string[] args) {
            int num;

            Console.WriteLine("Digite a quantidade de casos para calículo da media ponderada");
            num = int.Parse(Console.ReadLine());

            for(int a = 0; a < num; a++) {
                Console.WriteLine("Digite os tres valores para a media ponderada, um na frente do outro");

                string[] numeros = Console.ReadLine().Split(" ");
                double num1 = double.Parse(numeros[0]);
                double num2 = double.Parse(numeros[1]);
                double num3 = double.Parse(numeros[2]);

                double media = (num1 * 2 + num2 * 3 + num3 * 5) / (2 + 3 + 5);

                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}