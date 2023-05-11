namespace ex_4
{
    class Program {
        static void Main(string[] args) {
            int qt1, qt2, cod1, cod2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(" ");
            cod1 = int.Parse(valores[0]);
            qt1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2]);

            valores = Console.ReadLine().Split(" ");
            cod2 = int.Parse(valores[0]);
            qt2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2]);

            total = (qt1 * preco1) + (qt2 * preco2);

            Console.WriteLine($"VALOR A PAGAR: R$ {total}");
        }
    }
}