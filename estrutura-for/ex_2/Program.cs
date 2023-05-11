using System;

namespace ex_2 {
    class Program {
        static void Main(string[] args) {
            int num, fora = 0, dentro = 0;

            Console.WriteLine("Quantos números inteiros serão lidos");
            num = int.Parse(Console.ReadLine());

            for(int a = 0; a < num; a++) {
                int escolha = int.Parse(Console.ReadLine());

                if(escolha >=10 && escolha <= 20) {
                    dentro++;
                } else {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}