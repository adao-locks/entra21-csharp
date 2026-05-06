using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_poo_7
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