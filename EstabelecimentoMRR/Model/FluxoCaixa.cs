﻿using System;
using Dapper.Contrib.Extensions;
using EstabelecimentoMRR.Enum;

namespace EstabelecimentoMRR.Model
{
    [Table("fluxocaixa")]
    public class FluxoCaixa
    {
        public int Id { get; set; }
        public string Conta { get; set; }
        public TipoConta TipoConta { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public Status Status { get; set; }
        public string Descricao { get; set; }
    }
}
