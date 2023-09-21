
namespace Sesi.Models
{

    public class ContaCorrente
    {
        private string titular { get; set; }
        private decimal saldo { get; set; }

        public ContaCorrente(string titular, decimal saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }


        public void Saldo()
        {
            Console.WriteLine($"{titular} o seu saldo bancário é de R${saldo} ");
        }

        public void Depositar(decimal valor)
        {
            saldo = saldo + valor;
            Console.WriteLine($"Voce depositou R${valor}");
        }

        public void Sacar(decimal valor)
        {
            saldo = saldo - valor;
            Console.WriteLine($"O seu saldo é de {saldo}!");
        }

    }
}