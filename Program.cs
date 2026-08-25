Console.WriteLine("Seja bem-vindo(a) ao aplicativo de Finanças do Guilherme Damasio!\n");
Console.WriteLine("Qual painel você deseja acessar?\n");
Console.WriteLine("1. Painel de Receitas");
Console.WriteLine("2. Painel de Despesas");
Console.WriteLine("3. Painel de Investimentos");
Console.WriteLine("0. Sair");
int respostaPainel = Convert.ToInt32(Console.ReadLine());
if (respostaPainel == 1)
{
    Console.WriteLine("Você acessou o Painel de Receitas.");
    Console.WriteLine("Informe a sua receita mensal:");
    double receita = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Sua receita mensal é: R$ {receita:F2}");
}
else if (respostaPainel == 2)
{
    Console.WriteLine("Você acessou o Painel de Despesas.");
    Console.WriteLine("Informe a sua despesa mensal:");
    double despesa = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Sua despesa mensal é: R$ {despesa:F2}");
}
else if (respostaPainel == 3)
{
    Console.WriteLine("Você acessou o Painel de Investimentos.");
    Console.WriteLine("Informe o valor do seu investimento mensal:");
    double investimento = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Seu investimento mensal é: R$ {investimento:F2}");
}
else if (respostaPainel == 0)
{
    Console.WriteLine("Saindo do aplicativo...");
    Console.WriteLine("Obrigado por utilizar o aplicativo de Finanças do Guilherme Damasio!");
}
else
{
    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
}
