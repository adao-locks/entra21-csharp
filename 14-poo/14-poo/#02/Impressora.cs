using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    class Impressora
    {
        public void Imprimir(string texto)
        {
            Console.WriteLine(texto);
        }

        public void Imprimir(string texto, int vezes)
        {
            for (int i = 0; i < vezes; i++)
            {
                Console.WriteLine(texto);
            }
        }

        public void Imprimir(string texto, string cor)
        {
            Console.WriteLine($"[{cor} {texto}]");
        }
    }
}
