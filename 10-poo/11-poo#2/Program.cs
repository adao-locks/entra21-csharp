using _11_poo_2;

Pessoa pessoa = new Pessoa();

Console.WriteLine("Digite o nome: ");
pessoa.Nome = Console.ReadLine();
Console.WriteLine("Digite a idade: ");
pessoa.Idade = int.Parse(Console.ReadLine());

pessoa.Apresentar();
