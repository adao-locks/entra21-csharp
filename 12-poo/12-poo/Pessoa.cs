using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_poo
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public void setNome(string novoNome)
        {
            _nome = novoNome;
        }

        public string getNome()
        {
            return _nome;
        }

        public void setIdade(int novaIdade)
        {
            if (novaIdade <= 0)
            {
                Console.WriteLine("Idade inválida");
                return;
            }
            _idade = novaIdade;
        }
        
        public int getIdade()
        {
            return _idade;
        }
    }
}
