using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Carro acelerando na estrada");
        }
    }
}
