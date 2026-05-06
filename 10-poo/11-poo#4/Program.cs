
using _11_poo_4;

ContaBancaria pessoa = new ContaBancaria
{
    Titular = "João",
    Saldo = 0
};

pessoa.ExibirSaldo();
pessoa.Depositar(500);
pessoa.Sacar(25);