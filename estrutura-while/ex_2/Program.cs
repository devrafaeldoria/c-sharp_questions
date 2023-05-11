using System;

namespace ex_2 {
    class Program {
        static void Main(string[] args) {
            int x = 1, y = 1;

            while (x != 0 || y != 0) {
                Console.WriteLine("Digite valor de x e y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                } else if (x > 0 && y < 0) {
                    Console.WriteLine("quarto");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
            }
        }
    }
}

