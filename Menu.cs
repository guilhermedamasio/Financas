using System;
using System.Collections.Generic;
using System.Text;

namespace Financas
{
    public class Menu
    {
        public void ExibirOpcoes()
        {
            Console.Clear();
            Console.WriteLine("Seja bem-vindo(a) ao aplicativo de Finanças do Guilherme Damasio!\n");
            Console.WriteLine("Qual painel você deseja acessar?\n");
            Console.WriteLine("1. Painel de Receitas");
            Console.WriteLine("2. Painel de Despesas");
            Console.WriteLine("3. Painel de Investimentos");
            Console.WriteLine("0. Sair\n");
        }
    }
}
