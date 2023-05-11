using System;

namespace ex_1 {
    class Program {
        static void Main(string[] args) {
            string senhaCorreta = "2002";
            int valido = 0;

            while(valido != 1) {
                string senha = Console.ReadLine();

                if(senha != senhaCorreta) {
                    Console.WriteLine("Senha incorreta");
                } else {
                    Console.WriteLine("Senha correta");
                    valido = 1;
                }
            }
        }
    }
}