
public class Program
{

    public static void Main()
    {
        var pessoa1 = new {
            nome = "Michelle", 
            idade = 16
            };
        var pessoa2 = new {
            nome = "Rafaela",
            idade = 16
        };
        Console.WriteLine($"A Pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");

        Console.WriteLine("Digite o marca do carro");
        string marcaDigitado = Console.ReadLine();

        Console.WriteLine("Digite a modelo do carro");
        string modeloDigitado = Console.ReadLine();

        Console.WriteLine("Digite o ano do carro");
        string anoDigitado = Console.ReadLine();

        var carro = new 
        {
            marca = marcaDigitado,
            modelo = modeloDigitado,
            ano = anoDigitado,
        };

        Console.WriteLine($"A marca do carro é {carro.marca}, o modelo é {carro.modelo} e o ano é {carro.ano}");
    }
}