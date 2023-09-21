using Sesi.Models;

class Program 
{
    public static void Main()
    {
        Gato meuGato  = new Gato();
        meuGato.nome = "Bichento";
        meuGato.cor = "Laranja";
        meuGato.idade = 2;
        meuGato.especie = "Isfins";
        meuGato.genero = "macho";
        meuGato.peso = 5;
        meuGato.EmitirSom();

        Peixe meuPeixe = new Peixe();
        meuPeixe.especie = "Palhaço";
        meuPeixe.cor = "Laranja";
        meuPeixe.tamanho = 0.20M;
        meuPeixe.peso = 0.100M;
    }
}