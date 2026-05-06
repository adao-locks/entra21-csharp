using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _10_poo
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Modelo: {Modelo}, Marca: {Marca}");
        }
    }
}
