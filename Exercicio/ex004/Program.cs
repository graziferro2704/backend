class Metodo 
{
    public static void Main(){
        Console.WriteLine("Digite um nº para eu calcular seu dobro e sua metade:");
        int numero = int.Parse(Console.ReadLine());
        //int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Dobro(numero));
        Console.WriteLine(Metade(numero));

        Tabuada(numero);

        SomaComDoWhile();
    }

    public static int Dobro (int num)
    {
        int resultado = num * 2;
        return resultado;
    }

    public static int Metade (int num)
    {
        int resultado = num / 2;
        return resultado;
    }

    public static void Tabuada(int num) {
        int cont = 1;
        while (cont <= 1000)
        {
            Console.WriteLine($"{num} x {cont} = {cont * num}");
            cont++;
        }

    }

    public static void SomaComDoWhile()
    {
        int maior = 0;
        int menor = 10000;
        int soma = 0;
        int num = 0;

        do {
            Console.WriteLine("Informe um número positivo, negativo para encerrar");
            num = int.Parse(Console.ReadLine());

            if (num > maior)
                maior = num;

            if (num < menor && num > 0)
                menor = num;

            if (num > 0)
                soma = soma + num;
        } while (num > 0);
        Console.WriteLine($"Menor nº {menor} - maior nº {maior} - soma dos nº {soma}");
    }
}