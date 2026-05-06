using _11_poo_6;

Pessoa[] pessoa = new Pessoa[5];

for (int i = 0; i < pessoa.Length; i++)
{
    pessoa[i] = new Pessoa();

    Console.Write("Nome: ");
    pessoa[i].Nome = Console.ReadLine();
}

Console.WriteLine("Procurar pela pessoa: ");
string procurado = Console.ReadLine();

static bool Encontrar(Pessoa[] pessoas, string nomeProcurado)
{
    for (int i = 0; i < pessoas.Length; i++)
    {
        if (pessoas[i].Nome == nomeProcurado)
        {
            return true;
        }
    }
    return false;
}

bool encontrou = Encontrar(pessoa, procurado);

if (encontrou)
{
    Console.WriteLine("Pessoa encontrada!");
}
else
{
    Console.WriteLine("Pessoa não encontrada.");
}