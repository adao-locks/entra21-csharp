using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    class Barco : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Barco navegando na água");
        }
    }
}
