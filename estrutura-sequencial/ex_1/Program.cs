using System;

namespace ex_1 {
    class Program {
        static void Main(string[] args) {
            int num1, num2;

            Console.WriteLine("Digite dois números inteiros");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {num1 + num2}");
        }
    }
}