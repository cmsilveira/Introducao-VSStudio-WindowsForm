using System.Security.Cryptography.X509Certificates;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }
    }
}