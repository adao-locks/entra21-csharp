using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_poo_8
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public void Apresentar()
        {
            Console.Write($"{Nome}, ");
        }
    }
}
