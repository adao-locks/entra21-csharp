using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    class Boleto : Pagamento
    {
        public Boleto(double valor) : base(valor)
        {
        }

        public override void Processar()
        {
            Console.WriteLine($"Boleto de R$ {Valor} gerado com vencimento em 3 dias");
        }
    }
}
