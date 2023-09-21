using Sesi.Models;

class Program
{
    public static void Main()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("Você entrou no sistema");
        Console.WriteLine("----------------------");

        SistemaBancario();
    }

    public static void SistemaBancario()
    {

        Console.WriteLine("Digite aqui o seu nome da conta:");
        string titularDigitado = Console.ReadLine();

        ContaCorrente conta = new ContaCorrente(titularDigitado, 0);

        string opcao = "";

        do
        {
            Console.WriteLine("-------- Saldo Bancário --------");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("0 - Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Sair do saldo bancário");
                    System.Threading.Thread.Sleep(2000);
                    break;

                case "1":
                    conta.Saldo();
                    break;

                case "2":
                    Console.WriteLine("Digite o valor do deposito:");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(deposito);
                    break;

                case "3":
                    Console.WriteLine("Quanto você quer sacar?");
                    decimal deposito2 = decimal.Parse(Console.ReadLine());  
                    conta.Sacar(deposito2);
                    break;

                default:
                    Console.WriteLine("Opção inválida!!");
                    break;
            }

        } while (opcao != "0");

        
    }

}