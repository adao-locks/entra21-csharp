using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_poo_3
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: R$ {Preco}");
        }
    }
}
