using System;

namespace ex_1 {
    class Program {
        static void Main(string[] args) {
            int num;

            Console.WriteLine("Digite um numero inteiro maior que 0 e menor que 1000");
            num = int.Parse(Console.ReadLine());

            for(int a = 0; a < num; a++) {
                if(a % 2 != 0) {
                    Console.WriteLine(a);
                }
            }
        }
    }
}