class Churrasco
{
    public static void Main() 
    {
        ListaDoChurrasco();
    }

    public static void ListaDoChurrasco() 
    {
        string[] listaProdutos = new string[6];

        listaProdutos[0] = "Carne 3kg";
        for (int i = 0; i < listaProdutos.Length; i++)
        {
            Console.WriteLine("Informe o produto:");
            string produto = Console.ReadLine();
            listaProdutos[i] = produto;
        }

        Array.Sort(listaProdutos);

        foreach (string item in listaProdutos) 
        {
            Console.WriteLine($"Item {item}");
        }
    }

    public static void SonhoDeConsumo()
    {
        string[] listaSonhos = new string[3];
        int[] valorsonhos = new int[3];
        int soma = 0;

        for (int i = 0; i < listaSonhos.Length; i++)
        {
            Console.WriteLine("Informe o sonho:");
            string sonho = Console.ReadLine();
            listaSonhos[1] = sonho;

            Console.WriteLine("Informe o valor:");
            int valor = Console.ReadLine();
            valorsonhos[i] = valor;
        }

        foreach (int item in listaSonhos)
            soma += item;

        Console.WriteLine ($"Seus sonhos custarão R$ {soma}");    
    }
}