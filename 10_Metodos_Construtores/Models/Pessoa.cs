namespace Models
{
    public class Pessoa
    {
        //Atributos da nossa classe Pessoa
        private string nome { get; set; }
        private int idade { get; set; }

        //Criando nosso método construtor
        public Pessoa (string nomePessoa, int idadePessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
        }

        //Métodos de Classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Falar()
        {
            Console.WriteLine($"{nome} está falando que tem {idade} anos");
        }

        public void Dançar()
        {
            Console.WriteLine($"{nome} está cantando e dançando");
        }
    }
}