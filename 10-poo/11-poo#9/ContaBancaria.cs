using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_poo_9
{
    internal class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo da conta em posse de: {Titular}, é de R$ {Saldo}");
        }

        public void Depositar(double Valor)
        {
            Saldo += Valor;
            ExibirSaldo();
        }

        public void Sacar(double Valor)
        {
            Saldo -= Valor;
            ExibirSaldo();
        }
    }
}
