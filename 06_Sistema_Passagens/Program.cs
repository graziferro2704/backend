using System.Net.Http.Headers;
using System.Xml.Schema;

class Program
{
    public static string[] poltronas = new string[51];

    public static void Main() {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao GraziBus");
        Console.WriteLine("---------------------");
        Console.WriteLine("Contamos com 50 lugares disponíveis");

        Menu();
    }

    public static void Menu() {
        string opcao = "";

        do {
            Console.WriteLine("########## M E N U ##########");
            Console.WriteLine("1 - Para comprar passagem");
            Console.WriteLine("2 - Para poltronas disponíveis");
            Console.WriteLine("3 - Quantidade de poltronas disponíveis");
            Console.WriteLine("4 - Lista de passageiros");
            Console.WriteLine("0 - Para fechar sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch(opcao) {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;  
                case "3":
                    QuantidadeDePoltronas();
                    break;  
                case "4":
                    ListaPassageiros();
                    break;
                default:
                    Console.WriteLine("Opção inválida!!!");
                    break;        
            }

        } while (opcao != "0");
    }

    public static void ComprarPassagem() {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i= 1; i <= nrPassagens; i++) {
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro:");
            string nome = Console.ReadLine();

            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome) {
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponiveis() {
        Console.WriteLine("Lista de poltronas disponíveis");
        for (int i = 1; i <= 50; i++) {
            if (poltronas[i] == null) {
                Console.WriteLine($"Nª {i}");
            }
        }
   }

   public static void QuantidadeDePoltronas() {
    Console.WriteLine("Quantidade de poltronas disponíveis");
    int soma = 0;

    //for (int i = 1; i <= 50; i++) {
    //    if (poltronas[i]  == null) {
    //      soma++;       //soma = soma + 1;
    //    }
    // }

    foreach (string item in poltronas) {
        //soma = (item == null) ? soma =+ 1 : soma += 0;
        if (item == null){
        soma++;
    }
    }
    Console.WriteLine("Atualmente temos " + soma + " poltronas disponíveis");

   }

   public static void ListaPassageiros() {
        Console.WriteLine("Lista de Passageiros");
        for (int i = 1; i <= 50; i++) {
            if (poltronas[i] == null) {
                Console.WriteLine($"Nª {i} - Nome: {poltronas[i]}");
            }
        }
   }

}