namespace ex_2
{
    class Program {
        static void Main(string[] args) {
            const double PI = 3.14159;

            double raio, area;

            Console.WriteLine("Digite o raio do circulo");
            raio = double.Parse(Console.ReadLine());

            area = PI * (Math.Pow(raio, 2));

            Console.WriteLine($"A = {area.ToString("F4")}");
        }
    }
}