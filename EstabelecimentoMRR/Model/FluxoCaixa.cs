using System;
using Dapper.Contrib.Extensions;

namespace EstabelecimentoMRR.Model
{
    [Table("fluxocaixa")]
    public class FluxoCaixa
    {

        public int Id { get; set; }
        public string Conta { get; set; }
        public int TipoConta { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public int Status { get; set; }
        public string Descricao { get; set; }
    }
}
