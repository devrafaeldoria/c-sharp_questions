using System;

namespace ex_4 {
    class Program {
        static void Main(string[] args) {
            int numero;
            double salario, valorHora, horas;

            Console.WriteLine("Digite o numero do funcionario");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas de trabalho do funcionario");
            horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos por hora o funcionario recebe");
            valorHora = double.Parse(Console.ReadLine());

            salario = valorHora * horas;

            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = $ {salario.ToString("F2")}");
        }
    }
}