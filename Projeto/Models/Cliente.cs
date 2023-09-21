namespace Models
{
    public class Cliente 
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public int contato { get; set; }

        public Cliente (string nomeCliente, string enderecoCliente, int contatoCliente)
        {
            this.nome = nomeCliente;
            this.endereco = enderecoCliente;
            this.contato = contatoCliente;
        }
    }
}