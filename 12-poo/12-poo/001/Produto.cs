using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _12_poo._001
{
    internal class Produto
    {
        private string _nome;

        public void setNome(string novoNome)
        {
            _nome = novoNome;
        }

        public string getNome()
        {
            return $"Nome: {_nome}";
        }
    }
}
