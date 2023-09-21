namespace Models
{
    public class Pedidos
    {
        public int quantidade { get; set; }
        public int numeroDoPedido { get; set; }
        public decimal valorCompra { get; set; }

        public Pedidos (int quantidadePedido, int NumeroDoPedidoPedido, decimal ValorCompraPedido)
        {
            this.quantidade = quantidadePedido;
            this.numeroDoPedido = NumeroDoPedidoPedido;
            this.valorCompra = ValorCompraPedido;    
            }
    }
}