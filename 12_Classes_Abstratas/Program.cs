//Classe Pai que será herdada - SuperClasse
abstract class Animal 
{
    public string cor { get; set; }
    public abstract void EmitirSom();
   
}

//Classe Filha que herdará da classe Animal
class Cachorro : Animal
{
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} está latindo! Au au au");
    }
}

class Gato : Animal 
{
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando! Miau miau");
    }

    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando");
    }
}

class Program
{
    public static void Main() 
    {
        /*
        //Não é permitido criar um objeto de uma classe abstrata
        //Só conseguimos criar de sua classe derivada
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        */

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();

        //meuCachorro.Ronronar(); // Não posso chamar esse método pois não exite nessa classe
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}