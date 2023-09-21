using System.IO;

public class Program
{
    public static void Main()
    {
        gravarArquivo();
        LerArquivo();
    }

    public static void gravarArquivo()
    {
        try
        {
            //Gravando no arquivo de texto
            using (StreamWriter arquivo = new StreamWriter("arquivo.txt", true))
            {
                Console.WriteLine("Digite o texto a ser gravado  no arquivo:");
                string texto = Console.ReadLine();
                arquivo.WriteLine(texto);
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro no arquivo {erro.Message}");
        }
    }

    public static void LerArquivo()
    {
         using (StreamReader arquivo = new StreamReader("arquivo.txt"))
         {
            string linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
         }
    }
}