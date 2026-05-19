using _14_poo;

List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(new Gerente("Carlos", 8000));
funcionarios.Add(new Desenvolvedor("Ana", 5000));
funcionarios.Add(new Estagiario("Lucas", 1500));

foreach (Funcionario f in funcionarios)
{
    double bonus = f.CalcularBonus();
    double total = f.Salario + bonus;

    Console.WriteLine($"Nome: {f.Nome}");
    Console.WriteLine($"Salário: R$ {f.Salario}");
    Console.WriteLine($"Bônus: R$ {bonus}");
    Console.WriteLine($"Total: R$ {total}");
    Console.WriteLine("---------------------------");
}