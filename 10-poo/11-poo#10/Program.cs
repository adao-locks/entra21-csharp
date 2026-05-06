
using _11_poo_10;

string opcao = "0";
Pessoa[] p = new Pessoa[5];
int cadastros = 0;
bool finalizar = false;

while (!finalizar)
{
    Console.WriteLine("==== MENU ====");
    Console.WriteLine("1 - Cadastrar Pessoa");
    Console.WriteLine("2 - Listar Pessoas");
    Console.WriteLine("3 - Buscar Pessoa");
    Console.WriteLine("4 - Sair");

    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            if (cadastros < 5)
            {
                p[cadastros] = new Pessoa();
                Console.WriteLine("Informe nome da Pessoa: ");
                p[cadastros].Nome = Console.ReadLine();
                cadastros++;
            } else
            {
                Console.WriteLine("Limite de Pessoas atingido!");
            }
            break;
        case "2":
            Console.WriteLine("");
            Console.WriteLine("Pessoas Cadastradas: ");
            for (int i = 0; i < cadastros; i++)
            {
                p[i].Apresentar();
            }
            break;
        case "3":
            bool encontrou = false;
            Console.WriteLine("");
            Console.WriteLine("Buscar Pessoa: ");
            string busca = Console.ReadLine();
            for (int j = 0; j < cadastros; j++)
            {
                if (busca == p[j].Nome)
                {
                    encontrou = true;
                }
            };
            if (encontrou)
            {
                Console.WriteLine($"{busca} Encontrada!");
            } else
            {
                Console.WriteLine($"{busca} Não Encontrada!");
            }
            break;
        case "4":
            finalizar = true;
            break;
        default:
            Console.WriteLine("Opção inválida, informe uma opção correta!");
            break;
    }
}