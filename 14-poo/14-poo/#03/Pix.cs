using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    class Pix : Pagamento
    {
        public Pix(double valor) : base(valor)
        {
        }

        public override void Processar()
        {
            Console.WriteLine($"Pagamento de R$ {Valor} via Pix");
        }
    }
}
