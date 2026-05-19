using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, double salario)
            : base(nome, salario)
        {
        }

        public override double CalcularBonus()
        {
            return Salario * 0.20;
        }
    }
}
