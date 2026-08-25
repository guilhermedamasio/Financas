using System;
using System.Collections.Generic;
using System.Text;

namespace Financas
{
    public class Transacao
    {
        public Transacao() { }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public enum TipoTransacao
        {
            Receita,
            Despesa,
            Investimento
        }
    }
}
