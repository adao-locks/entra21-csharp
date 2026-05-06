
using _11_poo_5;

Produto[] produto = new Produto[3];

for (int i = 0; i < produto.Length; i++)
{
    produto[i] = new Produto();
    Console.WriteLine("Nome do produto: ");
    produto[i].Nome = Console.ReadLine();
    Console.WriteLine("Preço: R$");
    produto[i].Preco = int.Parse(Console.ReadLine());
}

for (int i = 0;i < produto.Length; i++)
{
    produto[i].Apresentar();
}