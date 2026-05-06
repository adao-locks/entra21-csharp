using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_poo_3
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public bool VerificarSituacao()
        {
            if (Nota >= 7)
            {
                Console.WriteLine("Aprovado!");
                return true;
            }
            Console.WriteLine("Reprovado!");
            return false;
        }
    }
}
