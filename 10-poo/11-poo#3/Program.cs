
using _11_poo_3;

Aluno aluno = new Aluno();

Console.WriteLine("Digite o nome do Aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite a nota: ");
aluno.Nota = int.Parse(Console.ReadLine());

aluno.VerificarSituacao();