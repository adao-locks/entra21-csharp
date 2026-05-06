using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_poo_4
{
    internal class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo da conta em posse de: {Titular}, é de R$ {Saldo}");
        }
    }
}
