using _11_poo_7;

Produto[] produto = new Produto[3];
produto[0] = new Produto
{
    Nome = "Caneta",
    Preco = 4
};
produto[1] = new Produto
{
    Nome = "Lápis",
    Preco = 3.5
};
produto[2] = new Produto
{
    Nome = "Borracha",
    Preco = 2
};

Produto maisCaro = new Produto {Preco = double.MinValue};

for (int i = 0; i < produto.Length; i++)
{
    if (produto[i].Preco > maisCaro.Preco)
    {
        maisCaro.Preco = produto[i].Preco;
        maisCaro.Nome = produto[i].Nome;
    }
}

maisCaro.Apresentar();