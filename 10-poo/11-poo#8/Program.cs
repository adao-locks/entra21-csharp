using _11_poo_8;

Aluno[] alunos = new Aluno[3];

for (int i = 0; i < alunos.Length; i++)
{
    alunos[i] = new Aluno();

    Console.WriteLine("Digite nome do Aluno: ");
    alunos[i].Nome = Console.ReadLine();
}

Console.WriteLine("");
Console.WriteLine("Alunos Cadastrados: ");
for (int i = 0;i < alunos.Length;i++)
{
    alunos[i].Apresentar();
}