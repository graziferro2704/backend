namespace Models
{
    public class Categoria
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public string ingredientes { get; set; }

        public Categoria (string nomeCategoria, string descricaoCategoria, string ingredientesCategoria)
        {
            this.nome = nomeCategoria;
            this.descricao = descricaoCategoria;
            this.ingredientes = ingredientesCategoria;    
        }
    }
}