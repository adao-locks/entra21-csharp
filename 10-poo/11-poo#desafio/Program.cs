using _11_poo_desafio;

string opcao = "0";
bool finalizar = false;
int cadastros = 0;
Aluno[] aluno = new Aluno[5];

while (!finalizar)
{
    Console.WriteLine("==== MENU ====");
    Console.WriteLine("1 - Cadastrar Aluno");
    Console.WriteLine("2 - Listar Alunos");
    Console.WriteLine("3 - Média da Turma");
    Console.WriteLine("4 - Quantos Foram Aprovados");
    Console.WriteLine("5 - Sair\n");
    opcao = Console.ReadLine();

    switch (opcao)
	{
		case "1":
            aluno[cadastros] = new Aluno();
            Console.WriteLine("Nome:");
            aluno[cadastros].Nome = Console.ReadLine();
            Console.WriteLine("Nota:");
            aluno[cadastros].Nota = float.Parse(Console.ReadLine());
            Console.WriteLine("Aluno Cadastrado com Sucesso!\n");
            cadastros++;
			break;
		case "2":
            Console.WriteLine("Alunos Cadastrados: ");
            Console.WriteLine(cadastros);
            for (int i = 0; i < cadastros; i++)
            {
                aluno[i].Apresentar();
            }
            break;
        case "3":
            float mediaTurma = 0;
            for (int i = 0; i < cadastros; i++)
            {
                mediaTurma += aluno[i].Nota;
            }
            Console.WriteLine($"A média da turma é {mediaTurma/cadastros}");
            break;
        case "4":
            int aprovados = 0;
            for (int i = 0; i < cadastros; i++)
            {
                if ( aluno[i].Nota >= 7)
                    aprovados++;
            }
            Console.WriteLine($"Tiveram {aprovados} Alunos Aprovados!");
            break;
		case "5":
            finalizar = true;
			break;
		default:
			break;
	}
}