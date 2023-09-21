namespace Models
{
    public class Produtos
    {
        public string nome { get; set;}
        public int quantidade { get; set;}

        public Produtos (string nomeProdutos, int quantidadeProdutos)
        {
            this.nome = nomeProdutos;
            this.quantidade = quantidadeProdutos;
        }
    }
}