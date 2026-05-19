using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    abstract class Pagamento
    {
        public double Valor { get; set; }

        public Pagamento(double valor)
        {
            Valor = valor;
        }

        public abstract void Processar();
    }
}
