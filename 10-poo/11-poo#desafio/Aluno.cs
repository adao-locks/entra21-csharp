using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_poo_desafio
{
    internal class Aluno
    {
        public string Nome {  get; set; }
        public float Nota { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Nota: {Nota}");
        }
    }
}
