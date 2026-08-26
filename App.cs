using System;
using System.Collections.Generic;
using System.Text;

namespace Financas
{
    public class App
    {
        public void Iniciar()
        {
            Menu meuMenu = new Menu();
            meuMenu.ExibirOpcoes();

            Painel respostaPainel = (Painel)Convert.ToInt32(Console.ReadLine());  // 1ª leitura, ANTES do while
            var lista = new List<Transacao>();

            while (respostaPainel != Painel.Sair)  // testa a variável já existente
            {
                switch (respostaPainel)
                {
                    case Painel.Receitas:
                        Console.WriteLine("Você está no Painel de Receitas.");
                        Console.WriteLine("Digite o valor da receita:");
                        double valorReceita = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite de onde veio o dinheiro da receita:");
                        string descricaoReceita = Console.ReadLine();

                        lista.Add(new Transacao { Descricao = descricaoReceita, Valor = valorReceita, Tipo = Transacao.TipoTransacao.Receita, Data = DateTime.Now });

                        Console.WriteLine($"Receita registrada: R$ {valorReceita:F2}");

                        Console.WriteLine("Deseja encerrar o aplicativo? (s/n)");
                        string encerrar = Console.ReadLine();
                        if (encerrar.ToLower() == "s")
                        {
                            respostaPainel = Painel.Sair;
                            continue;
                        }
                        else
                        {
                            meuMenu.ExibirOpcoes();
                        }
                        break;

                    case Painel.Despesa:
                        Console.WriteLine("Você está no Painel de Despesas.");
                        Console.WriteLine("Digite o valor da despesa:");
                        double valorDespesa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite de onde veio o dinheiro da despesa:");
                        string descricaoDespesa = Console.ReadLine();
                        lista.Add(new Transacao { Descricao = descricaoDespesa, Valor = valorDespesa, Tipo = Transacao.TipoTransacao.Despesa, Data = DateTime.Now });

                        Console.WriteLine($"Despesa registrada: R$ {valorDespesa:F2}");
                        Console.WriteLine("Deseja encerrar o aplicativo? (s/n)");
                        string encerrar2 = Console.ReadLine();
                        if (encerrar2.ToLower() == "s")
                        {
                            respostaPainel = Painel.Sair;
                            continue;
                        }
                        else
                        {
                            meuMenu.ExibirOpcoes();
                        }
                        break;
                    case Painel.Investimento:
                        Console.WriteLine("Você está no Painel de Investimentos.");
                        Console.WriteLine("Digite o valor do investimento:");
                        double valorInvestimento = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite de onde veio o dinheiro do investimento:");
                        string descricaoInvestimento = Console.ReadLine();
                        lista.Add(new Transacao { Descricao = descricaoInvestimento, Valor = valorInvestimento, Tipo = Transacao.TipoTransacao.Investimento, Data = DateTime.Now });
                        Console.WriteLine($"Investimento registrado: R$ {valorInvestimento:F2}");
                        Console.WriteLine("Deseja encerrar o aplicativo? (s/n)");
                        string encerrar3 = Console.ReadLine();
                        if (encerrar3.ToLower() == "s")
                        {
                            respostaPainel = Painel.Sair;
                            continue;
                        }
                        else
                        {
                            meuMenu.ExibirOpcoes();
                        }
                        break;
                    case Painel.Sair:
                        Console.WriteLine("Saindo do aplicativo.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                if (lista.Count > 0)
                {
                    Console.WriteLine("Transações registradas:");
                    foreach (var transacao in lista)
                    {
                        Console.WriteLine($"{transacao.Data:d}: {transacao.Tipo} - R${transacao.Valor:F2}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma transação registrada.");
                }
                respostaPainel = (Painel)Convert.ToInt32(Console.ReadLine());  // relê no FINAL do loop, atualiza a mesma variável

            }
        }
    }
}