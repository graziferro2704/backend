using Models;

public class Program 
{
    public static void Main()
    {
        //Criar um objeto da classe pessoa
        /*
        //Instanciando objeto sem método construtor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Grazielly";
        pessoa1.idade = 16;

        //Alternativa de um objeto instanciando sem construtor
        Pessoa pessoa1 = new Pessoa {
            nome = "Julia",
            idade = 16
        }
        */

        //Instanciando um objeto com o método construtor
        Pessoa pessoa1 = new Pessoa("Grazielly", 16);
        Pessoa pessoa2 = new Pessoa("Maria Real", 17);
        Pessoa pessoa3 = new Pessoa("Ana Tezzon", 16);

        //Chamando o método Cantar da classe Pessoa
        pessoa1.Cantar();
        pessoa2.Falar();
        pessoa3.Dançar();

    }
}
