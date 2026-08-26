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

            while (respostaPainel != Painel.Sair)  // testa a variável já existente
            {
                switch (respostaPainel)
                {
                    case Painel.Receitas:
                        Console.WriteLine("Você está no Painel de Receitas.");
                        break;
                    case Painel.Despesa:
                        Console.WriteLine("Você está no Painel de Despesas.");
                        break;
                    case Painel.Investimento:
                        Console.WriteLine("Você está no Painel de Investimentos.");
                        break;
                    case Painel.Sair:
                        Console.WriteLine("Saindo do aplicativo.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                respostaPainel = (Painel)Convert.ToInt32(Console.ReadLine());  // relê no FINAL do loop, atualiza a mesma variável
            }
        }
    }
}
