using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    class CartaoCredito : Pagamento
    {
        public CartaoCredito(double valor) : base(valor)
        {
        }

        public override void Processar()
        {
            Console.WriteLine($"Pagamento de R$ {Valor} no cartão de crédito");
        }
    }
}
