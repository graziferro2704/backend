public class Program 
{

    //O try serve para tratar um erro e não parar a execução do programa
    //Se ocorrer qualquer erro dentro do bloco try, o siteme interrompe
    //a execução do blocoe vai para o catch
    public static void Main()
    {
        try {
        Console.WriteLine("Digite um número inteiro");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Você digitou o nº {numero}");
        }
        //Tratando exceção de erro específica de formato
        catch (FormatException) 
        {
            Console.WriteLine("Digite um número inteiro");
        }
        //catch é o tratamento do erro, normalmente colocamos as mensagens de acordo
        //com o tipo do erro, para melhor compreenção do usuário
        catch (Exception erro) 
        {
            Console.WriteLine($"Ocorreu um erro genérico: {erro.Message}");
        }
        finally {
            Console.WriteLine($"No bloco finally o programa entra independentemente de exceção");
        }
    }
}