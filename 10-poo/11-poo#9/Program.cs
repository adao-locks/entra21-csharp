using _11_poo_9;

string opcao = "0";
bool finalizar = false;
ContaBancaria conta = new ContaBancaria();

while (!finalizar)
{
    Console.WriteLine("==== MENU ====");
    Console.WriteLine("1 - Criar Conta");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Ver Saldo");
    Console.WriteLine("5 - Sair");

	opcao = Console.ReadLine();
    switch (opcao)
	{
		case "1":
			do
            {
                Console.WriteLine("Informe nome do Titular: ");
                conta.Titular = Console.ReadLine();
            } while (conta.Titular == null || conta.Titular == "");
			break;
		case "2":
            Console.WriteLine("Informe o valor para depósito: ");
			conta.Depositar(double.Parse(Console.ReadLine()));
			break;
		case "3":
            Console.WriteLine("Informe o valor para sacar: ");
            conta.Sacar(double.Parse(Console.ReadLine()));
            break;
		case "4":
			conta.ExibirSaldo();
			break;
		case "5":
			finalizar = true;
			break;
		default:
            Console.WriteLine("Opção inválida, informe uma opção correta!");
			break;
	}
}