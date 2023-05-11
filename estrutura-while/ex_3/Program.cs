namespace ex_3
{
    class Program {
        static void Main(string[] args) {
            int escolha = 0;
            int qtGasolina = 0, qtAlcool = 0, qtDiesel = 0;

            Console.WriteLine("Vote no produto que voce tem preferência:  1.Álcool 2.Gasolina 3.Diesel 4.Fim");

            while(escolha != 4) {
                escolha = int.Parse(Console.ReadLine());

                switch(escolha) {
                    case 1:
                        qtAlcool++;
                        break;
                    case 2:
                        qtGasolina++;
                        break;
                    case 3:
                        qtDiesel++;
                        break;
                    default:
                        Console.WriteLine("Invalido");
                        break;
                }
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Alcool: {qtAlcool}");
            Console.WriteLine($"Gasolina: {qtGasolina}");
            Console.WriteLine($"Diesel: {qtDiesel}");
        }
    }
}