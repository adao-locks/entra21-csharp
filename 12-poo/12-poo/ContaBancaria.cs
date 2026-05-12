using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_poo
{
    internal class ContaBancaria
    {
        private decimal saldo;

        public decimal Depositar(decimal valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor de depósito inválido!");
                return 0;
            }
            return saldo += valor;
        }

        public decimal Sacar(decimal valor)
        {
            if (saldo <= 0)
            {
                Console.WriteLine("Saldo insuficiente!");
                return 0;
            }
            return saldo -= valor;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }
    }
}
