using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_poo
{
    internal class Aluno
    {
        private string Nome;
        private int Nota;

        public void setNome(string novoNome)
        {
            Nome = novoNome;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNota(int novaNota)
        {
            if (novaNota >= 0 && novaNota <= 10)
            {
                Nota = novaNota;
            }
        }

        public int getNota()
        {
            return Nota;
        }

        public void ApresentaAluno()
        {
            Console.WriteLine($"Aluno: {Nome}, Nota: {Nota}");
        }
    }
}
